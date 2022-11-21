namespace Ecommerce
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonRimuovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAggiungi
            // 
            resources.ApplyResources(this.buttonAggiungi, "buttonAggiungi");
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonRimuovi
            // 
            resources.ApplyResources(this.buttonRimuovi, "buttonRimuovi");
            this.buttonRimuovi.Name = "buttonRimuovi";
            this.buttonRimuovi.UseVisualStyleBackColor = true;
            this.buttonRimuovi.Click += new System.EventHandler(this.buttonRimuovi_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonRimuovi);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.listView1);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonRimuovi;
    }
}

