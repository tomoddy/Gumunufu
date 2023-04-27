using Gumunufu.Globals;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Account input form
    /// </summary>
    public partial class AccountInput : Form
    {
        /// <summary>
        /// Account name passback
        /// </summary>
        internal string AccountName { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccountInput()
        {
            InitializeComponent();
            AccountName = Config.DefaultAccount;
        }

        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void AccountInput_Load(object sender, EventArgs e)
        {
            AccountInputNameInput.Text = AccountName;
        }

        /// <summary>
        /// Submit click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void AccountInputSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AccountInputNameInput.Text))
            {
                AccountName = AccountInputNameInput.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}