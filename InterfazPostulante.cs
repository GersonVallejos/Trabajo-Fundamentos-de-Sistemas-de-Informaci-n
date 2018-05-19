using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptitus
{
    public partial class InterfazPostulante : Form
    {
        public InterfazPostulante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ofertas obj = new Ofertas();
            obj.ShowDialog();
        }
    }
}
