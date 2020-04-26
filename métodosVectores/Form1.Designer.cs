namespace métodosVectores
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.llenarAleatorio = new System.Windows.Forms.Button();
            this.llenarManual = new System.Windows.Forms.Button();
            this.textBoxLlenarManual = new System.Windows.Forms.TextBox();
            this.labelLLenarAleatorio = new System.Windows.Forms.Label();
            this.labelLlenarManual = new System.Windows.Forms.Label();
            this.revisarVector = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.indice = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.completar = new System.Windows.Forms.Button();
            this.Revertir = new System.Windows.Forms.Button();
            this.posicion1 = new System.Windows.Forms.TextBox();
            this.posicion2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar tamaño del vector";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Posición     Valor"});
            this.listBox1.Location = new System.Drawing.Point(438, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 212);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // llenarAleatorio
            // 
            this.llenarAleatorio.Location = new System.Drawing.Point(42, 173);
            this.llenarAleatorio.Name = "llenarAleatorio";
            this.llenarAleatorio.Size = new System.Drawing.Size(75, 23);
            this.llenarAleatorio.TabIndex = 5;
            this.llenarAleatorio.Text = "Aleatorio";
            this.llenarAleatorio.UseVisualStyleBackColor = true;
            this.llenarAleatorio.Visible = false;
            this.llenarAleatorio.Click += new System.EventHandler(this.button2_Click);
            // 
            // llenarManual
            // 
            this.llenarManual.Location = new System.Drawing.Point(154, 96);
            this.llenarManual.Name = "llenarManual";
            this.llenarManual.Size = new System.Drawing.Size(75, 23);
            this.llenarManual.TabIndex = 6;
            this.llenarManual.Text = "Agregar";
            this.llenarManual.UseVisualStyleBackColor = true;
            this.llenarManual.Visible = false;
            this.llenarManual.Click += new System.EventHandler(this.llenarManual_Click);
            // 
            // textBoxLlenarManual
            // 
            this.textBoxLlenarManual.Location = new System.Drawing.Point(42, 99);
            this.textBoxLlenarManual.Name = "textBoxLlenarManual";
            this.textBoxLlenarManual.Size = new System.Drawing.Size(100, 20);
            this.textBoxLlenarManual.TabIndex = 7;
            this.textBoxLlenarManual.Visible = false;
            this.textBoxLlenarManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelLLenarAleatorio
            // 
            this.labelLLenarAleatorio.AutoSize = true;
            this.labelLLenarAleatorio.Location = new System.Drawing.Point(39, 136);
            this.labelLLenarAleatorio.Name = "labelLLenarAleatorio";
            this.labelLLenarAleatorio.Size = new System.Drawing.Size(290, 13);
            this.labelLLenarAleatorio.TabIndex = 8;
            this.labelLLenarAleatorio.Text = "Presione \"Aleatorio\" para llenar su arreglo de forma aleatoria";
            // 
            // labelLlenarManual
            // 
            this.labelLlenarManual.AutoSize = true;
            this.labelLlenarManual.Location = new System.Drawing.Point(39, 69);
            this.labelLlenarManual.Name = "labelLlenarManual";
            this.labelLlenarManual.Size = new System.Drawing.Size(277, 13);
            this.labelLlenarManual.TabIndex = 9;
            this.labelLlenarManual.Text = "Digite un número y luego añádalo con el botón \"Agregar\"";
            // 
            // revisarVector
            // 
            this.revisarVector.Location = new System.Drawing.Point(673, 415);
            this.revisarVector.Name = "revisarVector";
            this.revisarVector.Size = new System.Drawing.Size(101, 23);
            this.revisarVector.TabIndex = 10;
            this.revisarVector.Text = "RevisarVector";
            this.revisarVector.UseVisualStyleBackColor = true;
            this.revisarVector.Visible = false;
            this.revisarVector.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // indice
            // 
            this.indice.Location = new System.Drawing.Point(82, 261);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(35, 20);
            this.indice.TabIndex = 13;
            this.indice.Visible = false;
            this.indice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.indice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(201, 261);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(36, 20);
            this.numero.TabIndex = 14;
            this.numero.Visible = false;
            this.numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para cambiar un dato del arreglo ingrese ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "el índice y el número que desea agregar ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Índice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Número";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cambiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // completar
            // 
            this.completar.Location = new System.Drawing.Point(254, 96);
            this.completar.Name = "completar";
            this.completar.Size = new System.Drawing.Size(75, 23);
            this.completar.TabIndex = 19;
            this.completar.Text = "Completar";
            this.completar.UseVisualStyleBackColor = true;
            this.completar.Visible = false;
            this.completar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Revertir
            // 
            this.Revertir.Location = new System.Drawing.Point(438, 303);
            this.Revertir.Name = "Revertir";
            this.Revertir.Size = new System.Drawing.Size(75, 23);
            this.Revertir.TabIndex = 20;
            this.Revertir.Text = "Revertir";
            this.Revertir.UseVisualStyleBackColor = true;
            this.Revertir.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // posicion1
            // 
            this.posicion1.Location = new System.Drawing.Point(90, 384);
            this.posicion1.Name = "posicion1";
            this.posicion1.Size = new System.Drawing.Size(35, 20);
            this.posicion1.TabIndex = 21;
            this.posicion1.Visible = false;
            this.posicion1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.posicion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // posicion2
            // 
            this.posicion2.Location = new System.Drawing.Point(210, 384);
            this.posicion2.Name = "posicion2";
            this.posicion2.Size = new System.Drawing.Size(36, 20);
            this.posicion2.TabIndex = 22;
            this.posicion2.Visible = false;
            this.posicion2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.posicion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Índice 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Índice 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ingrese los índices de los números que desea cambiar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Intercambiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.posicion2);
            this.Controls.Add(this.posicion1);
            this.Controls.Add(this.Revertir);
            this.Controls.Add(this.completar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.indice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.revisarVector);
            this.Controls.Add(this.labelLlenarManual);
            this.Controls.Add(this.labelLLenarAleatorio);
            this.Controls.Add(this.textBoxLlenarManual);
            this.Controls.Add(this.llenarManual);
            this.Controls.Add(this.llenarAleatorio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button llenarAleatorio;
        private System.Windows.Forms.Button llenarManual;
        private System.Windows.Forms.TextBox textBoxLlenarManual;
        private System.Windows.Forms.Label labelLLenarAleatorio;
        private System.Windows.Forms.Label labelLlenarManual;
        private System.Windows.Forms.Button revisarVector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox indice;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button completar;
        private System.Windows.Forms.Button Revertir;
        private System.Windows.Forms.TextBox posicion1;
        private System.Windows.Forms.TextBox posicion2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}

