namespace WinFormsApp1
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
            mainForm mainForm = new mainForm();
			myCtrLib.mainForm = mainForm;
			
			mainForm.Resize += new System.EventHandler(mainForm.GetDragable);

			MySet.form = mainForm;
            Event events = new Event();
            events.mainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}