namespace WindowsFormsAppTest
{
    partial class Form1
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.TBEmail = new System.Windows.Forms.Label();
            this.buttonGetGlobalVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(135, 25);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(149, 23);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "Please type Youe email";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.Location = new System.Drawing.Point(34, 133);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(250, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Set Value Globally";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBEmail
            // 
            this.TBEmail.AutoSize = true;
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBEmail.Location = new System.Drawing.Point(525, 25);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(146, 37);
            this.TBEmail.TabIndex = 5;
            this.TBEmail.Text = "Not set yet";
            // 
            // buttonGetGlobalVar
            // 
            this.buttonGetGlobalVar.Location = new System.Drawing.Point(464, 133);
            this.buttonGetGlobalVar.Name = "buttonGetGlobalVar";
            this.buttonGetGlobalVar.Size = new System.Drawing.Size(217, 23);
            this.buttonGetGlobalVar.TabIndex = 6;
            this.buttonGetGlobalVar.Text = "Show Global Variable";
            this.buttonGetGlobalVar.UseVisualStyleBackColor = true;
            this.buttonGetGlobalVar.Click += new System.EventHandler(this.buttonGetGlobalVar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetGlobalVar);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label TBEmail;
        private System.Windows.Forms.Button buttonGetGlobalVar;
    }
}

