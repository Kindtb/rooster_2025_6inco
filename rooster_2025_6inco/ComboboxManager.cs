using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rooster_2025_6inco
{
    internal class ComboboxManager
    {
       
        public ComboboxManager(Panel layout, CsvReader reader)
        {
            List<Leerkracht> leerkrachten = reader.getLeerkrachten();
            List<Klas> klassen = reader.getKlassen();
            List<Lokaal> lokalen = reader.getLokalen();

            ComboBox comboLeerkracht = new ComboBox();
            ComboBox comboklassen = new ComboBox();
            ComboBox combolokalen = new ComboBox();

            layout.Controls.Add(comboLeerkracht);
            layout.Controls.Add(comboklassen);
            layout.Controls.Add(comboklassen);


        }
    }
}
