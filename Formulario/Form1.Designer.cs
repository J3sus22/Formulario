namespace Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdhombre = new System.Windows.Forms.RadioButton();
            this.rdmujer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // rdhombre
            // 
            this.rdhombre.AutoSize = true;
            this.rdhombre.Location = new System.Drawing.Point(9, 32);
            this.rdhombre.Name = "rdhombre";
            this.rdhombre.Size = new System.Drawing.Size(62, 17);
            this.rdhombre.TabIndex = 5;
            this.rdhombre.TabStop = true;
            this.rdhombre.Text = "Hombre";
            this.rdhombre.UseVisualStyleBackColor = true;
            // 
            // rdmujer
            // 
            this.rdmujer.AutoSize = true;
            this.rdmujer.Location = new System.Drawing.Point(109, 32);
            this.rdmujer.Name = "rdmujer";
            this.rdmujer.Size = new System.Drawing.Size(51, 17);
            this.rdmujer.TabIndex = 6;
            this.rdmujer.TabStop = true;
            this.rdmujer.Text = "Mujer";
            this.rdmujer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 69);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(132, 30);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(99, 20);
            this.tbnombre.TabIndex = 10;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(132, 69);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(98, 20);
            this.tbapellido.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdmujer);
            this.groupBox1.Controls.Add(this.rdhombre);
            this.groupBox1.Location = new System.Drawing.Point(31, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero:";
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(127, 106);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(103, 20);
            this.tbtelefono.TabIndex = 13;
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(125, 145);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(105, 20);
            this.tbestatura.TabIndex = 14;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(125, 182);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(105, 20);
            this.tbedad.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdhombre;
        private System.Windows.Forms.RadioButton rdmujer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbestatura;
        private System.Windows.Forms.TextBox tbedad;
    }
}

