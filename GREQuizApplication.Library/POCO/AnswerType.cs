using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class AnswerType : BaseClass<AnswerType>
	{
		public string TypeName { get; set; }
		public string Description { get; set; }
	}

}
