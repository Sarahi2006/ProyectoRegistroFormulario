namespace FormularioRegistro
{
    partial class Registro
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
            groupBox1 = new GroupBox();
            Generolabel = new Label();
            labelApellido = new Label();
            labelEdad = new Label();
            Especialistalabel = new Label();
            ApellidosLbl = new Label();
            GeneroDlabel3 = new Label();
            labelEspecialista = new Label();
            EdadLabel = new Label();
            labelName = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(Generolabel);
            groupBox1.Controls.Add(labelApellido);
            groupBox1.Controls.Add(labelEdad);
            groupBox1.Controls.Add(Especialistalabel);
            groupBox1.Controls.Add(ApellidosLbl);
            groupBox1.Controls.Add(GeneroDlabel3);
            groupBox1.Controls.Add(labelEspecialista);
            groupBox1.Controls.Add(EdadLabel);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(105, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 586);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del registro";
            // 
            // Generolabel
            // 
            Generolabel.AutoSize = true;
            Generolabel.Font = new Font("Arial Rounded MT Bold", 12F);
            Generolabel.Location = new Point(206, 306);
            Generolabel.Name = "Generolabel";
            Generolabel.Size = new Size(0, 23);
            Generolabel.TabIndex = 15;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(207, 131);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(0, 23);
            labelApellido.TabIndex = 14;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdad.Location = new Point(172, 171);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(0, 23);
            labelEdad.TabIndex = 13;
            // 
            // Especialistalabel
            // 
            Especialistalabel.AutoSize = true;
            Especialistalabel.Font = new Font("Arial Rounded MT Bold", 12F);
            Especialistalabel.Location = new Point(274, 241);
            Especialistalabel.Name = "Especialistalabel";
            Especialistalabel.Size = new Size(0, 23);
            Especialistalabel.TabIndex = 12;
            // 
            // ApellidosLbl
            // 
            ApellidosLbl.AutoSize = true;
            ApellidosLbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApellidosLbl.Location = new Point(69, 125);
            ApellidosLbl.Name = "ApellidosLbl";
            ApellidosLbl.Size = new Size(132, 26);
            ApellidosLbl.TabIndex = 11;
            ApellidosLbl.Text = " Apellidos :";
            // 
            // GeneroDlabel3
            // 
            GeneroDlabel3.AutoSize = true;
            GeneroDlabel3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GeneroDlabel3.Location = new Point(69, 298);
            GeneroDlabel3.Name = "GeneroDlabel3";
            GeneroDlabel3.Size = new Size(125, 29);
            GeneroDlabel3.TabIndex = 7;
            GeneroDlabel3.Text = " Genero  :";
            // 
            // labelEspecialista
            // 
            labelEspecialista.AutoSize = true;
            labelEspecialista.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEspecialista.Location = new Point(69, 233);
            labelEspecialista.Name = "labelEspecialista";
            labelEspecialista.Size = new Size(180, 29);
            labelEspecialista.TabIndex = 4;
            labelEspecialista.Text = "Especialista  :";
            // 
            // EdadLabel
            // 
            EdadLabel.AutoSize = true;
            EdadLabel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EdadLabel.Location = new Point(69, 171);
            EdadLabel.Name = "EdadLabel";
            EdadLabel.Size = new Size(87, 29);
            EdadLabel.TabIndex = 2;
            EdadLabel.Text = "Edad :";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(189, 75);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 26);
            labelName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 75);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(975, 750);
            Controls.Add(groupBox1);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelName;
        private Label label1;
        private Label labelEspecialista;
        private Label EdadLabel;
        private Label GeneroDlabel3;
        private Label ApellidosLbl;
        private Label Generolabel;
        private Label labelApellido;
        private Label labelEdad;
        private Label Especialistalabel;
    }
}