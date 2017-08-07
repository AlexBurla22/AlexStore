namespace AlexStore
{
    partial class AddStockForm
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
            this.updateControls = new System.Windows.Forms.GroupBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addedStock = new System.Windows.Forms.NumericUpDown();
            this.addLabel = new System.Windows.Forms.Label();
            this.currentStock = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.errorAddStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.updateControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddStock)).BeginInit();
            this.SuspendLayout();
            // 
            // updateControls
            // 
            this.updateControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateControls.Controls.Add(this.updateLabel);
            this.updateControls.Controls.Add(this.updateBtn);
            this.updateControls.Controls.Add(this.addedStock);
            this.updateControls.Controls.Add(this.addLabel);
            this.updateControls.Controls.Add(this.currentStock);
            this.updateControls.Controls.Add(this.stockText);
            this.updateControls.Controls.Add(this.productBox);
            this.updateControls.Controls.Add(this.chooseLabel);
            this.updateControls.Location = new System.Drawing.Point(12, 12);
            this.updateControls.Name = "updateControls";
            this.updateControls.Size = new System.Drawing.Size(276, 181);
            this.updateControls.TabIndex = 0;
            this.updateControls.TabStop = false;
            this.updateControls.Text = "Update";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(16, 130);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(0, 13);
            this.updateLabel.TabIndex = 7;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(195, 138);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 37);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addedStock
            // 
            this.addedStock.Location = new System.Drawing.Point(119, 92);
            this.addedStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addedStock.Name = "addedStock";
            this.addedStock.Size = new System.Drawing.Size(106, 20);
            this.addedStock.TabIndex = 2;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(16, 94);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(68, 13);
            this.addLabel.TabIndex = 4;
            this.addLabel.Text = "Stock to add";
            // 
            // currentStock
            // 
            this.currentStock.AutoSize = true;
            this.currentStock.Location = new System.Drawing.Point(140, 62);
            this.currentStock.Name = "currentStock";
            this.currentStock.Size = new System.Drawing.Size(33, 13);
            this.currentStock.TabIndex = 3;
            this.currentStock.Text = "None";
            // 
            // stockText
            // 
            this.stockText.AutoSize = true;
            this.stockText.Location = new System.Drawing.Point(16, 62);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(118, 13);
            this.stockText.TabIndex = 2;
            this.stockText.Text = "Current stock available:";
            // 
            // productBox
            // 
            this.productBox.FormattingEnabled = true;
            this.productBox.IntegralHeight = false;
            this.productBox.Location = new System.Drawing.Point(119, 27);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(109, 21);
            this.productBox.TabIndex = 1;
            this.productBox.SelectedIndexChanged += new System.EventHandler(this.productBox_SelectedIndexChanged);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(16, 30);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(82, 13);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Choose product";
            // 
            // errorAddStock
            // 
            this.errorAddStock.BlinkRate = 0;
            this.errorAddStock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAddStock.ContainerControl = this;
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 205);
            this.Controls.Add(this.updateControls);
            this.MaximizeBox = false;
            this.Name = "AddStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update stock";
            this.updateControls.ResumeLayout(false);
            this.updateControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox updateControls;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label currentStock;
        private System.Windows.Forms.Label stockText;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.NumericUpDown addedStock;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.ErrorProvider errorAddStock;
    }
}