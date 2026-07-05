namespace CalculadoraForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculadora = new System.Windows.Forms.Panel();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_Multiplicacion = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.lbl_Casio = new System.Windows.Forms.Label();
            this.pantallaBox = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.calculadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculadora
            // 
            this.calculadora.BackColor = System.Drawing.Color.DarkCyan;
            this.calculadora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculadora.Controls.Add(this.btn_division);
            this.calculadora.Controls.Add(this.btn_igual);
            this.calculadora.Controls.Add(this.btn_Multiplicacion);
            this.calculadora.Controls.Add(this.btn_resta);
            this.calculadora.Controls.Add(this.btn_limpiar);
            this.calculadora.Controls.Add(this.btn_0);
            this.calculadora.Controls.Add(this.btn_Suma);
            this.calculadora.Controls.Add(this.lbl_Casio);
            this.calculadora.Controls.Add(this.pantallaBox);
            this.calculadora.Controls.Add(this.btn_1);
            this.calculadora.Controls.Add(this.btn_9);
            this.calculadora.Controls.Add(this.btn_2);
            this.calculadora.Controls.Add(this.btn_3);
            this.calculadora.Controls.Add(this.btn_7);
            this.calculadora.Controls.Add(this.btn_4);
            this.calculadora.Controls.Add(this.btn_8);
            this.calculadora.Controls.Add(this.btn_6);
            this.calculadora.Controls.Add(this.btn_5);
            this.calculadora.Location = new System.Drawing.Point(156, 3);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(299, 370);
            this.calculadora.TabIndex = 0;
            this.calculadora.Paint += new System.Windows.Forms.PaintEventHandler(this.calculadora_Paint);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.DarkGray;
            this.btn_division.Location = new System.Drawing.Point(231, 288);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(48, 51);
            this.btn_division.TabIndex = 17;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(154, 288);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(71, 37);
            this.btn_igual.TabIndex = 13;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_Multiplicacion
            // 
            this.btn_Multiplicacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Multiplicacion.Location = new System.Drawing.Point(231, 224);
            this.btn_Multiplicacion.Name = "btn_Multiplicacion";
            this.btn_Multiplicacion.Size = new System.Drawing.Size(48, 58);
            this.btn_Multiplicacion.TabIndex = 15;
            this.btn_Multiplicacion.Text = "x";
            this.btn_Multiplicacion.UseVisualStyleBackColor = false;
            this.btn_Multiplicacion.Click += new System.EventHandler(this.btn_Multiplicacion_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.Color.DarkGray;
            this.btn_resta.Location = new System.Drawing.Point(231, 158);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(48, 60);
            this.btn_resta.TabIndex = 16;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = false;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.DimGray;
            this.btn_limpiar.Location = new System.Drawing.Point(11, 288);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(60, 37);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(87, 288);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 37);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_Suma
            // 
            this.btn_Suma.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Suma.Location = new System.Drawing.Point(231, 92);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(48, 60);
            this.btn_Suma.TabIndex = 14;
            this.btn_Suma.Text = "+";
            this.btn_Suma.UseVisualStyleBackColor = false;
            this.btn_Suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Casio
            // 
            this.lbl_Casio.AutoSize = true;
            this.lbl_Casio.Location = new System.Drawing.Point(27, 4);
            this.lbl_Casio.Name = "lbl_Casio";
            this.lbl_Casio.Size = new System.Drawing.Size(59, 20);
            this.lbl_Casio.TabIndex = 1;
            this.lbl_Casio.Text = "CASIO";
            // 
            // pantallaBox
            // 
            this.pantallaBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pantallaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.pantallaBox.Location = new System.Drawing.Point(31, 27);
            this.pantallaBox.Multiline = true;
            this.pantallaBox.Name = "pantallaBox";
            this.pantallaBox.Size = new System.Drawing.Size(230, 59);
            this.pantallaBox.TabIndex = 0;
            this.pantallaBox.TextChanged += new System.EventHandler(this.pantallaBox_TextChanged);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(11, 224);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 44);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(165, 98);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 40);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(87, 224);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 44);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(165, 224);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 44);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(11, 98);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 40);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(11, 156);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 46);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(87, 98);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 40);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(165, 156);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 46);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(87, 156);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 46);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.calculadora.ResumeLayout(false);
            this.calculadora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel calculadora;
        private System.Windows.Forms.TextBox pantallaBox;
        private System.Windows.Forms.Label lbl_Casio;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Multiplicacion;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_division;
    }
}

