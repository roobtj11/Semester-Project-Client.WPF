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
                Network.Connect();
            }
            catch
            {
                goto Connect;
            }
            WelcomeText.Text = "WELCOME TO THE SCOREKEEPER!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}