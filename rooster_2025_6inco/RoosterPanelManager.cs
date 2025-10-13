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
                    lesuurPanelLeerkracht.Location = new Point(i * 50, j * 50);
                    lesuurPanelLeerkracht.Size = new Size(50, 50);
                    lesuurPanelLeerkracht.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanelLeerkracht);

                    Lesuur lesuurLeerkracht = new Lesuur(lesuurPanelLeerkracht);
                    lesLeerkracht[i,j] = lesuurLeerkracht;
                }
            }
            for (int i = 0;i < 5; i++)
            {
                for(int j = 0;j < 9; j++)
                {
                    Panel lesuurPanelKlas = new Panel();
                    lesuurPanelKlas.Location = new Point(i * 50 + 260, j * 50);
                    lesuurPanelKlas.Size = new Size(50, 50);
                    lesuurPanelKlas.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanelKlas);

                    Lesuur lesuurKlas = new Lesuur(lesuurPanelKlas);
                    lesKlas[i, j] = lesuurKlas;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Panel lesuurPanelLokaal = new Panel();
                    lesuurPanelLokaal.Location = new Point(i * 50 + 520, j * 50);
                    lesuurPanelLokaal.Size = new Size(50, 50);
                    lesuurPanelLokaal.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(lesuurPanelLokaal);

                    Lesuur lesuurLokaal = new Lesuur(lesuurPanelLokaal);
                    lesLokaal[i, j] = lesuurLokaal;
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
