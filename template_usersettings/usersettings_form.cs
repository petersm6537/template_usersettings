namespace template_usersettings
{
    public partial class usersettings_form : Form
    {
        public usersettings_form()
        {
            InitializeComponent();
            string defaultfilepath = Properties.Settings.Default.defaultfilepath;
            string userfilepath = Properties.Settings.Default.userfilepath;
            if (string.IsNullOrEmpty(userfilepath))
            {
                userfilepath = defaultfilepath;
            }

            filepathInput.Text = defaultfilepath;

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void browseInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.defaultfilepath;
            openFileDialog1.ShowDialog();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}