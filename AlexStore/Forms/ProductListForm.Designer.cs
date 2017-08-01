namespace AlexStore.Forms
{
    partial class ProductListForm
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
            this.productListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productListGridView
            // 
            this.productListGridView.AllowUserToAddRows = false;
            this.productListGridView.AllowUserToDeleteRows = false;
            this.productListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListGridView.Location = new System.Drawing.Point(0, 0);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.ReadOnly = true;
            this.productListGridView.RowHeadersVisible = false;
            this.productListGridView.Size = new System.Drawing.Size(423, 273);
            this.productListGridView.TabIndex = 0;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 273);
            this.Controls.Add(this.productListGridView);
            this.MaximizeBox = false;
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productListGridView;
    }
}