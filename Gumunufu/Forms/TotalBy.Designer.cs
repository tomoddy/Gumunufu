namespace Gumunufu.Forms
{
    partial class TotalBy
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
            this.TotalByTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TotalByTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalByTable
            // 
            this.TotalByTable.AllowUserToAddRows = false;
            this.TotalByTable.AllowUserToDeleteRows = false;
            this.TotalByTable.AllowUserToResizeColumns = false;
            this.TotalByTable.AllowUserToResizeRows = false;
            this.TotalByTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalByTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalByTable.Location = new System.Drawing.Point(12, 12);
            this.TotalByTable.Name = "TotalByTable";
            this.TotalByTable.RowHeadersWidth = 62;
            this.TotalByTable.RowTemplate.Height = 33;
            this.TotalByTable.Size = new System.Drawing.Size(741, 1054);
            this.TotalByTable.TabIndex = 1;
            // 
            // TotalBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 1078);
            this.Controls.Add(this.TotalByTable);
            this.Name = "TotalBy";
            this.Text = "Total by ";
            this.Load += new System.EventHandler(this.TotalBy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalByTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView TotalByTable;
    }
}