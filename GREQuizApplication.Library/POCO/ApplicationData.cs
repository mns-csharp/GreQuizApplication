using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary.POCO
{
    public class ApplicationData
    {
        public string LastEnteredWord____EntityForm { get; set; }
        public int? LastSelectedGroup____EntityForm { get; set; }
        public bool? GroupCheckBox___CollectionForm { get; set; }
        public int? GroupComboBox___CollectionForm { get; set; }        
        public bool? LearntCheckBox____CollectionForm { get; set; }
        public int? LearntComboBox____CollectionForm { get; set; }
        public string FilterTextBox____CollectionForm { get; set; }
        public int? LastSelectedGroupSelectGroupForm { get; set; }
        public string LastSelectedWordLearnForm { get; set; }
        public int? LastTopWordIndex____CollectionForm { get; set; }
        public int? LastSelectedWordIndex____CollectionForm { get; set; }
        public int? OrderBy_____CollectionForm { get; set; }

        public ApplicationData()
        {
            LastEnteredWord____EntityForm = string.Empty;
            LastSelectedGroup____EntityForm = 0;
            GroupCheckBox___CollectionForm = false;
            GroupComboBox___CollectionForm = 0;
            LearntCheckBox____CollectionForm = false;
            LearntComboBox____CollectionForm = 0;
            FilterTextBox____CollectionForm = string.Empty;
            LastSelectedGroupSelectGroupForm = 0;
            LastSelectedWordLearnForm = string.Empty;
            LastTopWordIndex____CollectionForm = 0;
            LastSelectedWordIndex____CollectionForm = 0;
            OrderBy_____CollectionForm = 0;
        }

        public override string ToString()
        {
 	        return LastEnteredWord____EntityForm;
        }
    }
}
