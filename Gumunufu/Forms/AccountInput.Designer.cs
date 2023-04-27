namespace Gumunufu.Forms
{
    partial class AccountInput
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
            this.AccountInputNameInput = new System.Windows.Forms.TextBox();
            this.AccountInputSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountInputNameInput
            // 
            this.AccountInputNameInput.Location = new System.Drawing.Point(12, 12);
            this.AccountInputNameInput.Name = "AccountInputNameInput";
            this.AccountInputNameInput.Size = new System.Drawing.Size(397, 31);
            this.AccountInputNameInput.TabIndex = 0;
            // 
            // AccountInputSubmit
            // 
            this.AccountInputSubmit.Location = new System.Drawing.Point(415, 10);
            this.AccountInputSubmit.Name = "AccountInputSubmit";
            this.AccountInputSubmit.Size = new System.Drawing.Size(112, 34);
            this.AccountInputSubmit.TabIndex = 1;
            this.AccountInputSubmit.Text = "Submit";
            this.AccountInputSubmit.UseVisualStyleBackColor = true;
            this.AccountInputSubmit.Click += new System.EventHandler(this.AccountInputSubmit_Click);
            // 
            // AccountInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 58);
            this.Controls.Add(this.AccountInputSubmit);
            this.Controls.Add(this.AccountInputNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountInput";
            this.Text = "Account Name?";
            this.Load += new System.EventHandler(this.AccountInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AccountInputNameInput;
        private Button AccountInputSubmit;
    }
}