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
            CategoriseDateLabel = new Label();
            CategoriseNameLabel = new Label();
            CategoriseAmountLabel = new Label();
            CategoriseDateTagLabel = new Label();
            CategoriseNameTagLabel = new Label();
            CategoriseAmountTagLabel = new Label();
            SuspendLayout();
            // 
            // CategoriseDateLabel
            // 
            CategoriseDateLabel.AutoSize = true;
            CategoriseDateLabel.Location = new Point(84, 9);
            CategoriseDateLabel.Name = "CategoriseDateLabel";
            CategoriseDateLabel.Size = new Size(30, 15);
            CategoriseDateLabel.TabIndex = 0;
            CategoriseDateLabel.Text = "date";
            CategoriseDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CategoriseNameLabel
            // 
            CategoriseNameLabel.AutoSize = true;
            CategoriseNameLabel.Location = new Point(84, 24);
            CategoriseNameLabel.Name = "CategoriseNameLabel";
            CategoriseNameLabel.Size = new Size(37, 15);
            CategoriseNameLabel.TabIndex = 1;
            CategoriseNameLabel.Text = "name";
            CategoriseNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CategoriseAmountLabel
            // 
            CategoriseAmountLabel.AutoSize = true;
            CategoriseAmountLabel.Location = new Point(84, 39);
            CategoriseAmountLabel.Name = "CategoriseAmountLabel";
            CategoriseAmountLabel.Size = new Size(49, 15);
            CategoriseAmountLabel.TabIndex = 2;
            CategoriseAmountLabel.Text = "amount";
            CategoriseAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CategoriseDateTagLabel
            // 
            CategoriseDateTagLabel.AutoSize = true;
            CategoriseDateTagLabel.Location = new Point(12, 9);
            CategoriseDateTagLabel.Name = "CategoriseDateTagLabel";
            CategoriseDateTagLabel.Size = new Size(37, 15);
            CategoriseDateTagLabel.TabIndex = 3;
            CategoriseDateTagLabel.Text = "Date :";
            CategoriseDateTagLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoriseNameTagLabel
            // 
            CategoriseNameTagLabel.AutoSize = true;
            CategoriseNameTagLabel.Location = new Point(12, 24);
            CategoriseNameTagLabel.Name = "CategoriseNameTagLabel";
            CategoriseNameTagLabel.Size = new Size(45, 15);
            CategoriseNameTagLabel.TabIndex = 4;
            CategoriseNameTagLabel.Text = "Name :";
            CategoriseNameTagLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoriseAmountTagLabel
            // 
            CategoriseAmountTagLabel.AutoSize = true;
            CategoriseAmountTagLabel.Location = new Point(12, 39);
            CategoriseAmountTagLabel.Name = "CategoriseAmountTagLabel";
            CategoriseAmountTagLabel.Size = new Size(57, 15);
            CategoriseAmountTagLabel.TabIndex = 5;
            CategoriseAmountTagLabel.Text = "Amount :";
            CategoriseAmountTagLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Categorise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 126);
            Controls.Add(CategoriseAmountTagLabel);
            Controls.Add(CategoriseNameTagLabel);
            Controls.Add(CategoriseDateTagLabel);
            Controls.Add(CategoriseAmountLabel);
            Controls.Add(CategoriseNameLabel);
            Controls.Add(CategoriseDateLabel);
            Name = "Categorise";
            Text = "Categorise";
            Load += Categorise_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoriseDateLabel;
        private Label CategoriseNameLabel;
        private Label CategoriseAmountLabel;
        private Label CategoriseDateTagLabel;
        private Label CategoriseNameTagLabel;
        private Label CategoriseAmountTagLabel;
    }
}