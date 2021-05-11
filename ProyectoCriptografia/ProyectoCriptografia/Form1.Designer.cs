namespace ProyectoCriptografia
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
            this.iCriptografia = new System.Windows.Forms.PictureBox();
            this.cMetodoCifrado = new System.Windows.Forms.ComboBox();
            this.lMetodoCifrado = new System.Windows.Forms.Label();
            this.cMensajeCifrar = new System.Windows.Forms.RichTextBox();
            this.lMensajeCifrar = new System.Windows.Forms.Label();
            this.bCifrar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iCriptografia)).BeginInit();
            this.SuspendLayout();
            // 
            // iCriptografia
            // 
            this.iCriptografia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iCriptografia.Location = new System.Drawing.Point(0, 0);
            this.iCriptografia.Name = "iCriptografia";
            this.iCriptografia.Size = new System.Drawing.Size(816, 472);
            this.iCriptografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iCriptografia.TabIndex = 0;
            this.iCriptografia.TabStop = false;
            // 
            // cMetodoCifrado
            // 
            this.cMetodoCifrado.FormattingEnabled = true;
            this.cMetodoCifrado.Location = new System.Drawing.Point(253, 137);
            this.cMetodoCifrado.Name = "cMetodoCifrado";
            this.cMetodoCifrado.Size = new System.Drawing.Size(520, 33);
            this.cMetodoCifrado.TabIndex = 1;
            // 
            // lMetodoCifrado
            // 
            this.lMetodoCifrado.AutoSize = true;
            this.lMetodoCifrado.Location = new System.Drawing.Point(30, 145);
            this.lMetodoCifrado.Name = "lMetodoCifrado";
            this.lMetodoCifrado.Size = new System.Drawing.Size(189, 25);
            this.lMetodoCifrado.TabIndex = 2;
            this.lMetodoCifrado.Text = "Método de Cifrado";
            // 
            // cMensajeCifrar
            // 
            this.cMensajeCifrar.Location = new System.Drawing.Point(253, 176);
            this.cMensajeCifrar.Name = "cMensajeCifrar";
            this.cMensajeCifrar.Size = new System.Drawing.Size(520, 194);
            this.cMensajeCifrar.TabIndex = 3;
            this.cMensajeCifrar.Text = "";
            // 
            // lMensajeCifrar
            // 
            this.lMensajeCifrar.AutoSize = true;
            this.lMensajeCifrar.Location = new System.Drawing.Point(30, 179);
            this.lMensajeCifrar.Name = "lMensajeCifrar";
            this.lMensajeCifrar.Size = new System.Drawing.Size(170, 25);
            this.lMensajeCifrar.TabIndex = 4;
            this.lMensajeCifrar.Text = "Mensaje a Cifrar";
            // 
            // bCifrar
            // 
            this.bCifrar.Location = new System.Drawing.Point(628, 392);
            this.bCifrar.Name = "bCifrar";
            this.bCifrar.Size = new System.Drawing.Size(145, 42);
            this.bCifrar.TabIndex = 5;
            this.bCifrar.Text = "Cifrar";
            this.bCifrar.UseVisualStyleBackColor = true;
            this.bCifrar.Click += new System.EventHandler(this.BCifrar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(452, 392);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(145, 42);
            this.bBorrar.TabIndex = 6;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 472);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bCifrar);
            this.Controls.Add(this.lMensajeCifrar);
            this.Controls.Add(this.cMensajeCifrar);
            this.Controls.Add(this.lMetodoCifrado);
            this.Controls.Add(this.cMetodoCifrado);
            this.Controls.Add(this.iCriptografia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iCriptografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iCriptografia;
        private System.Windows.Forms.ComboBox cMetodoCifrado;
        private System.Windows.Forms.Label lMetodoCifrado;
        private System.Windows.Forms.RichTextBox cMensajeCifrar;
        private System.Windows.Forms.Label lMensajeCifrar;
        private System.Windows.Forms.Button bCifrar;
        private System.Windows.Forms.Button bBorrar;
    }
}

