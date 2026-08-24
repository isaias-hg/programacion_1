namespace calculadora
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblRespuesta = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cboOpciones = new GroupBox();
            rdbFactorial = new RadioButton();
            rdbRaiz = new RadioButton();
            rdbExponente = new RadioButton();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            btnCalcular = new Button();
            txtModulo = new RadioButton();
            cboOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(47, 58);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(87, 32);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "num1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(45, 128);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(89, 32);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "num2:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(47, 212);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(152, 32);
            lblRespuesta.TabIndex = 2;
            lblRespuesta.Text = "respuesta: ?";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(153, 61);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(221, 31);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(153, 131);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(221, 31);
            txtNum2.TabIndex = 4;
            // 
            // cboOpciones
            // 
            cboOpciones.Controls.Add(txtModulo);
            cboOpciones.Controls.Add(rdbFactorial);
            cboOpciones.Controls.Add(rdbRaiz);
            cboOpciones.Controls.Add(rdbExponente);
            cboOpciones.Controls.Add(rdbDivision);
            cboOpciones.Controls.Add(rdbMultiplicacion);
            cboOpciones.Controls.Add(rdbResta);
            cboOpciones.Controls.Add(rdbSuma);
            cboOpciones.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboOpciones.ForeColor = SystemColors.ControlText;
            cboOpciones.Location = new Point(493, 13);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(261, 463);
            cboOpciones.TabIndex = 5;
            cboOpciones.TabStop = false;
            cboOpciones.Text = "opciones";
            // 
            // rdbFactorial
            // 
            rdbFactorial.AutoSize = true;
            rdbFactorial.Location = new Point(35, 359);
            rdbFactorial.Name = "rdbFactorial";
            rdbFactorial.Size = new Size(136, 36);
            rdbFactorial.TabIndex = 6;
            rdbFactorial.TabStop = true;
            rdbFactorial.Text = "factorial";
            rdbFactorial.UseVisualStyleBackColor = true;
            // 
            // rdbRaiz
            // 
            rdbRaiz.AutoSize = true;
            rdbRaiz.Location = new Point(35, 304);
            rdbRaiz.Name = "rdbRaiz";
            rdbRaiz.Size = new Size(81, 36);
            rdbRaiz.TabIndex = 5;
            rdbRaiz.TabStop = true;
            rdbRaiz.Text = "raiz";
            rdbRaiz.UseVisualStyleBackColor = true;
            // 
            // rdbExponente
            // 
            rdbExponente.AutoSize = true;
            rdbExponente.Location = new Point(35, 259);
            rdbExponente.Name = "rdbExponente";
            rdbExponente.Size = new Size(163, 36);
            rdbExponente.TabIndex = 4;
            rdbExponente.TabStop = true;
            rdbExponente.Text = "exponente";
            rdbExponente.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(35, 213);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(131, 36);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(35, 162);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(204, 36);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(35, 115);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(97, 36);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(35, 63);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(102, 36);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(103, 300);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(280, 141);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtModulo
            // 
            txtModulo.AutoSize = true;
            txtModulo.Location = new Point(35, 410);
            txtModulo.Name = "txtModulo";
            txtModulo.Size = new Size(129, 36);
            txtModulo.TabIndex = 7;
            txtModulo.TabStop = true;
            txtModulo.Text = "modulo";
            txtModulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(btnCalcular);
            Controls.Add(cboOpciones);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblRespuesta);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "calculadora basica";
            cboOpciones.ResumeLayout(false);
            cboOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblRespuesta;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private GroupBox cboOpciones;
        private RadioButton rdbSuma;
        private RadioButton rdbFactorial;
        private RadioButton rdbRaiz;
        private RadioButton rdbExponente;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private Button btnCalcular;
        private RadioButton txtModulo;
    }
}
