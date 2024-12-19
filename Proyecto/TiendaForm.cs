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
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.IO.Font.Constants;
using iText.IO.Image;
using Image = iText.Layout.Element.Image;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using Color = iText.Kernel.Colors.Color;
using System.Transactions;






namespace ProyectoFinalP2
{
    public partial class TiendaForm : Form
    {
        private int idUsuarioActual; // ID del usuario que se pasó desde LoginForm
        public TiendaForm(int idUsuario,string nombreCompleto) //Construuctor
        {
            InitializeComponent();
     
            timer1.Start();
            CargarProductos();
            InicializarCompra();
            idUsuarioActual = idUsuario;
            lblUsuario.Text = $"Bienvenido, {nombreCompleto}";

            // Agregar el botón "Realizar Compra"
            Button btnComprar = new Button
            {
                BackColor = System.Drawing.Color.Black,
                FlatStyle = FlatStyle.Flat, 
                Text = "Realizar Compra",
                ForeColor = System.Drawing.Color.Gold,
                Dock = DockStyle.Bottom,
                Height = 50,
                Font = new Font("Bahnschrift", 22, FontStyle.Bold)


            };

            btnComprar.Click += BtnComprar_Click;
            this.Controls.Add(btnComprar);

            Button btnBorrarProductos = new Button
            {
                BackColor = System.Drawing.Color.Red,
                FlatStyle = FlatStyle.Flat,
                Text = "Borrar Productos Seleccionados",
                ForeColor = System.Drawing.Color.White,
                Dock = DockStyle.Bottom,
                Height = 50,
                Font = new Font("Bahnschrift", 18, FontStyle.Bold)
            };

            btnBorrarProductos.Click += BtnBorrarProductos_Click;
            this.Controls.Add(btnBorrarProductos);

        }

       

        private class ProductoCarrito
        {
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal => Producto.Precio * Cantidad;

        }//Clase para controlar los productos seleccionados
        private List<ProductoCarrito> carrito = new List<ProductoCarrito>();
        private Panel CrearPanelProducto(Producto producto)
        {
            Panel panelProducto = new Panel
            {
                Width = 200,
                Height = 300,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            PictureBox pbImagen = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Height = 150
            };

            // Ruta relativa para cargar la imagen
            string rutaImagen = Path.Combine(Application.StartupPath, "imagenes", producto.Imagen);
            if (File.Exists(rutaImagen))
            {
                pbImagen.Image = System.Drawing.Image.FromFile(rutaImagen);
            }
            else
            {
                pbImagen.Image = Properties.Resources.MJ; // Imagen predeterminada
            }

            Label lblDescripcion = new Label
            {
                Text = producto.Descripcion,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 40,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label lblPrecio = new Label
            {
                Text = $"Precio: ${producto.Precio:F2}",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 30,
                Font = new Font("Arial", 9, FontStyle.Regular)
            };

            Label lblExistencias = new Label
            {
                Text = $"Existencias: {producto.Existencias}",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 30,
                Font = new Font("Arial", 9, FontStyle.Regular),
                ForeColor = producto.Existencias > 0 ? System.Drawing.Color.Black : System.Drawing.Color.Red
            };

            panelProducto.Controls.Add(lblExistencias);
            panelProducto.Controls.Add(lblPrecio);
            panelProducto.Controls.Add(lblDescripcion);
            panelProducto.Controls.Add(pbImagen);

            return panelProducto;
        }//Creacion del panel para mostrar los productos por su existencia




        private List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

           
            

            using (MySqlConnection conn = new DataAcces.Conexion().GetConnection())

            {
                conn.Open();

                // Consulta SQL para obtener los productos
                string query = "SELECT id, nombre_imagen, descripcion, precio, existencias FROM Productos WHERE existencias > 0";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32(0), // Id
                                Imagen = reader.GetString(1), // Imagen (nombre de archivo)
                                Descripcion = reader.GetString(2), // Descripción
                                Precio = reader.GetDecimal(3), // Precio
                                Existencias = reader.GetInt32(4) // Existencias
                            };

                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }//Metodo para obtener productos (Solo obtener los productos que tengan existencias >0)


