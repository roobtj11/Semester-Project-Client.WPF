
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

        private void textBox7_TextChanged(object sender, EventArgs e)
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
            Network.SendMessage(username);
            string response = Network.RecieveMessage();
            if (response.Contains("E:1"))
            {
                ErrorMessage.Text = "* Username is Already used please try another quit\n";
            }
            else if (response.Contains("E:2"))
            {
                ErrorMessage.Text = ErrorMessage.Text + "* Usernames Cannot Contain Commas\n";
            }
            else
            {
                if (Password != gethash(CreateNewUserConfirmPassword.Text))
                {
                    ErrorMessage.Text = ErrorMessage.Text + "* Passwords do not match\n";
                }
                Network.SendMessage(Password);
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
    }
}