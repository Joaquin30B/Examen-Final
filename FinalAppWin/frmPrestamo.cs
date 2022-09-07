using Final.Dominio;
using Final.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAppWin
{
    public partial class frmPrestamo : Form
    {
        Prestamo prestamo;
        public frmPrestamo(Prestamo prestamo)
        {
            this.prestamo = prestamo;
            InitializeComponent();
        }

        private void Consultar(object sender, EventArgs e)
        {
            
            var exito = false;
            if (prestamo.ID == 0)
            {
                exito = PrestamoBL.Insertar(prestamo);
            }
            else
            {
                exito = PrestamoBL.Actualizar(prestamo);
            }
            if (exito)
            {
                MessageBox.Show("El préstamo ha sido registrado", "Final",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha podido completar la operación", "Final",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDatos()
        {
            var listado = ClienteBL.Listar();
            listado.Insert(0, new Cliente
            {
                Nombres = "--SELECCIONE--"
            });
            cboCliente.DataSource = listado;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "ID";
        }
    }
}
