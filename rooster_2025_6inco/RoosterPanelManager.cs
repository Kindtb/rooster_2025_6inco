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
        Lesuur[,] lesKlas = new Lesuur[5, 9];
        Lesuur[,] lesLokaal = new Lesuur[5, 9];
        public RoosterPanelManager(Panel panel, ComboboxManager comboboxManager, CsvReader reader)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Panel lesuurPanelLeerkracht = new Panel();
                    lesuurPanelLeerkracht.Location = new Point(i * 50, j * 20);
                    lesuurPanelLeerkracht.Size = new Size(50, 20);
                    lesuurPanelLeerkracht.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanelLeerkracht);

                    Lesuur lesuurLeerkracht = new Lesuur(lesuurPanelLeerkracht);
                    lesLeerkracht[i,j] = lesuurLeerkracht;
                }


                comboboxManager.leerkrachtChanged += (sender, e) =>
                {

                    string leerkracht = e;
                    List<Les> lessen = reader.getLessenVoorLeerkracht(leerkracht);
                    // toon de rooster van leerkracht
                };
            }


        }


    }
}
