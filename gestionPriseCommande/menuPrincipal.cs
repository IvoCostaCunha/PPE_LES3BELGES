﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gestionPriseCommande
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

     

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saisirUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCommande frmgestCom = new GestionCommande();
            frmgestCom.ShowDialog();
        }
    }
}
