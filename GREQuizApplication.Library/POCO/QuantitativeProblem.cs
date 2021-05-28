using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class QuantitativeProblem : BaseClass<QuantitativeProblem>
	{
		public string ProblemText { get; set; }
		public string SolutionText { get; set; }
		public byte[] ProblemPhoto { get; set; }
		public byte[] SolutionPhoto { get; set; }
		public string AnswerText { get; set; }
		public QuantitativeProblemTypeEnum QuantitativeProblemType { get; set; }
        public AnswerTypeEnum AnswerType { get; set; }
		public ContentTypeEnum ContentType { get; set; }
	}

}
