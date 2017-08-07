namespace AlexStore.Forms
{
    partial class AuditForm
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
            this.dataAuditView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuditView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAuditView
            // 
            this.dataAuditView.AllowUserToAddRows = false;
            this.dataAuditView.AllowUserToDeleteRows = false;
            this.dataAuditView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAuditView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataAuditView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAuditView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAuditView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAuditView.Location = new System.Drawing.Point(0, 0);
            this.dataAuditView.Name = "dataAuditView";
            this.dataAuditView.ReadOnly = true;
            this.dataAuditView.Size = new System.Drawing.Size(689, 380);
            this.dataAuditView.TabIndex = 0;
            // 
            // AuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.dataAuditView);
            this.Name = "AuditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)(this.dataAuditView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAuditView;
    }
}