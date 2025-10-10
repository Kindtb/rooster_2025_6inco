using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace rooster_2025_6inco
{
    internal class RoosterPanelManager
    {
        Lesuur[,] lesLeerkracht = new Lesuur[5, 7];
        public RoosterPanelManager(Panel panel, ComboboxManager comboboxManager)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    Panel lesuurPanel = new Panel();
                    lesuurPanel.Location = new Point(i * 50, j * 20);
                    lesuurPanel.Size = new Size(50, 20);
                    lesuurPanel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanel);
                    //lesLeerkracht[i, j] = new Lesuur(lesuurPanel, comboboxManager);
                }


                comboboxManager.leerkrachtChanged += (sender, e) =>
                {

                    string leerkracht = e;
                    // toon de rooster van leerkracht
                };
            }


        }


    }
}
