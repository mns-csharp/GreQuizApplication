using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary.POCO
{
    public class DataGridViewSnapshot
    {
        public string Word { get; set; }
        public int FirstRowIndex { get; set; }
        public int SelectedRowIndex { get; set; }

        public DataGridViewSnapshot()
        {
            Word = string.Empty;
            FirstRowIndex = 0;
            SelectedRowIndex = 0;
        }
    }
}
