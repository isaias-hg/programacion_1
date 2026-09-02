namespace parcial_1_computo_1
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
            lblGanancias = new Label();
            txtGanancias = new TextBox();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            dgvDatos = new DataGridView();
            btnCalcular = new Button();
            btnSalir = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanancias.Location = new Point(353, 52);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(107, 25);
            lblGanancias.TabIndex = 0;
            lblGanancias.Text = "Ganancias:";
            // 
            // txtGanancias
            // 
            txtGanancias.Location = new Point(466, 52);
            txtGanancias.Name = "txtGanancias";
            txtGanancias.Size = new Size(100, 23);
            txtGanancias.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpresa.Location = new Point(40, 52);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(92, 25);
            lblEmpresa.TabIndex = 2;
            lblEmpresa.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(138, 57);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(137, 23);
            txtEmpresa.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDatos.Location = new Point(123, 102);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(443, 262);
            dgvDatos.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(123, 399);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(175, 96);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(367, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(175, 96);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "nombre de empresa";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "ganancias";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "impuesto";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "adicional";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(dgvDatos);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Controls.Add(txtGanancias);
            Controls.Add(lblGanancias);
            Name = "Form1";
            Text = "Impuesto de actividades";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGanancias;
        private TextBox txtGanancias;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private DataGridView dgvDatos;
        private Button btnCalcular;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
