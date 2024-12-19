namespace ProyectoFinalP2
{
    partial class TiendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiendaForm));
            button1 = new System.Windows.Forms.Button();
            panelLateral = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblUsuario = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            labelHora = new System.Windows.Forms.Label();
            panelHead = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelHead.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Dock = System.Windows.Forms.DockStyle.Right;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Goldenrod;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            button1.Location = new System.Drawing.Point(981, 0);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(197, 151);
            button1.TabIndex = 1;
            button1.Text = "Cerrar Sesion ";
            button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            panelLateral.Location = new System.Drawing.Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new System.Drawing.Size(259, 869);
            panelLateral.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(259, 177);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = System.Drawing.Color.White;
            lblUsuario.Location = new System.Drawing.Point(23, 108);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(65, 24);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "label2";
            lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblUsuario.Click += lblUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelHora);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.ForeColor = System.Drawing.Color.Black;
            panel1.Location = new System.Drawing.Point(259, 839);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1178, 30);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(542, 24);
            label3.TabIndex = 2;
            label3.Text = "Selecciona la cantidad de productos que deseas comprar :)";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            labelHora.Dock = System.Windows.Forms.DockStyle.Right;
            labelHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelHora.ForeColor = System.Drawing.Color.AliceBlue;
            labelHora.Location = new System.Drawing.Point(1047, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new System.Drawing.Size(131, 26);
            labelHora.TabIndex = 1;
            labelHora.Text = "Fecha y Hora";
            labelHora.Click += labelHora_Click;
            // 
            // panelHead
            // 
            panelHead.BackColor = System.Drawing.Color.Black;
            panelHead.Controls.Add(lblUsuario);
            panelHead.Controls.Add(label1);
            panelHead.Controls.Add(button1);
            panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            panelHead.Location = new System.Drawing.Point(259, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new System.Drawing.Size(1178, 151);
            panelHead.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Goldenrod;
            label1.Location = new System.Drawing.Point(6, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(575, 45);
            label1.TabIndex = 0;
            label1.Text = "¡CREANDO RECUERDOS FELICES!";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.BackColor = System.Drawing.Color.Orange;
            flpProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            flpProductos.Location = new System.Drawing.Point(259, 151);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new System.Drawing.Size(1178, 688);
            flpProductos.TabIndex = 6;
            // 
            // TiendaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(1437, 869);
            Controls.Add(flpProductos);
            Controls.Add(panelHead);
            Controls.Add(panel1);
            Controls.Add(panelLateral);
            Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "TiendaForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TiendaForm";
            panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
    }
}