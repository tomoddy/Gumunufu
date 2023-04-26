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
            HomeMenuStrip = new MenuStrip();
            HomeMenuStripInsert = new ToolStripMenuItem();
            HomeMenuStripInsertFromFile = new ToolStripMenuItem();
            HomeMenuStripInsertManual = new ToolStripMenuItem();
            HomeMenuStripCategorise = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)HomeTable).BeginInit();
            HomeMenuStrip.SuspendLayout();
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
            HomeTable.Location = new Point(11, 26);
            HomeTable.Margin = new Padding(2);
            HomeTable.Name = "HomeTable";
            HomeTable.RowHeadersWidth = 62;
            HomeTable.RowTemplate.Height = 33;
            HomeTable.Size = new Size(625, 699);
            HomeTable.TabIndex = 0;
            // 
            // HomeMenuStrip
            // 
            HomeMenuStrip.Items.AddRange(new ToolStripItem[] { HomeMenuStripInsert, HomeMenuStripCategorise });
            HomeMenuStrip.Location = new Point(0, 0);
            HomeMenuStrip.Name = "HomeMenuStrip";
            HomeMenuStrip.Size = new Size(647, 24);
            HomeMenuStrip.TabIndex = 1;
            HomeMenuStrip.Text = "HomeMenuStrip";
            // 
            // HomeMenuStripInsert
            // 
            HomeMenuStripInsert.DropDownItems.AddRange(new ToolStripItem[] { HomeMenuStripInsertFromFile, HomeMenuStripInsertManual });
            HomeMenuStripInsert.Name = "HomeMenuStripInsert";
            HomeMenuStripInsert.Size = new Size(48, 20);
            HomeMenuStripInsert.Text = "Insert";
            // 
            // HomeMenuStripInsertFromFile
            // 
            HomeMenuStripInsertFromFile.Name = "HomeMenuStripInsertFromFile";
            HomeMenuStripInsertFromFile.Size = new Size(123, 22);
            HomeMenuStripInsertFromFile.Text = "From File";
            // 
            // HomeMenuStripInsertManual
            // 
            HomeMenuStripInsertManual.Name = "HomeMenuStripInsertManual";
            HomeMenuStripInsertManual.Size = new Size(123, 22);
            HomeMenuStripInsertManual.Text = "Manual";
            // 
            // HomeMenuStripCategorise
            // 
            HomeMenuStripCategorise.Name = "HomeMenuStripCategorise";
            HomeMenuStripCategorise.Size = new Size(75, 20);
            HomeMenuStripCategorise.Text = "Categorise";
            HomeMenuStripCategorise.Click += HomeMenuStripCategorise_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 736);
            Controls.Add(HomeTable);
            Controls.Add(HomeMenuStrip);
            MainMenuStrip = HomeMenuStrip;
            Margin = new Padding(2);
            Name = "Home";
            Text = "Gumunufu";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)HomeTable).EndInit();
            HomeMenuStrip.ResumeLayout(false);
            HomeMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HomeTable;
        private MenuStrip HomeMenuStrip;
        private ToolStripMenuItem HomeMenuStripInsert;
        private ToolStripMenuItem HomeMenuStripInsertFromFile;
        private ToolStripMenuItem HomeMenuStripInsertManual;
        private ToolStripMenuItem HomeMenuStripCategorise;
    }
}