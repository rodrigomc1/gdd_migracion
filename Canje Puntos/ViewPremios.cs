﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Repositorios;
using PalcoNet.Config;
using PalcoNet.Vistas;

namespace PalcoNet.Canje_Puntos
{
    public partial class ViewPremios : CustomForm
    {
        RepoPremio repoPremio = new RepoPremio();

        public ViewPremios()
        {
            InitializeComponent();
            dataGridPremios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            btnActualizar_Click(null, null);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dataGridPremios.DataSource = repoPremio.GetPremios(UserSession.UserId);
        }

        private void ViewPremios_Load(object sender, EventArgs e)
        {
            this.dataGridPremios.RowHeadersVisible = false;
        }
    }
}
