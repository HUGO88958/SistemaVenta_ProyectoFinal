using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoFinalP2.DataAcces;




namespace ProyectoFinalP2
{
    public partial class GestionProductosForm : Form
    {
        private int idUsuario;
        public GestionProductosForm()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss"); // Actualizamos el label con la hora actual
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)//VER LISTADO CONSULTA
        {
            // Modificar la consulta para incluir el nombre de la imagen
            string query = "SELECT id, descripcion, precio, existencias, nombre_imagen FROM productos ORDER BY existencias ASC";// 
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new Conexion().GetConnection())
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt); // Llenar el DataTable con los datos
            }

            // Asignar el DataTable directamente al DataGridView
            dataGridViewProductos.DataSource = dt;

            // Ajustar el encabezado de la columna de la imagen (opcional)
            if (dataGridViewProductos.Columns.Contains("nombre_imagen"))
            {
                dataGridViewProductos.Columns["nombre_imagen"].HeaderText = "Nombre Imagen";
            }

            // Ajustar el ancho de las columnas para mejorar la visualización (opcional)
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private byte[] imagenBytes;
        private string nombreCompleto;

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la imagen en el PictureBox
                    pbImagen.Image = Image.FromFile(openFileDialog.FileName);

                    // Guardar la ruta de la imagen en el TextBox oculto
                    txtRutaImagen.Text = openFileDialog.FileName;

                    // Convertir la imagen a un arreglo de bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image img = Image.FromFile(openFileDialog.FileName);
                        img.Save(ms, img.RawFormat); // Guardar en el formato original (JPEG, PNG, etc.)
                        imagenBytes = ms.ToArray(); // Almacenar en la variable de clase
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar TextBoxes
            txtDescripcion.Text = string.Empty;

            // Restablecer NumericUpDowns
            numericPrecio.Value = 0;  // Restablecer a su valor mínimo
            numericExistencias.Value = 0;

            // Limpiar el PictureBox
            pbImagen.Image = null;

            // Limpiar la ruta de la imagen
            txtRutaImagen.Text = string.Empty;

            // Reiniciar el arreglo de bytes de la imagen
            imagenBytes = null;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || //Validacion ningun campo este vacio
                string.IsNullOrEmpty(numericPrecio.Text) ||
                string.IsNullOrEmpty(numericExistencias.Text) ||
                imagenBytes == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y cargue una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new Conexion().GetConnection())
                {
                    conn.Open();

                    // Leer el nombre del archivo de la ruta cargada
                    string nombreImagen = Path.GetFileName(txtRutaImagen.Text);

                    string query = "INSERT INTO productos (descripcion, precio, existencias, imagen, nombre_imagen) " +//INSERT INTO
                                   "VALUES (@descripcion, @precio, @existencias, @imagen, @nombre_imagen)";// Valor a insertar
                    //Funcion de inserccion
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);//
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(numericPrecio.Text));
                        cmd.Parameters.AddWithValue("@existencias", Convert.ToInt32(numericExistencias.Text));
                        cmd.Parameters.AddWithValue("@imagen", imagenBytes); // Imagen como byte[]
                        cmd.Parameters.AddWithValue("@nombre_imagen", nombreImagen); // Nombre de la imagen

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después de agregar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }//AGREGA PRODUCTO

        private void button1_Click(object sender, EventArgs e)
        {

            AdminForm frmAdmin = new AdminForm(idUsuario, nombreCompleto);
            frmAdmin.Show();
            Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIDEliminar.Text, out id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new Conexion().GetConnection())
            {
                conn.Open();

                // Verificar la cantidad total de registros en la tabla
                string queryCount = "SELECT COUNT(*) FROM Productos";
                MySqlCommand cmdCount = new MySqlCommand(queryCount, conn);
                int totalProductos = Convert.ToInt32(cmdCount.ExecuteScalar());

                if (totalProductos <= 6)
                {
                    MessageBox.Show("No es posible eliminar más productos. Se deben mantener al menos 6 productos.",
                                    "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consulta para obtener el producto a eliminar
                string querySelect = "SELECT * FROM Productos WHERE Id = @Id";
                MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn);
                cmdSelect.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    // Mostrar datos para confirmar eliminación
                    string descripcion = reader["descripcion"].ToString();
                    decimal precio = (decimal)reader["precio"];

                    DialogResult confirm = MessageBox.Show($"¿Deseas eliminar el producto?\n\nDescripción: {descripcion}\nPrecio: {precio}",
                                                           "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    reader.Close();

                    if (confirm == DialogResult.Yes)
                    {
                        // Eliminar producto
                        string queryDelete = "DELETE FROM Productos WHERE Id = @Id";
                        MySqlCommand cmdDelete = new MySqlCommand(queryDelete, conn);
                        cmdDelete.Parameters.AddWithValue("@Id", id);
                        cmdDelete.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//ELIMINAR PRODUCTO



        private void btnAgregarExistencias_Click_1(object sender, EventArgs e)
        {
            // Obtener el ID del producto y la cantidad a agregar desde los controles
            if (!int.TryParse(txtIDProductoAgregar.Text, out int idProducto) || idProducto <= 0)
            {
                MessageBox.Show("Ingrese un ID de producto válido (número entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidadAgregar.Text, out int cantidadAgregar) || cantidadAgregar <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de existencias a agregar (número entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la cantidad de existencias en la base de datos
            try
            {
                using (MySqlConnection conn = new Conexion().GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE productos SET existencias = existencias + @Cantidad WHERE Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidadAgregar);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Se agregaron {cantidadAgregar} existencias al producto con ID {idProducto}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Actualizar la lista de productos (opcional)
                            btnListar_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún producto con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las existencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
