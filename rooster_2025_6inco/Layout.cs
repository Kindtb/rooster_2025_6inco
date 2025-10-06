using System;
using System.Collections.Generic;
using System.Drawing;
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
            comboboxPanel.Location = new Point(10, 10);
            comboboxPanel.Size = new Size(800, 50);
            comboboxPanel.BorderStyle = BorderStyle.FixedSingle;
            form.Controls.Add(comboboxPanel);

            roosterPanel.Location = new Point(10, 70);
            roosterPanel.Size = new Size(800, 500);
            roosterPanel.BorderStyle = BorderStyle.FixedSingle;
            form.Controls.Add(roosterPanel);
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
