namespace AlexStore
{
    partial class MainForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.saleBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.productPage = new System.Windows.Forms.TabPage();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.salePage = new System.Windows.Forms.TabPage();
            this.saleGridView = new System.Windows.Forms.DataGridView();
            this.auditBtn = new System.Windows.Forms.Button();
            this.controlBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.productPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.salePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(18, 25);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 28);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlBox.Controls.Add(this.saleBtn);
            this.controlBox.Controls.Add(this.updateBtn);
            this.controlBox.Controls.Add(this.addBtn);
            this.controlBox.Location = new System.Drawing.Point(12, 12);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(156, 473);
            this.controlBox.TabIndex = 7;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "Controls";
            // 
            // saleBtn
            // 
            this.saleBtn.Location = new System.Drawing.Point(18, 91);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(121, 25);
            this.saleBtn.TabIndex = 6;
            this.saleBtn.Text = "Make Sale";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(18, 59);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(121, 26);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Add Stock";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.productPage);
            this.tabControl.Controls.Add(this.salePage);
            this.tabControl.Location = new System.Drawing.Point(174, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(655, 460);
            this.tabControl.TabIndex = 8;
            // 
            // productPage
            // 
            this.productPage.Controls.Add(this.productGridView);
            this.productPage.Location = new System.Drawing.Point(4, 22);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(647, 434);
            this.productPage.TabIndex = 0;
            this.productPage.Text = "Products";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.Location = new System.Drawing.Point(3, 3);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productGridView.Size = new System.Drawing.Size(641, 428);
            this.productGridView.TabIndex = 0;
            // 
            // salePage
            // 
            this.salePage.Controls.Add(this.saleGridView);
            this.salePage.Location = new System.Drawing.Point(4, 22);
            this.salePage.Name = "salePage";
            this.salePage.Padding = new System.Windows.Forms.Padding(3);
            this.salePage.Size = new System.Drawing.Size(647, 436);
            this.salePage.TabIndex = 1;
            this.salePage.Text = "Sales";
            this.salePage.UseVisualStyleBackColor = true;
            // 
            // saleGridView
            // 
            this.saleGridView.AllowUserToAddRows = false;
            this.saleGridView.AllowUserToDeleteRows = false;
            this.saleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.saleGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.saleGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.saleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleGridView.Location = new System.Drawing.Point(3, 3);
            this.saleGridView.Name = "saleGridView";
            this.saleGridView.ReadOnly = true;
            this.saleGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.saleGridView.Size = new System.Drawing.Size(641, 430);
            this.saleGridView.TabIndex = 0;
            this.saleGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.saleGridView_RowHeaderMouseDoubleClick);
            // 
            // auditBtn
            // 
            this.auditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.auditBtn.Location = new System.Drawing.Point(750, 12);
            this.auditBtn.Name = "auditBtn";
            this.auditBtn.Size = new System.Drawing.Size(75, 23);
            this.auditBtn.TabIndex = 9;
            this.auditBtn.Text = "Audit";
            this.auditBtn.UseVisualStyleBackColor = true;
            this.auditBtn.Click += new System.EventHandler(this.auditBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 497);
            this.Controls.Add(this.auditBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.controlBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlexStore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controlBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.productPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.salePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.TabPage salePage;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridView saleGridView;
        private System.Windows.Forms.Button auditBtn;
    }
}

