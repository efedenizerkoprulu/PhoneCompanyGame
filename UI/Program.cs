using UI.Forms.Eng;
using UI.Forms.TR;

namespace UI
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
            if (UI.Properties.Settings.Default.lang=="English")
            {
                Application.Run(new frmLoginENG());
            }
            else
                Application.Run(new frmLoginScreenTR());

            // böyle
        }
    }
}