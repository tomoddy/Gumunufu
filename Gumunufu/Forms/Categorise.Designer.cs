namespace Gumunufu.Forms
{
    partial class Categorise
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
            this.CategoriseDateLabel = new System.Windows.Forms.Label();
            this.CategoriseNameLabel = new System.Windows.Forms.Label();
            this.CategoriseAmountLabel = new System.Windows.Forms.Label();
            this.CategoriseDateTagLabel = new System.Windows.Forms.Label();
            this.CategoriseNameTagLabel = new System.Windows.Forms.Label();
            this.CategoriseAmountTagLabel = new System.Windows.Forms.Label();
            this.CategoriseListView = new System.Windows.Forms.ListView();
            this.CategoriseSubmit = new System.Windows.Forms.Button();
            this.CategoriseInput = new System.Windows.Forms.TextBox();
            this.CategoriseNewCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CategoriseDateLabel
            // 
            this.CategoriseDateLabel.AutoSize = true;
            this.CategoriseDateLabel.Location = new System.Drawing.Point(120, 15);
            this.CategoriseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseDateLabel.Name = "CategoriseDateLabel";
            this.CategoriseDateLabel.Size = new System.Drawing.Size(47, 25);
            this.CategoriseDateLabel.TabIndex = 0;
            this.CategoriseDateLabel.Text = "date";
            this.CategoriseDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoriseNameLabel
            // 
            this.CategoriseNameLabel.AutoSize = true;
            this.CategoriseNameLabel.Location = new System.Drawing.Point(120, 40);
            this.CategoriseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseNameLabel.Name = "CategoriseNameLabel";
            this.CategoriseNameLabel.Size = new System.Drawing.Size(56, 25);
            this.CategoriseNameLabel.TabIndex = 1;
            this.CategoriseNameLabel.Text = "name";
            this.CategoriseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoriseAmountLabel
            // 
            this.CategoriseAmountLabel.AutoSize = true;
            this.CategoriseAmountLabel.Location = new System.Drawing.Point(120, 65);
            this.CategoriseAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseAmountLabel.Name = "CategoriseAmountLabel";
            this.CategoriseAmountLabel.Size = new System.Drawing.Size(74, 25);
            this.CategoriseAmountLabel.TabIndex = 2;
            this.CategoriseAmountLabel.Text = "amount";
            this.CategoriseAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoriseDateTagLabel
            // 
            this.CategoriseDateTagLabel.AutoSize = true;
            this.CategoriseDateTagLabel.Location = new System.Drawing.Point(17, 15);
            this.CategoriseDateTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseDateTagLabel.Name = "CategoriseDateTagLabel";
            this.CategoriseDateTagLabel.Size = new System.Drawing.Size(58, 25);
            this.CategoriseDateTagLabel.TabIndex = 3;
            this.CategoriseDateTagLabel.Text = "Date :";
            this.CategoriseDateTagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoriseNameTagLabel
            // 
            this.CategoriseNameTagLabel.AutoSize = true;
            this.CategoriseNameTagLabel.Location = new System.Drawing.Point(17, 40);
            this.CategoriseNameTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseNameTagLabel.Name = "CategoriseNameTagLabel";
            this.CategoriseNameTagLabel.Size = new System.Drawing.Size(68, 25);
            this.CategoriseNameTagLabel.TabIndex = 4;
            this.CategoriseNameTagLabel.Text = "Name :";
            this.CategoriseNameTagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoriseAmountTagLabel
            // 
            this.CategoriseAmountTagLabel.AutoSize = true;
            this.CategoriseAmountTagLabel.Location = new System.Drawing.Point(17, 65);
            this.CategoriseAmountTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriseAmountTagLabel.Name = "CategoriseAmountTagLabel";
            this.CategoriseAmountTagLabel.Size = new System.Drawing.Size(86, 25);
            this.CategoriseAmountTagLabel.TabIndex = 5;
            this.CategoriseAmountTagLabel.Text = "Amount :";
            this.CategoriseAmountTagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoriseListView
            // 
            this.CategoriseListView.Location = new System.Drawing.Point(12, 128);
            this.CategoriseListView.MultiSelect = false;
            this.CategoriseListView.Name = "CategoriseListView";
            this.CategoriseListView.Size = new System.Drawing.Size(325, 191);
            this.CategoriseListView.TabIndex = 7;
            this.CategoriseListView.UseCompatibleStateImageBehavior = false;
            this.CategoriseListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // CategoriseSubmit
            // 
            this.CategoriseSubmit.Location = new System.Drawing.Point(230, 325);
            this.CategoriseSubmit.Name = "CategoriseSubmit";
            this.CategoriseSubmit.Size = new System.Drawing.Size(112, 34);
            this.CategoriseSubmit.TabIndex = 8;
            this.CategoriseSubmit.Text = "Submit";
            this.CategoriseSubmit.UseVisualStyleBackColor = true;
            this.CategoriseSubmit.Click += new System.EventHandler(this.CategoriseSubmit_Click);
            // 
            // CategoriseInput
            // 
            this.CategoriseInput.Enabled = false;
            this.CategoriseInput.Location = new System.Drawing.Point(12, 328);
            this.CategoriseInput.Name = "CategoriseInput";
            this.CategoriseInput.Size = new System.Drawing.Size(207, 31);
            this.CategoriseInput.TabIndex = 9;
            // 
            // CategoriseNewCheckBox
            // 
            this.CategoriseNewCheckBox.AutoSize = true;
            this.CategoriseNewCheckBox.Location = new System.Drawing.Point(12, 93);
            this.CategoriseNewCheckBox.Name = "CategoriseNewCheckBox";
            this.CategoriseNewCheckBox.Size = new System.Drawing.Size(155, 29);
            this.CategoriseNewCheckBox.TabIndex = 10;
            this.CategoriseNewCheckBox.Text = "New category?";
            this.CategoriseNewCheckBox.UseVisualStyleBackColor = true;
            this.CategoriseNewCheckBox.CheckedChanged += new System.EventHandler(this.CategoriseNewCheckBox_CheckedChanged);
            // 
            // Categorise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 371);
            this.Controls.Add(this.CategoriseNewCheckBox);
            this.Controls.Add(this.CategoriseInput);
            this.Controls.Add(this.CategoriseSubmit);
            this.Controls.Add(this.CategoriseListView);
            this.Controls.Add(this.CategoriseAmountTagLabel);
            this.Controls.Add(this.CategoriseNameTagLabel);
            this.Controls.Add(this.CategoriseDateTagLabel);
            this.Controls.Add(this.CategoriseAmountLabel);
            this.Controls.Add(this.CategoriseNameLabel);
            this.Controls.Add(this.CategoriseDateLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Categorise";
            this.Text = "Categorise";
            this.Load += new System.EventHandler(this.Categorise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CategoriseDateLabel;
        private Label CategoriseNameLabel;
        private Label CategoriseAmountLabel;
        private Label CategoriseDateTagLabel;
        private Label CategoriseNameTagLabel;
        private Label CategoriseAmountTagLabel;
        private ListView CategoriseListView;
        private Button CategoriseSubmit;
        private TextBox CategoriseInput;
        private CheckBox CategoriseNewCheckBox;
    }
}