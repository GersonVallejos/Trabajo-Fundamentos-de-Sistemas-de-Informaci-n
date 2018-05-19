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
    public partial class Agregar_Empresa : Form
    {
        public Agregar_Empresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iniciarsesionempresa obj = new Iniciarsesionempresa();
            obj.ShowDialog();
        }
    }
}
