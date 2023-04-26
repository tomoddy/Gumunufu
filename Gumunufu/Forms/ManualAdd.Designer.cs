namespace Gumunufu.Forms
{
    partial class ManualAdd
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
            this.ManualAddDateLabel = new System.Windows.Forms.Label();
            this.ManualAddAmountLabel = new System.Windows.Forms.Label();
            this.ManualAddNameLabel = new System.Windows.Forms.Label();
            this.ManualAddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ManualAddNameInput = new System.Windows.Forms.TextBox();
            this.ManualAddAmountInput = new System.Windows.Forms.TextBox();
            this.ManualAddCategoryInput = new System.Windows.Forms.TextBox();
            this.ManualAddCategoryLabel = new System.Windows.Forms.Label();
            this.ManualAddSubmit = new System.Windows.Forms.Button();
            this.ManualAddNegativeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ManualAddDateLabel
            // 
            this.ManualAddDateLabel.AutoSize = true;
            this.ManualAddDateLabel.Location = new System.Drawing.Point(13, 14);
            this.ManualAddDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualAddDateLabel.Name = "ManualAddDateLabel";
            this.ManualAddDateLabel.Size = new System.Drawing.Size(58, 25);
            this.ManualAddDateLabel.TabIndex = 4;
            this.ManualAddDateLabel.Text = "Date :";
            this.ManualAddDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualAddAmountLabel
            // 
            this.ManualAddAmountLabel.AutoSize = true;
            this.ManualAddAmountLabel.Location = new System.Drawing.Point(13, 86);
            this.ManualAddAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualAddAmountLabel.Name = "ManualAddAmountLabel";
            this.ManualAddAmountLabel.Size = new System.Drawing.Size(86, 25);
            this.ManualAddAmountLabel.TabIndex = 7;
            this.ManualAddAmountLabel.Text = "Amount :";
            this.ManualAddAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualAddNameLabel
            // 
            this.ManualAddNameLabel.AutoSize = true;
            this.ManualAddNameLabel.Location = new System.Drawing.Point(13, 49);
            this.ManualAddNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManualAddNameLabel.Name = "ManualAddNameLabel";
            this.ManualAddNameLabel.Size = new System.Drawing.Size(68, 25);
            this.ManualAddNameLabel.TabIndex = 6;
            this.ManualAddNameLabel.Text = "Name :";
            this.ManualAddNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualAddDatePicker
            // 
            this.ManualAddDatePicker.Location = new System.Drawing.Point(112, 9);
            this.ManualAddDatePicker.Name = "ManualAddDatePicker";
            this.ManualAddDatePicker.Size = new System.Drawing.Size(400, 31);
            this.ManualAddDatePicker.TabIndex = 8;
            // 
            // ManualAddNameInput
            // 
            this.ManualAddNameInput.Location = new System.Drawing.Point(112, 46);
            this.ManualAddNameInput.Name = "ManualAddNameInput";
            this.ManualAddNameInput.Size = new System.Drawing.Size(400, 31);
            this.ManualAddNameInput.TabIndex = 9;
            this.ManualAddNameInput.Text = "GUMUFUNU ADJUSTMENT";
            // 
            // ManualAddAmountInput
            // 
            this.ManualAddAmountInput.Location = new System.Drawing.Point(112, 83);
            this.ManualAddAmountInput.Name = "ManualAddAmountInput";
            this.ManualAddAmountInput.Size = new System.Drawing.Size(400, 31);
            this.ManualAddAmountInput.TabIndex = 10;
            this.ManualAddAmountInput.TextChanged += new System.EventHandler(this.ManualAddAmountInput_TextChanged);
            // 
            // ManualAddCategoryInput
            // 
            this.ManualAddCategoryInput.Location = new System.Drawing.Point(112, 120);
            this.ManualAddCategoryInput.Name = "ManualAddCategoryInput";
            this.ManualAddCategoryInput.Size = new System.Drawing.Size(400, 31);
            this.ManualAddCategoryInput.TabIndex = 11;
            // 
            // ManualAddCategoryLabel
            // 
            this.ManualAddCategoryLabel.AutoSize = true;
            this.ManualAddCategoryLabel.Location = new System.Drawing.Point(13, 123);
            this.ManualAddCategoryLabel.Name = "ManualAddCategoryLabel";
            this.ManualAddCategoryLabel.Size = new System.Drawing.Size(93, 25);
            this.ManualAddCategoryLabel.TabIndex = 12;
            this.ManualAddCategoryLabel.Text = "Category :";
            this.ManualAddCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManualAddSubmit
            // 
            this.ManualAddSubmit.Location = new System.Drawing.Point(400, 158);
            this.ManualAddSubmit.Name = "ManualAddSubmit";
            this.ManualAddSubmit.Size = new System.Drawing.Size(112, 34);
            this.ManualAddSubmit.TabIndex = 13;
            this.ManualAddSubmit.Text = "Submit";
            this.ManualAddSubmit.UseVisualStyleBackColor = true;
            this.ManualAddSubmit.Click += new System.EventHandler(this.ManualAddSubmit_Click);
            // 
            // ManualAddNegativeCheckBox
            // 
            this.ManualAddNegativeCheckBox.AutoSize = true;
            this.ManualAddNegativeCheckBox.Location = new System.Drawing.Point(273, 162);
            this.ManualAddNegativeCheckBox.Name = "ManualAddNegativeCheckBox";
            this.ManualAddNegativeCheckBox.Size = new System.Drawing.Size(116, 29);
            this.ManualAddNegativeCheckBox.TabIndex = 14;
            this.ManualAddNegativeCheckBox.Text = "Negative?";
            this.ManualAddNegativeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManualAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 204);
            this.Controls.Add(this.ManualAddNegativeCheckBox);
            this.Controls.Add(this.ManualAddSubmit);
            this.Controls.Add(this.ManualAddCategoryLabel);
            this.Controls.Add(this.ManualAddCategoryInput);
            this.Controls.Add(this.ManualAddAmountInput);
            this.Controls.Add(this.ManualAddNameInput);
            this.Controls.Add(this.ManualAddDatePicker);
            this.Controls.Add(this.ManualAddAmountLabel);
            this.Controls.Add(this.ManualAddNameLabel);
            this.Controls.Add(this.ManualAddDateLabel);
            this.Name = "ManualAdd";
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.ManualAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ManualAddDateLabel;
        private Label ManualAddAmountLabel;
        private Label ManualAddNameLabel;
        private DateTimePicker ManualAddDatePicker;
        private TextBox ManualAddNameInput;
        private TextBox ManualAddAmountInput;
        private TextBox ManualAddCategoryInput;
        private Label ManualAddCategoryLabel;
        private Button ManualAddSubmit;
        private CheckBox ManualAddNegativeCheckBox;
    }
}