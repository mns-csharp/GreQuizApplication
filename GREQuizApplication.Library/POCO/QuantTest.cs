using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class QuantTest : BaseClass<QuantTest>
	{
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public int TotalNumberOfQuestions { get; set; }
        public IList<QuantitativeProblem> Problems { get; set; }
	}
}
