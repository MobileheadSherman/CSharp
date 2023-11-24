﻿using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NovelReader.Classes
{
    public class DatabaseAccess
    {
        public static List<FavoriteNovelModel> LoadFavoriteData(string search)
        {
            //List<(string ID, string NovelName, string NovelLink, string ImgLink, int sourcesite)> Data 
            //    = new List<(string ID, string NovelName, string NovelLink, string ImgLink, int sourcesite)>();
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = string.Empty;

                    if (!string.IsNullOrEmpty(search))
                        query = $"Select * from NovelFavorites where NovelName LIKE '%{search}%'";
                    else
                        query = $"Select * from NovelFavorites";

                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                dt.Load(dr);
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    dr.Close();
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<FavoriteNovelModel> favoriteNovels = dt.AsEnumerable().Select(
                    favorite => new FavoriteNovelModel
                    {
                        ID = Convert.ToInt32(favorite["ID"]),
                        NovelName = (string)(favorite["NovelName"]),
                        NovelLink = (string)(favorite["NovelLink"]),
                        Img = (string)(favorite["Img"]),
                        Source = (string)(favorite["Source"])
                    }
                ).ToList();

            return favoriteNovels;
        }
        public static List<HistoryModel> LoadHistoryData()
        {
            //List<(string ID, string NovelName, string NovelLink, string ImgLink, int sourcesite)> Data 
            //    = new List<(string ID, string NovelName, string NovelLink, string ImgLink, int sourcesite)>();
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = $"Select * from NovelHistory";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                dt.Load(dr);
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    dr.Close();
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<HistoryModel> historyDatas = dt.AsEnumerable().Select(
                    favorite => new HistoryModel
                    {
                        NovelName = (string)(favorite["NovelName"]),
                        PreviousChapterLink = (string)(favorite["PreviousChapterLink"]),
                        Source = Convert.ToInt32(favorite["Source"])
                    }
                ).ToList();

            return historyDatas;
        }

        public static bool RemoveHistory(string novelname, int source)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "DELETE FROM NovelHistory WHERE NovelName=@NovelName AND Source=@Source";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        try
                        {
                            sqlcmd.Parameters.AddWithValue("@NovelName", novelname);
                            sqlcmd.Parameters.AddWithValue("@Source", source);
                            sqlcmd.ExecuteNonQuery();

                            if (sqlcon.State == ConnectionState.Open)
                            {
                                sqlcon.Close();
                                return true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public static bool CheckNovelFavorites(string novel, int source)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT NovelName from NovelFavorites where NovelName=@NovelName and Source=@Source";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        sqlcmd.Parameters.AddWithValue("@Source", source);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        if (sqlcon.State == ConnectionState.Open)
                                        {
                                            sqlcon.Close();
                                            return true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (sqlcon.State == ConnectionState.Open)
                                    {
                                        sqlcon.Close();
                                        return false;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public static bool SaveAndUnsaveNovelFavorites(string novelname, string novellink, string imglink, int sourcesite)
        {
            if (!CheckNovelFavorites(novelname, sourcesite))
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "INSERT INTO NovelFavorites VALUES (@ID,@NovelName,@NovelLink,@Img,@Source)";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@ID", null);
                                sqlcmd.Parameters.AddWithValue("@NovelName", novelname);
                                sqlcmd.Parameters.AddWithValue("@NovelLink", novellink);
                                sqlcmd.Parameters.AddWithValue("@Img", imglink);
                                sqlcmd.Parameters.AddWithValue("@Source", sourcesite);
                                sqlcmd.ExecuteNonQuery();

                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "DELETE FROM NovelFavorites WHERE NovelName=@NovelName AND Source=@Source";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@NovelName", novelname);
                                sqlcmd.Parameters.AddWithValue("@Source", sourcesite);
                                sqlcmd.ExecuteNonQuery();

                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        public static (int sourcesite, string chapterlink) ContinueReading(string novel, int source)
        {
            string chapterlink = string.Empty;
            int sourcesite = 0;
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT PreviousChapterLink, Source from NovelHistory where NovelName=@NovelName AND Source=@Source";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        sqlcmd.Parameters.AddWithValue("@Source", source);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        chapterlink = dr.GetString(0).ToString();
                                        sourcesite = dr.GetInt32(1);
                                    }
                                }
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (sourcesite, chapterlink);
        }
        private static bool CheckNovelHistory(string novel, int source)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT NovelName from NovelHistory where NovelName=@NovelName and Source=@Source";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        sqlcmd.Parameters.AddWithValue("@Source", source);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        if (sqlcon.State == ConnectionState.Open)
                                        {
                                            sqlcon.Close();
                                            return true;
                                        };
                                    }
                                }
                                else
                                {
                                    if (sqlcon.State == ConnectionState.Open)
                                    {
                                        sqlcon.Close();
                                        return false;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public static void UpdatePreviousChapter(string title, string chapterlink, int sourcesite)
        {
            if (CheckNovelHistory(title, sourcesite))
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "UPDATE NovelHistory SET PreviousChapterLink=@PreviousChapterLink WHERE NovelName=@NovelName";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@NovelName", title);
                                sqlcmd.Parameters.AddWithValue("@PreviousChapterLink", chapterlink);
                                sqlcmd.ExecuteNonQuery();
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "INSERT INTO NovelHistory VALUES (@NovelName,@PreviousChapterLink,@Source)";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@NovelName", title);
                                sqlcmd.Parameters.AddWithValue("@PreviousChapterLink", chapterlink);
                                sqlcmd.Parameters.AddWithValue("@Source", sourcesite);
                                sqlcmd.ExecuteNonQuery();

                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private protected static string LoadConnectionString()
        {
            return string.Format("Data source={0};Version=3;New=False;Compress=True;FailIfMissing=False",
                (Directory.GetCurrentDirectory().ToString().Replace(@"\bin\Debug", "") + @"\NovelReaderDB.db").Replace(@"\", @"\\"));
        }

        ~DatabaseAccess()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
