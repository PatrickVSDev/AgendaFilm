namespace AgendaFilm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                var loginPage = new PaginaLogin();
                var loginResult = loginPage.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    Application.Run(new MenuPage());
                }
                else
                {
                    break;
                }
            }
        }
    }
}
