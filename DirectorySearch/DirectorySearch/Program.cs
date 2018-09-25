using OwlFileSearch;
using System;
using System.IO;
using System.Windows.Forms;

namespace DirectorySearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String resultPath = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "EULA.txt");

            if(File.Exists(resultPath))
            {
                Application.Run(new DirectorySearchMain());
            }
            else
            {
                Application.Run(new Eula());
            }         
        }
    }
}
