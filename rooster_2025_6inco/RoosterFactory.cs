using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rooster_2025_6inco
{
    internal class RoosterFactory
    {
        public Les[,] getRooster(List<Les> lessen)
        {
            Les[,] rooster = new Les[5, 9];

            foreach (Les les in lessen)
            {
                int dag = les.dag - 1;
                int uur = les.uur - 1;
                rooster[dag, uur] = les;
            }

            return rooster;
        }
    }
}
