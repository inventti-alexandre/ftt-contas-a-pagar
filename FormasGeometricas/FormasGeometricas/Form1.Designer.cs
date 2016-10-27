namespace FormasGeometricas
{
    partial class Form1
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
            this.cbFormaGeometrica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtY4 = new System.Windows.Forms.TextBox();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.pnlCalculo = new System.Windows.Forms.Panel();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.pnlCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFormaGeometrica
            // 
            this.cbFormaGeometrica.FormattingEnabled = true;
            this.cbFormaGeometrica.Location = new System.Drawing.Point(12, 36);
            this.cbFormaGeometrica.Name = "cbFormaGeometrica";
            this.cbFormaGeometrica.Size = new System.Drawing.Size(210, 21);
            this.cbFormaGeometrica.TabIndex = 0;
            this.cbFormaGeometrica.SelectedValueChanged += new System.EventHandler(this.cbFormaGeometrica_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a forma geométrica:";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(18, 33);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(80, 20);
            this.txtX1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y1:";
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastro.Controls.Add(this.btnCadastrar);
            this.pnlCadastro.Controls.Add(this.txtY4);
            this.pnlCadastro.Controls.Add(this.txtY3);
            this.pnlCadastro.Controls.Add(this.txtX3);
            this.pnlCadastro.Controls.Add(this.txtX4);
            this.pnlCadastro.Controls.Add(this.label8);
            this.pnlCadastro.Controls.Add(this.label6);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.label9);
            this.pnlCadastro.Controls.Add(this.txtY2);
            this.pnlCadastro.Controls.Add(this.txtX2);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.label5);
            this.pnlCadastro.Controls.Add(this.txtY1);
            this.pnlCadastro.Controls.Add(this.txtX1);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Location = new System.Drawing.Point(12, 74);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(210, 255);
            this.pnlCadastro.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(65, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(108, 181);
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(80, 20);
            this.txtY4.TabIndex = 18;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(108, 129);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(80, 20);
            this.txtY3.TabIndex = 14;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(18, 129);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(80, 20);
            this.txtX3.TabIndex = 11;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(18, 181);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(80, 20);
            this.txtX4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "y4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "y3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "x3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "x4:";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(108, 81);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(80, 20);
            this.txtY2.TabIndex = 10;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(18, 81);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(80, 20);
            this.txtX2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "y2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x2:";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(108, 33);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(80, 20);
            this.txtY1.TabIndex = 6;
            // 
            // pnlCalculo
            // 
            this.pnlCalculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalculo.Controls.Add(this.btnCalcularPerimetro);
            this.pnlCalculo.Controls.Add(this.btnCalcularArea);
            this.pnlCalculo.Location = new System.Drawing.Point(12, 339);
            this.pnlCalculo.Name = "pnlCalculo";
            this.pnlCalculo.Size = new System.Drawing.Size(209, 49);
            this.pnlCalculo.TabIndex = 7;
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(108, 13);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPerimetro.TabIndex = 1;
            this.btnCalcularPerimetro.Text = "Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(27, 13);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularArea.TabIndex = 0;
            this.btnCalcularArea.Text = "Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 399);
            this.Controls.Add(this.pnlCalculo);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormaGeometrica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlCalculo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormaGeometrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY4;
        private System.Windows.Forms.TextBox txtY3;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.TextBox txtX4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlCalculo;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnCalcularArea;
    }
}

