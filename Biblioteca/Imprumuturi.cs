using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Imprumuturi
    {
        private int imprumutId;
        private string cititorId;
        private int carteId;
        private DateTime dataImprumut;

        public Imprumuturi(int imprumutId, string cititorId, int carteId, DateTime dataImprumut)
        {
            this.imprumutId = imprumutId;
            this.cititorId = cititorId;
            this.carteId = carteId;
            this.dataImprumut = dataImprumut;
        }

        public int ImprumutId { get => imprumutId; set => imprumutId = value; }
        public string CititorId { get => cititorId; set => cititorId = value; }
        public int CarteId { get => carteId; set => carteId = value; }
        public DateTime DataImprumut { get => dataImprumut; set => dataImprumut = value; }

    
 
    }
}
