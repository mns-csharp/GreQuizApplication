using QuizApplicationLibrary;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizApplicationLibrary.BLL;
using QuizApplicationLibrary.POCO;
using Simple.Framework.Gui;

namespace QuizApplication
{
    public partial class FlashCardForm : BaseForm
    {
        private readonly int GROUP_NO;
        private readonly int CORRECTNESS_COUNT;
        private IList<Word> _circularList;
        private YesNoDialogPanel _panel;
        string _caption = string.Empty;

        public FlashCardForm(int groupNo)
        {
            InitializeComponent();

            _caption = this.Text;

            GROUP_NO = groupNo;
            CORRECTNESS_COUNT = InMemoryValues.CorrectnessRepetition;

            _panel = new YesNoDialogPanel();
            _panel.Location = new Point(1, 220);
            _panel.ItemStateChangeEvent += _panel_ItemStateChangeEvent;
            this.Controls.Add(_panel);
            _panel.Hide();

            WordBLL database = new WordBLL();
            IList<Word> list = database.GetByGroup(GROUP_NO);
            database.Dispose();

            ShuffleList.Shuffle<Word>(list);

            _circularList = list;

            _oldCount = list.Count;

            StartFlashCard();
        }

        int _i = 0;
        int _oldCount = 0;
        int _newCount = 0;
        Word _item = null;

        private void StartFlashCard()
        {
            answerTextBox.Text = string.Empty;            
            _item = _circularList[_i];
            _newCount = _circularList.Count;
            
            //////////////////////////////
            //wordTextBox.Image = (_item.Photo!=null)?ConvertImage.ToImage(_item.Photo):null;
            
            this.Text = _caption + " (" + (_i+1).ToString() + " of " + _newCount.ToString()+")"; 
            wordTextBox.Text = _item.Name;


            //////////////////////////////
            //if (_oldCount == _newCount)
            //{
                _i++;
           // }

            _oldCount = _newCount;
            

            ///OnItemStateChanged();

            return;
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            if(_i <= _circularList.Count)
            {
                answerTextBox.Text = _item.Meaning;
                revealButton.Enabled = false;

                _panel.TheWord = _item;
                _panel.Show();

                this.Size = new Size(this.Size.Width, this.Size.Height + 150);
            }
            else
            {
                MessageBox.Show("End of list","Caption", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        void _panel_ItemStateChangeEvent()
        {
            this.Size = new Size(this.Size.Width, this.Size.Height - 150);

            revealButton.Enabled = true;

            if (_panel.TheWord.CorrectnessCount >= CORRECTNESS_COUNT)
            {
                _circularList.Remove(_panel.TheWord);
            }

            if (_i < _circularList.Count)
            {
                StartFlashCard();
            }
        }
    }
}
