using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proiect_ImprumuturiBiblioteca
{
    [Serializable]
    public class Cititor
    {
        private int id;
        private string nume;
        private DateTime dataNasterii;
        private string email;
        private string telefon;

        public Cititor()
        {
            id = 0;
            nume = "Necunoscut";
            dataNasterii = DateTime.Now;
            email = "Necunoscut";
            telefon = "-";
        }
        public Cititor(int id, string nume, DateTime dataNasterii, string email, string telefon)
        {
            this.id = id;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.email = email;
            this.telefon = telefon;
        }

        public int ID
        {
            get { return id; }
            //set { if (value > 0) id = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { if (value.Length > 5) nume = value; }
        }
        public DateTime DataNasterii
        {
            get { return dataNasterii; }
            set { if (value.Year <= 2011) dataNasterii = value; }
        }
        public string Email
        {
            get { return email; }
            set { if (new Regex(@"^([A-Za-z0-9._]+)@([A-Za-z0-9.]+)\.(com|ro)$").IsMatch(value) == true) email = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { if (new Regex("^07[0-9]{2}.[0-9]{3}.[0-9]{3}$").IsMatch(value)) telefon = value; }
        }

        public override string ToString()
        {
            return "Cititorul " + nume + " cu id-ul " + id + " este nascut pe " + dataNasterii.ToShortDateString() + " si are emailul: " + email + ", iar telefonul: " + telefon;
        }
    }
}
