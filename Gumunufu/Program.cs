using Gumunufu.Forms;
using Gumunufu.Globals;

namespace Gumunufu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resource.Message.UNKNOWN_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}