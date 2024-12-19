using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoFinalP2.DataAcces;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinalP2
{
    public partial class AdminForm : Form
    {


        public AdminForm(int idUsuario, string nombreCompleto)
        {
            InitializeComponent();
            timer1.Start();
            lblNombreCompleto.Text = nombreCompleto;

        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {

            string nombreCompleto = DatosCompartidos.NombreUsuario;
            string cuenta = DatosCompartidos.NombreUsuario;


            this.Hide();

            // Crear y mostrar el formulario GestionarProductosForm
            GestionProductosForm frmGestionarProductos = new GestionProductosForm();
            frmGestionarProductos.Show();


        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss"); // Actualizamos el label con la hora actual
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentasTotales_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalVentas = CalcularVentasTotales();
                // Asignar el valor de las ventas totales al label
                lblVentasTotales.Text = $"Ventas Totales: {totalVentas:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar las ventas: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private decimal CalcularVentasTotales() //VENTAS TOTALES
        {
            decimal totalVentas = 0;


            using (MySqlConnection conn = new DataAcces.Conexion().GetConnection())
            {
                conn.Open();

                string query = "SELECT SUM(monto) AS TotalVentas FROM usuarios";//TOTAL DE VENTAS

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)//Filtro que me permite calcular el monto de los invitados o toda cuenta que pueda hacer una compra
                    {
                        totalVentas = Convert.ToDecimal(result);
                    }
                }
            }

            return totalVentas;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            FormGrafica grafica = new FormGrafica();
            grafica.ShowDialog();
        }

        private void lblVentasTotales_Click(object sender, EventArgs e)
        {

        }
    }
}
