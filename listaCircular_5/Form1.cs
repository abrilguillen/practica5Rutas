using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaCircular_5
{
    public partial class frmListaCircular : Form
    {

        Ruta miRuta = new Ruta();

        public frmListaCircular()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int hora = int.Parse(txtMinutos.Text);

            miRuta.agregarBase(new Base(nombre, hora));
            
            txtNombre.Clear();
            txtMinutos.Clear();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miRuta.reporte();
        }

        private void cmdAgregarInicio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int hora = int.Parse(txtMinutos.Text);

            miRuta.agregarInicio(new Base(nombre, hora));

            txtNombre.Clear();
            txtMinutos.Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Base nuevaBase = miRuta.buscar(txtBuscar.Text);

            if (nuevaBase != null)
            {
                txtReporte.Text = nuevaBase.ToString();
            }
            else
                MessageBox.Show("El producto que indica no se encuentra");
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            miRuta.eliminar(txtBuscar.Text);
        }

        private void cmdEliminarInicio_Click(object sender, EventArgs e)
        {
            miRuta.eliminarInicio();
        }

        private void cmdInsertarDespuesDe_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int hora = int.Parse(txtMinutos.Text);

            miRuta.insertarDespuesDe(txtInsertarNombre.Text, new Base(nombre, hora));


            txtNombre.Clear();
            txtMinutos.Clear();
        }

        private void cmdRecorrido_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miRuta.recorrido(txtNombreBase.Text, dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
