namespace template_usersettings
{
    /*public static class GlobalVariables
    {
        public static string defaultfilepath;
        public static string userfilepath;

    }*/
    public partial class usersettings_form : Form
    {
        public usersettings_form()
        {
            #region Comments
            /*1.Initializes main form
             * 2. Adds user selected filepath to textbox
             */
            #endregion Comments

            InitializeComponent();

            filepathInput.Text = Program.GlobalVariables.userfilepath;

        }




        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            #region Comments
            /* Open file dialog event hit Open Button
             * 1. Gets the selected file name
             * 2. Changes it to a directory name, and puts it into a string
             * 3. Changes the text in textbox to the correct file string
             */
            #endregion Comments

            System.IO.FileInfo finfo = new System.IO.FileInfo(openFileDialog1.FileName);
            string filepath = finfo.DirectoryName;
            filepathInput.Text = filepath;

        }





        public void browseInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }





        private void applyInput_Click(object sender, EventArgs e)
        {
            #region Comments
            /* Apply button event hit button
             * 1. Put the text in the textbox into a string
             * 2. changes the settings to the text in the string
             * 3. Saves the changes to settings
             */
            #endregion Comments

            string filepath = filepathInput.Text;

            if(MessageBox.Show("Are you sure?","Apply",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Properties.Settings.Default.userfilepath = filepath;
                Properties.Settings.Default.Save();
            }

        }

        private void defaultInput_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you'd like to reset your filepath?", "Reset", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Properties.Settings.Default.userfilepath = Properties.Settings.Default.defaultfilepath;
                Properties.Settings.Default.Save();
            }
        }
    }
}