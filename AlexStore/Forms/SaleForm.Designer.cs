namespace AlexStore
{
    partial class SaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactBox = new System.Windows.Forms.GroupBox();
            this.juridPanel = new System.Windows.Forms.Panel();
            this.emailJuridBox = new System.Windows.Forms.TextBox();
            this.juridPhoneBox = new System.Windows.Forms.TextBox();
            this.cuiLabel = new System.Windows.Forms.Label();
            this.cuiBox = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.city2Label = new System.Windows.Forms.Label();
            this.city2Box = new System.Windows.Forms.TextBox();
            this.juridPhoneLabel = new System.Windows.Forms.Label();
            this.emial2Label = new System.Windows.Forms.Label();
            this.compNameBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.physicalPanel = new System.Windows.Forms.Panel();
            this.cnpBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addresBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.physRadio = new System.Windows.Forms.RadioButton();
            this.jurRadio = new System.Windows.Forms.RadioButton();
            this.box = new System.Windows.Forms.GroupBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.quantityUp = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.sbmitBtn = new System.Windows.Forms.Button();
            this.prodsBox = new System.Windows.Forms.ComboBox();
            this.errorSale = new System.Windows.Forms.ErrorProvider(this.components);
            this.buyerCB = new System.Windows.Forms.ComboBox();
            this.addBuyerBTN = new System.Windows.Forms.Button();
            this.buyersGroupBox = new System.Windows.Forms.GroupBox();
            this.addedLabel = new System.Windows.Forms.Label();
            this.currStock = new System.Windows.Forms.Label();
            this.contactBox.SuspendLayout();
            this.juridPanel.SuspendLayout();
            this.physicalPanel.SuspendLayout();
            this.box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSale)).BeginInit();
            this.buyersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactBox
            // 
            this.contactBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactBox.Controls.Add(this.juridPanel);
            this.contactBox.Controls.Add(this.physicalPanel);
            this.contactBox.Controls.Add(this.physRadio);
            this.contactBox.Controls.Add(this.jurRadio);
            this.contactBox.Location = new System.Drawing.Point(12, 74);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(242, 250);
            this.contactBox.TabIndex = 2;
            this.contactBox.TabStop = false;
            this.contactBox.Text = "Add buyer";
            // 
            // juridPanel
            // 
            this.juridPanel.Controls.Add(this.emailJuridBox);
            this.juridPanel.Controls.Add(this.juridPhoneBox);
            this.juridPanel.Controls.Add(this.cuiLabel);
            this.juridPanel.Controls.Add(this.cuiBox);
            this.juridPanel.Controls.Add(this.address2Box);
            this.juridPanel.Controls.Add(this.address2Label);
            this.juridPanel.Controls.Add(this.city2Label);
            this.juridPanel.Controls.Add(this.city2Box);
            this.juridPanel.Controls.Add(this.juridPhoneLabel);
            this.juridPanel.Controls.Add(this.emial2Label);
            this.juridPanel.Controls.Add(this.compNameBox);
            this.juridPanel.Controls.Add(this.companyLabel);
            this.juridPanel.Location = new System.Drawing.Point(12, 42);
            this.juridPanel.Name = "juridPanel";
            this.juridPanel.Size = new System.Drawing.Size(212, 165);
            this.juridPanel.TabIndex = 2;
            this.juridPanel.Visible = false;
            // 
            // emailJuridBox
            // 
            this.emailJuridBox.Location = new System.Drawing.Point(91, 35);
            this.emailJuridBox.Name = "emailJuridBox";
            this.emailJuridBox.Size = new System.Drawing.Size(100, 20);
            this.emailJuridBox.TabIndex = 2;
            // 
            // juridPhoneBox
            // 
            this.juridPhoneBox.Location = new System.Drawing.Point(91, 61);
            this.juridPhoneBox.Name = "juridPhoneBox";
            this.juridPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.juridPhoneBox.TabIndex = 3;
            // 
            // cuiLabel
            // 
            this.cuiLabel.AutoSize = true;
            this.cuiLabel.Location = new System.Drawing.Point(6, 142);
            this.cuiLabel.Name = "cuiLabel";
            this.cuiLabel.Size = new System.Drawing.Size(25, 13);
            this.cuiLabel.TabIndex = 13;
            this.cuiLabel.Text = "CUI";
            // 
            // cuiBox
            // 
            this.cuiBox.Location = new System.Drawing.Point(91, 139);
            this.cuiBox.Name = "cuiBox";
            this.cuiBox.Size = new System.Drawing.Size(100, 20);
            this.cuiBox.TabIndex = 6;
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(91, 113);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(100, 20);
            this.address2Box.TabIndex = 5;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(6, 116);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(45, 13);
            this.address2Label.TabIndex = 10;
            this.address2Label.Text = "Address";
            // 
            // city2Label
            // 
            this.city2Label.AutoSize = true;
            this.city2Label.Location = new System.Drawing.Point(6, 90);
            this.city2Label.Name = "city2Label";
            this.city2Label.Size = new System.Drawing.Size(24, 13);
            this.city2Label.TabIndex = 9;
            this.city2Label.Text = "City";
            // 
            // city2Box
            // 
            this.city2Box.Location = new System.Drawing.Point(91, 87);
            this.city2Box.Name = "city2Box";
            this.city2Box.Size = new System.Drawing.Size(100, 20);
            this.city2Box.TabIndex = 4;
            // 
            // juridPhoneLabel
            // 
            this.juridPhoneLabel.AutoSize = true;
            this.juridPhoneLabel.Location = new System.Drawing.Point(3, 64);
            this.juridPhoneLabel.Name = "juridPhoneLabel";
            this.juridPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.juridPhoneLabel.TabIndex = 7;
            this.juridPhoneLabel.Text = "Phone";
            // 
            // emial2Label
            // 
            this.emial2Label.AutoSize = true;
            this.emial2Label.Location = new System.Drawing.Point(3, 38);
            this.emial2Label.Name = "emial2Label";
            this.emial2Label.Size = new System.Drawing.Size(32, 13);
            this.emial2Label.TabIndex = 5;
            this.emial2Label.Text = "Email";
            // 
            // compNameBox
            // 
            this.compNameBox.Location = new System.Drawing.Point(91, 9);
            this.compNameBox.Name = "compNameBox";
            this.compNameBox.Size = new System.Drawing.Size(100, 20);
            this.compNameBox.TabIndex = 1;
            // 
            // companyLabel
            // 
            this.companyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(1, 12);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(82, 13);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company Name";
            // 
            // physicalPanel
            // 
            this.physicalPanel.Controls.Add(this.cnpBox);
            this.physicalPanel.Controls.Add(this.phoneBox);
            this.physicalPanel.Controls.Add(this.emailBox);
            this.physicalPanel.Controls.Add(this.cnpLabel);
            this.physicalPanel.Controls.Add(this.addressLabel);
            this.physicalPanel.Controls.Add(this.addresBox);
            this.physicalPanel.Controls.Add(this.cityLabel);
            this.physicalPanel.Controls.Add(this.cityBox);
            this.physicalPanel.Controls.Add(this.phoneLabel);
            this.physicalPanel.Controls.Add(this.emailLabel);
            this.physicalPanel.Controls.Add(this.lastNameLabel);
            this.physicalPanel.Controls.Add(this.lastNameBox);
            this.physicalPanel.Controls.Add(this.firstNameBox);
            this.physicalPanel.Controls.Add(this.firstNameLabel);
            this.physicalPanel.Location = new System.Drawing.Point(9, 42);
            this.physicalPanel.Name = "physicalPanel";
            this.physicalPanel.Size = new System.Drawing.Size(215, 187);
            this.physicalPanel.TabIndex = 2;
            this.physicalPanel.Visible = false;
            // 
            // cnpBox
            // 
            this.cnpBox.Location = new System.Drawing.Point(87, 165);
            this.cnpBox.Name = "cnpBox";
            this.cnpBox.Size = new System.Drawing.Size(100, 20);
            this.cnpBox.TabIndex = 7;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(87, 87);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(87, 61);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 3;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(16, 168);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(29, 13);
            this.cnpLabel.TabIndex = 12;
            this.cnpLabel.Text = "CNP";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(16, 142);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Address";
            // 
            // addresBox
            // 
            this.addresBox.Location = new System.Drawing.Point(87, 139);
            this.addresBox.Name = "addresBox";
            this.addresBox.Size = new System.Drawing.Size(100, 20);
            this.addresBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(16, 116);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(87, 113);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 90);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(13, 64);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(87, 35);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(87, 9);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 12);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // physRadio
            // 
            this.physRadio.AutoSize = true;
            this.physRadio.Location = new System.Drawing.Point(116, 19);
            this.physRadio.Name = "physRadio";
            this.physRadio.Size = new System.Drawing.Size(100, 17);
            this.physRadio.TabIndex = 0;
            this.physRadio.TabStop = true;
            this.physRadio.Text = "Physical Person";
            this.physRadio.UseVisualStyleBackColor = true;
            this.physRadio.CheckedChanged += new System.EventHandler(this.physRadio_CheckedChanged);
            // 
            // jurRadio
            // 
            this.jurRadio.AutoSize = true;
            this.jurRadio.Location = new System.Drawing.Point(9, 19);
            this.jurRadio.Name = "jurRadio";
            this.jurRadio.Size = new System.Drawing.Size(99, 17);
            this.jurRadio.TabIndex = 1;
            this.jurRadio.TabStop = true;
            this.jurRadio.Text = "Juridical Person";
            this.jurRadio.UseVisualStyleBackColor = true;
            this.jurRadio.CheckedChanged += new System.EventHandler(this.jurRadio_CheckedChanged);
            // 
            // box
            // 
            this.box.Controls.Add(this.currStock);
            this.box.Controls.Add(this.checkLabel);
            this.box.Controls.Add(this.quantityUp);
            this.box.Controls.Add(this.priceLabel);
            this.box.Controls.Add(this.productsGrid);
            this.box.Controls.Add(this.addBtn);
            this.box.Controls.Add(this.sbmitBtn);
            this.box.Controls.Add(this.prodsBox);
            this.box.Location = new System.Drawing.Point(260, 3);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(540, 435);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Text = "Products";
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(381, 404);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(36, 13);
            this.checkLabel.TabIndex = 6;
            this.checkLabel.Text = "Done!";
            this.checkLabel.Visible = false;
            // 
            // quantityUp
            // 
            this.quantityUp.Location = new System.Drawing.Point(413, 45);
            this.quantityUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUp.Name = "quantityUp";
            this.quantityUp.Size = new System.Drawing.Size(44, 20);
            this.quantityUp.TabIndex = 9;
            this.quantityUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 390);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Total: ";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productsGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.productsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGrid.DefaultCellStyle = dataGridViewCellStyle26;
            this.productsGrid.Location = new System.Drawing.Point(6, 71);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.productsGrid.Size = new System.Drawing.Size(528, 316);
            this.productsGrid.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Location = new System.Drawing.Point(459, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // sbmitBtn
            // 
            this.sbmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbmitBtn.Location = new System.Drawing.Point(459, 392);
            this.sbmitBtn.Name = "sbmitBtn";
            this.sbmitBtn.Size = new System.Drawing.Size(75, 37);
            this.sbmitBtn.TabIndex = 11;
            this.sbmitBtn.Text = "Submit";
            this.sbmitBtn.UseVisualStyleBackColor = true;
            this.sbmitBtn.Click += new System.EventHandler(this.sbmitBtn_Click);
            // 
            // prodsBox
            // 
            this.prodsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodsBox.FormattingEnabled = true;
            this.prodsBox.IntegralHeight = false;
            this.prodsBox.Location = new System.Drawing.Point(6, 15);
            this.prodsBox.Name = "prodsBox";
            this.prodsBox.Size = new System.Drawing.Size(528, 21);
            this.prodsBox.TabIndex = 8;
            this.prodsBox.SelectedIndexChanged += new System.EventHandler(this.prodsBox_SelectedIndexChanged);
            // 
            // errorSale
            // 
            this.errorSale.BlinkRate = 0;
            this.errorSale.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorSale.ContainerControl = this;
            // 
            // buyerCB
            // 
            this.buyerCB.FormattingEnabled = true;
            this.buyerCB.IntegralHeight = false;
            this.buyerCB.Location = new System.Drawing.Point(21, 28);
            this.buyerCB.Name = "buyerCB";
            this.buyerCB.Size = new System.Drawing.Size(195, 21);
            this.buyerCB.TabIndex = 3;
            // 
            // addBuyerBTN
            // 
            this.addBuyerBTN.Location = new System.Drawing.Point(170, 336);
            this.addBuyerBTN.Name = "addBuyerBTN";
            this.addBuyerBTN.Size = new System.Drawing.Size(75, 54);
            this.addBuyerBTN.TabIndex = 3;
            this.addBuyerBTN.Text = "Add new buyer";
            this.addBuyerBTN.UseVisualStyleBackColor = true;
            this.addBuyerBTN.Click += new System.EventHandler(this.addBuyerBTN_Click);
            // 
            // buyersGroupBox
            // 
            this.buyersGroupBox.Controls.Add(this.buyerCB);
            this.buyersGroupBox.Location = new System.Drawing.Point(12, 3);
            this.buyersGroupBox.Name = "buyersGroupBox";
            this.buyersGroupBox.Size = new System.Drawing.Size(242, 65);
            this.buyersGroupBox.TabIndex = 4;
            this.buyersGroupBox.TabStop = false;
            this.buyersGroupBox.Text = "Buyers";
            // 
            // addedLabel
            // 
            this.addedLabel.AutoSize = true;
            this.addedLabel.Location = new System.Drawing.Point(18, 336);
            this.addedLabel.Name = "addedLabel";
            this.addedLabel.Size = new System.Drawing.Size(41, 13);
            this.addedLabel.TabIndex = 5;
            this.addedLabel.Text = "Added!";
            this.addedLabel.Visible = false;
            // 
            // currStock
            // 
            this.currStock.AutoSize = true;
            this.currStock.Location = new System.Drawing.Point(357, 47);
            this.currStock.Name = "currStock";
            this.currStock.Size = new System.Drawing.Size(41, 13);
            this.currStock.TabIndex = 12;
            this.currStock.Text = "Stock: ";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.addedLabel);
            this.Controls.Add(this.buyersGroupBox);
            this.Controls.Add(this.addBuyerBTN);
            this.Controls.Add(this.box);
            this.Controls.Add(this.contactBox);
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Sale";
            this.contactBox.ResumeLayout(false);
            this.contactBox.PerformLayout();
            this.juridPanel.ResumeLayout(false);
            this.juridPanel.PerformLayout();
            this.physicalPanel.ResumeLayout(false);
            this.physicalPanel.PerformLayout();
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSale)).EndInit();
            this.buyersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox prodsBox;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.Button sbmitBtn;
        private System.Windows.Forms.RadioButton physRadio;
        private System.Windows.Forms.RadioButton jurRadio;
        private System.Windows.Forms.GroupBox contactBox;
        private System.Windows.Forms.Panel physicalPanel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addresBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Panel juridPanel;
        private System.Windows.Forms.TextBox compNameBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label juridPhoneLabel;
        private System.Windows.Forms.Label emial2Label;
        private System.Windows.Forms.TextBox city2Box;
        private System.Windows.Forms.Label city2Label;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cuiLabel;
        private System.Windows.Forms.TextBox cuiBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown quantityUp;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.TextBox juridPhoneBox;
        private System.Windows.Forms.TextBox emailJuridBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox cnpBox;
        private System.Windows.Forms.ErrorProvider errorSale;
        private System.Windows.Forms.ComboBox buyerCB;
        private System.Windows.Forms.Button addBuyerBTN;
        private System.Windows.Forms.GroupBox buyersGroupBox;
        private System.Windows.Forms.Label addedLabel;
        private System.Windows.Forms.Label currStock;
    }
}