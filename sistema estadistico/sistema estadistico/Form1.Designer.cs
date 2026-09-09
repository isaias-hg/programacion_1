namespace sistema_estadistico
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
            lblOpciones = new Label();
            lblTiempo = new Label();
            lblTiempoCel = new Label();
            dgvDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lblEstudiante = new Label();
            lblEdad = new Label();
            txtTiempoCelular = new TextBox();
            txtEdad = new TextBox();
            txtEstudiantes = new TextBox();
            txtTiempoUgb = new TextBox();
            cmbOpciones = new ComboBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblOpciones
            // 
            lblOpciones.AutoSize = true;
            lblOpciones.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpciones.Location = new Point(136, 54);
            lblOpciones.Name = "lblOpciones";
            lblOpciones.Size = new Size(145, 38);
            lblOpciones.TabIndex = 0;
            lblOpciones.Text = "Opciones";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(33, 230);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(375, 38);
            lblTiempo.TabIndex = 1;
            lblTiempo.Text = "tiempo en llegar a la ugb:";
            // 
            // lblTiempoCel
            // 
            lblTiempoCel.AutoSize = true;
            lblTiempoCel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempoCel.Location = new Point(678, 230);
            lblTiempoCel.Name = "lblTiempoCel";
            lblTiempoCel.Size = new Size(270, 38);
            lblTiempoCel.TabIndex = 2;
            lblTiempoCel.Text = "tiempo en celular:";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3 });
            dgvDatos.Location = new Point(70, 388);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(665, 225);
            dgvDatos.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Estudiante";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Edad";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "tiempo en llegar a la ugb";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "tiempo en celular";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiante.Location = new Point(51, 154);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(348, 38);
            lblEstudiante.TabIndex = 4;
            lblEstudiante.Text = "Nombre del estudiante:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(744, 154);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(93, 38);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // txtTiempoCelular
            // 
            txtTiempoCelular.Location = new Point(954, 238);
            txtTiempoCelular.Name = "txtTiempoCelular";
            txtTiempoCelular.Size = new Size(150, 31);
            txtTiempoCelular.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(852, 161);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 31);
            txtEdad.TabIndex = 7;
            // 
            // txtEstudiantes
            // 
            txtEstudiantes.Location = new Point(405, 162);
            txtEstudiantes.Name = "txtEstudiantes";
            txtEstudiantes.Size = new Size(246, 31);
            txtEstudiantes.TabIndex = 8;
            // 
            // txtTiempoUgb
            // 
            txtTiempoUgb.Location = new Point(414, 238);
            txtTiempoUgb.Name = "txtTiempoUgb";
            txtTiempoUgb.Size = new Size(150, 31);
            txtTiempoUgb.TabIndex = 9;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(316, 62);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(347, 33);
            cmbOpciones.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(879, 388);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(202, 102);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(879, 511);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(202, 102);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(890, 636);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 85);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 742);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOpciones);
            Controls.Add(txtTiempoUgb);
            Controls.Add(txtEstudiantes);
            Controls.Add(txtEdad);
            Controls.Add(txtTiempoCelular);
            Controls.Add(lblEdad);
            Controls.Add(lblEstudiante);
            Controls.Add(dgvDatos);
            Controls.Add(lblTiempoCel);
            Controls.Add(lblTiempo);
            Controls.Add(lblOpciones);
            Name = "Form1";
            Text = "sistema estadistico";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpciones;
        private Label lblTiempo;
        private Label lblTiempoCel;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lblEstudiante;
        private Label lblEdad;
        private TextBox txtTiempoCelular;
        private TextBox txtEdad;
        private TextBox txtEstudiantes;
        private TextBox txtTiempoUgb;
        private ComboBox cmbOpciones;
        private Button btnCalcular;
        private Button btnSalir;
        private Button btnAgregar;
    }
}
