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
            this.HomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.HomeMenuStripInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripInsertFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripInsertFromFileLloyds = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStrupInsertFromFileMonzo = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripInsertManual = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripCategorise = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripViewTotalBy = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStrupViewTotalByAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripViewTotalByCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripViewTotalByName = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStripExport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTable)).BeginInit();
            this.HomeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTable
            // 
            this.HomeTable.AllowUserToAddRows = false;
            this.HomeTable.AllowUserToDeleteRows = false;
            this.HomeTable.AllowUserToResizeColumns = false;
            this.HomeTable.AllowUserToResizeRows = false;
            this.HomeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeTable.Location = new System.Drawing.Point(16, 43);
            this.HomeTable.Name = "HomeTable";
            this.HomeTable.ReadOnly = true;
            this.HomeTable.RowHeadersWidth = 62;
            this.HomeTable.RowTemplate.Height = 33;
            this.HomeTable.Size = new System.Drawing.Size(893, 1165);
            this.HomeTable.TabIndex = 0;
            this.HomeTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomeTable_CellDoubleClick);
            // 
            // HomeMenuStrip
            // 
            this.HomeMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.HomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuStripInsert,
            this.HomeMenuStripCategorise,
            this.HomeMenuStripView,
            this.HomeMenuStripQuery,
            this.HomeMenuStripExport});
            this.HomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuStrip.Name = "HomeMenuStrip";
            this.HomeMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.HomeMenuStrip.Size = new System.Drawing.Size(924, 35);
            this.HomeMenuStrip.TabIndex = 1;
            this.HomeMenuStrip.Text = "HomeMenuStrip";
            // 
            // HomeMenuStripInsert
            // 
            this.HomeMenuStripInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuStripInsertFromFile,
            this.HomeMenuStripInsertManual});
            this.HomeMenuStripInsert.Name = "HomeMenuStripInsert";
            this.HomeMenuStripInsert.Size = new System.Drawing.Size(72, 29);
            this.HomeMenuStripInsert.Text = "Insert";
            // 
            // HomeMenuStripInsertFromFile
            // 
            this.HomeMenuStripInsertFromFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuStripInsertFromFileLloyds,
            this.HomeMenuStrupInsertFromFileMonzo});
            this.HomeMenuStripInsertFromFile.Name = "HomeMenuStripInsertFromFile";
            this.HomeMenuStripInsertFromFile.Size = new System.Drawing.Size(187, 34);
            this.HomeMenuStripInsertFromFile.Text = "From File";
            // 
            // HomeMenuStripInsertFromFileLloyds
            // 
            this.HomeMenuStripInsertFromFileLloyds.Name = "HomeMenuStripInsertFromFileLloyds";
            this.HomeMenuStripInsertFromFileLloyds.Size = new System.Drawing.Size(170, 34);
            this.HomeMenuStripInsertFromFileLloyds.Text = "Lloyds";
            this.HomeMenuStripInsertFromFileLloyds.Click += new System.EventHandler(this.HomeMenuStripInsertFromFileLloyds_Click);
            // 
            // HomeMenuStrupInsertFromFileMonzo
            // 
            this.HomeMenuStrupInsertFromFileMonzo.Name = "HomeMenuStrupInsertFromFileMonzo";
            this.HomeMenuStrupInsertFromFileMonzo.Size = new System.Drawing.Size(170, 34);
            this.HomeMenuStrupInsertFromFileMonzo.Text = "Monzo";
            this.HomeMenuStrupInsertFromFileMonzo.Click += new System.EventHandler(this.HomeMenuStrupInsertFromFileMonzo_Click);
            // 
            // HomeMenuStripInsertManual
            // 
            this.HomeMenuStripInsertManual.Name = "HomeMenuStripInsertManual";
            this.HomeMenuStripInsertManual.Size = new System.Drawing.Size(187, 34);
            this.HomeMenuStripInsertManual.Text = "Manual";
            this.HomeMenuStripInsertManual.Click += new System.EventHandler(this.HomeMenuStripInsertManual_Click);
            // 
            // HomeMenuStripCategorise
            // 
            this.HomeMenuStripCategorise.Name = "HomeMenuStripCategorise";
            this.HomeMenuStripCategorise.Size = new System.Drawing.Size(112, 29);
            this.HomeMenuStripCategorise.Text = "Categorise";
            this.HomeMenuStripCategorise.Click += new System.EventHandler(this.HomeMenuStripCategorise_Click);
            // 
            // HomeMenuStripView
            // 
            this.HomeMenuStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuStripViewAll,
            this.HomeMenuStripViewTotalBy});
            this.HomeMenuStripView.Name = "HomeMenuStripView";
            this.HomeMenuStripView.Size = new System.Drawing.Size(65, 29);
            this.HomeMenuStripView.Text = "View";
            // 
            // HomeMenuStripViewAll
            // 
            this.HomeMenuStripViewAll.Name = "HomeMenuStripViewAll";
            this.HomeMenuStripViewAll.Size = new System.Drawing.Size(175, 34);
            this.HomeMenuStripViewAll.Text = "All";
            this.HomeMenuStripViewAll.Click += new System.EventHandler(this.HomeMenuStripViewAll_Click);
            // 
            // HomeMenuStripViewTotalBy
            // 
            this.HomeMenuStripViewTotalBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuStrupViewTotalByAccount,
            this.HomeMenuStripViewTotalByCategory,
            this.HomeMenuStripViewTotalByName});
            this.HomeMenuStripViewTotalBy.Name = "HomeMenuStripViewTotalBy";
            this.HomeMenuStripViewTotalBy.Size = new System.Drawing.Size(175, 34);
            this.HomeMenuStripViewTotalBy.Text = "Total By";
            // 
            // HomeMenuStrupViewTotalByAccount
            // 
            this.HomeMenuStrupViewTotalByAccount.Name = "HomeMenuStrupViewTotalByAccount";
            this.HomeMenuStrupViewTotalByAccount.Size = new System.Drawing.Size(186, 34);
            this.HomeMenuStrupViewTotalByAccount.Text = "Account";
            this.HomeMenuStrupViewTotalByAccount.Click += new System.EventHandler(this.HomeMenuStrupViewTotalByAccount_Click);
            // 
            // HomeMenuStripViewTotalByCategory
            // 
            this.HomeMenuStripViewTotalByCategory.Name = "HomeMenuStripViewTotalByCategory";
            this.HomeMenuStripViewTotalByCategory.Size = new System.Drawing.Size(186, 34);
            this.HomeMenuStripViewTotalByCategory.Text = "Category";
            this.HomeMenuStripViewTotalByCategory.Click += new System.EventHandler(this.HomeMenuStripViewTotalByCategory_Click);
            // 
            // HomeMenuStripViewTotalByName
            // 
            this.HomeMenuStripViewTotalByName.Name = "HomeMenuStripViewTotalByName";
            this.HomeMenuStripViewTotalByName.Size = new System.Drawing.Size(186, 34);
            this.HomeMenuStripViewTotalByName.Text = "Name";
            this.HomeMenuStripViewTotalByName.Click += new System.EventHandler(this.HomeMenuStripViewTotalByName_Click);
            // 
            // HomeMenuStripQuery
            // 
            this.HomeMenuStripQuery.Name = "HomeMenuStripQuery";
            this.HomeMenuStripQuery.Size = new System.Drawing.Size(76, 29);
            this.HomeMenuStripQuery.Text = "Query";
            this.HomeMenuStripQuery.Click += new System.EventHandler(this.HomeMenuStripQuery_Click);
            // 
            // HomeMenuStripExport
            // 
            this.HomeMenuStripExport.Enabled = false;
            this.HomeMenuStripExport.Name = "HomeMenuStripExport";
            this.HomeMenuStripExport.Size = new System.Drawing.Size(79, 29);
            this.HomeMenuStripExport.Text = "Export";
            this.HomeMenuStripExport.Visible = false;
            this.HomeMenuStripExport.Click += new System.EventHandler(this.HomeMenuStripExport_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 1227);
            this.Controls.Add(this.HomeTable);
            this.Controls.Add(this.HomeMenuStrip);
            this.MainMenuStrip = this.HomeMenuStrip;
            this.Name = "Home";
            this.Text = "Gumunufu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeTable)).EndInit();
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView HomeTable;
        private MenuStrip HomeMenuStrip;
        private ToolStripMenuItem HomeMenuStripInsert;
        private ToolStripMenuItem HomeMenuStripInsertFromFile;
        private ToolStripMenuItem HomeMenuStripInsertManual;
        private ToolStripMenuItem HomeMenuStripCategorise;
        private ToolStripMenuItem HomeMenuStripInsertFromFileLloyds;
        private ToolStripMenuItem HomeMenuStripView;
        private ToolStripMenuItem HomeMenuStripViewAll;
        private ToolStripMenuItem HomeMenuStripViewTotalBy;
        private ToolStripMenuItem HomeMenuStripViewTotalByCategory;
        private ToolStripMenuItem HomeMenuStripViewTotalByName;
        private ToolStripMenuItem HomeMenuStrupViewTotalByAccount;
        private ToolStripMenuItem HomeMenuStrupInsertFromFileMonzo;
        private ToolStripMenuItem HomeMenuStripQuery;
        private ToolStripMenuItem HomeMenuStripExport;
    }
}