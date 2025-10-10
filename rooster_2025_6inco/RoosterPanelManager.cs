using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rooster_2025_6inco
{
    internal class RoosterPanelManager
    {
        Lesuur[,] les = new Lesuur[5, 7];
        public RoosterPanelManager(Panel panel, ComboboxManager comboboxManager) 
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Panel lesuurPanel = new Panel();
                    //les[i, j] = new lesuur()
                }
            }
        }
    }
}
