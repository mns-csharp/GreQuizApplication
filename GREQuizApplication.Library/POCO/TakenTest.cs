using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class TakenTest : BaseClass<TakenTest>
	{
		public int TestID { get; set; }
		public int TestTakerID { get; set; }
		public int DateOfTestTaken { get; set; }
	}

}
