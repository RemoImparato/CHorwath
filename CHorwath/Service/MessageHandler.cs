using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHorwath.Service
{
	public static class MessageHandler
	{

		public static string GetMessage(string forClient)
		{
			string retval = "";
			switch (forClient.ToUpper())
			{
				case "WEB":
					retval = "Hello World!";
					break;
				case "DESKTOP":
					retval = "Hello Local User.";
					break;
				case "MOBILE":
				default:
					retval = "under development";
					break;

			}

			return retval;
		}

		public static bool SaveMessage(string msg)
		{
			//TODO: define a database connection in web.config then connect to the database and save the message
			throw new NotImplementedException();
		}
	}
}