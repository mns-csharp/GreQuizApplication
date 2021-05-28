using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class TestAndTestTakerRelation : BaseClass<TestAndTestTakerRelation>
	{
		public int TestID { get; set; }
		public int TestTakerID { get; set; }
	}

}
