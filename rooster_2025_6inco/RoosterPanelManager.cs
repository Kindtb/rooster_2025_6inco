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
        Lesuur[,] lesLeerkracht = new Lesuur[5, 9];
        public RoosterPanelManager(Panel panel, ComboboxManager comboboxManager, CsvReader reader)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Panel lesuurPanel = new Panel();
                    lesuurPanel.Location = new Point(i * 50, j * 20);
                    lesuurPanel.Size = new Size(50, 20);
                    lesuurPanel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanel);

                    Lesuur lesuur = new Lesuur(lesuurPanel);
                    lesLeerkracht[i,j] = lesuur;
                }
            }


            comboboxManager.leerkrachtChanged += (sender, e) =>
            {

                string leerkracht = e;
                List<Les> lessen = reader.getLessenVoorLeerkracht(leerkracht);

                RoosterFactory roosterFactory = new RoosterFactory();
                Les[,] rooster = roosterFactory.getRooster(lessen);
                // toon de rooster van leerkracht

                for (int dag = 0; dag < 5; dag++)
                {
                    for (int uur = 0; uur < 9; uur++)
                    {
                        if (rooster[dag,uur] != null)
                        {
                            lesLeerkracht[dag, uur].update(rooster[dag, uur]);
                        }
                    }
                }
            };


        }


    }
}
