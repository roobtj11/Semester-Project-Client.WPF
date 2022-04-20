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
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.GoBack1 = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.Signin = new System.Windows.Forms.Button();
            this.NewUserTab = new System.Windows.Forms.TabPage();
            this.GoBack2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorMessage = new System.Windows.Forms.TextBox();
            this.CreateNewUserConfirmPassword = new System.Windows.Forms.TextBox();
            this.CreateNewUser = new System.Windows.Forms.Button();
            this.CreateNewUserPassword = new System.Windows.Forms.TextBox();
            this.CreateNewUserUsername = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Game1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.WelcomeMessage = new System.Windows.Forms.TextBox();
            this.Game = new System.Windows.Forms.TabPage();
            this.logout = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.gotoMenu = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.ChatPage = new System.Windows.Forms.TabPage();
            this.SendMessage = new System.Windows.Forms.Button();
            this.Chat = new System.Windows.Forms.RichTextBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TitleBar = new System.Windows.Forms.TextBox();
            this.HomeaddPoint = new System.Windows.Forms.Button();
            this.AwayScorePoint = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.NewUserTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ChatPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Controls.Add(this.Game);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 745);
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
            this.WelcomeTab.Location = new System.Drawing.Point(4, 5);
            this.WelcomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(1215, 736);
            this.WelcomeTab.TabIndex = 0;
            this.WelcomeTab.Text = "tabPage1";
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
            this.WelcomeText.Size = new System.Drawing.Size(475, 123);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Connect To The Server";
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginTab.Controls.Add(this.GoBack1);
            this.LoginTab.Controls.Add(this.LoginPanel);
            this.LoginTab.Location = new System.Drawing.Point(4, 5);
            this.LoginTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(1215, 736);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "tabPage1";
            // 
            // GoBack1
            // 
            this.GoBack1.Location = new System.Drawing.Point(1115, 13);
            this.GoBack1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBack1.Name = "GoBack1";
            this.GoBack1.Size = new System.Drawing.Size(86, 31);
            this.GoBack1.TabIndex = 1;
            this.GoBack1.Text = "GoBack";
            this.GoBack1.UseVisualStyleBackColor = true;
            this.GoBack1.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoginPanel.Controls.Add(this.textBox3);
            this.LoginPanel.Controls.Add(this.loginUsername);
            this.LoginPanel.Controls.Add(this.loginPassword);
            this.LoginPanel.Controls.Add(this.Signin);
            this.LoginPanel.Location = new System.Drawing.Point(431, 123);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(360, 347);
            this.LoginPanel.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(121, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Login";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(109, 181);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.PlaceholderText = "Enter Username Here";
            this.loginUsername.Size = new System.Drawing.Size(149, 27);
            this.loginUsername.TabIndex = 0;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(109, 227);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.PlaceholderText = "Enter Password Here";
            this.loginPassword.Size = new System.Drawing.Size(149, 27);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(135, 279);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(94, 29);
            this.Signin.TabIndex = 2;
            this.Signin.Text = "SignIn";
            this.Signin.UseVisualStyleBackColor = true;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // NewUserTab
            // 
            this.NewUserTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewUserTab.Controls.Add(this.GoBack2);
            this.NewUserTab.Controls.Add(this.panel1);
            this.NewUserTab.Location = new System.Drawing.Point(4, 5);
            this.NewUserTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewUserTab.Name = "NewUserTab";
            this.NewUserTab.Size = new System.Drawing.Size(1215, 736);
            this.NewUserTab.TabIndex = 2;
            this.NewUserTab.Text = "tabPage1";
            // 
            // GoBack2
            // 
            this.GoBack2.Location = new System.Drawing.Point(1115, 13);
            this.GoBack2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBack2.Name = "GoBack2";
            this.GoBack2.Size = new System.Drawing.Size(86, 31);
            this.GoBack2.TabIndex = 2;
            this.GoBack2.Text = "Back";
            this.GoBack2.UseVisualStyleBackColor = true;
            this.GoBack2.Click += new System.EventHandler(this.GoBack_Click);
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
            this.panel1.Location = new System.Drawing.Point(401, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 347);
            this.panel1.TabIndex = 1;
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
            // CreateNewUserConfirmPassword
            // 
            this.CreateNewUserConfirmPassword.Location = new System.Drawing.Point(94, 237);
            this.CreateNewUserConfirmPassword.Name = "CreateNewUserConfirmPassword";
            this.CreateNewUserConfirmPassword.PasswordChar = '*';
            this.CreateNewUserConfirmPassword.PlaceholderText = "Confirm Password Here";
            this.CreateNewUserConfirmPassword.Size = new System.Drawing.Size(179, 27);
            this.CreateNewUserConfirmPassword.TabIndex = 2;
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.Location = new System.Drawing.Point(135, 279);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(94, 29);
            this.CreateNewUser.TabIndex = 3;
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
            // 
            // CreateNewUserUsername
            // 
            this.CreateNewUserUsername.Location = new System.Drawing.Point(94, 171);
            this.CreateNewUserUsername.Name = "CreateNewUserUsername";
            this.CreateNewUserUsername.PlaceholderText = "Enter Username Here";
            this.CreateNewUserUsername.Size = new System.Drawing.Size(179, 27);
            this.CreateNewUserUsername.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.AllowDrop = true;
            this.Menu.Controls.Add(this.tableLayoutPanel1);
            this.Menu.Controls.Add(this.WelcomeMessage);
            this.Menu.Location = new System.Drawing.Point(4, 5);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1215, 736);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.48588F));
            this.tableLayoutPanel1.Controls.Add(this.Game1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 184);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 552);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Game1
            // 
            this.Game1.Location = new System.Drawing.Point(3, 4);
            this.Game1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Game1.Name = "Game1";
            this.Game1.Size = new System.Drawing.Size(205, 113);
            this.Game1.TabIndex = 1;
            this.Game1.Text = "Open Game";
            this.Game1.UseVisualStyleBackColor = true;
            this.Game1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(215, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(114, 112);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeMessage.Location = new System.Drawing.Point(0, 0);
            this.WelcomeMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(1215, 27);
            this.WelcomeMessage.TabIndex = 0;
            // 
            // Game
            // 
            this.Game.Controls.Add(this.logout);
            this.Game.Controls.Add(this.Quit);
            this.Game.Controls.Add(this.gotoMenu);
            this.Game.Controls.Add(this.splitContainer1);
            this.Game.Controls.Add(this.TitleBar);
            this.Game.Location = new System.Drawing.Point(4, 5);
            this.Game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(1215, 736);
            this.Game.TabIndex = 4;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(1035, 11);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 31);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(1128, 11);
            this.Quit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(86, 31);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // gotoMenu
            // 
            this.gotoMenu.Location = new System.Drawing.Point(943, 11);
            this.gotoMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gotoMenu.Name = "gotoMenu";
            this.gotoMenu.Size = new System.Drawing.Size(86, 31);
            this.gotoMenu.TabIndex = 4;
            this.gotoMenu.Text = "Menu";
            this.gotoMenu.UseVisualStyleBackColor = true;
            this.gotoMenu.Click += new System.EventHandler(this.gotoMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox3);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 692);
            this.splitContainer1.SplitterDistance = 726;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.ChatPage);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(3, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(480, 689);
            this.tabControl2.TabIndex = 5;
            // 
            // ChatPage
            // 
            this.ChatPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ChatPage.Controls.Add(this.SendMessage);
            this.ChatPage.Controls.Add(this.Chat);
            this.ChatPage.Controls.Add(this.MessageBox);
            this.ChatPage.Location = new System.Drawing.Point(4, 32);
            this.ChatPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatPage.Name = "ChatPage";
            this.ChatPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatPage.Size = new System.Drawing.Size(472, 653);
            this.ChatPage.TabIndex = 0;
            this.ChatPage.Text = "Chat";
            this.ChatPage.UseVisualStyleBackColor = true;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(390, 596);
            this.SendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(82, 56);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // Chat
            // 
            this.Chat.Location = new System.Drawing.Point(0, 0);
            this.Chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.Size = new System.Drawing.Size(470, 592);
            this.Chat.TabIndex = 4;
            this.Chat.Text = "";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(3, 623);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.PlaceholderText = "Type Message Here";
            this.MessageBox.Size = new System.Drawing.Size(381, 27);
            this.MessageBox.TabIndex = 3;
            this.MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage2.Controls.Add(this.AwayScorePoint);
            this.tabPage2.Controls.Add(this.HomeaddPoint);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(472, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TitleBar.CausesValidation = false;
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.PlaceholderText = "Team 1 V.S. Team 2";
            this.TitleBar.Size = new System.Drawing.Size(1215, 44);
            this.TitleBar.TabIndex = 50;
            this.TitleBar.TabStop = false;
            this.TitleBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeaddPoint
            // 
            this.HomeaddPoint.Location = new System.Drawing.Point(96, 177);
            this.HomeaddPoint.Name = "HomeaddPoint";
            this.HomeaddPoint.Size = new System.Drawing.Size(101, 63);
            this.HomeaddPoint.TabIndex = 0;
            this.HomeaddPoint.Text = "Home Point +1";
            this.HomeaddPoint.UseVisualStyleBackColor = true;
            // 
            // AwayScorePoint
            // 
            this.AwayScorePoint.Location = new System.Drawing.Point(235, 177);
            this.AwayScorePoint.Name = "AwayScorePoint";
            this.AwayScorePoint.Size = new System.Drawing.Size(94, 63);
            this.AwayScorePoint.TabIndex = 1;
            this.AwayScorePoint.Text = "Away Point +1";
            this.AwayScorePoint.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(154, 227);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(125, 120);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "15";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox3.Location = new System.Drawing.Point(475, 227);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(125, 120);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "24";
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
            this.tabControl1.ResumeLayout(false);
            this.WelcomeTab.ResumeLayout(false);
            this.WelcomeTab.PerformLayout();
            this.LoginTab.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.NewUserTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ChatPage.ResumeLayout(false);
            this.ChatPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage WelcomeTab;
        private TabPage LoginTab;
        private TabPage NewUserTab;
        private TextBox WelcomeText;
        private Button Connect;
        private Button NewUserButton;
        private Button LoginButton;
        private Button QuitButton;
        private Panel LoginPanel;
        private Button Signin;
        private TextBox loginPassword;
        private TextBox loginUsername;
        private Panel panel1;
        private TextBox CreateNewUserConfirmPassword;
        private Button CreateNewUser;
        private TextBox CreateNewUserPassword;
        private TextBox CreateNewUserUsername;
        private TextBox textBox3;
        private TextBox ErrorMessage;
        private TabPage Menu;
        private Button GoBack2;
        private Button GoBack1;
        private TextBox WelcomeMessage;
        private TabPage Game;
        private SplitContainer splitContainer1;
        private Button SendMessage;
        private TextBox TitleBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Game1;
        private RichTextBox richTextBox1;
        private RichTextBox Chat;
        private TextBox MessageBox;
        private Button logout;
        private Button Quit;
        private Button gotoMenu;
        private TabControl tabControl2;
        private TabPage ChatPage;
        private TabPage tabPage2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Button AwayScorePoint;
        private Button HomeaddPoint;
    }
}