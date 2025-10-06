using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rooster_2025_6inco
{
    internal class CsvReader
    {

        public CsvReader(string filePath)
        {

        }
        public List<Klas> getKlassen()
        {
            return new List<Klas>();
        }

        public List<Leerkracht> getLeerkrachten()
        {
            return new List<Leerkracht>();
        }

        public List<Lokaal> getLokalen()
        {
            return new List<Lokaal>();
        }
    }
}
