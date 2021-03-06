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
using PalcoNet.Modelo;
using PalcoNet.Vistas;
using PalcoNet.Utils;

namespace PalcoNet.Abm_Grado
{
    public partial class CreateGrado : CustomForm
    {
        RepoGradoPublicacion repo = new RepoGradoPublicacion();

        public CreateGrado()
        {
            InitializeComponent();
            numComisionGrado.Minimum = 0;
            numComisionGrado.Maximum = 100;
        }

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validator = new ValidatorData();
            validator.ValidateTextWithRegex(txtNombreGrado.Text, ValidatorData.REGEX_DESCRIPCION_GRADO);
            return validator;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields().ShowIfThereAreErrors()) return;
            if (repo.ExistsGrado(this.txtNombreGrado.Text))
            {
                MessageBox.Show("Ya existe el grado " + this.txtNombreGrado.Text + ".");
                return;
            }
            Grado grado = new Grado(
                (int)numComisionGrado.Value,
                txtNombreGrado.Text);
            try
            {
                repo.InsertGrado(grado);
                MessageBox.Show(Messages.OPERACION_EXITOSA);
            }
            catch {
                MessageBox.Show(Messages.ERROR_INESPERADO);
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numComisionGrado.Value = 0;
            txtNombreGrado.Clear();
        }

    }
}
