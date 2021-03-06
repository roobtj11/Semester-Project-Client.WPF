using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semester_Project_Client.WPF
{
    public partial class WelcomePage : Form
    {

        static Dictionary<int, Games> GameList = new Dictionary<int, Games>();
        public List<string> messages = new List<string>();
        static int GameOpen;

        string username = string.Empty;
        int accLv;
        public WelcomePage()
        {
            InitializeComponent();

        }
        internal void connect()
        {

        Connect:

            try
            {
                while (Network.Connect() == false) ;
            }
            catch
            {
                goto Connect;
            }
            WelcomeText.Text = "WELCOME TO THE SCOREKEEPER!";
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = false;
            if (!Network.Connect())
            {
                WelcomeText.Text = "Connection Failed Try Again";
                Connect.Enabled = true;
            }
            else
            {
                WelcomeText.Text = "WELCOME TO THE SCOREKEEPER!";
                Connect.Visible = false;
                LoginButton.Visible = true;
                LoginButton.Enabled = true;
                NewUserButton.Enabled = true;
                NewUserButton.Visible = true;
            }

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Network.Close_Connection();
            }
            catch { }
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Network.SendMessage("L");
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            Network.SendMessage("C");
        }


        private void CreateUserButton(object sender, EventArgs e)
        {
            CreateNewUser.Enabled = false;
            string username = CreateNewUserUsername.Text;
            string Password = gethash(CreateNewUserPassword.Text);
            bool invalid = false;
            ErrorMessage.Text = "";
            if (username.Length <= 3 || username.Length > 12)
            {
                ErrorMessage.Text = "*Username must be 3 or more characters and less than 12\n";
                invalid = true;
            }
            if (username.Contains(','))
            {
                ErrorMessage.Text = ErrorMessage.Text + "* Usernames Cannot Contain Commas\n";
                invalid = true;
            }
            if (CreateNewUserPassword.Text.Length < 5 || CreateNewUserPassword.Text.Length > 20)
            {
                ErrorMessage.Text = ErrorMessage.Text + "*Passwords must be between 6 and 19 characters\n";
                invalid = true;
            }
            if (!CreateNewUserPassword.Text.Contains('1') && !CreateNewUserPassword.Text.Contains('2') && !CreateNewUserPassword.Text.Contains('3') && !CreateNewUserPassword.Text.Contains('4') && !CreateNewUserPassword.Text.Contains('5') && !CreateNewUserPassword.Text.Contains('6') && !CreateNewUserPassword.Text.Contains('7') && !CreateNewUserPassword.Text.Contains('8') && !CreateNewUserPassword.Text.Contains('9') && !CreateNewUserPassword.Text.Contains('0'))
            {
                ErrorMessage.Text = ErrorMessage.Text + "*Passwords must contain a number\n";
                invalid = true;
            }
            if (!CreateNewUserPassword.Text.Contains('!') && !CreateNewUserPassword.Text.Contains('@') && !CreateNewUserPassword.Text.Contains('#') && !CreateNewUserPassword.Text.Contains('$') && !CreateNewUserPassword.Text.Contains('%') && !CreateNewUserPassword.Text.Contains('^') && !CreateNewUserPassword.Text.Contains('&') && !CreateNewUserPassword.Text.Contains('*') && !CreateNewUserPassword.Text.Contains('=') && !CreateNewUserPassword.Text.Contains('+'))
            {
                ErrorMessage.Text = ErrorMessage.Text + "*Passwords must contain a symbol\n";
                invalid = true;
            }
            if (Password != gethash(CreateNewUserConfirmPassword.Text))
            {
                ErrorMessage.Text = ErrorMessage.Text + "* Passwords do not match\n";
                invalid = true;
            }
            if (invalid)
            {
                CreateNewUser.Enabled = true;
                return;
            }
            Network.SendMessage(username);
            string response = Network.RecieveMessage();
            if (response == "E:1")
            {
                ErrorMessage.Text = "* Username is Already used please try another quit\n";
                CreateNewUser.Enabled = true;
                return;
            }
            else
            {
                Network.SendMessage(Password);
                CreateNewUserUsername.Text = "";
                CreateNewUserPassword.Text = "";
                CreateNewUserConfirmPassword.Text = "";
                LoggedIn(1, username);
            }


        }
        static string gethash(string text)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] bytes = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void GoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            Network.SendMessage("quit");
            CreateNewUserUsername.Text = "";
            CreateNewUserPassword.Text = "";
            CreateNewUserConfirmPassword.Text = "";
            loginPassword.Text = "";
            loginUsername.Text = "";
            Signin.Enabled = true;
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            Signin.Enabled = false;
            string username = loginUsername.Text;
            string Password = gethash(loginPassword.Text);
            string combo = username + ',' + Password;
            Network.SendMessage(combo);
            string allowORdeny = Network.RecieveMessage();
            string[] parts = allowORdeny.Split(',');
            if (parts[0] == "Approved")
            {
                tabControl1.SelectedIndex = 3;
                loginPassword.Text = "";
                loginUsername.Text = "";
                LoggedIn(int.Parse(parts[1]), username);
            }
            else
            {
                Signin.Enabled = true;
                loginPassword.Text = "";
                loginUsername.Text = "";
                SignIntextBox.Text = "Signin Failed";
            }
        }

        private void LoggedIn(int accounttype, string username)
        {
            this.username = username;
            this.accLv = accounttype;

            OpenMenu();
            WelcomeMessage.Text = $"Welcome {this.username} you are a level {this.accLv} user.";

        }

        private void RecieveGames()
        {
            GameList.Clear();
            string message = Network.RecieveMessage();
            Stack<string> GameStrings = new Stack<string>();
            GameStrings = JsonSerializer.Deserialize<Stack<string>>(message);
            while (GameStrings.Count > 0)
            {
                Games a = JsonSerializer.Deserialize<Games>(GameStrings.Pop());
                GameList.Add(a.getID(), a);
            }
        }

        private void ShowGameList()
        {
            GameIDs.Items.Clear();
            var keys = GameList.Keys.ToList();
            foreach (var key in keys)
            {
                TextBox game1 = new TextBox();
                GameIDs.Items.Add(game1.Text = GameList[key].PrintReadable());
            }
        }

        public void Event1()
        {
            WelcomeMessage.Text = "wrong";
        }



        private void SendMessage_Click(object sender, EventArgs e)
        {
            //Chat.Text = Chat.Text + this.username + ": " + MessageBox.Text + "\n";
            //MessageBox.Text = string.Empty;

            GameList[GameOpen].messages.Add(this.username + ": " + MessageBox.Text);
            MessageBox.Clear();
            SendGameUpdate(GameOpen);
        }

        private void gotoMenu_Click(object sender, EventArgs e)
        {
            Network.SendMessage("Back");
            GameOpen = -1;
            OpenMenu();
        }

        private void OpenMenu()
        {
            RecieveGames();
            ShowGameList();
            tabControl1.SelectedIndex = 3;
            GameSearchTB.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4)
            {
                if (this.accLv == 1)
                {
                    //tabControl2.Enabled = false;
                    tabControl2.ItemSize = new Size(0, 1);
                    tabControl2.Location = new Point(0, -1);
                }
            }
        }


        private void MessageBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendMessage.PerformClick();
        }

        private void OpenGameButtonClick(object sender, EventArgs e)
        {
            var keys = GameList.Keys.ToList();
            try
            {
                int gameid = int.Parse(GameSearchTB.Text.ToString());
                if (keys.Contains(gameid))
                {
                    GameOpen = gameid;
                    Games game = GameList[gameid];

                    Network.SendMessage("OpenGame");
                    Network.SendMessage(gameid.ToString());
                    //RecieveGameUpdate(gameid);
                    tabControl1.SelectedIndex++;
                    TitleBar.Text = game.teams[0] + " V.S. " + game.teams[1];
                    Team1_addPoint.Enabled = true;
                    AwayScorePoint.Enabled = true;
                    Team1_RemovePoint.Enabled = true;
                    Team2_RemovePoint.Enabled = true;
                    EndSet.Enabled = true;
                    UpdateGameScreen(gameid);
                }
                else
                {
                    throw new Exception("DNE");
                }
            }
            catch
            {
                GameSearchTB.Text = "Game Does Not Exist";
            }
            
        }

        private void UpdateGameScreen(int GameID)
        {
            Games game = GameList[GameID];
            if (game.GameOver)
            {
                Action<string> DelegateEndScreen_ModifyText = EndScreen_Mod;
                Invoke(DelegateEndScreen_ModifyText, "Modify By Thread");
            }
            else
            {
                Action<string> DelegateUpdateScreen_ModifyText = Screen_Mod;
                Invoke(DelegateUpdateScreen_ModifyText, "Modify By Thread");

            }
        }

        private void EndScreen_Mod(string teste)
        {
            Games game = GameList[GameOpen];
            Team1_addPoint.Enabled = false;
            AwayScorePoint.Enabled = false;
            Team1_RemovePoint.Enabled = false;
            Team2_RemovePoint.Enabled = false;
            EndSet.Enabled = false;
            CurrentSetBox.Text = "Sets Won";
            Team1_CurrentSetScore.Text = game.t1SetsWon.ToString();
            Team2_CurrentSetScore.Text = game.t2SetsWon.ToString();
            ChatBox.Items.Clear();
            foreach (var msg in GameList[GameOpen].messages)
            {
                TextBox message = new TextBox();
                ChatBox.Items.Add(message.Text = msg);
            }
        }

        private void Screen_Mod(string teste)
        {
            Games game = GameList[GameOpen];
            CurrentSetBox.Text = "Set " + game.CurrentSet.ToString();
            Team1_Title.Text = game.teams[0];
            Team2_Title.Text = game.teams[1];
            Team1_CurrentSetScore.Text = game.t1Scores[game.CurrentSet - 1].ToString();
            Team2_CurrentSetScore.Text = game.t2Scores[game.CurrentSet - 1].ToString();
            ChatBox.Items.Clear();
            foreach (var msg in GameList[GameOpen].messages)
            {
                TextBox message = new TextBox();
                ChatBox.Items.Add(message.Text = msg);
            }
        }
        /*
                public delegate void UpdateGameScreenDelegate(Object source, EventArgs args);
                public event UpdateGameScreenDelegate UpdateGameScreen1;

                protected virtual void OnUpdateGameScreen1()
                {
                    if (UpdateGameScreen1 != null)
                        UpdateGameScreen1(this, EventArgs.Empty);
                }
        */
        public void RecieveGameUpdate(string message)
        {
            Games a = JsonSerializer.Deserialize<Games>(message);
            GameList[a.GameNum] = a;
            if (GameOpen == a.GameNum)
            {
                //OnUpdateGameScreen1();
                UpdateGameScreen(GameOpen);
            }
        }
        private void SendGameUpdate(int GameID)
        {
            Network.SendMessage("GameUpdate");
            string message = JsonSerializer.Serialize(GameList[GameID]);
            Network.SendMessage(message);
        }

        private void Team1_addPoint_Click(object sender, EventArgs e)
        {

            GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1] = GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1] + 1;
            Team1_CurrentSetScore.Text = GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1].ToString();
            SendGameUpdate(GameOpen);
        }

        private void Team1_RemovePoint_Click(object sender, EventArgs e)
        {
            GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1] = GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1] - 1;
            Team1_CurrentSetScore.Text = GameList[GameOpen].t1Scores[GameList[GameOpen].CurrentSet - 1].ToString();
            SendGameUpdate(GameOpen);
        }

        private void AwayScorePoint_Click(object sender, EventArgs e)
        {
            GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1] = GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1] + 1;
            Team2_CurrentSetScore.Text = GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1].ToString();
            SendGameUpdate(GameOpen);
        }

        private void Team2_RemovePoint_Click(object sender, EventArgs e)
        {
            GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1] = GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1] - 1;
            Team2_CurrentSetScore.Text = GameList[GameOpen].t2Scores[GameList[GameOpen].CurrentSet - 1].ToString();
            SendGameUpdate(GameOpen);
        }

        private void EndSet_Click(object sender, EventArgs e)
        {
            Games game = GameList[GameOpen];
            if (game.t1Scores[game.CurrentSet - 1] == game.t2Scores[game.CurrentSet - 1])
            {
                GameEditErrorBox.Text = "ERROR SET CANNOT END WHEN SCORE IS TIED";
            }
            else if (game.t1Scores[game.CurrentSet - 1] > game.t2Scores[game.CurrentSet - 1])
            {
                game.t1SetsWon++;
                if (game.t1SetsWon == 2)
                {
                    game.GameOver = true;
                    game.CurrentSet = 69;
                    game.Winner = game.teams[0];
                }
                else
                {
                    game.CurrentSet++;
                }
            }
            else
            {
                game.t2SetsWon++;
                if (game.t2SetsWon == 2)
                {
                    game.GameOver = true;
                    game.CurrentSet = 69;
                    game.Winner = game.teams[1];
                }
                else
                {
                    game.CurrentSet++;
                }
            }
            GameList[GameOpen] = game;
            SendGameUpdate(GameOpen);
            if (game.GameOver)
            {
                Team1_addPoint.Enabled = false;
                AwayScorePoint.Enabled = false;
                Team1_RemovePoint.Enabled = false;
                Team2_RemovePoint.Enabled = false;
                EndSet.Enabled = false;
            }
        }

        private void CreateNewGameButton_Click(object sender, EventArgs e)
        {
            if (accLv > 1)
            {
                Network.SendMessage("NewGame");
                tabControl1.SelectedIndex = 5;
                //Thread test = new Thread(new ThreadStart(() => listen()));
                //test.Start();
            }
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            string T1Name = T1NameTB.Text;
            string T2Name = T2NameTB.Text;

            string message = T1Name + ',' + T2Name;
            Network.SendMessage(message);
            CreateGameText.Text = Network.RecieveMessage();

        }

        private void ExportGames_Click(object sender, EventArgs e)
        {
            Network.SendMessage("SaveGames");
            if (Network.RecieveMessage() == "Games Saved")
            {
                CreateGameText.Text = "All Games Have Been Saved";
            }
        }

        private void RefreshGames_Click(object sender, EventArgs e)
        {
            ShowGameList();
        }

        private void SearchBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OpenGameButton.PerformClick();
        }

        private void CloseServerButton_Click(object sender, EventArgs e)
        {
            AreYouSureBox.Enabled = true;
            AreYouSureBox.Visible = true;
            MenuButton.Enabled = false;
            ExportGames.Enabled = false;
            CloseServerButton.Enabled = false;
            CloseServerButton.Visible = false;
            CreateGameButton.Enabled = false;
            Network.SendMessage("Close Server");
        }

        private void CloseServerYes_Click(object sender, EventArgs e)
        {
            string confirmPword = gethash(CloseServerPassword.Text);
            Network.SendMessage(confirmPword);
            string response = Network.RecieveMessage();
            if (response == "Failed")
            {
                AreYouSureBox.Enabled = false;
                AreYouSureBox.Visible = false;
                CloseServerButton.Enabled = true;
                CloseServerButton.Visible = true;
                MenuButton.Enabled = true;
                ExportGames.Enabled = true;
                CreateGameButton.Enabled = true;
                CreateGameText.Text = "Failed To Close Server, Insufficent permissions or Incorrect password.";
            }
            else
            {
                AreYouSureBox.Enabled = false;
                AreYouSureBox.Visible = false;
                CreateGameText.Text = response;
            }

        }

        public void ServerClosed()
        {
            Action<string> ServerClosed_ModifyScreen = CloseServer_Mod;
            Invoke(ServerClosed_ModifyScreen, "Modify By Thread");
        }

        private void CloseServer_Mod(string obj)
        {
            WelcomeText.Text = "Server Has Now Been Closed Try Again Later";
            LoginButton.Enabled = false;
            LoginButton.Visible = false;
            QuitButton.Visible = true;
            QuitButton.Enabled = true;
            NewUserButton.Enabled = false;
            NewUserButton.Visible = false;
            Connect.Enabled = false;
            Connect.Visible = false;
            tabControl1.SelectedIndex = 0;
        }

        public void Server_Close()
        {
            Action<string> DelegateServerClose = CloseServer_Mod;
            Invoke(DelegateServerClose, "Modify By Thread");

        }

        private void DelegateServerClose(string teste)
        {
            WelcomeText.Text = "Server Has Now Been Closed Try Again Later";
            LoginButton.Enabled = false;
            LoginButton.Visible = false;
            QuitButton.Visible = true;
            QuitButton.Enabled = true;
            NewUserButton.Enabled = false;
            NewUserButton.Visible = false;
            Connect.Enabled = false;
            Connect.Visible = false;
        }
    }
}