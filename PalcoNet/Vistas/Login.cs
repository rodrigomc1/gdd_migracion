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


namespace PalcoNet
{
    public partial class Login : CustomForm
    {
        Usuario user = new Usuario();

        public Login() : base()
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsRegistered())
            {
                FormManager.getInstance().OpenAndClose(new UserHome(), this);
            }
            
        }

        private Boolean IsRegistered()
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            //esta hardcodeado para que podamos entrar directamente
            return true;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
