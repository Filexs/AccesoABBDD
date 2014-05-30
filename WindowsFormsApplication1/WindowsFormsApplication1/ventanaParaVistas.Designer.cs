namespace WindowsFormsApplication1
{
    partial class ventanaParaVistas
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
            this.boton_Fran = new System.Windows.Forms.Button();
            this.boton_Alvaro = new System.Windows.Forms.Button();
            this.boton_Pedro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_Fran
            // 
            this.boton_Fran.Location = new System.Drawing.Point(71, 58);
            this.boton_Fran.Name = "boton_Fran";
            this.boton_Fran.Size = new System.Drawing.Size(164, 133);
            this.boton_Fran.TabIndex = 0;
            this.boton_Fran.Text = "Clientes";
            this.boton_Fran.UseVisualStyleBackColor = true;
            this.boton_Fran.Click += new System.EventHandler(this.boton_Fran_Click);
            // 
            // boton_Alvaro
            // 
            this.boton_Alvaro.Location = new System.Drawing.Point(296, 58);
            this.boton_Alvaro.Name = "boton_Alvaro";
            this.boton_Alvaro.Size = new System.Drawing.Size(164, 133);
            this.boton_Alvaro.TabIndex = 1;
            this.boton_Alvaro.Text = "Empleados";
            this.boton_Alvaro.UseVisualStyleBackColor = true;
            this.boton_Alvaro.Click += new System.EventHandler(this.boton_Alvaro_Click);
            // 
            // boton_Pedro
            // 
            this.boton_Pedro.Location = new System.Drawing.Point(524, 58);
            this.boton_Pedro.Name = "boton_Pedro";
            this.boton_Pedro.Size = new System.Drawing.Size(164, 133);
            this.boton_Pedro.TabIndex = 2;
            this.boton_Pedro.Text = "Proveedores";
            this.boton_Pedro.UseVisualStyleBackColor = true;
            this.boton_Pedro.Click += new System.EventHandler(this.boton_Pedro_Click);
            // 
            // ventanaParaVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 258);
            this.Controls.Add(this.boton_Pedro);
            this.Controls.Add(this.boton_Alvaro);
            this.Controls.Add(this.boton_Fran);
            this.Name = "ventanaParaVistas";
            this.Text = "programa_prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Fran;
        private System.Windows.Forms.Button boton_Alvaro;
        private System.Windows.Forms.Button boton_Pedro;
    }
}