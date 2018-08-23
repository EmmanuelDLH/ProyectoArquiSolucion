namespace ProyectoArqui
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.explorarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ArchivoNombre = new System.Windows.Forms.TextBox();
            this.ejecutarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Palabra de mayor longitud:",
            "2. \"N\" palabras más comunes:",
            "3. Número de veces que aparce una palabra:",
            "4. Total de palabras:",
            "5. Número de palabras diferentes:",
            "6. Número total de caracteres:",
            "7. Número de caracteres sin espacios:",
            "8. Recuento de oraciones:"});
            this.comboBox1.Location = new System.Drawing.Point(373, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccione la opción a escoger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Determine la operacion a realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo de ejecución:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 369);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 161);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abrir documento de Texto";
            // 
            // explorarButton
            // 
            this.explorarButton.Location = new System.Drawing.Point(700, 112);
            this.explorarButton.Name = "explorarButton";
            this.explorarButton.Size = new System.Drawing.Size(75, 23);
            this.explorarButton.TabIndex = 5;
            this.explorarButton.Text = "Explorar";
            this.explorarButton.UseVisualStyleBackColor = true;
            this.explorarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ubicacion del archivo:";
            // 
            // ArchivoNombre
            // 
            this.ArchivoNombre.Location = new System.Drawing.Point(373, 114);
            this.ArchivoNombre.Name = "ArchivoNombre";
            this.ArchivoNombre.Size = new System.Drawing.Size(286, 20);
            this.ArchivoNombre.TabIndex = 7;
            // 
            // ejecutarButton
            // 
            this.ejecutarButton.Location = new System.Drawing.Point(700, 311);
            this.ejecutarButton.Name = "ejecutarButton";
            this.ejecutarButton.Size = new System.Drawing.Size(75, 23);
            this.ejecutarButton.TabIndex = 8;
            this.ejecutarButton.Text = "Ejecutar";
            this.ejecutarButton.UseVisualStyleBackColor = true;
            this.ejecutarButton.Click += new System.EventHandler(this.ejecutarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 709);
            this.Controls.Add(this.ejecutarButton);
            this.Controls.Add(this.ArchivoNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.explorarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button explorarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArchivoNombre;
        private System.Windows.Forms.Button ejecutarButton;
    }
}

