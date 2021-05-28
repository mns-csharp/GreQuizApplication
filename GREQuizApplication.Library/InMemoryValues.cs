using QuizApplicationLibrary.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public static class InMemoryValues
    {
        private static ApplicationData _appData = null;
        public static int CorrectnessRepetition { get; set; }
        public static int MultipleChoiceCount { get; set; }
        static InMemoryValues()
        {
            _appData = ApplicationDataBLLL.Get();
            if (_appData == null)
            {
                _appData = new ApplicationData();
            }
        }
        
        public static ApplicationData ApplicationData
        {
            set 
            {
                _appData = value;
            }
            get 
            {
                
                return _appData;
            }
        }

        public static void Save()
        {
            ApplicationDataBLLL.Save(_appData);
        }
    }
}
