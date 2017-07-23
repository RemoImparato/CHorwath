using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace CHorwath.Service
{
	[ServiceContract(Namespace = "")]
	public class Messages
	{
		[OperationContract]
		[WebInvoke(Method = "POST"
			, BodyStyle = WebMessageBodyStyle.Wrapped
			, RequestFormat = WebMessageFormat.Json
			, ResponseFormat = WebMessageFormat.Json)]
		public string GetMessage(string forClient)
		{
			//get the message from the application logic layer, in this instance it could be a separate DLL or server request
			//for simplicity i've stubbed it out as a static class so the Unit Test code is simpler.
			return MessageHandler.GetMessage(forClient);
		}

		[OperationContract]
		[WebInvoke(Method = "POST"
			, BodyStyle = WebMessageBodyStyle.Wrapped
			, RequestFormat = WebMessageFormat.Json
			, ResponseFormat = WebMessageFormat.Json)]
		public bool SaveMessage(string msg)
		{
			//save the message to the application logic layer, on that layer the DLL would need to create a connection
			//to a database, use a stored procedure, SQL or EntityFramework to save the message based on business requirements.
			//for simplicity i've stubbed it out as a static class so the Unit Test code is simpler.
			return MessageHandler.SaveMessage(msg);
		}

	}
}
