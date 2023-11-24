using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ImprumuturiBiblioteca
{
    public class Imprumut
    {
        private Cititor cititor;
        private List<Carte> carti;
        private DateTime dataImprumut;
        private DateTime termenRestituire;
        private DateTime dataRestituire;
        private bool depasireTermen;

        public Imprumut()
        {
            cititor = null;
            carti = null;
            dataImprumut = DateTime.Now;
            termenRestituire = DateTime.Now;
            dataRestituire = DateTime.Now;
            depasireTermen = false;
        }
        public Imprumut(Cititor cititor, List<Carte> carti, DateTime dataImprumut, DateTime termenRestituire, bool depasireTermen)
        {
            this.cititor = cititor;
            this.carti = carti;
            this.dataImprumut = dataImprumut;
            this.termenRestituire = termenRestituire;
            this.depasireTermen = depasireTermen;
        }

        public Cititor Cititor
        {
            get { return cititor; }
            set { if (value.ID > 0) cititor = value; }
        }
        public List<Carte> Carti
        {
            get { return carti; }
            set { if (value.Count > 0) carti = value; }
        }
        public DateTime DataImprumut
        {
            get { return dataImprumut; }
            set { if (value <= DateTime.Now) dataImprumut = value; }
        }
        public DateTime TermenRestituire
        {
            get { return termenRestituire; }
            set { if (value > DateTime.Now) termenRestituire = value; }
        }

        public DateTime DataRestituire
        {
            get { return dataRestituire; }
            set { if (value > dataImprumut) dataRestituire = value; }
        }
        public bool DepasireTermen
        {
            get { return depasireTermen; }
            set { if (dataRestituire > termenRestituire) depasireTermen = true; }
        }

        public override string ToString()
        {
            string result = "Cititorul " + cititor.Nume + " a imprumutat pe data de " + dataImprumut + " urmatoarele carti:\n";
            int i = 1;
            foreach (Carte c in carti)
            {
                result += i + ")'" + c.Titlu + "' - " + c.Autor + "\n";
                i++;
            }
            result += "Termenul de restituire este " + termenRestituire + ". Acesta a returnat cartile pe data de " + dataRestituire + " si ";
            if (depasireTermen == true)
            {
                result += "a depasit termenul.";
            }
            else
            {
                result += "nu a depasit termenul.";
            }
            return result;
        }
    }
}
