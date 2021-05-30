using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using QuizApplicationLibrary;
using QuizApplicationLibrary.BLL;
using QuizApplicationLibrary.POCO;
using Simple.Framework;
using Simple.Framework.Orm;

namespace QuizApplication
{
    public partial class YesNoDialogPanel : UserControl
    {
        public bool IsClicked { get; set; }
        public bool IsKnown { get; set; }
        public Word TheWord { get; set; }

        ///////////Event Mechanism///////////        
        protected internal event ItemStateChanged ItemStateChangeEvent;
        protected internal void OnItemStateChanged()
        {
            if (ItemStateChangeEvent != null)
            {
                ItemStateChangeEvent();
            }
        }
        ///////////Event Mechanism///////////

        public YesNoDialogPanel()
        {
            InitializeComponent();

            IsClicked = false;
            IsKnown = false;
        }
        
        private void yesButton_Click(object sender, EventArgs e)
        {
            IsClicked = true;
            IsKnown = true;
            
            TheWord.CorrectnessCount = TheWord.CorrectnessCount + 1;
                        
            WordBLL database = new WordBLL();
            database.Update(TheWord);
            database.Dispose();
            
            this.Hide();

            OnItemStateChanged();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            IsClicked = true;
            IsKnown = false;

            TheWord.CorrectnessCount = TheWord.CorrectnessCount - 1;

            WordBLL database = new WordBLL();
            database.Update(TheWord);
            database.Dispose();

            this.Hide();

            OnItemStateChanged();
        }
    }
}
