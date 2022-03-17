namespace Semester_Project_Client.WPF
{
    partial class WelcomePage
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
            System.Windows.Forms.TextBox textBox4;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WelcomeTab = new System.Windows.Forms.TabPage();
            this.QuitButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.Quit = new System.Windows.Forms.Button();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Signin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NewUserTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateNewUserConfirmPassword = new System.Windows.Forms.TextBox();
            this.CreateNewUser = new System.Windows.Forms.Button();
            this.CreateNewUserPassword = new System.Windows.Forms.TextBox();
            this.CreateNewUserUsername = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ErrorMessage = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.NewUserTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new System.Drawing.Point(121, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Create New User";
            textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.WelcomeTab);
            this.tabControl1.Controls.Add(this.LoginTab);
            this.tabControl1.Controls.Add(this.NewUserTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1751, 1044);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // WelcomeTab
            // 
            this.WelcomeTab.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WelcomeTab.Controls.Add(this.QuitButton);
            this.WelcomeTab.Controls.Add(this.NewUserButton);
            this.WelcomeTab.Controls.Add(this.LoginButton);
            this.WelcomeTab.Controls.Add(this.Connect);
            this.WelcomeTab.Controls.Add(this.WelcomeText);
            this.WelcomeTab.Controls.Add(this.Quit);
            this.WelcomeTab.Location = new System.Drawing.Point(4, 5);
            this.WelcomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(1743, 1035);
            this.WelcomeTab.TabIndex = 0;
            this.WelcomeTab.Text = "tabPage1";
            this.WelcomeTab.Click += new System.EventHandler(this.WelcomeTab_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(1109, 11);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Enabled = false;
            this.NewUserButton.Location = new System.Drawing.Point(766, 375);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(94, 49);
            this.NewUserButton.TabIndex = 4;
            this.NewUserButton.Text = "Create New User";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Visible = false;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(384, 375);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 49);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Visible = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(575, 375);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(94, 49);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WelcomeText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.Location = new System.Drawing.Point(384, 223);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WelcomeText.Multiline = true;
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.ReadOnly = true;
            this.WelcomeText.Size = new System.Drawing.Size(476, 100);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Connect To The Server";
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeText.TextChanged += new System.EventHandler(this.textBox1_Clicked);
            // 
            // Quit
            // 
            this.Quit.AccessibleName = "Quit";
            this.Quit.Location = new System.Drawing.Point(1653, 4);
            this.Quit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(86, 31);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginTab.Controls.Add(this.LoginPanel);
            this.LoginTab.Location = new System.Drawing.Point(4, 5);
            this.LoginTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(1743, 1035);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "tabPage1";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoginPanel.Controls.Add(this.textBox3);
            this.LoginPanel.Controls.Add(this.Signin);
            this.LoginPanel.Controls.Add(this.textBox2);
            this.LoginPanel.Controls.Add(this.textBox1);
            this.LoginPanel.Location = new System.Drawing.Point(431, 123);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(360, 346);
            this.LoginPanel.TabIndex = 0;
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(135, 279);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(94, 29);
            this.Signin.TabIndex = 2;
            this.Signin.Text = "SignIn";
            this.Signin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Enter Password Here";
            this.textBox2.Size = new System.Drawing.Size(149, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter Username Here";
            this.textBox1.Size = new System.Drawing.Size(149, 27);
            this.textBox1.TabIndex = 0;
            // 
            // NewUserTab
            // 
            this.NewUserTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewUserTab.Controls.Add(this.panel1);
            this.NewUserTab.Location = new System.Drawing.Point(4, 5);
            this.NewUserTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewUserTab.Name = "NewUserTab";
            this.NewUserTab.Size = new System.Drawing.Size(1743, 1035);
            this.NewUserTab.TabIndex = 2;
            this.NewUserTab.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.ErrorMessage);
            this.panel1.Controls.Add(this.CreateNewUserConfirmPassword);
            this.panel1.Controls.Add(textBox4);
            this.panel1.Controls.Add(this.CreateNewUser);
            this.panel1.Controls.Add(this.CreateNewUserPassword);
            this.panel1.Controls.Add(this.CreateNewUserUsername);
            this.panel1.Location = new System.Drawing.Point(401, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 346);
            this.panel1.TabIndex = 1;
            // 
            // CreateNewUserConfirmPassword
            // 
            this.CreateNewUserConfirmPassword.Location = new System.Drawing.Point(94, 237);
            this.CreateNewUserConfirmPassword.Name = "CreateNewUserConfirmPassword";
            this.CreateNewUserConfirmPassword.PasswordChar = '*';
            this.CreateNewUserConfirmPassword.PlaceholderText = "Confirm Password Here";
            this.CreateNewUserConfirmPassword.Size = new System.Drawing.Size(179, 27);
            this.CreateNewUserConfirmPassword.TabIndex = 4;
            this.CreateNewUserConfirmPassword.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.Location = new System.Drawing.Point(135, 279);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(94, 29);
            this.CreateNewUser.TabIndex = 2;
            this.CreateNewUser.Text = "Create User";
            this.CreateNewUser.UseVisualStyleBackColor = true;
            this.CreateNewUser.Click += new System.EventHandler(this.CreateUserButton);
            // 
            // CreateNewUserPassword
            // 
            this.CreateNewUserPassword.Location = new System.Drawing.Point(94, 204);
            this.CreateNewUserPassword.Name = "CreateNewUserPassword";
            this.CreateNewUserPassword.PasswordChar = '*';
            this.CreateNewUserPassword.PlaceholderText = "Enter Password Here";
            this.CreateNewUserPassword.Size = new System.Drawing.Size(179, 27);
            this.CreateNewUserPassword.TabIndex = 1;
            this.CreateNewUserPassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // CreateNewUserUsername
            // 
            this.CreateNewUserUsername.Location = new System.Drawing.Point(94, 171);
            this.CreateNewUserUsername.Name = "CreateNewUserUsername";
            this.CreateNewUserUsername.PlaceholderText = "Enter Username Here";
            this.CreateNewUserUsername.Size = new System.Drawing.Size(179, 27);
            this.CreateNewUserUsername.TabIndex = 0;
            this.CreateNewUserUsername.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(121, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Login";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.SystemColors.Info;
            this.ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(55, 101);
            this.ErrorMessage.Multiline = true;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(255, 64);
            this.ErrorMessage.TabIndex = 5;
            // 
            // WelcomePage
            // 
            this.AccessibleName = "WelcomePage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 740);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.WelcomeTab.ResumeLayout(false);
            this.WelcomeTab.PerformLayout();
            this.LoginTab.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.NewUserTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage WelcomeTab;
        private TabPage LoginTab;
        private TabPage NewUserTab;
        private Button Quit;
        private TextBox WelcomeText;
        private Button Connect;
        private Button NewUserButton;
        private Button LoginButton;
        private Button QuitButton;
        private Panel LoginPanel;
        private Button Signin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox CreateNewUserConfirmPassword;
        private Button CreateNewUser;
        private TextBox CreateNewUserPassword;
        private TextBox CreateNewUserUsername;
        private TextBox textBox3;
        private TextBox ErrorMessage;
    }
}