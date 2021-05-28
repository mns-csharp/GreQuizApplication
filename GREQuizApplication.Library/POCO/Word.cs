using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace QuizApplicationLibrary.POCO
{
    public class Word : BaseClass<Word>, IDisposable
    {
        public int? GroupNo { get; set; }
        public string Name { get; set; }
        public string Meaning { get; set; }
        public string Hint { get; set; }
        public string Synonyms { get; set; }
        public string Etymology { get; set; }        
        public string ExampleEnglishSentence { get; set; }
        public int CorrectnessCount { get; set; }
        public byte[] Photo { get; set; }

        #region IDisposable
        private bool disposed = false; // to detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //TODO: dispose managed resources here
                    
                }
                
                //TODO: dispose unmanaged resources here
                GroupNo = 0;
                Name = string.Empty;
                Meaning = string.Empty;
                Hint = string.Empty;
                Synonyms = string.Empty;
                Etymology = string.Empty;
                ExampleEnglishSentence = string.Empty;
                CorrectnessCount = 0;
                Photo = null; 
                //////////////////////////////////////////

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
