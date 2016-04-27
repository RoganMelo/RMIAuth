namespace RMIAuthServer
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnVerify = new System.Windows.Forms.Button();
            this.ListBoxClientInformations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(15, 25);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(154, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(15, 64);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(154, 20);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // BtnVerify
            // 
            this.BtnVerify.Location = new System.Drawing.Point(15, 90);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(323, 38);
            this.BtnVerify.TabIndex = 4;
            this.BtnVerify.Text = "Verify";
            this.BtnVerify.UseVisualStyleBackColor = true;
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // ListBoxClientInformations
            // 
            this.ListBoxClientInformations.FormattingEnabled = true;
            this.ListBoxClientInformations.Location = new System.Drawing.Point(15, 133);
            this.ListBoxClientInformations.Name = "ListBoxClientInformations";
            this.ListBoxClientInformations.Size = new System.Drawing.Size(323, 173);
            this.ListBoxClientInformations.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First letter must be a capital letter.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Must contain letters and numbers.";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxClientInformations);
            this.Controls.Add(this.BtnVerify);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button BtnVerify;
        private System.Windows.Forms.ListBox ListBoxClientInformations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}