namespace verona
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cerca = new System.Windows.Forms.Button();
            this.inserisci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(145, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 26);
            this.textBox1.TabIndex = 0;
            // 
            // cerca
            // 
            this.cerca.Location = new System.Drawing.Point(236, 182);
            this.cerca.Name = "cerca";
            this.cerca.Size = new System.Drawing.Size(75, 23);
            this.cerca.TabIndex = 1;
            this.cerca.Text = "Cerca";
            this.cerca.UseVisualStyleBackColor = true;
            this.cerca.Click += new System.EventHandler(this.cerca_Click);
            // 
            // inserisci
            // 
            this.inserisci.Enabled = false;
            this.inserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.inserisci.Location = new System.Drawing.Point(183, 75);
            this.inserisci.Name = "inserisci";
            this.inserisci.Size = new System.Drawing.Size(186, 31);
            this.inserisci.TabIndex = 2;
            this.inserisci.Text = "Insierisci il comune";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 288);
            this.Controls.Add(this.inserisci);
            this.Controls.Add(this.cerca);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cerca;
        private System.Windows.Forms.TextBox inserisci;
    }
}

