using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class TakenTestAnswer : BaseClass<TakenTestAnswer>
	{
		public int TakenTestID { get; set; }
		public int QuantQuestionID { get; set; }
		public string TakersWrittenAnswer { get; set; }
	}

}
