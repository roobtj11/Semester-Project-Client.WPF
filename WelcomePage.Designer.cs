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
            this.SignIntextBox = new System.Windows.Forms.TextBox();
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
            this.RefreshGames = new System.Windows.Forms.Button();
            this.CreateNewGameButton = new System.Windows.Forms.Button();
            this.GameSearchTB = new System.Windows.Forms.TextBox();
            this.GameIDs = new System.Windows.Forms.ListBox();
            this.OpenGameButton = new System.Windows.Forms.Button();
            this.WelcomeMessage = new System.Windows.Forms.TextBox();
            this.Game = new System.Windows.Forms.TabPage();
            this.logout = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.gotoMenu = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CurrentSetBox = new System.Windows.Forms.TextBox();
            this.Team2_Title = new System.Windows.Forms.RichTextBox();
            this.Team1_Title = new System.Windows.Forms.RichTextBox();
            this.Team2_CurrentSetScore = new System.Windows.Forms.RichTextBox();
            this.Team1_CurrentSetScore = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.ChatPage = new System.Windows.Forms.TabPage();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GameEditErrorBox = new System.Windows.Forms.TextBox();
            this.Team2_RemovePoint = new System.Windows.Forms.Button();
            this.Team1_RemovePoint = new System.Windows.Forms.Button();
            this.EndSet = new System.Windows.Forms.Button();
            this.AwayScorePoint = new System.Windows.Forms.Button();
            this.Team1_addPoint = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.TextBox();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.AreYouSureBox = new System.Windows.Forms.Panel();
            this.CloseServerPassword = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CloseServerYes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AreYouSureText = new System.Windows.Forms.TextBox();
            this.CloseServerButton = new System.Windows.Forms.Button();
            this.ExportGames = new System.Windows.Forms.Button();
            this.CreateGameText = new System.Windows.Forms.TextBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.T2NameTB = new System.Windows.Forms.TextBox();
            this.T1NameTB = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.NewUserTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ChatPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.AreYouSureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new System.Drawing.Point(106, 51);
            textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(110, 23);
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
            this.tabControl1.Controls.Add(this.AdminPage);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 559);
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
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(1062, 550);
            this.WelcomeTab.TabIndex = 0;
            this.WelcomeTab.Text = "tabPage1";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(970, 8);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(82, 22);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Enabled = false;
            this.NewUserButton.Location = new System.Drawing.Point(670, 281);
            this.NewUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(82, 37);
            this.NewUserButton.TabIndex = 4;
            this.NewUserButton.Text = "Create New User";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Visible = false;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(336, 281);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(82, 37);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Visible = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(503, 281);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(82, 37);
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
            this.WelcomeText.Location = new System.Drawing.Point(336, 167);
            this.WelcomeText.Multiline = true;
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.ReadOnly = true;
            this.WelcomeText.Size = new System.Drawing.Size(416, 93);
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
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(1062, 550);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "tabPage1";
            // 
            // GoBack1
            // 
            this.GoBack1.Location = new System.Drawing.Point(976, 10);
            this.GoBack1.Name = "GoBack1";
            this.GoBack1.Size = new System.Drawing.Size(75, 23);
            this.GoBack1.TabIndex = 1;
            this.GoBack1.Text = "GoBack";
            this.GoBack1.UseVisualStyleBackColor = true;
            this.GoBack1.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoginPanel.Controls.Add(this.SignIntextBox);
            this.LoginPanel.Controls.Add(this.textBox3);
            this.LoginPanel.Controls.Add(this.loginUsername);
            this.LoginPanel.Controls.Add(this.loginPassword);
            this.LoginPanel.Controls.Add(this.Signin);
            this.LoginPanel.Location = new System.Drawing.Point(377, 92);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(315, 260);
            this.LoginPanel.TabIndex = 0;
            // 
            // SignIntextBox
            // 
            this.SignIntextBox.Location = new System.Drawing.Point(42, 79);
            this.SignIntextBox.Name = "SignIntextBox";
            this.SignIntextBox.ReadOnly = true;
            this.SignIntextBox.Size = new System.Drawing.Size(243, 23);
            this.SignIntextBox.TabIndex = 4;
            this.SignIntextBox.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(106, 39);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 16);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Login";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(95, 136);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.PlaceholderText = "Enter Username Here";
            this.loginUsername.Size = new System.Drawing.Size(131, 23);
            this.loginUsername.TabIndex = 0;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(95, 170);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.PlaceholderText = "Enter Password Here";
            this.loginPassword.Size = new System.Drawing.Size(131, 23);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(118, 209);
            this.Signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(82, 22);
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
            this.NewUserTab.Name = "NewUserTab";
            this.NewUserTab.Size = new System.Drawing.Size(1062, 550);
            this.NewUserTab.TabIndex = 2;
            this.NewUserTab.Text = "tabPage1";
            // 
            // GoBack2
            // 
            this.GoBack2.Location = new System.Drawing.Point(976, 10);
            this.GoBack2.Name = "GoBack2";
            this.GoBack2.Size = new System.Drawing.Size(75, 23);
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
            this.panel1.Location = new System.Drawing.Point(351, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 260);
            this.panel1.TabIndex = 1;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.SystemColors.Info;
            this.ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(48, 76);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ErrorMessage.Multiline = true;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(223, 48);
            this.ErrorMessage.TabIndex = 5;
            // 
            // CreateNewUserConfirmPassword
            // 
            this.CreateNewUserConfirmPassword.Location = new System.Drawing.Point(82, 178);
            this.CreateNewUserConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewUserConfirmPassword.Name = "CreateNewUserConfirmPassword";
            this.CreateNewUserConfirmPassword.PasswordChar = '*';
            this.CreateNewUserConfirmPassword.PlaceholderText = "Confirm Password Here";
            this.CreateNewUserConfirmPassword.Size = new System.Drawing.Size(157, 23);
            this.CreateNewUserConfirmPassword.TabIndex = 2;
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.Location = new System.Drawing.Point(118, 209);
            this.CreateNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(82, 22);
            this.CreateNewUser.TabIndex = 3;
            this.CreateNewUser.Text = "Create User";
            this.CreateNewUser.UseVisualStyleBackColor = true;
            this.CreateNewUser.Click += new System.EventHandler(this.CreateUserButton);
            // 
            // CreateNewUserPassword
            // 
            this.CreateNewUserPassword.Location = new System.Drawing.Point(82, 153);
            this.CreateNewUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewUserPassword.Name = "CreateNewUserPassword";
            this.CreateNewUserPassword.PasswordChar = '*';
            this.CreateNewUserPassword.PlaceholderText = "Enter Password Here";
            this.CreateNewUserPassword.Size = new System.Drawing.Size(157, 23);
            this.CreateNewUserPassword.TabIndex = 1;
            // 
            // CreateNewUserUsername
            // 
            this.CreateNewUserUsername.Location = new System.Drawing.Point(82, 128);
            this.CreateNewUserUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewUserUsername.Name = "CreateNewUserUsername";
            this.CreateNewUserUsername.PlaceholderText = "Enter Username Here";
            this.CreateNewUserUsername.Size = new System.Drawing.Size(157, 23);
            this.CreateNewUserUsername.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.AllowDrop = true;
            this.Menu.Controls.Add(this.RefreshGames);
            this.Menu.Controls.Add(this.CreateNewGameButton);
            this.Menu.Controls.Add(this.GameSearchTB);
            this.Menu.Controls.Add(this.GameIDs);
            this.Menu.Controls.Add(this.OpenGameButton);
            this.Menu.Controls.Add(this.WelcomeMessage);
            this.Menu.Location = new System.Drawing.Point(4, 5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1062, 550);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // RefreshGames
            // 
            this.RefreshGames.Location = new System.Drawing.Point(830, 29);
            this.RefreshGames.Name = "RefreshGames";
            this.RefreshGames.Size = new System.Drawing.Size(75, 23);
            this.RefreshGames.TabIndex = 5;
            this.RefreshGames.Text = "Refresh Games";
            this.RefreshGames.UseVisualStyleBackColor = true;
            this.RefreshGames.Click += new System.EventHandler(this.RefreshGames_Click);
            // 
            // CreateNewGameButton
            // 
            this.CreateNewGameButton.Location = new System.Drawing.Point(911, 29);
            this.CreateNewGameButton.Name = "CreateNewGameButton";
            this.CreateNewGameButton.Size = new System.Drawing.Size(140, 23);
            this.CreateNewGameButton.TabIndex = 4;
            this.CreateNewGameButton.Text = "Admin Page";
            this.CreateNewGameButton.UseVisualStyleBackColor = true;
            this.CreateNewGameButton.Click += new System.EventHandler(this.CreateNewGameButton_Click);
            // 
            // GameSearchTB
            // 
            this.GameSearchTB.Location = new System.Drawing.Point(82, 152);
            this.GameSearchTB.Name = "GameSearchTB";
            this.GameSearchTB.PlaceholderText = "Enter GameID to open here";
            this.GameSearchTB.Size = new System.Drawing.Size(188, 23);
            this.GameSearchTB.TabIndex = 3;
            this.GameSearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_Enter);
            // 
            // GameIDs
            // 
            this.GameIDs.FormattingEnabled = true;
            this.GameIDs.ItemHeight = 15;
            this.GameIDs.Location = new System.Drawing.Point(82, 214);
            this.GameIDs.Name = "GameIDs";
            this.GameIDs.Size = new System.Drawing.Size(847, 259);
            this.GameIDs.TabIndex = 2;
            // 
            // OpenGameButton
            // 
            this.OpenGameButton.Location = new System.Drawing.Point(320, 90);
            this.OpenGameButton.Name = "OpenGameButton";
            this.OpenGameButton.Size = new System.Drawing.Size(179, 85);
            this.OpenGameButton.TabIndex = 4;
            this.OpenGameButton.Text = "Open Game";
            this.OpenGameButton.UseVisualStyleBackColor = true;
            this.OpenGameButton.Click += new System.EventHandler(this.OpenGameButtonClick);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeMessage.Location = new System.Drawing.Point(0, 0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(1062, 23);
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
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(1062, 550);
            this.Game.TabIndex = 4;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(906, 8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(987, 8);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // gotoMenu
            // 
            this.gotoMenu.Location = new System.Drawing.Point(825, 8);
            this.gotoMenu.Name = "gotoMenu";
            this.gotoMenu.Size = new System.Drawing.Size(75, 23);
            this.gotoMenu.TabIndex = 4;
            this.gotoMenu.Text = "Menu";
            this.gotoMenu.UseVisualStyleBackColor = true;
            this.gotoMenu.Click += new System.EventHandler(this.gotoMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CurrentSetBox);
            this.splitContainer1.Panel1.Controls.Add(this.Team2_Title);
            this.splitContainer1.Panel1.Controls.Add(this.Team1_Title);
            this.splitContainer1.Panel1.Controls.Add(this.Team2_CurrentSetScore);
            this.splitContainer1.Panel1.Controls.Add(this.Team1_CurrentSetScore);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 513);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.TabIndex = 3;
            // 
            // CurrentSetBox
            // 
            this.CurrentSetBox.Font = new System.Drawing.Font("Vivaldi", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CurrentSetBox.Location = new System.Drawing.Point(242, 189);
            this.CurrentSetBox.Name = "CurrentSetBox";
            this.CurrentSetBox.ReadOnly = true;
            this.CurrentSetBox.Size = new System.Drawing.Size(177, 47);
            this.CurrentSetBox.TabIndex = 7;
            this.CurrentSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Team2_Title
            // 
            this.Team2_Title.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Team2_Title.Location = new System.Drawing.Point(416, 108);
            this.Team2_Title.Name = "Team2_Title";
            this.Team2_Title.ReadOnly = true;
            this.Team2_Title.Size = new System.Drawing.Size(205, 48);
            this.Team2_Title.TabIndex = 6;
            this.Team2_Title.Text = "";
            // 
            // Team1_Title
            // 
            this.Team1_Title.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Team1_Title.Location = new System.Drawing.Point(23, 108);
            this.Team1_Title.Name = "Team1_Title";
            this.Team1_Title.ReadOnly = true;
            this.Team1_Title.Size = new System.Drawing.Size(222, 48);
            this.Team1_Title.TabIndex = 5;
            this.Team1_Title.Text = "";
            // 
            // Team2_CurrentSetScore
            // 
            this.Team2_CurrentSetScore.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Team2_CurrentSetScore.Location = new System.Drawing.Point(471, 167);
            this.Team2_CurrentSetScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team2_CurrentSetScore.Name = "Team2_CurrentSetScore";
            this.Team2_CurrentSetScore.ReadOnly = true;
            this.Team2_CurrentSetScore.Size = new System.Drawing.Size(110, 91);
            this.Team2_CurrentSetScore.TabIndex = 1;
            this.Team2_CurrentSetScore.Text = "24";
            // 
            // Team1_CurrentSetScore
            // 
            this.Team1_CurrentSetScore.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Team1_CurrentSetScore.Location = new System.Drawing.Point(73, 167);
            this.Team1_CurrentSetScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team1_CurrentSetScore.Name = "Team1_CurrentSetScore";
            this.Team1_CurrentSetScore.ReadOnly = true;
            this.Team1_CurrentSetScore.Size = new System.Drawing.Size(110, 91);
            this.Team1_CurrentSetScore.TabIndex = 0;
            this.Team1_CurrentSetScore.Text = "15";
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.ChatPage);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(3, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(420, 517);
            this.tabControl2.TabIndex = 5;
            // 
            // ChatPage
            // 
            this.ChatPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ChatPage.Controls.Add(this.ChatBox);
            this.ChatPage.Controls.Add(this.SendMessage);
            this.ChatPage.Controls.Add(this.MessageBox);
            this.ChatPage.Location = new System.Drawing.Point(4, 27);
            this.ChatPage.Name = "ChatPage";
            this.ChatPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChatPage.Size = new System.Drawing.Size(412, 486);
            this.ChatPage.TabIndex = 0;
            this.ChatPage.Text = "Chat";
            this.ChatPage.UseVisualStyleBackColor = true;
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.ItemHeight = 15;
            this.ChatBox.Location = new System.Drawing.Point(0, 0);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(412, 439);
            this.ChatBox.TabIndex = 8;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(342, 441);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(72, 42);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(6, 458);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.PlaceholderText = "Type Message Here";
            this.MessageBox.Size = new System.Drawing.Size(334, 23);
            this.MessageBox.TabIndex = 3;
            this.MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage2.Controls.Add(this.GameEditErrorBox);
            this.tabPage2.Controls.Add(this.Team2_RemovePoint);
            this.tabPage2.Controls.Add(this.Team1_RemovePoint);
            this.tabPage2.Controls.Add(this.EndSet);
            this.tabPage2.Controls.Add(this.AwayScorePoint);
            this.tabPage2.Controls.Add(this.Team1_addPoint);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GameEditErrorBox
            // 
            this.GameEditErrorBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameEditErrorBox.ForeColor = System.Drawing.Color.Red;
            this.GameEditErrorBox.Location = new System.Drawing.Point(41, 270);
            this.GameEditErrorBox.Multiline = true;
            this.GameEditErrorBox.Name = "GameEditErrorBox";
            this.GameEditErrorBox.ReadOnly = true;
            this.GameEditErrorBox.Size = new System.Drawing.Size(328, 207);
            this.GameEditErrorBox.TabIndex = 5;
            this.GameEditErrorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Team2_RemovePoint
            // 
            this.Team2_RemovePoint.Location = new System.Drawing.Point(206, 184);
            this.Team2_RemovePoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team2_RemovePoint.Name = "Team2_RemovePoint";
            this.Team2_RemovePoint.Size = new System.Drawing.Size(82, 47);
            this.Team2_RemovePoint.TabIndex = 4;
            this.Team2_RemovePoint.Text = "Away Point -1";
            this.Team2_RemovePoint.UseVisualStyleBackColor = true;
            this.Team2_RemovePoint.Click += new System.EventHandler(this.Team2_RemovePoint_Click);
            // 
            // Team1_RemovePoint
            // 
            this.Team1_RemovePoint.Location = new System.Drawing.Point(84, 184);
            this.Team1_RemovePoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team1_RemovePoint.Name = "Team1_RemovePoint";
            this.Team1_RemovePoint.Size = new System.Drawing.Size(88, 47);
            this.Team1_RemovePoint.TabIndex = 3;
            this.Team1_RemovePoint.Text = "Home Point -1";
            this.Team1_RemovePoint.UseVisualStyleBackColor = true;
            this.Team1_RemovePoint.Click += new System.EventHandler(this.Team1_RemovePoint_Click);
            // 
            // EndSet
            // 
            this.EndSet.Location = new System.Drawing.Point(146, 82);
            this.EndSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndSet.Name = "EndSet";
            this.EndSet.Size = new System.Drawing.Size(88, 47);
            this.EndSet.TabIndex = 2;
            this.EndSet.Text = "End Set";
            this.EndSet.UseVisualStyleBackColor = true;
            this.EndSet.Click += new System.EventHandler(this.EndSet_Click);
            // 
            // AwayScorePoint
            // 
            this.AwayScorePoint.Location = new System.Drawing.Point(206, 133);
            this.AwayScorePoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AwayScorePoint.Name = "AwayScorePoint";
            this.AwayScorePoint.Size = new System.Drawing.Size(82, 47);
            this.AwayScorePoint.TabIndex = 1;
            this.AwayScorePoint.Text = "Away Point +1";
            this.AwayScorePoint.UseVisualStyleBackColor = true;
            this.AwayScorePoint.Click += new System.EventHandler(this.AwayScorePoint_Click);
            // 
            // Team1_addPoint
            // 
            this.Team1_addPoint.Location = new System.Drawing.Point(84, 133);
            this.Team1_addPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team1_addPoint.Name = "Team1_addPoint";
            this.Team1_addPoint.Size = new System.Drawing.Size(88, 47);
            this.Team1_addPoint.TabIndex = 0;
            this.Team1_addPoint.Text = "Home Point +1";
            this.Team1_addPoint.UseVisualStyleBackColor = true;
            this.Team1_addPoint.Click += new System.EventHandler(this.Team1_addPoint_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TitleBar.CausesValidation = false;
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.PlaceholderText = "Team 1 V.S. Team 2";
            this.TitleBar.ReadOnly = true;
            this.TitleBar.Size = new System.Drawing.Size(1062, 37);
            this.TitleBar.TabIndex = 50;
            this.TitleBar.TabStop = false;
            this.TitleBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.AreYouSureBox);
            this.AdminPage.Controls.Add(this.CloseServerButton);
            this.AdminPage.Controls.Add(this.ExportGames);
            this.AdminPage.Controls.Add(this.CreateGameText);
            this.AdminPage.Controls.Add(this.MenuButton);
            this.AdminPage.Controls.Add(this.CreateGameButton);
            this.AdminPage.Controls.Add(this.T2NameTB);
            this.AdminPage.Controls.Add(this.T1NameTB);
            this.AdminPage.Location = new System.Drawing.Point(4, 5);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Size = new System.Drawing.Size(1062, 550);
            this.AdminPage.TabIndex = 5;
            this.AdminPage.Text = "tabPage1";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // AreYouSureBox
            // 
            this.AreYouSureBox.BackColor = System.Drawing.Color.Black;
            this.AreYouSureBox.Controls.Add(this.CloseServerPassword);
            this.AreYouSureBox.Controls.Add(this.button3);
            this.AreYouSureBox.Controls.Add(this.CloseServerYes);
            this.AreYouSureBox.Controls.Add(this.textBox1);
            this.AreYouSureBox.Controls.Add(this.AreYouSureText);
            this.AreYouSureBox.Enabled = false;
            this.AreYouSureBox.Location = new System.Drawing.Point(352, 174);
            this.AreYouSureBox.Name = "AreYouSureBox";
            this.AreYouSureBox.Size = new System.Drawing.Size(331, 195);
            this.AreYouSureBox.TabIndex = 9;
            this.AreYouSureBox.Visible = false;
            // 
            // CloseServerPassword
            // 
            this.CloseServerPassword.Location = new System.Drawing.Point(95, 156);
            this.CloseServerPassword.Name = "CloseServerPassword";
            this.CloseServerPassword.PlaceholderText = "Enter Password Here";
            this.CloseServerPassword.Size = new System.Drawing.Size(138, 23);
            this.CloseServerPassword.TabIndex = 4;
            this.CloseServerPassword.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "NO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CloseServerYes
            // 
            this.CloseServerYes.Location = new System.Drawing.Point(14, 156);
            this.CloseServerYes.Name = "CloseServerYes";
            this.CloseServerYes.Size = new System.Drawing.Size(75, 23);
            this.CloseServerYes.TabIndex = 2;
            this.CloseServerYes.Text = "YES";
            this.CloseServerYes.UseVisualStyleBackColor = true;
            this.CloseServerYes.Click += new System.EventHandler(this.CloseServerYes_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(64, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(213, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter your password and select yes if you want to close the server!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AreYouSureText
            // 
            this.AreYouSureText.BackColor = System.Drawing.Color.Black;
            this.AreYouSureText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AreYouSureText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AreYouSureText.ForeColor = System.Drawing.Color.LimeGreen;
            this.AreYouSureText.Location = new System.Drawing.Point(64, 27);
            this.AreYouSureText.Multiline = true;
            this.AreYouSureText.Name = "AreYouSureText";
            this.AreYouSureText.ReadOnly = true;
            this.AreYouSureText.Size = new System.Drawing.Size(213, 42);
            this.AreYouSureText.TabIndex = 0;
            this.AreYouSureText.Text = "ARE YOU SURE YOU WANT TO CLOSE THE SERVER";
            this.AreYouSureText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseServerButton
            // 
            this.CloseServerButton.BackColor = System.Drawing.Color.Red;
            this.CloseServerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseServerButton.ForeColor = System.Drawing.Color.White;
            this.CloseServerButton.Location = new System.Drawing.Point(456, 492);
            this.CloseServerButton.Name = "CloseServerButton";
            this.CloseServerButton.Size = new System.Drawing.Size(115, 49);
            this.CloseServerButton.TabIndex = 8;
            this.CloseServerButton.Text = "Close Server";
            this.CloseServerButton.UseVisualStyleBackColor = false;
            this.CloseServerButton.Click += new System.EventHandler(this.CloseServerButton_Click);
            // 
            // ExportGames
            // 
            this.ExportGames.Location = new System.Drawing.Point(8, 10);
            this.ExportGames.Name = "ExportGames";
            this.ExportGames.Size = new System.Drawing.Size(107, 23);
            this.ExportGames.TabIndex = 7;
            this.ExportGames.Text = "ExportGames";
            this.ExportGames.UseVisualStyleBackColor = true;
            this.ExportGames.Click += new System.EventHandler(this.ExportGames_Click);
            // 
            // CreateGameText
            // 
            this.CreateGameText.Location = new System.Drawing.Point(366, 310);
            this.CreateGameText.Name = "CreateGameText";
            this.CreateGameText.ReadOnly = true;
            this.CreateGameText.Size = new System.Drawing.Size(300, 23);
            this.CreateGameText.TabIndex = 6;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(956, 10);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.gotoMenu_Click);
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.Location = new System.Drawing.Point(456, 201);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(115, 42);
            this.CreateGameButton.TabIndex = 2;
            this.CreateGameButton.Text = "Create Game";
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // T2NameTB
            // 
            this.T2NameTB.Location = new System.Drawing.Point(541, 264);
            this.T2NameTB.Name = "T2NameTB";
            this.T2NameTB.PlaceholderText = "Team 2\'s Name";
            this.T2NameTB.Size = new System.Drawing.Size(125, 23);
            this.T2NameTB.TabIndex = 1;
            // 
            // T1NameTB
            // 
            this.T1NameTB.Location = new System.Drawing.Point(366, 264);
            this.T1NameTB.Name = "T1NameTB";
            this.T1NameTB.PlaceholderText = "Team 1\'s Name";
            this.T1NameTB.Size = new System.Drawing.Size(125, 23);
            this.T1NameTB.TabIndex = 0;
            // 
            // WelcomePage
            // 
            this.AccessibleName = "WelcomePage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 555);
            this.Controls.Add(this.tabControl1);
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
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ChatPage.ResumeLayout(false);
            this.ChatPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.AdminPage.ResumeLayout(false);
            this.AdminPage.PerformLayout();
            this.AreYouSureBox.ResumeLayout(false);
            this.AreYouSureBox.PerformLayout();
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
        private TextBox MessageBox;
        private Button logout;
        private Button Quit;
        private Button gotoMenu;
        private TabControl tabControl2;
        private TabPage ChatPage;
        private TabPage tabPage2;
        private RichTextBox Team2_CurrentSetScore;
        private RichTextBox Team1_CurrentSetScore;
        private Button AwayScorePoint;
        private Button Team1_addPoint;
        private ListBox GameIDs;
        private Button OpenGameButton;
        private TextBox SignIntextBox;
        private TextBox GameSearchTB;
        private TextBox CurrentSetBox;
        private RichTextBox Team2_Title;
        private RichTextBox Team1_Title;
        private Button EndSet;
        private Button Team2_RemovePoint;
        private Button Team1_RemovePoint;
        private TextBox GameEditErrorBox;
        private Button CreateNewGameButton;
        private TabPage AdminPage;
        private Button CreateGameButton;
        private TextBox T2NameTB;
        private TextBox T1NameTB;
        private Button MenuButton;
        private TextBox CreateGameText;
        private Button ExportGames;
        private Button RefreshGames;
        private ListBox ChatBox;
        private Panel AreYouSureBox;
        private TextBox textBox1;
        private TextBox AreYouSureText;
        private Button CloseServerButton;
        private TextBox CloseServerPassword;
        private Button button3;
        private Button CloseServerYes;
    }
}