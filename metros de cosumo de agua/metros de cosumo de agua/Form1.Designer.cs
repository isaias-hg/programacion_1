namespace metros_de_cosumo_de_agua
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
            lblMetros = new Label();
            lblAguaConsumida = new Label();
            txtMetros = new TextBox();
            txtagua = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetros.Location = new Point(58, 116);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(140, 45);
            lblMetros.TabIndex = 0;
            lblMetros.Text = "metros:";
            // 
            // lblAguaConsumida
            // 
            lblAguaConsumida.AutoSize = true;
            lblAguaConsumida.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAguaConsumida.Location = new Point(35, 212);
            lblAguaConsumida.Name = "lblAguaConsumida";
            lblAguaConsumida.Size = new Size(292, 45);
            lblAguaConsumida.TabIndex = 1;
            lblAguaConsumida.Text = "Agua consumida:";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(217, 129);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(150, 31);
            txtMetros.TabIndex = 2;
            // 
            // txtagua
            // 
            txtagua.Location = new Point(346, 226);
            txtagua.Name = "txtagua";
            txtagua.Size = new Size(150, 31);
            txtagua.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(108, 318);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 72);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(346, 318);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 72);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtagua);
            Controls.Add(txtMetros);
            Controls.Add(lblAguaConsumida);
            Controls.Add(lblMetros);
            Name = "Form1";
            Text = "metros de consumo de agua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetros;
        private Label lblAguaConsumida;
        private TextBox txtMetros;
        private TextBox txtagua;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
