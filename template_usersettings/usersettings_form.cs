namespace template_usersettings
{
    public static class GlobalVariables
    {
        public static string defaultfilepath;
        public static string userfilepath;

    }
    public partial class usersettings_form : Form
    {
        public usersettings_form()
        {
            InitializeComponent();

            GlobalVariables.defaultfilepath = Properties.Settings.Default.defaultfilepath;
            GlobalVariables.userfilepath = Properties.Settings.Default.userfilepath;
            if (string.IsNullOrEmpty(GlobalVariables.userfilepath))
            {
                GlobalVariables.userfilepath = GlobalVariables.defaultfilepath;
            }

            filepathInput.Text = GlobalVariables.defaultfilepath;

        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void browseInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = GlobalVariables.userfilepath;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.IO.Directory.GetFiles(openFileDialog1.FileName);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}