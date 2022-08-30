namespace StoreManagement
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
            this.btnAnagCustomers = new System.Windows.Forms.Button();
            this.btnAnagSuppliers = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnMovements = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnagCustomers
            // 
            this.btnAnagCustomers.Location = new System.Drawing.Point(74, 68);
            this.btnAnagCustomers.Name = "btnAnagCustomers";
            this.btnAnagCustomers.Size = new System.Drawing.Size(238, 90);
            this.btnAnagCustomers.TabIndex = 0;
            this.btnAnagCustomers.Text = "AnagraficaClienti";
            this.btnAnagCustomers.UseVisualStyleBackColor = true;
            this.btnAnagCustomers.Click += new System.EventHandler(this.btnAnagCustomers_Click);
            // 
            // btnAnagSuppliers
            // 
            this.btnAnagSuppliers.Location = new System.Drawing.Point(435, 68);
            this.btnAnagSuppliers.Name = "btnAnagSuppliers";
            this.btnAnagSuppliers.Size = new System.Drawing.Size(238, 90);
            this.btnAnagSuppliers.TabIndex = 1;
            this.btnAnagSuppliers.Text = "AnagraficaFornitori";
            this.btnAnagSuppliers.UseVisualStyleBackColor = true;
            this.btnAnagSuppliers.Click += new System.EventHandler(this.btnAnagSuppliers_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(804, 68);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(238, 90);
            this.btnGoods.TabIndex = 2;
            this.btnGoods.Text = "Prodotti";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnMovements
            // 
            this.btnMovements.Location = new System.Drawing.Point(224, 289);
            this.btnMovements.Name = "btnMovements";
            this.btnMovements.Size = new System.Drawing.Size(238, 90);
            this.btnMovements.TabIndex = 3;
            this.btnMovements.Text = "Movimenti";
            this.btnMovements.UseVisualStyleBackColor = true;
            this.btnMovements.Click += new System.EventHandler(this.btnMovements_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(656, 289);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(238, 90);
            this.btnInvoices.TabIndex = 4;
            this.btnInvoices.Text = "Fatture";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 525);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnMovements);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnAnagSuppliers);
            this.Controls.Add(this.btnAnagCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnagCustomers;
        private System.Windows.Forms.Button btnAnagSuppliers;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnMovements;
        private System.Windows.Forms.Button btnInvoices;
    }
}

