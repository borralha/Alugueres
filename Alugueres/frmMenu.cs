﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alugueres
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void brnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm =new frmClientes ();
            frm.ShowDialog();
        }
    }
}
