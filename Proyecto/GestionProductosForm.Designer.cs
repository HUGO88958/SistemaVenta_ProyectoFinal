using Microsoft.VisualBasic.ApplicationServices;

namespace ProyectoFinalP2
{
    partial class GestionProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProductosForm));
            panelMenuLateral = new System.Windows.Forms.Panel();
            btnAgregarExistencias = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            panelCabecera = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtRutaImagen = new System.Windows.Forms.TextBox();
            panelLogout = new System.Windows.Forms.Panel();
            labelHora = new System.Windows.Forms.Label();
            labelRefresh = new System.Windows.Forms.Label();
            btnListar = new System.Windows.Forms.Button();
            labelCerrarSesion = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            panelCentral = new System.Windows.Forms.Panel();
            dataGridViewProductos = new System.Windows.Forms.DataGridView();
            panelCampos = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtCantidadAgregar = new System.Windows.Forms.TextBox();
            txtIDProductoAgregar = new System.Windows.Forms.TextBox();
            txtIDEliminar = new System.Windows.Forms.TextBox();
            labelEliminar = new System.Windows.Forms.Label();
            numericExistencias = new System.Windows.Forms.NumericUpDown();
            numericPrecio = new System.Windows.Forms.NumericUpDown();
            btnCargarImagen = new System.Windows.Forms.Button();
            pbImagen = new System.Windows.Forms.PictureBox();
            labelExistencias = new System.Windows.Forms.Label();
            labelPrecio = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            labelDescripcion = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            labelID = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenuLateral.SuspendLayout();
            panelCabecera.SuspendLayout();
            panelLogout.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericExistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = System.Drawing.Color.Black;
            panelMenuLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panelMenuLateral.Controls.Add(btnAgregarExistencias);
            panelMenuLateral.Controls.Add(button1);
            panelMenuLateral.Controls.Add(btnEliminar);
            panelMenuLateral.Controls.Add(btnAgregar);
            panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new System.Drawing.Size(269, 766);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnAgregarExistencias
            // 
            btnAgregarExistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregarExistencias.FlatAppearance.BorderSize = 3;
            btnAgregarExistencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnAgregarExistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            btnAgregarExistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregarExistencias.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregarExistencias.ForeColor = System.Drawing.Color.Gold;
            btnAgregarExistencias.Image = (System.Drawing.Image)resources.GetObject("btnAgregarExistencias.Image");
            btnAgregarExistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAgregarExistencias.Location = new System.Drawing.Point(12, 520);
            btnAgregarExistencias.Name = "btnAgregarExistencias";
            btnAgregarExistencias.Size = new System.Drawing.Size(237, 62);
            btnAgregarExistencias.TabIndex = 5;
            btnAgregarExistencias.Text = "Agregar Existencias";
            btnAgregarExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAgregarExistencias.Click += btnAgregarExistencias_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 0);
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(269, 179);
            button1.TabIndex = 0;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = System.Drawing.Color.Gold;
            btnEliminar.Image = (System.Drawing.Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.Location = new System.Drawing.Point(12, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(237, 62);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Productos";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Black;
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = System.Drawing.Color.Gold;
            btnAgregar.Image = (System.Drawing.Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAgregar.Location = new System.Drawing.Point(12, 277);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnAgregar.Size = new System.Drawing.Size(237, 59);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Productos";
            btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelCabecera
            // 
            panelCabecera.BackColor = System.Drawing.Color.Black;
            panelCabecera.Controls.Add(label1);
            panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            panelCabecera.Location = new System.Drawing.Point(269, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new System.Drawing.Size(1060, 58);
            panelCabecera.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Gold;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(448, 41);
            label1.TabIndex = 11;
            label1.Text = "¡CREANDO RECUERDOS FELICES!";
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new System.Drawing.Point(849, 94);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.ReadOnly = true;
            txtRutaImagen.Size = new System.Drawing.Size(103, 27);
            txtRutaImagen.TabIndex = 10;
            txtRutaImagen.Visible = false;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(labelHora);
            panelLogout.Controls.Add(labelRefresh);
            panelLogout.Controls.Add(btnListar);
            panelLogout.Controls.Add(labelCerrarSesion);
            panelLogout.Controls.Add(btnLogout);
            panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelLogout.Location = new System.Drawing.Point(269, 720);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new System.Drawing.Size(1060, 46);
            panelLogout.TabIndex = 2;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHora.Location = new System.Drawing.Point(465, 13);
            labelHora.Name = "labelHora";
            labelHora.Size = new System.Drawing.Size(2, 22);
            labelHora.TabIndex = 4;
            // 
            // labelRefresh
            // 
            labelRefresh.AutoSize = true;
            labelRefresh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            labelRefresh.Location = new System.Drawing.Point(55, 11);
            labelRefresh.Name = "labelRefresh";
            labelRefresh.Size = new System.Drawing.Size(83, 22);
            labelRefresh.TabIndex = 3;
            labelRefresh.Text = "Ver Lista";
            // 
            // btnListar
            // 
            btnListar.BackgroundImage = Properties.Resources.Refresh;
            btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnListar.Dock = System.Windows.Forms.DockStyle.Left;
            btnListar.Location = new System.Drawing.Point(0, 0);
            btnListar.Name = "btnListar";
            btnListar.Size = new System.Drawing.Size(49, 46);
            btnListar.TabIndex = 2;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // labelCerrarSesion
            // 
            labelCerrarSesion.AutoSize = true;
            labelCerrarSesion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            labelCerrarSesion.Location = new System.Drawing.Point(880, 11);
            labelCerrarSesion.Name = "labelCerrarSesion";
            labelCerrarSesion.Size = new System.Drawing.Size(125, 22);
            labelCerrarSesion.TabIndex = 1;
            labelCerrarSesion.Text = "Cerrar Sesion";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = Properties.Resources.logout;
            btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.ForeColor = System.Drawing.Color.Transparent;
            btnLogout.Location = new System.Drawing.Point(995, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(65, 46);
            btnLogout.TabIndex = 0;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            panelCentral.Controls.Add(dataGridViewProductos);
            panelCentral.Controls.Add(txtRutaImagen);
            panelCentral.Controls.Add(panelCampos);
            panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCentral.Location = new System.Drawing.Point(269, 58);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new System.Drawing.Size(1060, 662);
            panelCentral.TabIndex = 3;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new System.Drawing.Point(11, 127);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new System.Drawing.Size(1035, 510);
            dataGridViewProductos.TabIndex = 1;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = System.Drawing.Color.Gold;
            panelCampos.Controls.Add(label3);
            panelCampos.Controls.Add(label2);
            panelCampos.Controls.Add(txtCantidadAgregar);
            panelCampos.Controls.Add(txtIDProductoAgregar);
            panelCampos.Controls.Add(txtIDEliminar);
            panelCampos.Controls.Add(labelEliminar);
            panelCampos.Controls.Add(numericExistencias);
            panelCampos.Controls.Add(numericPrecio);
            panelCampos.Controls.Add(btnCargarImagen);
            panelCampos.Controls.Add(pbImagen);
            panelCampos.Controls.Add(labelExistencias);
            panelCampos.Controls.Add(labelPrecio);
            panelCampos.Controls.Add(txtDescripcion);
            panelCampos.Controls.Add(labelDescripcion);
            panelCampos.Controls.Add(txtID);
            panelCampos.Controls.Add(labelID);
            panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            panelCampos.Location = new System.Drawing.Point(0, 0);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new System.Drawing.Size(1060, 106);
            panelCampos.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(641, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 24);
            label3.TabIndex = 17;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(518, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 24);
            label2.TabIndex = 16;
            label2.Text = "ID:";
            // 
            // txtCantidadAgregar
            // 
            txtCantidadAgregar.Location = new System.Drawing.Point(737, 70);
            txtCantidadAgregar.Name = "txtCantidadAgregar";
            txtCantidadAgregar.Size = new System.Drawing.Size(66, 27);
            txtCantidadAgregar.TabIndex = 15;
            // 
            // txtIDProductoAgregar
            // 
            txtIDProductoAgregar.Location = new System.Drawing.Point(557, 70);
            txtIDProductoAgregar.Name = "txtIDProductoAgregar";
            txtIDProductoAgregar.Size = new System.Drawing.Size(50, 27);
            txtIDProductoAgregar.TabIndex = 14;
            // 
            // txtIDEliminar
            // 
            txtIDEliminar.Location = new System.Drawing.Point(120, 71);
            txtIDEliminar.Name = "txtIDEliminar";
            txtIDEliminar.Size = new System.Drawing.Size(82, 27);
            txtIDEliminar.TabIndex = 13;
            // 
            // labelEliminar
            // 
            labelEliminar.AutoSize = true;
            labelEliminar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelEliminar.Location = new System.Drawing.Point(6, 73);
            labelEliminar.Name = "labelEliminar";
            labelEliminar.Size = new System.Drawing.Size(114, 24);
            labelEliminar.TabIndex = 12;
            labelEliminar.Text = "ID Eliminar:";
            // 
            // numericExistencias
            // 
            numericExistencias.Location = new System.Drawing.Point(695, 30);
            numericExistencias.Name = "numericExistencias";
            numericExistencias.Size = new System.Drawing.Size(59, 27);
            numericExistencias.TabIndex = 11;
            // 
            // numericPrecio
            // 
            numericPrecio.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericPrecio.Location = new System.Drawing.Point(465, 29);
            numericPrecio.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new System.Drawing.Size(59, 27);
            numericPrecio.TabIndex = 10;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackgroundImage = Properties.Resources.CargarImagenes;
            btnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCargarImagen.Location = new System.Drawing.Point(980, 21);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new System.Drawing.Size(52, 48);
            btnCargarImagen.TabIndex = 9;
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // pbImagen
            // 
            pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pbImagen.Location = new System.Drawing.Point(812, 6);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new System.Drawing.Size(162, 91);
            pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 8;
            pbImagen.TabStop = false;
            // 
            // labelExistencias
            // 
            labelExistencias.AutoSize = true;
            labelExistencias.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelExistencias.Location = new System.Drawing.Point(582, 28);
            labelExistencias.Name = "labelExistencias";
            labelExistencias.Size = new System.Drawing.Size(117, 24);
            labelExistencias.TabIndex = 6;
            labelExistencias.Text = "Existencias:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPrecio.Location = new System.Drawing.Point(395, 27);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new System.Drawing.Size(73, 24);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(257, 28);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(109, 27);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelDescripcion.Location = new System.Drawing.Point(141, 27);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new System.Drawing.Size(121, 24);
            labelDescripcion.TabIndex = 2;
            labelDescripcion.Text = "Descripción:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(34, 27);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(82, 27);
            txtID.TabIndex = 1;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelID.Location = new System.Drawing.Point(6, 26);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(33, 24);
            labelID.TabIndex = 0;
            labelID.Text = "ID:";
            // 
            // GestionProductosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1329, 766);
            Controls.Add(panelCentral);
            Controls.Add(panelLogout);
            Controls.Add(panelCabecera);
            Controls.Add(panelMenuLateral);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "GestionProductosForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestion de Productos - Mundo Juguete";
            panelMenuLateral.ResumeLayout(false);
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelLogout.ResumeLayout(false);
            panelLogout.PerformLayout();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericExistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label labelCerrarSesion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelExistencias;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.NumericUpDown numericExistencias;
        private System.Windows.Forms.NumericUpDown numericPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAgregarExistencias;
        private System.Windows.Forms.TextBox txtIDProductoAgregar;
        private System.Windows.Forms.TextBox txtCantidadAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}