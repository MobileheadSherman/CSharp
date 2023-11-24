using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ImprumuturiBiblioteca
{
    public class Carte
    {
        private int cod;
        private string titlu;
        private string autor;
        private string editura;
        private string categorie;

        public Carte()
        {
            cod = 0;
            titlu = "Necunoscut";
            autor = "Necunoscut";
            editura = "Necunoscuta";
            categorie = "Necunoscuta";
        }
        public Carte(int cod, string titlu, string autor, string editura, string categorie)
        {
            this.cod = cod;
            this.titlu = titlu;
            this.autor = autor;
            this.editura = editura;
            this.categorie = categorie;
        }

        public int Cod
        {
            get { return cod; }
            //set { if (value > 0) cod = value; }
        }
        public string Titlu
        {
            get { return titlu; }
            set { if (value.Length > 2) titlu = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { if (value.Length > 5) autor = value; }
        }
        public string Editura
        {
            get { return editura; }
            set { if (value.Length > 2) editura = value; }
        }
        public string Categorie
        {
            get { return categorie; }
            set { if (value.Length > 5) categorie = value; }
        }

        public override string ToString()
        {
            return "Cartea " + titlu + ", de " + autor + " cu codul " + cod + " face parte din categoria " + categorie + " si este de la editura " + editura;
        }
    }
}
