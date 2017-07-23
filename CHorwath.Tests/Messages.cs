using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CHorwath.Service;

namespace CHorwath.Tests
{
	[TestClass]
	public class Messages
	{
		[TestMethod]
		public void GetMessageTest()
		{

			string msg = "";
			msg = MessageHandler.GetMessage("web");
			Assert.AreEqual("Hello World!", msg);

			msg = MessageHandler.GetMessage("desktop");
			Assert.AreEqual("Hello Local User.", msg);

			msg = MessageHandler.GetMessage("mobile");
			Assert.AreEqual("under development", msg);


		}

		[TestMethod]
		[ExpectedException(typeof(NotImplementedException))]
		public void SaveMessageTest()
		{
			//this is expected to throw an expection since it's not developed
			MessageHandler.SaveMessage("test message to save");

		}
	}
}
