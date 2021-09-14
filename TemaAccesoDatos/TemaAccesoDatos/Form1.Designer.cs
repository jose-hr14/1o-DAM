
namespace TemaAccesoDatos
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
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Nombre_textbox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.PrimeroButton = new System.Windows.Forms.Button();
            this.AnteriorButton = new System.Windows.Forms.Button();
            this.SiguienteButton = new System.Windows.Forms.Button();
            this.UltimoButton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(129, 59);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(100, 23);
            this.ID_textbox.TabIndex = 0;
            // 
            // Nombre_textbox
            // 
            this.Nombre_textbox.Location = new System.Drawing.Point(129, 120);
            this.Nombre_textbox.Name = "Nombre_textbox";
            this.Nombre_textbox.Size = new System.Drawing.Size(100, 23);
            this.Nombre_textbox.TabIndex = 1;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(22, 59);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 15);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "ID";
            this.ID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(22, 120);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(51, 15);
            this.Nombre_label.TabIndex = 3;
            this.Nombre_label.Text = "Nombre";
            // 
            // PrimeroButton
            // 
            this.PrimeroButton.Location = new System.Drawing.Point(91, 174);
            this.PrimeroButton.Name = "PrimeroButton";
            this.PrimeroButton.Size = new System.Drawing.Size(75, 23);
            this.PrimeroButton.TabIndex = 4;
            this.PrimeroButton.Text = "Primero";
            this.PrimeroButton.UseVisualStyleBackColor = true;
            this.PrimeroButton.Click += new System.EventHandler(this.PrimeroButton_Click);
            // 
            // AnteriorButton
            // 
            this.AnteriorButton.Location = new System.Drawing.Point(91, 203);
            this.AnteriorButton.Name = "AnteriorButton";
            this.AnteriorButton.Size = new System.Drawing.Size(75, 23);
            this.AnteriorButton.TabIndex = 5;
            this.AnteriorButton.Text = "Anterior";
            this.AnteriorButton.UseVisualStyleBackColor = true;
            this.AnteriorButton.Click += new System.EventHandler(this.AnteriorButton_Click);
            // 
            // SiguienteButton
            // 
            this.SiguienteButton.Location = new System.Drawing.Point(91, 232);
            this.SiguienteButton.Name = "SiguienteButton";
            this.SiguienteButton.Size = new System.Drawing.Size(75, 23);
            this.SiguienteButton.TabIndex = 6;
            this.SiguienteButton.Text = "Siguiente";
            this.SiguienteButton.UseVisualStyleBackColor = true;
            this.SiguienteButton.Click += new System.EventHandler(this.SiguienteButton_Click);
            // 
            // UltimoButton
            // 
            this.UltimoButton.Location = new System.Drawing.Point(91, 261);
            this.UltimoButton.Name = "UltimoButton";
            this.UltimoButton.Size = new System.Drawing.Size(75, 23);
            this.UltimoButton.TabIndex = 7;
            this.UltimoButton.Text = "Último";
            this.UltimoButton.UseVisualStyleBackColor = true;
            this.UltimoButton.Click += new System.EventHandler(this.UltimoButton_Click);
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(91, 290);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 23);
            this.AñadirButton.TabIndex = 8;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(91, 321);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 356);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.UltimoButton);
            this.Controls.Add(this.SiguienteButton);
            this.Controls.Add(this.AnteriorButton);
            this.Controls.Add(this.PrimeroButton);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Nombre_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox Nombre_textbox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.Button PrimeroButton;
        private System.Windows.Forms.Button AnteriorButton;
        private System.Windows.Forms.Button SiguienteButton;
        private System.Windows.Forms.Button UltimoButton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.Button GuardarButton;
    }
}

