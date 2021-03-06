﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PalcoNet.Vistas;

namespace PalcoNet.Comprar
{
    public partial class FormAddRubros : CustomForm
    {
        public String selectedRubro;

        public FormAddRubros(List<String> rubrosList)
        {
            InitializeComponent();

            listBoxRubros.DataSource = rubrosList;
        }

        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            selectedRubro = listBoxRubros.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
