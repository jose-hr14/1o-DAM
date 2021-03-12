namespace GestionAlumnos
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
            this.cListaAlumnos = new System.Windows.Forms.RichTextBox();
            this.CNombre = new System.Windows.Forms.TextBox();
            this.CApellidos = new System.Windows.Forms.TextBox();
            this.CFechaNacimiento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CGrupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupo";
            // 
            // cListaAlumnos
            // 
            this.cListaAlumnos.Location = new System.Drawing.Point(57, 257);
            this.cListaAlumnos.Name = "cListaAlumnos";
            this.cListaAlumnos.Size = new System.Drawing.Size(420, 85);
            this.cListaAlumnos.TabIndex = 4;
            this.cListaAlumnos.Text = "";
            // 
            // CNombre
            // 
            this.CNombre.Location = new System.Drawing.Point(223, 53);
            this.CNombre.Name = "CNombre";
            this.CNombre.Size = new System.Drawing.Size(254, 20);
            this.CNombre.TabIndex = 5;
            // 
            // CApellidos
            // 
            this.CApellidos.Location = new System.Drawing.Point(223, 97);
            this.CApellidos.Name = "CApellidos";
            this.CApellidos.Size = new System.Drawing.Size(254, 20);
            this.CApellidos.TabIndex = 6;
            // 
            // CFechaNacimiento
            // 
            this.CFechaNacimiento.Location = new System.Drawing.Point(223, 136);
            this.CFechaNacimiento.Name = "CFechaNacimiento";
            this.CFechaNacimiento.Size = new System.Drawing.Size(254, 20);
            this.CFechaNacimiento.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear Alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CGrupo
            // 
            this.CGrupo.FormattingEnabled = true;
            this.CGrupo.Location = new System.Drawing.Point(223, 180);
            this.CGrupo.Name = "CGrupo";
            this.CGrupo.Size = new System.Drawing.Size(254, 21);
            this.CGrupo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 425);
            this.Controls.Add(this.CGrupo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CFechaNacimiento);
            this.Controls.Add(this.CApellidos);
            this.Controls.Add(this.CNombre);
            this.Controls.Add(this.cListaAlumnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox cListaAlumnos;
        private System.Windows.Forms.TextBox CNombre;
        private System.Windows.Forms.TextBox CApellidos;
        private System.Windows.Forms.TextBox CFechaNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CGrupo;
    }
}

