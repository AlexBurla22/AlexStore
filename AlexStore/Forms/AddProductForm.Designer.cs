namespace AlexStore
{
    partial class AddProductForm
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
            this.productProps = new System.Windows.Forms.GroupBox();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.categBox = new System.Windows.Forms.ComboBox();
            this.stockBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.addedLabel = new System.Windows.Forms.Label();
            this.sbmtBtn = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.errorAddProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.productProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // productProps
            // 
            this.productProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productProps.Controls.Add(this.brandBox);
            this.productProps.Controls.Add(this.categBox);
            this.productProps.Controls.Add(this.stockBox);
            this.productProps.Controls.Add(this.priceBox);
            this.productProps.Controls.Add(this.addedLabel);
            this.productProps.Controls.Add(this.sbmtBtn);
            this.productProps.Controls.Add(this.stockLabel);
            this.productProps.Controls.Add(this.priceLabel);
            this.productProps.Controls.Add(this.brandLabel);
            this.productProps.Controls.Add(this.categoryLabel);
            this.productProps.Controls.Add(this.nameBox);
            this.productProps.Controls.Add(this.nameLabel);
            this.productProps.Location = new System.Drawing.Point(12, 12);
            this.productProps.Name = "productProps";
            this.productProps.Size = new System.Drawing.Size(274, 225);
            this.productProps.TabIndex = 0;
            this.productProps.TabStop = false;
            this.productProps.Text = "Product";
            // 
            // brandBox
            // 
            this.brandBox.FormattingEnabled = true;
            this.brandBox.IntegralHeight = false;
            this.brandBox.Location = new System.Drawing.Point(114, 77);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(121, 21);
            this.brandBox.TabIndex = 3;
            // 
            // categBox
            // 
            this.categBox.FormattingEnabled = true;
            this.categBox.Location = new System.Drawing.Point(115, 50);
            this.categBox.Name = "categBox";
            this.categBox.Size = new System.Drawing.Size(121, 21);
            this.categBox.TabIndex = 2;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(115, 130);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(120, 20);
            this.stockBox.TabIndex = 5;
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(115, 104);
            this.priceBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(120, 20);
            this.priceBox.TabIndex = 4;
            // 
            // addedLabel
            // 
            this.addedLabel.AutoSize = true;
            this.addedLabel.Location = new System.Drawing.Point(22, 180);
            this.addedLabel.Name = "addedLabel";
            this.addedLabel.Size = new System.Drawing.Size(0, 13);
            this.addedLabel.TabIndex = 11;
            // 
            // sbmtBtn
            // 
            this.sbmtBtn.Location = new System.Drawing.Point(162, 168);
            this.sbmtBtn.Name = "sbmtBtn";
            this.sbmtBtn.Size = new System.Drawing.Size(92, 37);
            this.sbmtBtn.TabIndex = 6;
            this.sbmtBtn.Text = "Submit product";
            this.sbmtBtn.UseVisualStyleBackColor = true;
            this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(22, 132);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(35, 13);
            this.stockLabel.TabIndex = 8;
            this.stockLabel.Text = "Stock";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(22, 107);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(22, 80);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Brand";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(22, 53);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(136, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Product name";
            // 
            // errorAddProduct
            // 
            this.errorAddProduct.BlinkRate = 0;
            this.errorAddProduct.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAddProduct.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 249);
            this.Controls.Add(this.productProps);
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a product";
            this.productProps.ResumeLayout(false);
            this.productProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productProps;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button sbmtBtn;
        private System.Windows.Forms.Label addedLabel;
        private System.Windows.Forms.NumericUpDown stockBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.ComboBox categBox;
        private System.Windows.Forms.ErrorProvider errorAddProduct;
    }
}