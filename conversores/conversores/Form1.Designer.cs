namespace conversores
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
            cboOpciones = new ComboBox();
            label1 = new Label();
            btnCalcular = new Button();
            txtCantidad = new TextBox();
            lblRespuesta = new Label();
            lblCantidad = new Label();
            cboA = new ComboBox();
            cboDe = new ComboBox();
            lblA = new Label();
            lblDe = new Label();
            SuspendLayout();
            // 
            // cboOpciones
            // 
            cboOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Items.AddRange(new object[] { "Longitud", "Moneda", "Masa", "Volumen", "Almacenamiento", "Tiempo" });
            cboOpciones.Location = new Point(383, 35);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(374, 33);
            cboOpciones.TabIndex = 49;
            cboOpciones.SelectedIndexChanged += cboOpciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(232, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 48;
            label1.Text = "Opciones";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btnCalcular.ImeMode = ImeMode.NoControl;
            btnCalcular.Location = new Point(407, 438);
            btnCalcular.Margin = new Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(274, 183);
            btnCalcular.TabIndex = 47;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(232, 356);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(225, 31);
            txtCantidad.TabIndex = 46;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblRespuesta.ImeMode = ImeMode.NoControl;
            lblRespuesta.Location = new Point(580, 342);
            lblRespuesta.Margin = new Padding(4, 0, 4, 0);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(202, 45);
            lblRespuesta.TabIndex = 45;
            lblRespuesta.Text = "Respuesta: ?";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblCantidad.ImeMode = ImeMode.NoControl;
            lblCantidad.Location = new Point(44, 356);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(158, 45);
            lblCantidad.TabIndex = 44;
            lblCantidad.Text = "cantidad:";
            // 
            // cboA
            // 
            cboA.FormattingEnabled = true;
            cboA.Location = new Point(697, 184);
            cboA.Margin = new Padding(4, 5, 4, 5);
            cboA.Name = "cboA";
            cboA.Size = new Size(171, 33);
            cboA.TabIndex = 43;
            // 
            // cboDe
            // 
            cboDe.FormattingEnabled = true;
            cboDe.Location = new Point(219, 184);
            cboDe.Margin = new Padding(4, 5, 4, 5);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(171, 33);
            cboDe.TabIndex = 42;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblA.ImeMode = ImeMode.NoControl;
            lblA.Location = new Point(602, 171);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(52, 45);
            lblA.TabIndex = 41;
            lblA.Text = "A:";
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblDe.ImeMode = ImeMode.NoControl;
            lblDe.Location = new Point(121, 172);
            lblDe.Margin = new Padding(4, 0, 4, 0);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(70, 45);
            lblDe.TabIndex = 40;
            lblDe.Text = "De:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 643);
            Controls.Add(cboOpciones);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtCantidad);
            Controls.Add(lblRespuesta);
            Controls.Add(lblCantidad);
            Controls.Add(cboA);
            Controls.Add(cboDe);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboOpciones;
        private Label label1;
        private Button btnCalcular;
        private TextBox txtCantidad;
        private Label lblRespuesta;
        private Label lblCantidad;
        private ComboBox cboA;
        private ComboBox cboDe;
        private Label lblA;
        private Label lblDe;
    }
}
