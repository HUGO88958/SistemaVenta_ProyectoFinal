namespace ProyectoFinalP2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new System.Windows.Forms.Panel();
            labelEslogan = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panelLogin = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            txtContraseña = new System.Windows.Forms.TextBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            buttonSalir = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            labelUsuario = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelEslogan);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(3, 9);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(343, 516);
            panel1.TabIndex = 0;
            // 
            // labelEslogan
            // 
            labelEslogan.AutoSize = true;
            labelEslogan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelEslogan.ForeColor = System.Drawing.Color.Gold;
            labelEslogan.Location = new System.Drawing.Point(39, 338);
            labelEslogan.Name = "labelEslogan";
            labelEslogan.Size = new System.Drawing.Size(258, 24);
            labelEslogan.TabIndex = 1;
            labelEslogan.Text = "¡Creando recuerdos felices!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MJ;
            pictureBox1.Location = new System.Drawing.Point(3, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(327, 319);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = System.Drawing.Color.Gray;
            panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelLogin.Controls.Add(panel2);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new System.Drawing.Point(352, 1);
            panelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new System.Drawing.Size(428, 530);
            panelLogin.TabIndex = 1;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Black;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel2.Controls.Add(txtContraseña);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(buttonSalir);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelUsuario);
            panel2.Location = new System.Drawing.Point(8, 89);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(403, 381);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtContraseña.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            txtContraseña.Location = new System.Drawing.Point(50, 186);
            txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            txtContraseña.Size = new System.Drawing.Size(303, 28);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            txtUsuario.Location = new System.Drawing.Point(47, 88);
            txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(303, 28);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = System.Drawing.Color.IndianRed;
            buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSalir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = System.Drawing.Color.White;
            buttonSalir.Location = new System.Drawing.Point(213, 272);
            buttonSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new System.Drawing.Size(116, 49);
            buttonSalir.TabIndex = 4;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(73, 272);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(116, 49);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Gold;
            label4.Location = new System.Drawing.Point(46, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 24);
            label4.TabIndex = 2;
            label4.Text = "CONTRASEÑA:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = System.Drawing.Color.Gold;
            labelUsuario.Location = new System.Drawing.Point(46, 54);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new System.Drawing.Size(82, 24);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(154, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 41);
            label2.TabIndex = 0;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(772, 530);
            Controls.Add(panelLogin);
            Controls.Add(panel1);
            ForeColor = System.Drawing.SystemColors.ButtonFace;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mundo Juguete";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEslogan;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}