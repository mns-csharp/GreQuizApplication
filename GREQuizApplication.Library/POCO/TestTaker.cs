using System;
using System.Collections.Generic;
using System.Text;
using Simple.Framework;

namespace QuizApplicationLibrary.POCO
{
    public class TestTaker : BaseClass<TestTaker>
	{
		public string Usernameee { get; set; }
		public string MobileNumber { get; set; }
		public string EmailID { get; set; }
		public string ResidenceAddress { get; set; }
	}

}
