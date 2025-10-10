using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace rooster_2025_6inco
{
     
    internal class ComboboxManager
    {
        public event EventHandler leerkrachtChanged;
        public event EventHandler klassenChanged;
        public event EventHandler lokalenChanged;


        public ComboboxManager(Panel layout, CsvReader reader)
        {
            List<Leerkracht> leerkrachten = reader.getLeerkrachten();
            List<Klas> klassen = reader.getKlassen();
            List<Lokaal> lokalen = reader.getLokalen();

            ComboBox comboLeerkracht = new ComboBox();
            ComboBox comboklassen = new ComboBox();
            ComboBox combolokalen = new ComboBox();

            comboLeerkracht.Location = new Point(0, 0);
            comboklassen.Location = new Point(100, 0);
            combolokalen.Location = new Point(200, 0);

            layout.Controls.Add(comboLeerkracht);
            layout.Controls.Add(comboklassen);
            layout.Controls.Add(comboklassen);

            comboLeerkracht.SelectedIndexChanged += (sender, e) =>
            {
                leerkrachtChanged?.Invoke(this, new EventArgs());
            };
            comboklassen.SelectedIndexChanged += (sender, e) =>
            {
                klassenChanged?.Invoke(this, new EventArgs());
            };
            combolokalen.SelectedIndexChanged += (sender, e) =>
            {
                lokalenChanged ?.Invoke(this, new EventArgs());
            };



        }
    }
}