        private void CargarProductos()
        {
            // Limpia el FlowLayoutPanel antes de cargar productos
            flpProductos.Controls.Clear();

            // Simula obtener productos de la base de datos
            List<Producto> productos = ObtenerProductos();

            foreach (var producto in productos)
            {
                // Crear un panel para cada producto
                Panel panelProducto = CrearPanelProducto(producto);

                // Agregar el panel al FlowLayoutPanel
                flpProductos.Controls.Add(panelProducto);
            }
        }//Metodo para cargar productos

        private void AgregarMetodoCompra()
        {

            //PANELES DE LOS PRODUCTOS CON CONTROL NUMERICUPDOWN
            foreach (Panel panelProducto in flpProductos.Controls)
            {
                NumericUpDown nudCantidad = new NumericUpDown()
                {
                    Minimum = 0,
                    Maximum = 10,
                    Dock = DockStyle.Bottom,
                    TextAlign = System.Windows.Forms.HorizontalAlignment.Center,
                };

                Label lblExistencias = panelProducto.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("Existencias:"));

                if (lblExistencias != null) //Validacion para limitar el maximo de la cantidad de existencias
                {
                    int existencias = int.Parse(lblExistencias.Text.Replace("Existencias: ", ""));
                    nudCantidad.Maximum = existencias;
                }

                panelProducto.Controls.Add(nudCantidad);
            }




        }// Metodo para seleccion productos


