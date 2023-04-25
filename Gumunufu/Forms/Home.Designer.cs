namespace Gumunufu.Forms
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeTable
            // 
            this.HomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeTable.Location = new System.Drawing.Point(12, 12);
            this.HomeTable.Name = "HomeTable";
            this.HomeTable.RowHeadersWidth = 62;
            this.HomeTable.RowTemplate.Height = 33;
            this.HomeTable.Size = new System.Drawing.Size(2523, 1203);
            this.HomeTable.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2547, 1227);
            this.Controls.Add(this.HomeTable);
            this.Name = "Home";
            this.Text = "Gumunufu";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView HomeTable;
    }
}