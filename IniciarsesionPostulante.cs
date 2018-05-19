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
    public partial class IniciarsesionPostulante : Form
    {
        public IniciarsesionPostulante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfazPostulante obj = new InterfazPostulante();
            obj.ShowDialog();
        }
    }
}
