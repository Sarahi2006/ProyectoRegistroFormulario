namespace FormularioRegistro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblTitulo = new Label();
            lblDui = new Label();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblGeneros = new Label();
            lblEspecialidad = new Label();
            lblEdad = new Label();
            lblObservaciones = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            labelEdad = new NumericUpDown();
            comboBoxEspecialidad = new ComboBox();
            txtobservaciones = new TextBox();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            txtDui = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            lblPrincipal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelEdad).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.conf;
            pictureBox1.Location = new Point(1006, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 734);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(1006, 259);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 20);
            lblTitulo.TabIndex = 2;
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDui.Location = new Point(341, 416);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(52, 23);
            lblDui.TabIndex = 3;
            lblDui.Text = "DUI :";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(297, 97);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(103, 23);
            lblNombres.TabIndex = 4;
            lblNombres.Text = "NOMBRES :";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(292, 162);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(114, 23);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "APELLIDOS :";
            // 
            // lblGeneros
            // 
            lblGeneros.AutoSize = true;
            lblGeneros.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneros.Location = new Point(318, 229);
            lblGeneros.Name = "lblGeneros";
            lblGeneros.Size = new Size(89, 23);
            lblGeneros.TabIndex = 6;
            lblGeneros.Text = "GENERO :";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEspecialidad.Location = new Point(268, 300);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(142, 23);
            lblEspecialidad.TabIndex = 7;
            lblEspecialidad.Text = "ESPECIALIDAD :";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(326, 363);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(67, 23);
            lblEdad.TabIndex = 8;
            lblEdad.Text = "EDAD :";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(244, 484);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(159, 23);
            lblObservaciones.TabIndex = 9;
            lblObservaciones.Text = "OBSERVACIONES :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(364, 650);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 53);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(583, 650);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 53);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelEdad
            // 
            labelEdad.Location = new Point(417, 364);
            labelEdad.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            labelEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(62, 27);
            labelEdad.TabIndex = 16;
            labelEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Items.AddRange(new object[] { "", "Ingenier@ En Desarollo De Software", "Programador", "Ingenieria en Sistemas", "Licenciad@ en conputacion" });
            comboBoxEspecialidad.Location = new Point(417, 300);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(317, 28);
            comboBoxEspecialidad.TabIndex = 17;
            // 
            // txtobservaciones
            // 
            txtobservaciones.Location = new Point(409, 484);
            txtobservaciones.Multiline = true;
            txtobservaciones.Name = "txtobservaciones";
            txtobservaciones.Size = new Size(407, 135);
            txtobservaciones.TabIndex = 18;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMasculino.ForeColor = Color.Gray;
            rbMasculino.Location = new Point(413, 229);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(128, 25);
            rbMasculino.TabIndex = 19;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "MASCULINO ";
            rbMasculino.UseVisualStyleBackColor = true;
            rbMasculino.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemenino.ForeColor = SystemColors.ControlDarkDark;
            rbFemenino.Location = new Point(572, 229);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(116, 25);
            rbFemenino.TabIndex = 20;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "FEMENINO ";
            rbFemenino.UseVisualStyleBackColor = true;
            rbFemenino.CheckedChanged += rbFemenino_CheckedChanged;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(409, 416);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(125, 27);
            txtDui.TabIndex = 21;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(409, 162);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(228, 27);
            txtApellidos.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(409, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1006, 70);
            textBox1.TabIndex = 24;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrincipal.Location = new Point(434, 21);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(243, 29);
            lblPrincipal.TabIndex = 25;
            lblPrincipal.Text = "REGISTRO PERSONAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1253, 734);
            Controls.Add(lblPrincipal);
            Controls.Add(textBox1);
            Controls.Add(txtNombre);
            Controls.Add(txtApellidos);
            Controls.Add(txtDui);
            Controls.Add(rbFemenino);
            Controls.Add(rbMasculino);
            Controls.Add(txtobservaciones);
            Controls.Add(comboBoxEspecialidad);
            Controls.Add(labelEdad);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblObservaciones);
            Controls.Add(lblEdad);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblGeneros);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(lblDui);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTitulo;
        private Label lblDui;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblGeneros;
        private Label lblEspecialidad;
        private Label lblEdad;
        private Label lblObservaciones;
        private Button btnRegistrar;
        private Button btnCancelar;
        private NumericUpDown labelEdad;
        private ComboBox comboBoxEspecialidad;
        private TextBox txtobservaciones;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private TextBox txtDui;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox textBox1;
        private Label lblPrincipal;
    }
}
