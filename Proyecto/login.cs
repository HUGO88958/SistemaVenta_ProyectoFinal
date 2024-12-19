using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinalP2
{
    public partial class login : Form
    {
        private int idUsuarioActual;
        public login()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(250, Color.Black);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(250, Color.Black);


        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener datos de usuario y contraseña
            string cuenta = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(cuenta) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Error");
                return;
            }

            // Conexión a la base de datos
            try
            {
                using (MySqlConnection conn = new DataAcces.Conexion().GetConnection())
                {
                    conn.Open(); // Abre la conexión

                    // CONSULTA DE ID Y NOMBRE COMPLETO
                    string query = "SELECT id, nombreCompleto FROM Usuarios WHERE cuenta = @cuenta AND contraseña = @contraseña";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cuenta", cuenta);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);// Asocio el resultado de la peticion a la variable local

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener id y nombre completo
                            int idUsuario = Convert.ToInt32(reader["id"]);
                            string nombreCompleto = reader["nombreCompleto"].ToString();

                            this.Hide(); // Ocultar la pantalla de login
                            CargaForm form = new CargaForm(nombreCompleto);
                            form.ShowDialog();

                            // Validacion del tipo de cuenta 
                            if (cuenta == "admin" || cuenta == "Hugo")
                            {
                                AdminForm adminForm = new AdminForm(idUsuario, nombreCompleto);
                                adminForm.Show();
                            }
                            else
                            {
                                TiendaForm tiendaForm = new TiendaForm(idUsuario, nombreCompleto);
                                tiendaForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error");
            }
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            DatosCompartidos.NombreUsuario = txtUsuario.Text;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
