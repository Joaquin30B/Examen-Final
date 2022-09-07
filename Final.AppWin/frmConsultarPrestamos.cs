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

namespace Final.AppWin
{
    public partial class frmConsultarPrestamos : Form
    {
        Prestamo prestamo;
        public frmConsultarPrestamos(Prestamo prestamo)
        {
            this.prestamo = prestamo;
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvListado.DataSource = PrestamoBL.Listar();
        }

        private void iniciarFormulario(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void cargarDatos()
        {
            var listado = PrestamoBL.Listar();
            listado.Insert(0, new Prestamo
            {
                 Numero = "--SELECCIONE--"
            });
            cboPrestamo.DataSource = listado;
            cboPrestamo.DisplayMember = "Numero";
            cboPrestamo.ValueMember = "ID";
        }
    }
}
