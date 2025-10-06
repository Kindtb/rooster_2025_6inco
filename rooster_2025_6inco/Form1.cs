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
            CsvReader reader = new CsvReader("data/rooster.txt");
            Panel comboboxPanel = new Panel();
            ComboboxManager comboboxManager = new ComboboxManager(comboboxPanel, csvReader);

            Panel roosterPanel = new Panel();
            RoosterPanelManager roosterPanelManager = new RoosterPanelManager(roosterPanel);

        }
    }
}
