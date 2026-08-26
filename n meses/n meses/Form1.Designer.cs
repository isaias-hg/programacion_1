namespace n_meses
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
            lblNmeses = new Label();
            txtNMeses = new TextBox();
            dvgMeses = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgMeses).BeginInit();
            SuspendLayout();
            // 
            // lblNmeses
            // 
            lblNmeses.AutoSize = true;
            lblNmeses.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNmeses.Location = new Point(20, 39);
            lblNmeses.Margin = new Padding(2, 0, 2, 0);
            lblNmeses.Name = "lblNmeses";
            lblNmeses.Size = new Size(161, 45);
            lblNmeses.TabIndex = 0;
            lblNmeses.Text = "N meses:";
            // 
            // txtNMeses
            // 
            txtNMeses.Location = new Point(186, 52);
            txtNMeses.Name = "txtNMeses";
            txtNMeses.Size = new Size(193, 31);
            txtNMeses.TabIndex = 1;
            // 
            // dvgMeses
            // 
            dvgMeses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMeses.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dvgMeses.Location = new Point(43, 102);
            dvgMeses.Name = "dvgMeses";
            dvgMeses.RowHeadersWidth = 62;
            dvgMeses.Size = new Size(514, 212);
            dvgMeses.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "N meses";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "meses calculado";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "meses total";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(43, 362);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 82);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(310, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 82);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 472);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(dvgMeses);
            Controls.Add(txtNMeses);
            Controls.Add(lblNmeses);
            Name = "Form1";
            Text = "N meses";
            ((System.ComponentModel.ISupportInitialize)dvgMeses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNmeses;
        private TextBox txtNMeses;
        private DataGridView dvgMeses;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
