using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rooster_2025_6inco
{
    internal class Layout
    {
        Panel comboboxPanel = new Panel();
        Panel roosterPanel = new Panel();

        public Layout(Form1 form)
        {

        }

        public Panel getComboboxPanel()
        {
            return comboboxPanel;   
        }
        public Panel getRoosterPanel()
        {
            return roosterPanel;
        }
    }
}
