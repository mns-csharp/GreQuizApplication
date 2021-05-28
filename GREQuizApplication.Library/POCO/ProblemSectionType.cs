using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class ProblemSectionType : BaseClass<ProblemSectionType>
	{
		//public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}

}
