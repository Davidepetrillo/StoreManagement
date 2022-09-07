namespace StoreManagement
{
    partial class WinCustomers
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dGV = new System.Windows.Forms.DataGridView();
            this.NameLegalOwnerGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameLegalOwnerGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CivicNumberGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCodeGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PECGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebSiteGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDI_CodeGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT_CodeGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCustomerGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.CivicNumberTextBox = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.NationTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CivicNumberLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.NationLabel = new System.Windows.Forms.Label();
            this.StatusCustomerLabel = new System.Windows.Forms.Label();
            this.VATCodeLabel = new System.Windows.Forms.Label();
            this.SDICodeLabel = new System.Windows.Forms.Label();
            this.WebSiteLabel = new System.Windows.Forms.Label();
            this.PECLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StatusCustomerTextBox = new System.Windows.Forms.TextBox();
            this.VatCodeTextBox = new System.Windows.Forms.TextBox();
            this.SdiCodeTextBox = new System.Windows.Forms.TextBox();
            this.WebsiteTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PecTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameLegalOwnerGS,
            this.SurnameLegalOwnerGS,
            this.CompanyNameGS,
            this.AddressGS,
            this.CivicNumberGS,
            this.ZipCodeGS,
            this.CityGS,
            this.RegionGS,
            this.NationGS,
            this.PhoneGS,
            this.EmailGS,
            this.PECGS,
            this.WebSiteGS,
            this.SDI_CodeGS,
            this.VAT_CodeGS,
            this.StatusCustomerGS});
            this.dGV.Location = new System.Drawing.Point(12, 404);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(1698, 278);
            this.dGV.TabIndex = 48;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameLegalOwnerGS
            // 
            this.NameLegalOwnerGS.Frozen = true;
            this.NameLegalOwnerGS.HeaderText = "Name";
            this.NameLegalOwnerGS.MinimumWidth = 6;
            this.NameLegalOwnerGS.Name = "NameLegalOwnerGS";
            this.NameLegalOwnerGS.ReadOnly = true;
            this.NameLegalOwnerGS.Width = 150;
            // 
            // SurnameLegalOwnerGS
            // 
            this.SurnameLegalOwnerGS.Frozen = true;
            this.SurnameLegalOwnerGS.HeaderText = "Surname";
            this.SurnameLegalOwnerGS.MinimumWidth = 6;
            this.SurnameLegalOwnerGS.Name = "SurnameLegalOwnerGS";
            this.SurnameLegalOwnerGS.ReadOnly = true;
            this.SurnameLegalOwnerGS.Width = 150;
            // 
            // CompanyNameGS
            // 
            this.CompanyNameGS.Frozen = true;
            this.CompanyNameGS.HeaderText = "Company";
            this.CompanyNameGS.MinimumWidth = 6;
            this.CompanyNameGS.Name = "CompanyNameGS";
            this.CompanyNameGS.ReadOnly = true;
            this.CompanyNameGS.Width = 150;
            // 
            // AddressGS
            // 
            this.AddressGS.HeaderText = "Address";
            this.AddressGS.MinimumWidth = 6;
            this.AddressGS.Name = "AddressGS";
            this.AddressGS.Width = 150;
            // 
            // CivicNumberGS
            // 
            this.CivicNumberGS.HeaderText = "CivicNumber";
            this.CivicNumberGS.MinimumWidth = 6;
            this.CivicNumberGS.Name = "CivicNumberGS";
            this.CivicNumberGS.Width = 150;
            // 
            // ZipCodeGS
            // 
            this.ZipCodeGS.HeaderText = "Zip";
            this.ZipCodeGS.MinimumWidth = 6;
            this.ZipCodeGS.Name = "ZipCodeGS";
            this.ZipCodeGS.Width = 150;
            // 
            // CityGS
            // 
            this.CityGS.HeaderText = "City";
            this.CityGS.MinimumWidth = 6;
            this.CityGS.Name = "CityGS";
            this.CityGS.Width = 150;
            // 
            // RegionGS
            // 
            this.RegionGS.HeaderText = "Region";
            this.RegionGS.MinimumWidth = 6;
            this.RegionGS.Name = "RegionGS";
            this.RegionGS.Width = 150;
            // 
            // NationGS
            // 
            this.NationGS.HeaderText = "Nation";
            this.NationGS.MinimumWidth = 6;
            this.NationGS.Name = "NationGS";
            this.NationGS.Width = 150;
            // 
            // PhoneGS
            // 
            this.PhoneGS.HeaderText = "Phone";
            this.PhoneGS.MinimumWidth = 6;
            this.PhoneGS.Name = "PhoneGS";
            this.PhoneGS.Width = 150;
            // 
            // EmailGS
            // 
            this.EmailGS.HeaderText = "Email";
            this.EmailGS.MinimumWidth = 6;
            this.EmailGS.Name = "EmailGS";
            this.EmailGS.Width = 150;
            // 
            // PECGS
            // 
            this.PECGS.HeaderText = "PEC";
            this.PECGS.MinimumWidth = 6;
            this.PECGS.Name = "PECGS";
            this.PECGS.Width = 150;
            // 
            // WebSiteGS
            // 
            this.WebSiteGS.HeaderText = "WebSite";
            this.WebSiteGS.MinimumWidth = 6;
            this.WebSiteGS.Name = "WebSiteGS";
            this.WebSiteGS.Width = 150;
            // 
            // SDI_CodeGS
            // 
            this.SDI_CodeGS.HeaderText = "SDI";
            this.SDI_CodeGS.MinimumWidth = 6;
            this.SDI_CodeGS.Name = "SDI_CodeGS";
            this.SDI_CodeGS.Width = 150;
            // 
            // VAT_CodeGS
            // 
            this.VAT_CodeGS.HeaderText = "VAT";
            this.VAT_CodeGS.MinimumWidth = 6;
            this.VAT_CodeGS.Name = "VAT_CodeGS";
            this.VAT_CodeGS.Width = 150;
            // 
            // StatusCustomerGS
            // 
            this.StatusCustomerGS.HeaderText = "StatusCustomer";
            this.StatusCustomerGS.MinimumWidth = 6;
            this.StatusCustomerGS.Name = "StatusCustomerGS";
            this.StatusCustomerGS.Width = 150;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Blue;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(12, 332);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 43);
            this.btnSelect.TabIndex = 65;
            this.btnSelect.Text = "CERCA";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(890, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 43);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "ELIMINA";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(312, 332);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 43);
            this.btnInsert.TabIndex = 67;
            this.btnInsert.Text = "INSERISCI";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(605, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 43);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "AGGIORNA";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 63);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(125, 22);
            this.NameTextBox.TabIndex = 73;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(164, 63);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(125, 22);
            this.SurnameTextBox.TabIndex = 90;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Location = new System.Drawing.Point(12, 129);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(125, 22);
            this.CompanyTextBox.TabIndex = 98;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(164, 129);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(125, 22);
            this.AddressTextBox.TabIndex = 106;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 133;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(161, 34);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(61, 16);
            this.SurnameLabel.TabIndex = 134;
            this.SurnameLabel.Text = "Surname";
            // 
            // CivicNumberTextBox
            // 
            this.CivicNumberTextBox.Location = new System.Drawing.Point(313, 129);
            this.CivicNumberTextBox.Name = "CivicNumberTextBox";
            this.CivicNumberTextBox.Size = new System.Drawing.Size(125, 22);
            this.CivicNumberTextBox.TabIndex = 135;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(12, 100);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(65, 16);
            this.CompanyLabel.TabIndex = 136;
            this.CompanyLabel.Text = "Company";
            this.CompanyLabel.Click += new System.EventHandler(this.CompanyLabel_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(458, 129);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(125, 22);
            this.CityTextBox.TabIndex = 137;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(603, 129);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(125, 22);
            this.ZipCodeTextBox.TabIndex = 138;
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(750, 129);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(125, 22);
            this.RegionTextBox.TabIndex = 139;
            // 
            // NationTextBox
            // 
            this.NationTextBox.Location = new System.Drawing.Point(890, 129);
            this.NationTextBox.Name = "NationTextBox";
            this.NationTextBox.Size = new System.Drawing.Size(125, 22);
            this.NationTextBox.TabIndex = 140;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(161, 100);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 16);
            this.AddressLabel.TabIndex = 141;
            this.AddressLabel.Text = "Address";
            // 
            // CivicNumberLabel
            // 
            this.CivicNumberLabel.AutoSize = true;
            this.CivicNumberLabel.Location = new System.Drawing.Point(305, 100);
            this.CivicNumberLabel.Name = "CivicNumberLabel";
            this.CivicNumberLabel.Size = new System.Drawing.Size(90, 16);
            this.CivicNumberLabel.TabIndex = 142;
            this.CivicNumberLabel.Text = "Civic Number ";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(454, 100);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 16);
            this.CityLabel.TabIndex = 143;
            this.CityLabel.Text = "City";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Location = new System.Drawing.Point(602, 100);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(62, 16);
            this.ZipCodeLabel.TabIndex = 144;
            this.ZipCodeLabel.Text = "Zip Code";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(747, 100);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(51, 16);
            this.RegionLabel.TabIndex = 145;
            this.RegionLabel.Text = "Region";
            // 
            // NationLabel
            // 
            this.NationLabel.AutoSize = true;
            this.NationLabel.Location = new System.Drawing.Point(887, 100);
            this.NationLabel.Name = "NationLabel";
            this.NationLabel.Size = new System.Drawing.Size(46, 16);
            this.NationLabel.TabIndex = 146;
            this.NationLabel.Text = "Nation";
            // 
            // StatusCustomerLabel
            // 
            this.StatusCustomerLabel.AutoSize = true;
            this.StatusCustomerLabel.Location = new System.Drawing.Point(310, 241);
            this.StatusCustomerLabel.Name = "StatusCustomerLabel";
            this.StatusCustomerLabel.Size = new System.Drawing.Size(104, 16);
            this.StatusCustomerLabel.TabIndex = 160;
            this.StatusCustomerLabel.Text = "Status Customer";
            this.StatusCustomerLabel.Click += new System.EventHandler(this.StatusCustomerLabel_Click);
            // 
            // VATCodeLabel
            // 
            this.VATCodeLabel.AutoSize = true;
            this.VATCodeLabel.Location = new System.Drawing.Point(168, 241);
            this.VATCodeLabel.Name = "VATCodeLabel";
            this.VATCodeLabel.Size = new System.Drawing.Size(34, 16);
            this.VATCodeLabel.TabIndex = 159;
            this.VATCodeLabel.Text = "VAT";
            this.VATCodeLabel.Click += new System.EventHandler(this.VATCodeLabel_Click);
            // 
            // SDICodeLabel
            // 
            this.SDICodeLabel.AutoSize = true;
            this.SDICodeLabel.Location = new System.Drawing.Point(12, 241);
            this.SDICodeLabel.Name = "SDICodeLabel";
            this.SDICodeLabel.Size = new System.Drawing.Size(29, 16);
            this.SDICodeLabel.TabIndex = 158;
            this.SDICodeLabel.Text = "SDI";
            // 
            // WebSiteLabel
            // 
            this.WebSiteLabel.AutoSize = true;
            this.WebSiteLabel.Location = new System.Drawing.Point(747, 171);
            this.WebSiteLabel.Name = "WebSiteLabel";
            this.WebSiteLabel.Size = new System.Drawing.Size(59, 16);
            this.WebSiteLabel.TabIndex = 157;
            this.WebSiteLabel.Text = "WebSite";
            // 
            // PECLabel
            // 
            this.PECLabel.AutoSize = true;
            this.PECLabel.Location = new System.Drawing.Point(455, 171);
            this.PECLabel.Name = "PECLabel";
            this.PECLabel.Size = new System.Drawing.Size(34, 16);
            this.PECLabel.TabIndex = 156;
            this.PECLabel.Text = "PEC";
            this.PECLabel.Click += new System.EventHandler(this.PECLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(161, 171);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 155;
            this.EmailLabel.Text = "Email";
            // 
            // StatusCustomerTextBox
            // 
            this.StatusCustomerTextBox.Location = new System.Drawing.Point(307, 275);
            this.StatusCustomerTextBox.Name = "StatusCustomerTextBox";
            this.StatusCustomerTextBox.Size = new System.Drawing.Size(130, 22);
            this.StatusCustomerTextBox.TabIndex = 154;
            this.StatusCustomerTextBox.TextChanged += new System.EventHandler(this.StatusCustomerTextBox_TextChanged);
            // 
            // VatCodeTextBox
            // 
            this.VatCodeTextBox.Location = new System.Drawing.Point(164, 275);
            this.VatCodeTextBox.Name = "VatCodeTextBox";
            this.VatCodeTextBox.Size = new System.Drawing.Size(125, 22);
            this.VatCodeTextBox.TabIndex = 153;
            this.VatCodeTextBox.TextChanged += new System.EventHandler(this.VatCodeTextBox_TextChanged);
            // 
            // SdiCodeTextBox
            // 
            this.SdiCodeTextBox.Location = new System.Drawing.Point(12, 275);
            this.SdiCodeTextBox.Name = "SdiCodeTextBox";
            this.SdiCodeTextBox.Size = new System.Drawing.Size(125, 22);
            this.SdiCodeTextBox.TabIndex = 152;
            // 
            // WebsiteTextBox
            // 
            this.WebsiteTextBox.Location = new System.Drawing.Point(750, 198);
            this.WebsiteTextBox.Name = "WebsiteTextBox";
            this.WebsiteTextBox.Size = new System.Drawing.Size(265, 22);
            this.WebsiteTextBox.TabIndex = 151;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 171);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(46, 16);
            this.PhoneLabel.TabIndex = 150;
            this.PhoneLabel.Text = "Phone";
            // 
            // PecTextBox
            // 
            this.PecTextBox.Location = new System.Drawing.Point(457, 198);
            this.PecTextBox.Name = "PecTextBox";
            this.PecTextBox.Size = new System.Drawing.Size(270, 22);
            this.PecTextBox.TabIndex = 149;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(164, 198);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(273, 22);
            this.EmailTextBox.TabIndex = 148;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 198);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(125, 22);
            this.PhoneTextBox.TabIndex = 147;
            // 
            // WinCustomers
            // 
            this.ClientSize = new System.Drawing.Size(1924, 730);
            this.Controls.Add(this.StatusCustomerLabel);
            this.Controls.Add(this.VATCodeLabel);
            this.Controls.Add(this.SDICodeLabel);
            this.Controls.Add(this.WebSiteLabel);
            this.Controls.Add(this.PECLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.StatusCustomerTextBox);
            this.Controls.Add(this.VatCodeTextBox);
            this.Controls.Add(this.SdiCodeTextBox);
            this.Controls.Add(this.WebsiteTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PecTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NationLabel);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.ZipCodeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CivicNumberLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NationTextBox);
            this.Controls.Add(this.RegionTextBox);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.CivicNumberTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dGV);
            this.Name = "WinCustomers";
            this.Load += new System.EventHandler(this.WinCustomers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox CivicNumberTextBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.TextBox NationTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CivicNumberLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label NationLabel;
        private System.Windows.Forms.Label StatusCustomerLabel;
        private System.Windows.Forms.Label VATCodeLabel;
        private System.Windows.Forms.Label SDICodeLabel;
        private System.Windows.Forms.Label WebSiteLabel;
        private System.Windows.Forms.Label PECLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox StatusCustomerTextBox;
        private System.Windows.Forms.TextBox VatCodeTextBox;
        private System.Windows.Forms.TextBox SdiCodeTextBox;
        private System.Windows.Forms.TextBox WebsiteTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PecTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLegalOwnerGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameLegalOwnerGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CivicNumberGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCodeGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PECGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebSiteGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDI_CodeGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT_CodeGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCustomerGS;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}