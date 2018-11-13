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
using PalcoNet.Modelo;
using PalcoNet.Repositorios;

namespace PalcoNet.Abm_Rol
{
    public partial class ListadoRol : CustomForm
    {
        private BindingSource bindingSource = new BindingSource();
        List<Rol> roles = new List<Rol>();
        Rol elegido;

        public ListadoRol()
        {
            InitializeComponent();
            roles = new RepoRol().GetRoles();
            roles.ForEach(rol => bindingSource.Add(rol));
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seleccionar
            using (ListadoFuncionalidades form = new ListadoFuncionalidades())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Funcionalidad val = form.Elegida;
                    textBox2.Text = val.Nombre;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Buscar
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}