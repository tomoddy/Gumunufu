using Gumunufu.Helpers;

namespace Gumunufu
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Home()
        {
            InitializeComponent();
            DataReader reader = new("Database.csv");
            reader.GetTransactions();
        }
    }
}