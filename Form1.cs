﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ofertas obj = new Ofertas();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar_Empresa obj = new Agregar_Empresa();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Postulante obj = new Agregar_Postulante();
            obj.ShowDialog();
        }
    }
}
