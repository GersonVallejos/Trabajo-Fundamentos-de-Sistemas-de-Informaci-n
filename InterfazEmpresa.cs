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
    public partial class InterfazEmpresa : Form
    {
        public InterfazEmpresa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agregaranuncio obj = new Agregaranuncio();
            obj.ShowDialog();
        }
    }
}
