namespace Gumunufu.Forms
{
    partial class TransactionView
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
            this.TransactionViewTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionViewTable
            // 
            this.TransactionViewTable.AllowUserToAddRows = false;
            this.TransactionViewTable.AllowUserToDeleteRows = false;
            this.TransactionViewTable.AllowUserToResizeColumns = false;
            this.TransactionViewTable.AllowUserToResizeRows = false;
            this.TransactionViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionViewTable.Location = new System.Drawing.Point(12, 12);
            this.TransactionViewTable.Name = "TransactionViewTable";
            this.TransactionViewTable.ReadOnly = true;
            this.TransactionViewTable.RowHeadersWidth = 62;
            this.TransactionViewTable.RowTemplate.Height = 33;
            this.TransactionViewTable.Size = new System.Drawing.Size(776, 1273);
            this.TransactionViewTable.TabIndex = 0;
            this.TransactionViewTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionViewTable_CellDoubleClick);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1297);
            this.Controls.Add(this.TransactionViewTable);
            this.Name = "TransactionView";
            this.Text = "All Transactions";
            this.Load += new System.EventHandler(this.TransactionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView TransactionViewTable;
    }
}