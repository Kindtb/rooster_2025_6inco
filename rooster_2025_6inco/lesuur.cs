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

        public Lesuur(Panel panel, Klas klas, Leerkracht leerkracht, Lokaal lokaal)
        {

            int width = panel.Width;
            int height = panel.Height / 4;

            lblKlas.Text = klas.ToString();
            lblLeerkracht.Text = leerkracht.ToString();
            lblLokaal.Text = lokaal.ToString();

            lblKlas.Size = new Size(width, height);
            lblKlas.Location = new Point(panel.Location.X, panel.Location.Y + height);
            lblKlas.TextAlign = ContentAlignment.MiddleCenter;

            lblLeerkracht.Size = new Size(width, height);
            lblLeerkracht.Location = new Point(panel.Location.X, lblKlas.Location.Y + height);
            lblLeerkracht.TextAlign = ContentAlignment.MiddleCenter;

            lblLokaal.Size = new Size(width, height);
            lblLokaal.Location = new Point(panel.Location.X, lblLeerkracht.Location.Y + height);
            lblLokaal.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(lblKlas);
            panel.Controls.Add(lblLeerkracht);
            panel.Controls.Add(lblLokaal);
            

        }
    }
}
