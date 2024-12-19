using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;

namespace ProyectoFinalP2
{
    public partial class FormGrafica : Form
    {
        private LiveCharts.WinForms.CartesianChart chart; // Control de LiveCharts para la gráfica

        public FormGrafica()
        {
            InitializeComponent();
            ConfigurarGrafica(); // Configura la gráfica al iniciar el formulario
            CargarDatosGrafica(); // Carga los datos desde la base de datos
        }

        private void ConfigurarGrafica()
        {
            // Inicialización del control de la gráfica
            chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill 
            };

            // Añadir la gráfica al formulario
            this.Controls.Add(chart);
        }

        private void CargarDatosGrafica()
        {
        
            
            DataTable dtDatos = new DataTable();

            try
            {
                using (MySqlConnection conn = new DataAcces.Conexion().GetConnection())
                {
                    conn.Open();

                    // Consulta para seleccionar nombreCompleto y monto de cada usuario
                    string query = "SELECT nombreCompleto, monto FROM usuarios WHERE monto>0";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dtDatos); // Llena el DataTable con los resultados de la consulta
                    }

                    // Verificar si hay datos para graficar
                    if (dtDatos.Rows.Count > 0)
                    {
                        // Listas para los datos de la gráfica
                        ChartValues<decimal> valoresMonto = new ChartValues<decimal>();
                        List<string> nombresUsuarios = new List<string>();

                        // Recorrer los resultados y almacenar los datos
                        foreach (DataRow row in dtDatos.Rows)
                        {
                            nombresUsuarios.Add(row["nombreCompleto"].ToString());
                            valoresMonto.Add(Convert.ToDecimal(row["monto"]));
                        }

                        // Configurar los ejes de la gráfica
                        chart.AxisX.Add(new Axis
                        {
                            Title = "Usuarios",
                            Labels = nombresUsuarios
                        });

                        chart.AxisY.Add(new Axis
                        {
                            Title = "Monto Total ($)",
                            LabelFormatter = value => value.ToString("C") // Formato de moneda
                           
                        });


                        chart.Series.Add(new ColumnSeries
                        {
                            Title = "Monto Total Compras de Invitados",
                            Values = valoresMonto,
                            DataLabels = true,
                            LabelPoint = point => point.Y.ToString("C") // Mostrar el valor del monto con formato de moneda
                        });

                    }
                    else
                    {
                        MessageBox.Show("No hay datos disponibles para graficar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la gráfica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//GRAFICA DINAMICA
    }
}
