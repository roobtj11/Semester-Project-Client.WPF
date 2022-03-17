
using System.Security.Cryptography;
using System.Text;

namespace Semester_Project_Client.WPF
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        
        }
        internal void connect()
        {
        Connect:

            try
            {
                while (Network.Connect() == false);
            }
            catch
            {
                goto Connect;
            }
            WelcomeText.Text = "WELCOME TO THE SCOREKEEPER!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeTab_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Clicked(object sender, EventArgs e)
        {
        
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserButton(object sender, EventArgs e)
        {
            CreateNewUser.Enabled = false;
            string username = CreateNewUserUsername.Text;
            string Password = gethash(CreateNewUserPassword.Text);
            bool invalid = false;
            ErrorMessage.Text = "";
            if(username.Length <= 3 || username.Length >12)
            {
                ErrorMessage.Text = "*Username must be 3 or more characters and less than 12\n";
                invalid = true;
            }
            if (username.Contains(',')){
                ErrorMessage.Text = ErrorMessage.Text + "* Usernames Cannot Contain Commas\n";
                invalid = true;
            }
            if (CreateNewUserPassword.Text.Length < 5 || CreateNewUserPassword.Text.Length > 20)
            {
                ErrorMessage.Text = ErrorMessage.Text + "*Passwords must be between 6 and 19 characters\n";
                invalid = true;
            }
            if(!CreateNewUserPassword.Text.Contains('1') && !CreateNewUserPassword.Text.Contains('2') && !CreateNewUserPassword.Text.Contains('3') && !CreateNewUserPassword.Text.Contains('4') && !CreateNewUserPassword.Text.Contains('5') && !CreateNewUserPassword.Text.Contains('6') && !CreateNewUserPassword.Text.Contains('7') && !CreateNewUserPassword.Text.Contains('8') && !CreateNewUserPassword.Text.Contains('9') && !CreateNewUserPassword.Text.Contains('0'))
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
            if (response.Contains("E:1\r"))
            {
                ErrorMessage.Text = "* Username is Already used please try another quit\n";
                invalid = true;
            }
            if (invalid)
            {
                CreateNewUser.Enabled = true;
                return;
            }
            else
            {
                Network.SendMessage(Password);
                CreateNewUserUsername.Text = "";
                CreateNewUserPassword.Text = "";
                CreateNewUserConfirmPassword.Text = "";
                tabControl1.TabIndex = 3;
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

        private void CreateNewUserConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Quit1_Click(object sender, EventArgs e)
        {
            Network.SendMessage("quit");
            tabControl1.TabIndex = 1;
        }
    }
}