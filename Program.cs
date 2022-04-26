namespace Semester_Project_Client.WPF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Network.welcomepage = new WelcomePage();
            Application.Run(Network.welcomepage);
        }
        
    }
}