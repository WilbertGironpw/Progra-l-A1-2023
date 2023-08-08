
namespace primerproyecto
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
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.btncomprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(172, 146);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 0;
            this.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(134, 149);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "Edad";
            // 
            // btncomprobar
            // 
            this.btncomprobar.Location = new System.Drawing.Point(172, 172);
            this.btncomprobar.Name = "btncomprobar";
            this.btncomprobar.Size = new System.Drawing.Size(100, 27);
            this.btncomprobar.TabIndex = 2;
            this.btncomprobar.Text = "comprobar";
            this.btncomprobar.UseVisualStyleBackColor = true;
            this.btncomprobar.Click += new System.EventHandler(this.btncomprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 591);
            this.Controls.Add(this.btncomprobar);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.txtedad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Button btncomprobar;
    }
}

