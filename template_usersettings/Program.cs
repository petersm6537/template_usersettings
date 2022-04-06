namespace template_usersettings
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Comments
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // 1. Main program tree
            #endregion Comments

            ApplicationConfiguration.Initialize();
            establishVariables();
            Application.Run(new usersettings_form());

        }





        static public void establishVariables()
        {
            #region Comments
            /* 1. Establishes the values of our global variables
             * 2. Then checks to see if a user editable one has a value
             */
            #endregion Comments

            GlobalVariables.defaultfilepath = Properties.Settings.Default.defaultfilepath;
            GlobalVariables.userfilepath = Properties.Settings.Default.userfilepath;

            if (string.IsNullOrWhiteSpace(GlobalVariables.userfilepath))
            {
                GlobalVariables.userfilepath = GlobalVariables.defaultfilepath;
                Properties.Settings.Default.userfilepath = GlobalVariables.userfilepath;
                Properties.Settings.Default.Save();
            }

        }




        static public class GlobalVariables
        {
            #region Comments
            /*All of our global variables are stored here
             * 
             */
            #endregion Comments

            static public string defaultfilepath;
            static public string userfilepath;
        }
    }
}