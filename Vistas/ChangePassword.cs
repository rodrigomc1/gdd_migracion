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
using PalcoNet.Repositorios;
using PalcoNet.Utils;

namespace PalcoNet.Vistas
{
    public partial class FormChangePassword : CustomForm
    {

        RepoUsuario repoUsuario = new RepoUsuario();
        String password;
       

        public FormChangePassword()
        {
            InitializeComponent();
        }

        

        private ValidatorData ValidateAllFields()
        {
            ValidatorData validatorData = new ValidatorData();
            validatorData.ValidateTextWithRegex(txtPassword.Text, ValidatorData.REGEX_PASSWORD);
            validatorData.ValidateTextWithRegex(txtConfirmarPassword.Text, ValidatorData.REGEX_PASSWORD);
            return validatorData;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!CheckPasswords())
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error");
                return;   
            }
            if (ValidateAllFields().ShowIfThereAreErrors()) return;
            password = txtConfirmarPassword.Text;

            try
            {
                repoUsuario.ChangePassword(password);
                MessageBox.Show("Contraseña actualizada.", "Message");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.ERROR_INESPERADO, "Error");
            }            
        }

        

        private Boolean CheckPasswords()
        {
            return txtPassword.Text == txtConfirmarPassword.Text;
        }
    }
}
