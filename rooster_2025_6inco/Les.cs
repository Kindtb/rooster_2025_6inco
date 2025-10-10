using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rooster_2025_6inco
{
    internal class Les
    {
        public string klas;
        public string leerkracht;
        public string lokaal;
        public string vak;
        public int dag;
        public int uur;

        public Les(string klas, string leerkracht, string lokaal, string vak, int dag, int uur)
        {
            this.klas = klas;
            this.leerkracht = leerkracht;
            this.lokaal = lokaal;
            this.vak = vak;
            this.dag = dag;
            this.uur = uur;
        }
    }
}
