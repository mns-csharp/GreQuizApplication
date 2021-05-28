using QuizApplicationLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace QuizApplication
{
    public static class Program
    {
        private static Mutex mutex = null;
        [STAThread]
        static void Main()
        {

            OleDbEnumerator enums = new OleDbEnumerator();

            DataTable tbl = enums.GetElements();

            List<Source> list = DataTableToSourceList.DataTableToList<Source>(tbl);

            try
            {
                InMemoryValues.CorrectnessRepetition = 15;
                InMemoryValues.MultipleChoiceCount = 6;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            const string appName = "GREQuizApplication";  
            bool createdNew;  
  
            mutex = new Mutex(true, appName, out createdNew);  
  
            if (!createdNew)  
            {  
               //app is already running! Exiting the application  
                MessageBox.Show("GREQuizApplication is already running!");

                return;  
            }

            Application.EnableVisualStyles();  
            Application.SetCompatibleTextRenderingDefault(false);  
            Application.Run(new CollectionForm());  
        }  
    }
}
