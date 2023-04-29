namespace Gumunufu.Forms
{
    partial class Manual
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
            this.ManualDateLabel = new System.Windows.Forms.Label();
            this.ManualAmountLabel = new System.Windows.Forms.Label();
            this.ManualNameLabel = new System.Windows.Forms.Label();
            this.ManualDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ManualNameInput = new System.Windows.Forms.TextBox();
            this.ManualAmountInput = new System.Windows.Forms.TextBox();
            this.ManualCategoryInput = new System.Windows.Forms.TextBox();
            this.ManualCategoryLabel = new System.Windows.Forms.Label();
            this.ManualSave = new System.Windows.Forms.Button();
            this.ManualNegativeCheckBox = new System.Windows.Forms.CheckBox();
            this.ManualAccountInput = new System.Windows.Forms.TextBox();
            this.ManualAccountLabel = new System.Windows.Forms.Label();
            this.ManualDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManualDateLabel
            // 
            this.ManualDateLabel.AutoSize = true;
            this.ManualDateLabel.Location = new System.Drawing.Point(13, 14);
            this.ManualDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualDateLabel.Name = "ManualDateLabel";
            this.ManualDateLabel.Size = new System.Drawing.Size(58, 25);
            this.ManualDateLabel.TabIndex = 4;
            this.ManualDateLabel.Text = "Date :";
            this.ManualDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualAmountLabel
            // 
            this.ManualAmountLabel.AutoSize = true;
            this.ManualAmountLabel.Location = new System.Drawing.Point(13, 163);
            this.ManualAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualAmountLabel.Name = "ManualAmountLabel";
            this.ManualAmountLabel.Size = new System.Drawing.Size(86, 25);
            this.ManualAmountLabel.TabIndex = 7;
            this.ManualAmountLabel.Text = "Amount :";
            this.ManualAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualNameLabel
            // 
            this.ManualNameLabel.AutoSize = true;
            this.ManualNameLabel.Location = new System.Drawing.Point(13, 126);
            this.ManualNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualNameLabel.Name = "ManualNameLabel";
            this.ManualNameLabel.Size = new System.Drawing.Size(68, 25);
            this.ManualNameLabel.TabIndex = 6;
            this.ManualNameLabel.Text = "Name :";
            this.ManualNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualDatePicker
            // 
            this.ManualDatePicker.Location = new System.Drawing.Point(112, 9);
            this.ManualDatePicker.Name = "ManualDatePicker";
            this.ManualDatePicker.Size = new System.Drawing.Size(400, 31);
            this.ManualDatePicker.TabIndex = 0;
            // 
            // ManualNameInput
            // 
            this.ManualNameInput.Location = new System.Drawing.Point(112, 123);
            this.ManualNameInput.Name = "ManualNameInput";
            this.ManualNameInput.Size = new System.Drawing.Size(400, 31);
            this.ManualNameInput.TabIndex = 3;
            // 
            // ManualAmountInput
            // 
            this.ManualAmountInput.Location = new System.Drawing.Point(112, 160);
            this.ManualAmountInput.Name = "ManualAmountInput";
            this.ManualAmountInput.Size = new System.Drawing.Size(400, 31);
            this.ManualAmountInput.TabIndex = 4;
            this.ManualAmountInput.TextChanged += new System.EventHandler(this.ManualAmountInput_TextChanged);
            // 
            // ManualCategoryInput
            // 
            this.ManualCategoryInput.Location = new System.Drawing.Point(112, 83);
            this.ManualCategoryInput.Name = "ManualCategoryInput";
            this.ManualCategoryInput.Size = new System.Drawing.Size(400, 31);
            this.ManualCategoryInput.TabIndex = 2;
            // 
            // ManualCategoryLabel
            // 
            this.ManualCategoryLabel.AutoSize = true;
            this.ManualCategoryLabel.Location = new System.Drawing.Point(13, 86);
            this.ManualCategoryLabel.Name = "ManualCategoryLabel";
            this.ManualCategoryLabel.Size = new System.Drawing.Size(93, 25);
            this.ManualCategoryLabel.TabIndex = 12;
            this.ManualCategoryLabel.Text = "Category :";
            this.ManualCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualSave
            // 
            this.ManualSave.Location = new System.Drawing.Point(400, 197);
            this.ManualSave.Name = "ManualSave";
            this.ManualSave.Size = new System.Drawing.Size(112, 34);
            this.ManualSave.TabIndex = 13;
            this.ManualSave.Text = "Save";
            this.ManualSave.UseVisualStyleBackColor = true;
            this.ManualSave.Click += new System.EventHandler(this.ManualSave_Click);
            // 
            // ManualNegativeCheckBox
            // 
            this.ManualNegativeCheckBox.AutoSize = true;
            this.ManualNegativeCheckBox.Location = new System.Drawing.Point(112, 201);
            this.ManualNegativeCheckBox.Name = "ManualNegativeCheckBox";
            this.ManualNegativeCheckBox.Size = new System.Drawing.Size(116, 29);
            this.ManualNegativeCheckBox.TabIndex = 5;
            this.ManualNegativeCheckBox.Text = "Negative?";
            this.ManualNegativeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManualAccountInput
            // 
            this.ManualAccountInput.Location = new System.Drawing.Point(112, 46);
            this.ManualAccountInput.Name = "ManualAccountInput";
            this.ManualAccountInput.Size = new System.Drawing.Size(400, 31);
            this.ManualAccountInput.TabIndex = 1;
            // 
            // ManualAccountLabel
            // 
            this.ManualAccountLabel.AutoSize = true;
            this.ManualAccountLabel.Location = new System.Drawing.Point(13, 49);
            this.ManualAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualAccountLabel.Name = "ManualAccountLabel";
            this.ManualAccountLabel.Size = new System.Drawing.Size(86, 25);
            this.ManualAccountLabel.TabIndex = 15;
            this.ManualAccountLabel.Text = "Account :";
            this.ManualAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualDelete
            // 
            this.ManualDelete.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.ManualDelete.Location = new System.Drawing.Point(282, 197);
            this.ManualDelete.Name = "ManualDelete";
            this.ManualDelete.Size = new System.Drawing.Size(112, 34);
            this.ManualDelete.TabIndex = 6;
            this.ManualDelete.Text = "Delete";
            this.ManualDelete.UseVisualStyleBackColor = true;
            this.ManualDelete.Click += new System.EventHandler(this.ManualDelete_Click);
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 243);
            this.Controls.Add(this.ManualDelete);
            this.Controls.Add(this.ManualAccountInput);
            this.Controls.Add(this.ManualAccountLabel);
            this.Controls.Add(this.ManualNegativeCheckBox);
            this.Controls.Add(this.ManualSave);
            this.Controls.Add(this.ManualCategoryLabel);
            this.Controls.Add(this.ManualCategoryInput);
            this.Controls.Add(this.ManualAmountInput);
            this.Controls.Add(this.ManualNameInput);
            this.Controls.Add(this.ManualDatePicker);
            this.Controls.Add(this.ManualAmountLabel);
            this.Controls.Add(this.ManualNameLabel);
            this.Controls.Add(this.ManualDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manual";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ManualDateLabel;
        private Label ManualAmountLabel;
        private Label ManualNameLabel;
        private DateTimePicker ManualDatePicker;
        private TextBox ManualNameInput;
        private TextBox ManualAmountInput;
        private TextBox ManualCategoryInput;
        private Label ManualCategoryLabel;
        private Button ManualSave;
        private CheckBox ManualNegativeCheckBox;
        private TextBox ManualAccountInput;
        private Label ManualAccountLabel;
        private Button ManualDelete;
    }
}