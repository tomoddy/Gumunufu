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
            HomeTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HomeTable).BeginInit();
            SuspendLayout();
            // 
            // HomeTable
            // 
            HomeTable.AllowUserToAddRows = false;
            HomeTable.AllowUserToDeleteRows = false;
            HomeTable.AllowUserToResizeColumns = false;
            HomeTable.AllowUserToResizeRows = false;
            HomeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HomeTable.Location = new Point(11, 11);
            HomeTable.Margin = new Padding(2);
            HomeTable.Name = "HomeTable";
            HomeTable.RowHeadersWidth = 62;
            HomeTable.RowTemplate.Height = 33;
            HomeTable.Size = new Size(625, 714);
            HomeTable.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 736);
            Controls.Add(HomeTable);
            Margin = new Padding(2);
            Name = "Home";
            Text = "Gumunufu";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)HomeTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HomeTable;
    }
}