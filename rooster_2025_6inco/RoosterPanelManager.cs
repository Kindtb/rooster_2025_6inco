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
<<<<<<< HEAD
        //lesuur[,] les = new lesuur[5, 7];
=======
        Lesuur[,] les = new Lesuur[5, 7];
>>>>>>> 0d41e043c2f5fa21975e0c8a3fabce56d78aa30f
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

            comboboxManager.leerkrachtChanged += (sender, e) =>
            {

                string leerkracht = e;
                // toon de rooster van leerkracht
            };
        }

        
    }

    
}
