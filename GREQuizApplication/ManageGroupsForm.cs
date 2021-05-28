

namespace QuizApplication
{
    using QuizApplicationLibrary;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using QuizApplicationLibrary.BLL;
    using QuizApplicationLibrary.POCO;
    public partial class ManageGroupsForm : Form
    {
        private WordBLL _wordDatabase = new WordBLL();
        private MaxGroupBll _maxGroupDatabase = new MaxGroupBll();

        public ManageGroupsForm()
        {
            InitializeComponent();

            LoadFromComboBox();
            LoadToComboBox();

            LoadFromListBox();
            LoadToListBox();
        }

        private void LoadFromListBox()
        {
            listBox1.Rows.Clear();

            int group = (int)comboBox1.SelectedItem;

            IList<Word> list = _wordDatabase.GetByGroup(group);

            int i = 0;
            foreach(Word w in list)
            {
                listBox1.Rows.Add(w.Name, w.Meaning, w.CorrectnessCount.ToString());
                listBox1.Rows[i].Tag = w;
                
                i++;
            }

            toolStripStatusLabel2.Text = list.Count.ToString();
        }

        private void LoadFromComboBox()
        {
            comboBox1.Items.Clear();
            MaxGroup item = _maxGroupDatabase.Get();

            for (int i = 1; i <= item.GroupNo; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void LoadToComboBox()
        {
            comboBox2.Items.Clear();
            MaxGroup item = _maxGroupDatabase.Get();

            for (int i = 1; i <= item.GroupNo; i++)
            {
                comboBox2.Items.Add(i);
            }

            comboBox2.SelectedIndex = 0;
        }

        private void LoadToListBox()
        {
            listBox2.Rows.Clear();

            int group = (int)comboBox2.SelectedItem;

            IList<Word> list = _wordDatabase.GetByGroup(group);

            int i = 0;
            foreach (Word w in list)
            {
                listBox2.Rows.Add(w.Name, w.Meaning, w.CorrectnessCount.ToString());
                listBox2.Rows[i].Tag = w;
                i++;
            }

            toolStripStatusLabel4.Text = list.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fromGroup = (int)comboBox1.SelectedItem;
            int toGroup = (int)comboBox2.SelectedItem;

            if (fromGroup != toGroup)
            {
                Word item = listBox1.SelectedRows[0].Tag as Word;

                if (item != null)
                {
                    item.GroupNo = toGroup;

                    _wordDatabase.Update(item);
                }

                LoadFromListBox();
                LoadToListBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fromGroup = (int)comboBox1.SelectedItem;
            int toGroup = (int)comboBox2.SelectedItem;

            if (fromGroup != toGroup)
            {
                Word item = listBox2.SelectedRows[0].Tag as Word;

                if (item != null)
                {
                    item.GroupNo = fromGroup;

                    _wordDatabase.Update(item);
                }

                LoadFromListBox();
                LoadToListBox();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromListBox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToListBox();
        }
    }
}
