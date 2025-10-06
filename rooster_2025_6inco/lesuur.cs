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
            lblKlas.Text = klas.ToString();
            lblLeerkracht.Text = leerkracht.ToString();
            lblLokaal.Text = lokaal.ToString();

            

            panel.Controls.Add(lblKlas);
            panel.Controls.Add(lblLeerkracht);
            panel.Controls.Add(lblLokaal);

            
        }
    }
}
