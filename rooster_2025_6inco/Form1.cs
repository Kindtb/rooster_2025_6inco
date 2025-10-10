using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rooster_2025_6inco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Layout layout = new Layout(this);

            CsvReader reader = new CsvReader("data/rooster.txt");
            ComboboxManager comboboxManager = new ComboboxManager(layout.getComboboxPanel(), reader);

            RoosterPanelManager roosterPanelManager = new RoosterPanelManager(layout.getRoosterPanel(), comboboxManager);

            comboboxManager.leerkrachtChanged += (sender, e) =>
            {
                string leerkracht = "DBLE";
                roosterPanelManager.toonLeerkrachtRooster(leerkracht);
            };
        }
    }
}
