namespace sueldo
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
            lblSueldo = new Label();
            txtSueldo = new TextBox();
            dgvResualtado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResualtado).BeginInit();
            SuspendLayout();
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldo.Location = new Point(35, 55);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(162, 48);
            lblSueldo.TabIndex = 0;
            lblSueldo.Text = "sueldo$:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(203, 71);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(224, 31);
            txtSueldo.TabIndex = 1;
            // 
            // dgvResualtado
            // 
            dgvResualtado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResualtado.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvResualtado.Location = new Point(35, 126);
            dgvResualtado.Name = "dgvResualtado";
            dgvResualtado.RowHeadersWidth = 62;
            dgvResualtado.Size = new Size(814, 137);
            dgvResualtado.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "sueldo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "ISSS";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "AFP";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "ISR";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "total";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(82, 332);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(188, 81);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(373, 332);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(187, 81);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(dgvResualtado);
            Controls.Add(txtSueldo);
            Controls.Add(lblSueldo);
            Name = "Form1";
            Text = "sueldo";
            ((System.ComponentModel.ISupportInitialize)dgvResualtado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSueldo;
        private TextBox txtSueldo;
        private DataGridView dgvResualtado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