        private void BtnComprar_Click(object sender, EventArgs e)
        {
            carrito.Clear();

            //ALMCENAR PRODUCTOS SELECCIONADOS
            foreach (Panel panelProducto in flpProductos.Controls)
            {
                NumericUpDown nudCantidad = panelProducto.Controls.OfType<NumericUpDown>().FirstOrDefault();

                if (nudCantidad != null && nudCantidad.Value > 0)
                {
                    //informacion de producto
                    Label lblDescripcion = panelProducto.Controls.OfType<Label>().FirstOrDefault(l => !l.Text.StartsWith("Precio:") && !l.Text.StartsWith("Existencias: "));
                    Label lblPrecio = panelProducto.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("Precio:"));

                    if (lblDescripcion != null && lblPrecio != null)
                    {
                        Producto producto = ObtenerProductos().FirstOrDefault(p => p.Descripcion == lblDescripcion.Text);
                        if (producto != null)
                        {
                            carrito.Add(new ProductoCarrito { Producto = producto, Cantidad = (int)nudCantidad.Value });
                        }


                    }
                }
            }
            //VERIFICAR SI HAY PRODUCTOS 
            if (carrito.Count == 0)
            {
                MessageBox.Show("No ha seleccionado ningun producto.", "Carrito Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Mostrar lo que se ha comprado
            MostrarResumenCompra();

        }//Boton REALIZAR COMPRA
        private void BtnBorrarProductos_Click(object sender, EventArgs e) //Boton BORRAR PRODUC SELEC
        {
            //recorre todos los paneles
            foreach (Panel panelProducto in flpProductos.Controls)
            {
                // Encuentra el control NumericUpDown en cada panel
                NumericUpDown nudCantidad = panelProducto.Controls.OfType<NumericUpDown>().FirstOrDefault();

                // Resetea el valor del control a 0
                if (nudCantidad != null)
                {
                    nudCantidad.Value = 0;
                }
            }

            // Limpia
            carrito.Clear();
        }




        private void GenerarPDF()//Metodo para generar el PDFgit
        {
            try
            {
                // Crea un cuadro de diálogo para guardar el archivo para elegir la ubicación para guardar el PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Guardar Resumen de Compra",
                    FileName = $"ResumenCompra_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Uso de iText7
                    using (var writer = new PdfWriter(saveFileDialog.FileName))
                    using (var pdf = new PdfDocument(writer))
                    using (var document = new Document(pdf))
                    {
                        //Establecer margenes
                        document.SetMargins(50, 50, 50, 50);

                        //Fuentes
                        PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                        PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                        //Agregar Logo y nombre = Mundo Juguete
                        string logoPath = Path.Combine(Application.StartupPath, "imagenes", "MJ.jpg");

                        //Comprobacion de errores...
                        if (!Directory.Exists(Path.Combine(Application.StartupPath, "imagenes")))
                        {
                            MessageBox.Show($"La carpeta 'imagenes' no existe en: {Application.StartupPath}", "Error de Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Verificar existencia del archivo
                        if (!File.Exists(logoPath))
                        {
                            MessageBox.Show($"El archivo logo no existe en: {logoPath}\n" +
                                            $"Carpeta de inicio: {Application.StartupPath}\n" +
                                            "Verifica la ruta y el nombre del archivo.",
                                            "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Agregar un logo de respaldo o texto si no se encuentra
                            document.Add(new Paragraph("¡CREANDO RECUERDOS FELCIES!")
                                .SetFont(titleFont)
                                .SetFontSize(18)
                                .SetTextAlignment(TextAlignment.CENTER));
                        }
                        else
                        {
                            //Agregar Logo
                            ImageData imageData = ImageDataFactory.Create(logoPath);
                            Image logo = new Image(imageData).ScaleToFit(100, 100);

                            // Crea la tabla
                            Table headerTable = new Table(2).UseAllAvailableWidth();
                            headerTable.SetBorder(Border.NO_BORDER);

                            // Logo en la primer celda
                            Cell logoCell = new Cell().Add(logo).SetBorder(Border.NO_BORDER);
                            headerTable.AddCell(logoCell);

                            //Nombre empresa seguna celda
                            Cell companyNameCell = new Cell()
                                .Add(new Paragraph("MUNDO JUGUETE")
                                    .SetFont(titleFont)
                                    .SetFontSize(18)
                                    .SetTextAlignment(TextAlignment.RIGHT))
                                .Add(new Paragraph("Av. Universidad 940, Ciudad Universitaria, Universidad Autónoma de Aguascalientes, 20100 Aguascalientes, Ags.")
                                    .SetFont(normalFont)
                                    .SetFontSize(10)
                                    .SetTextAlignment(TextAlignment.RIGHT)
                                    .SetFontColor(ColorConstants.BLUE))
                                .SetBorder(Border.NO_BORDER);

                            headerTable.AddCell(companyNameCell);

                            document.Add(headerTable);
                        }


                        
                        document.Add(new Paragraph("\n"));

                        //Titulo
                        document.Add(new Paragraph("Resumen de Compra")
                            .SetFont(titleFont)
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontColor(new DeviceRgb(44, 62, 80))); // Dark blue color

                        //Fecha Y hora
                        document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                            .SetFont(normalFont)
                            .SetFontSize(12)
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetFontColor(ColorConstants.GRAY));

                        //Creacion de tablas de productos comprados
                        Table table = new Table(4).UseAllAvailableWidth();
                        Color headerBackgroundColor = new DeviceRgb(52, 152, 219); // Blue color
                        Color headerTextColor = ColorConstants.WHITE;

                        // Método auxiliar para crear celdas de encabezado con estilo
                        Cell CreateHeaderCell(string text)
                        {
                            return new Cell()
                                .Add(new Paragraph(text).SetFont(titleFont).SetFontColor(headerTextColor))
                                .SetBackgroundColor(headerBackgroundColor)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetBorder(Border.NO_BORDER);
                        }

                        table.AddHeaderCell(CreateHeaderCell("Producto"));
                        table.AddHeaderCell(CreateHeaderCell("Cantidad"));
                        table.AddHeaderCell(CreateHeaderCell("Precio Unitario"));
                        table.AddHeaderCell(CreateHeaderCell("Subtotal"));

                        //Agregar Productsos 
                        decimal subtotal = 0;
                        bool isAlternateRow = false;
                        foreach (var item in carrito)
                        {
                            Color rowColor = isAlternateRow
                                ? new DeviceRgb(230, 240, 250) 
                                : ColorConstants.WHITE;

                            void AddStyledCell(string text)
                            {
                                table.AddCell(new Cell()
                                    .Add(new Paragraph(text).SetFont(normalFont))
                                    .SetBackgroundColor(rowColor)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetBorder(Border.NO_BORDER));
                            }

                            AddStyledCell(item.Producto.Descripcion);
                            AddStyledCell(item.Cantidad.ToString());
                            AddStyledCell($"${item.Producto.Precio:F2}");

                            decimal itemSubtotal = item.Cantidad * item.Producto.Precio;
                            AddStyledCell($"${itemSubtotal:F2}");

                            subtotal += itemSubtotal;
                            isAlternateRow = !isAlternateRow;
                        }

                        //Agregar tabla en el documento
                        document.Add(table);

                        //Totales
                        decimal impuestos = subtotal * 0.06m;
                        decimal total = subtotal + impuestos;

                        Style totalStyle = new Style()
                            .SetFont(normalFont)
                            .SetFontSize(12)
                            .SetTextAlignment(TextAlignment.RIGHT);

                        document.Add(new Paragraph($"\nSubtotal: ${subtotal:F2}")
                            .AddStyle(totalStyle));

                        document.Add(new Paragraph($"Impuestos (6%): ${impuestos:F2}")
                            .AddStyle(totalStyle));

                        document.Add(new Paragraph($"Total: ${total:F2}")
                            .SetFont(titleFont)
                            .SetFontSize(14)
                            .SetFontColor(new DeviceRgb(39, 174, 96))//Verde
                            .SetTextAlignment(TextAlignment.RIGHT));

                        //SE GENERA EL DOCUMENTO
                        MessageBox.Show("PDF generado exitosamente", "Descarga Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = saveFileDialog.FileName,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception openEx)
                        {
                            MessageBox.Show($"No se pudo abrir el PDF automáticamente: {openEx.Message}", "Error al Abrir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void MostrarResumenCompra()
        {
            // Calcular totales (calcula el subtotal total multiplicando el precio de cada producto por su cantidad y luego sumando todos esos valores.)
            decimal subtotal = carrito.Sum(c => c.Subtotal);
            decimal impuestos = subtotal * 0.06m;
            decimal total = subtotal + impuestos;

            // Crear formulario de confirmación
            Form formResumen = new Form
            {
                Text = "Resumen de Compra",
                Size = new Size(600, 400),
                StartPosition = FormStartPosition.CenterScreen,
            };

            // DataGridView para mostrar productos
            DataGridView dgvProductos = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 200,
                ReadOnly = true,
                AutoGenerateColumns = false
            };

            //columnas
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Producto",
                Name = "Descripcion"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Name = "Cantidad"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Name = "Precio"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Name = "Subtotal"
            });

            // Preparar datos para el DataGridView
            var datosGrid = carrito.Select(c => new
            {
                Descripcion = c.Producto.Descripcion,
                Cantidad = c.Cantidad,
                Precio = c.Producto.Precio.ToString("C2"),
                Subtotal = c.Subtotal.ToString("C2")
            }).ToList();

            dgvProductos.DataSource = datosGrid;

            // Labels de totales
            Label lblSubtotal = new Label
            {
                Text = $"Subtotal: {subtotal:C2}",
                Location = new Point(10, 210),
                AutoSize = true
            };

            Label lblImpuestos = new Label
            {
                Text = $"Impuestos (6%): {impuestos:C2}",
                Location = new Point(10, 240),
                AutoSize = true
            };

            Label lblTotal = new Label
            {
                Text = $"Total: {total:C2}",
                Location = new Point(10, 270),
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            // Botones
            Button btnConfirmar = new Button
            {
                Text = "Confirmar Compra",
                Location = new Point(50, 300),
                DialogResult = DialogResult.OK
            };

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(200, 300),
                DialogResult = DialogResult.Cancel
            };

            Button btnDescargarPDF = new Button
            {
                Text = "Descargar PDF",
                Location = new Point(350, 300),
                DialogResult = DialogResult.None
        
            };

            btnConfirmar.Click += (s, e) =>
            {
                // Mostrar opciones de pago
                DialogResult resultado = MessageBox.Show("Seleccione un método de pago:\n\nSí = Efectivo\nNo = Tarjeta",
                                                        "Método de Pago",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Pago en Efectivo
                    SimularPagoEfectivo(total);
                }
                else if (resultado == DialogResult.No)
                {
                    // Pago con Tarjeta
                    SimularPagoTarjeta(total);
                }

            };

            btnDescargarPDF.Click += (s, e) =>
            {
                GenerarPDF(); // Genera el PDF

            };

            // Agregar controles
            formResumen.Controls.Add(dgvProductos);
            formResumen.Controls.Add(lblSubtotal);
            formResumen.Controls.Add(lblImpuestos);
            formResumen.Controls.Add(lblTotal);
            formResumen.Controls.Add(btnConfirmar);
            formResumen.Controls.Add(btnCancelar);
            formResumen.Controls.Add(btnDescargarPDF);

            // Mostrar formulario
            formResumen.ShowDialog();
        }//Detalles de la compra

        private void RealizarCompra()
        {
            using (MySqlConnection conn = new DataAcces.Conexion().GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    decimal totalCompra = 0;

                    foreach (var itemCarrito in carrito)
                    {
                        // Actualizar existencias
                        string queryActualizar = @"UPDATE Productos SET existencias = existencias - @Cantidad WHERE id = @ProductoId AND existencias >= @Cantidad";

                        using (MySqlCommand cmd = new MySqlCommand(queryActualizar, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Cantidad", itemCarrito.Cantidad);
                            cmd.Parameters.AddWithValue("@ProductoId", itemCarrito.Producto.Id);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas == 0)
                            {
                                throw new Exception($"No hay suficientes existencias para {itemCarrito.Producto.Descripcion}");
                            }

                            totalCompra += itemCarrito.Subtotal;
                        }
                    }

                    // Actualizar el campo "monto" en la tabla de usuarios
                    string queryActualizarMonto = @"UPDATE usuarios SET monto = monto + @Total WHERE id = @UsuarioId";

                    using (MySqlCommand cmdMonto = new MySqlCommand(queryActualizarMonto, conn, transaction))
                    {
                        cmdMonto.Parameters.AddWithValue("@Total", totalCompra);
                        cmdMonto.Parameters.AddWithValue("@UsuarioId", idUsuarioActual);

                        cmdMonto.ExecuteNonQuery();
                    }

                    // Commit de la transacción
                    transaction.Commit();

                    // Mensaje de éxito
                    MessageBox.Show("Compra realizada con éxito",
                        "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar productos
                    CargarProductos();
                    AgregarMetodoCompra();
                }
                catch (Exception ex)
                {
                    // Rollback en caso de error
                    transaction.Rollback();

                    MessageBox.Show($"Error al realizar la compra: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }// DISMINUCION DE EXXITENCIAS
        private int ObtenerIdUsuarioActual()
        {
            return DatosCompartidos.UsuarioId;
        }
        private void InicializarCompra()
        {
            AgregarMetodoCompra();
        }


        private void SimularPagoEfectivo(decimal total)
        {
            // Obtener el ID del usuario actual (almacénalo en una variable de clase al iniciar sesión)
            int usuarioId = ObtenerIdUsuarioActual();

            Form formEfectivo = new Form
            {
                Text = "Pago en Efectivo",
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblTotal = new Label
            {
                Text = $"Total a pagar: {total:C2}",
                Location = new Point(10, 20),
                AutoSize = true
            };

            Label lblPago = new Label
            {
                Text = "Ingrese el monto pagado:",
                Location = new Point(10, 60),
                AutoSize = true
            };

            TextBox txtMontoPagado = new TextBox
            {
                Location = new Point(150, 60),
                Width = 100
            };

            Button btnCalcularCambio = new Button
            {
                Text = "Calcular Cambio",
                Location = new Point(100, 100),
                DialogResult = DialogResult.OK
            };

            btnCalcularCambio.Click += (s, e) =>
            {
                if (decimal.TryParse(txtMontoPagado.Text, out decimal montoPagado))
                {
                    if (montoPagado >= total)
                    {
                        decimal cambio = montoPagado - total;
                        MessageBox.Show($"Pago recibido: {montoPagado:C2}\nCambio: {cambio:C2}",
                                        "Pago Exitoso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        

                        RealizarCompra();
                        formEfectivo.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("El monto ingresado es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            formEfectivo.Controls.Add(lblTotal);
            formEfectivo.Controls.Add(lblPago);
            formEfectivo.Controls.Add(txtMontoPagado);
            formEfectivo.Controls.Add(btnCalcularCambio);

            formEfectivo.ShowDialog();
        }//APORTACION1


        private void SimularPagoTarjeta(decimal total)
        {
            int usuarioId = ObtenerIdUsuarioActual();
            // Crear un formulario para ingresar datos de tarjeta
            Form formTarjeta = new Form
            {
                Text = "Pago con Tarjeta",
                Size = new Size(400, 250),
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblTotal = new Label
            {
                Text = $"Total a pagar: {total:C2}",
                Location = new Point(10, 20),
                AutoSize = true
            };

            Label lblTarjeta = new Label
            {
                Text = "Número de Tarjeta:",
                Location = new Point(10, 60),
                AutoSize = true
            };

            TextBox txtNumeroTarjeta = new TextBox
            {
                Location = new Point(150, 60),
                Width = 200
            };

            Label lblCVV = new Label
            {
                Text = "CVV:",
                Location = new Point(10, 100),
                AutoSize = true
            };

            TextBox txtCVV = new TextBox
            {
                Location = new Point(150, 100),
                Width = 50
            };

            Button btnPagar = new Button
            {
                Text = "Confirmar Pago",
                Location = new Point(150, 150),
                DialogResult = DialogResult.OK
            };

            btnPagar.Click += (s, e) =>
            {
                // Simular validación simple
                if (txtNumeroTarjeta.Text.Length == 16 && txtCVV.Text.Length == 3)
                {
                    MessageBox.Show("Pago con tarjeta exitoso. Gracias por su compra.",
                                    "Pago Exitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    
                    if (usuarioId != -1)
                    {
                       
                        RealizarCompra();
                        formTarjeta.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al encontrar la cuenta de 'guest'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Número de tarjeta o CVV inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            formTarjeta.Controls.Add(lblTotal);
            formTarjeta.Controls.Add(lblTarjeta);
            formTarjeta.Controls.Add(txtNumeroTarjeta);
            formTarjeta.Controls.Add(lblCVV);
            formTarjeta.Controls.Add(txtCVV);
            formTarjeta.Controls.Add(btnPagar);

            formTarjeta.ShowDialog();
        }//APORTACION2

        private void button1_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual(TiendaForm)
            this.Hide();

            // Mostrar el formulario de login
            login loginForm = new login();
            loginForm.Show();
        }//boton para hacer logout

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }//Mostrar fecha

        private void labelHora_Click(object sender, EventArgs e)
        {

        }//

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }//

      
    }
}
