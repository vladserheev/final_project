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
            this.label1 = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.SignInBtn.Location = new System.Drawing.Point(330, 241);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Ввійти";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(278, 321);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(0, 16);
            this.resLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизація";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(298, 283);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(143, 23);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Зареєструватися";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ім\'я:";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}