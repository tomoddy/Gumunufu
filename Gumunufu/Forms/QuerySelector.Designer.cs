namespace Gumunufu.Forms
{
    partial class QuerySelector
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
            this.QuerySelectorStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.QuerySelectorStartDateLabel = new System.Windows.Forms.Label();
            this.QuerySelectorEndDateLabel = new System.Windows.Forms.Label();
            this.QuerySelectorEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.QuerySelectorAccountInput = new System.Windows.Forms.CheckedListBox();
            this.QuerySelectorAccountLabel = new System.Windows.Forms.Label();
            this.QuerySelectorMaxLabel = new System.Windows.Forms.Label();
            this.QuerySelectorMinLabel = new System.Windows.Forms.Label();
            this.QuerySelectorMaxInput = new System.Windows.Forms.TextBox();
            this.QuerySelectorMinInput = new System.Windows.Forms.TextBox();
            this.QuerySelectorCategoryInput = new System.Windows.Forms.CheckedListBox();
            this.QuerySelectorCategoryLabel = new System.Windows.Forms.Label();
            this.QuerySelectorSubmit = new System.Windows.Forms.Button();
            this.QuerySelectorMinNegativeCheckbox = new System.Windows.Forms.CheckBox();
            this.QuerySelectorMaxNegativeCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QuerySelectorStartDatePicker
            // 
            this.QuerySelectorStartDatePicker.Location = new System.Drawing.Point(12, 37);
            this.QuerySelectorStartDatePicker.Name = "QuerySelectorStartDatePicker";
            this.QuerySelectorStartDatePicker.Size = new System.Drawing.Size(300, 31);
            this.QuerySelectorStartDatePicker.TabIndex = 0;
            // 
            // QuerySelectorStartDateLabel
            // 
            this.QuerySelectorStartDateLabel.AutoSize = true;
            this.QuerySelectorStartDateLabel.Location = new System.Drawing.Point(12, 9);
            this.QuerySelectorStartDateLabel.Name = "QuerySelectorStartDateLabel";
            this.QuerySelectorStartDateLabel.Size = new System.Drawing.Size(99, 25);
            this.QuerySelectorStartDateLabel.TabIndex = 1;
            this.QuerySelectorStartDateLabel.Text = "Start Date :";
            // 
            // QuerySelectorEndDateLabel
            // 
            this.QuerySelectorEndDateLabel.AutoSize = true;
            this.QuerySelectorEndDateLabel.Location = new System.Drawing.Point(318, 9);
            this.QuerySelectorEndDateLabel.Name = "QuerySelectorEndDateLabel";
            this.QuerySelectorEndDateLabel.Size = new System.Drawing.Size(93, 25);
            this.QuerySelectorEndDateLabel.TabIndex = 2;
            this.QuerySelectorEndDateLabel.Text = "End Date :";
            // 
            // QuerySelectorEndDatePicker
            // 
            this.QuerySelectorEndDatePicker.Location = new System.Drawing.Point(318, 37);
            this.QuerySelectorEndDatePicker.Name = "QuerySelectorEndDatePicker";
            this.QuerySelectorEndDatePicker.Size = new System.Drawing.Size(300, 31);
            this.QuerySelectorEndDatePicker.TabIndex = 1;
            // 
            // QuerySelectorAccountInput
            // 
            this.QuerySelectorAccountInput.FormattingEnabled = true;
            this.QuerySelectorAccountInput.Location = new System.Drawing.Point(12, 102);
            this.QuerySelectorAccountInput.MultiColumn = true;
            this.QuerySelectorAccountInput.Name = "QuerySelectorAccountInput";
            this.QuerySelectorAccountInput.Size = new System.Drawing.Size(606, 88);
            this.QuerySelectorAccountInput.TabIndex = 2;
            // 
            // QuerySelectorAccountLabel
            // 
            this.QuerySelectorAccountLabel.AutoSize = true;
            this.QuerySelectorAccountLabel.Location = new System.Drawing.Point(12, 74);
            this.QuerySelectorAccountLabel.Name = "QuerySelectorAccountLabel";
            this.QuerySelectorAccountLabel.Size = new System.Drawing.Size(86, 25);
            this.QuerySelectorAccountLabel.TabIndex = 5;
            this.QuerySelectorAccountLabel.Text = "Account :";
            // 
            // QuerySelectorMaxLabel
            // 
            this.QuerySelectorMaxLabel.AutoSize = true;
            this.QuerySelectorMaxLabel.Location = new System.Drawing.Point(12, 380);
            this.QuerySelectorMaxLabel.Name = "QuerySelectorMaxLabel";
            this.QuerySelectorMaxLabel.Size = new System.Drawing.Size(170, 25);
            this.QuerySelectorMaxLabel.TabIndex = 7;
            this.QuerySelectorMaxLabel.Text = "Maximum Amount :";
            // 
            // QuerySelectorMinLabel
            // 
            this.QuerySelectorMinLabel.AutoSize = true;
            this.QuerySelectorMinLabel.Location = new System.Drawing.Point(12, 318);
            this.QuerySelectorMinLabel.Name = "QuerySelectorMinLabel";
            this.QuerySelectorMinLabel.Size = new System.Drawing.Size(167, 25);
            this.QuerySelectorMinLabel.TabIndex = 6;
            this.QuerySelectorMinLabel.Text = "Minimum Amount :";
            // 
            // QuerySelectorMaxInput
            // 
            this.QuerySelectorMaxInput.Location = new System.Drawing.Point(12, 408);
            this.QuerySelectorMaxInput.Name = "QuerySelectorMaxInput";
            this.QuerySelectorMaxInput.Size = new System.Drawing.Size(484, 31);
            this.QuerySelectorMaxInput.TabIndex = 6;
            this.QuerySelectorMaxInput.TextChanged += new System.EventHandler(this.QuerySelectorMaxInput_TextChanged);
            // 
            // QuerySelectorMinInput
            // 
            this.QuerySelectorMinInput.Location = new System.Drawing.Point(12, 346);
            this.QuerySelectorMinInput.Name = "QuerySelectorMinInput";
            this.QuerySelectorMinInput.Size = new System.Drawing.Size(484, 31);
            this.QuerySelectorMinInput.TabIndex = 4;
            this.QuerySelectorMinInput.TextChanged += new System.EventHandler(this.QuerySelectorMinInput_TextChanged);
            // 
            // QuerySelectorCategoryInput
            // 
            this.QuerySelectorCategoryInput.FormattingEnabled = true;
            this.QuerySelectorCategoryInput.Location = new System.Drawing.Point(12, 221);
            this.QuerySelectorCategoryInput.MultiColumn = true;
            this.QuerySelectorCategoryInput.Name = "QuerySelectorCategoryInput";
            this.QuerySelectorCategoryInput.Size = new System.Drawing.Size(606, 88);
            this.QuerySelectorCategoryInput.TabIndex = 3;
            // 
            // QuerySelectorCategoryLabel
            // 
            this.QuerySelectorCategoryLabel.AutoSize = true;
            this.QuerySelectorCategoryLabel.Location = new System.Drawing.Point(12, 193);
            this.QuerySelectorCategoryLabel.Name = "QuerySelectorCategoryLabel";
            this.QuerySelectorCategoryLabel.Size = new System.Drawing.Size(93, 25);
            this.QuerySelectorCategoryLabel.TabIndex = 11;
            this.QuerySelectorCategoryLabel.Text = "Category :";
            // 
            // QuerySelectorSubmit
            // 
            this.QuerySelectorSubmit.Location = new System.Drawing.Point(506, 459);
            this.QuerySelectorSubmit.Name = "QuerySelectorSubmit";
            this.QuerySelectorSubmit.Size = new System.Drawing.Size(112, 34);
            this.QuerySelectorSubmit.TabIndex = 12;
            this.QuerySelectorSubmit.Text = "Submit";
            this.QuerySelectorSubmit.UseVisualStyleBackColor = true;
            this.QuerySelectorSubmit.Click += new System.EventHandler(this.QuerySelectorSubmit_Click);
            // 
            // QuerySelectorMinNegativeCheckbox
            // 
            this.QuerySelectorMinNegativeCheckbox.AutoSize = true;
            this.QuerySelectorMinNegativeCheckbox.Location = new System.Drawing.Point(502, 348);
            this.QuerySelectorMinNegativeCheckbox.Name = "QuerySelectorMinNegativeCheckbox";
            this.QuerySelectorMinNegativeCheckbox.Size = new System.Drawing.Size(116, 29);
            this.QuerySelectorMinNegativeCheckbox.TabIndex = 5;
            this.QuerySelectorMinNegativeCheckbox.Text = "Negative?";
            this.QuerySelectorMinNegativeCheckbox.UseVisualStyleBackColor = true;
            // 
            // QuerySelectorMaxNegativeCheckbox
            // 
            this.QuerySelectorMaxNegativeCheckbox.AutoSize = true;
            this.QuerySelectorMaxNegativeCheckbox.Location = new System.Drawing.Point(502, 410);
            this.QuerySelectorMaxNegativeCheckbox.Name = "QuerySelectorMaxNegativeCheckbox";
            this.QuerySelectorMaxNegativeCheckbox.Size = new System.Drawing.Size(116, 29);
            this.QuerySelectorMaxNegativeCheckbox.TabIndex = 7;
            this.QuerySelectorMaxNegativeCheckbox.Text = "Negative?";
            this.QuerySelectorMaxNegativeCheckbox.UseVisualStyleBackColor = true;
            // 
            // QuerySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 504);
            this.Controls.Add(this.QuerySelectorMaxNegativeCheckbox);
            this.Controls.Add(this.QuerySelectorMinNegativeCheckbox);
            this.Controls.Add(this.QuerySelectorSubmit);
            this.Controls.Add(this.QuerySelectorCategoryLabel);
            this.Controls.Add(this.QuerySelectorCategoryInput);
            this.Controls.Add(this.QuerySelectorMinInput);
            this.Controls.Add(this.QuerySelectorMaxInput);
            this.Controls.Add(this.QuerySelectorMaxLabel);
            this.Controls.Add(this.QuerySelectorMinLabel);
            this.Controls.Add(this.QuerySelectorAccountLabel);
            this.Controls.Add(this.QuerySelectorAccountInput);
            this.Controls.Add(this.QuerySelectorEndDatePicker);
            this.Controls.Add(this.QuerySelectorEndDateLabel);
            this.Controls.Add(this.QuerySelectorStartDateLabel);
            this.Controls.Add(this.QuerySelectorStartDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuerySelector";
            this.Text = "Custom Query";
            this.Load += new System.EventHandler(this.QuerySelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker QuerySelectorStartDatePicker;
        private Label QuerySelectorStartDateLabel;
        private Label QuerySelectorEndDateLabel;
        private DateTimePicker QuerySelectorEndDatePicker;
        private CheckedListBox QuerySelectorAccountInput;
        private Label QuerySelectorAccountLabel;
        private Label QuerySelectorMaxLabel;
        private Label QuerySelectorMinLabel;
        private TextBox QuerySelectorMaxInput;
        private TextBox QuerySelectorMinInput;
        private CheckedListBox QuerySelectorCategoryInput;
        private Label QuerySelectorCategoryLabel;
        private Button QuerySelectorSubmit;
        private CheckBox QuerySelectorMinNegativeCheckbox;
        private CheckBox QuerySelectorMaxNegativeCheckbox;
    }
}