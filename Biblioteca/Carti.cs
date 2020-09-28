using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carti
    {
        private int carteId;
        private string titlu;
        private string autor;
        private string editura;
        private int anAparitie;

        public Carti(int carteId,string titlu,string autor,string editura,int anAparitie)
        {
            this.carteId = carteId;
            this.titlu = titlu;
            this.autor = autor;
            this.editura = editura;
            this.anAparitie = anAparitie;
        }

        public int CarteId { get => carteId; set => carteId = value; }
        public string Titlu { get => titlu; set => titlu = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editura { get => editura; set => editura = value; }
        public int AnAparitie { get => anAparitie; set => anAparitie = value; }
    }
}
