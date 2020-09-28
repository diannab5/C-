using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cititori
    {
        private int cititorId;
        private string nume;
        private string cnp;
        private string adresa;
        private string telefon;

       

        public Cititori(int cititorId, string nume, string cnp, string adresa, string telefon)
        {
            this.CititorId = cititorId;
            this.Nume = nume;
            this.Cnp = cnp;
            this.Adresa = adresa;
            this.Telefon = telefon;
        }
        public int CititorId { get => cititorId; set => cititorId = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
