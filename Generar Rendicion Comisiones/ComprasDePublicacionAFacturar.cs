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
using PalcoNet.Utils;
using PalcoNet.Vistas;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class ComprasDePublicacionAFacturar : CustomForm
    {
        RepoPublicacion repoPublicacion = new RepoPublicacion();

        RepoCompra repoCompra = new RepoCompra();

        RepoFactura repoFacturas = new RepoFactura();

        List<DetalleCompra> compras = new List<DetalleCompra>();

        Publicacion publicacion;

        public ComprasDePublicacionAFacturar(decimal id)
        {
            InitializeComponent();
            dataGridCompras.RowHeadersVisible = false;
            dataGridCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            publicacion = repoPublicacion.FindById(id);
            lblTituloPublicacion.Text = "#" + publicacion.Codigo + ": " + publicacion.Descripcion;
            compras = repoCompra.FindComprasToCheckIn(publicacion.Codigo);
            dataGridCompras.DataSource = new BindingSource(compras, String.Empty);
            this.numCantidadARendir.Minimum = 1;
            this.numCantidadARendir.Maximum = compras.Count;
        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            int cantidadARendir = Convert.ToInt32(numCantidadARendir.Value);
            try
            {
                repoFacturas.RendirComisiones(cantidadARendir, publicacion.Codigo);
                compras.RemoveRange(0, cantidadARendir);
                dataGridCompras.DataSource = new BindingSource(compras, String.Empty);
                MessageBox.Show(Messages.OPERACION_EXITOSA);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(Messages.ERROR_INESPERADO);
            }
        }

    }
}
