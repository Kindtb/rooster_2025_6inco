using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rooster_2025_6inco
{
    internal class Lesuur
    {
        Label lblKlas = new Label();
        Label lblLeerkracht = new Label();
        Label lblLokaal = new Label();

        public Lesuur(Panel panel)
        {
            init(panel);
            lblKlas.Text = "";
            lblLeerkracht.Text = "";
            lblLokaal.Text = "";
        }
        public Lesuur(Panel panel, Klas klas, Leerkracht leerkracht, Lokaal lokaal)
        {
            init(panel);

            lblKlas.Text = klas.ToString();
            lblLeerkracht.Text = leerkracht.ToString();
            lblLokaal.Text = lokaal.ToString();

            
  
        }
        void init(Panel panel)
        {
            panel.Controls.Add(lblKlas);
            panel.Controls.Add(lblLeerkracht);
            panel.Controls.Add(lblLokaal);
            int width = panel.Width;
            int height = panel.Height / 4;
            lblKlas.Size = new Size(width, height);
            lblKlas.Location = new Point(0, 0);
            lblKlas.TextAlign = ContentAlignment.MiddleCenter;

            lblLeerkracht.Size = new Size(width, height);
            lblLeerkracht.Location = new Point(0, height);
            lblLeerkracht.TextAlign = ContentAlignment.MiddleCenter;

            lblLokaal.Size = new Size(width, height);
            lblLokaal.Location = new Point(0, 2* height);
            lblLokaal.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void update(Les les)
        {
            lblKlas.Text = les.klas;
            lblLeerkracht.Text = les.leerkracht;
            lblLokaal.Text = les.lokaal;
        }
    }
}
