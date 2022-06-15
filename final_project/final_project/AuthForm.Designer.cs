namespace final_project
{
    partial class AuthForm
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
            this.UserPassInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.resLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(298, 196);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(143, 22);
            this.UserPassInput.TabIndex = 0;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(298, 131);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(143, 22);
            this.UserNameInput.TabIndex = 1;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(331, 254);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "button1";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(348, 319);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(44, 16);
            this.resLabel.TabIndex = 3;
            this.resLabel.Text = "label1";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.UserPassInput);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPassInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label resLabel;
    }
}