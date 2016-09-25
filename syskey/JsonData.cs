using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace syskey
{
	public class SettingsData
	{
		public string passkeyLogger { get; set; }
		public string messages { get; set; }
	}

	public class Message
	{
		public string title { get; set; }
		public string message { get; set; }
	}

	public class Messages
	{
		//public List<List<string>> messages { get; set; }
		//public List<Dictionary<string, string>> messages { get; set; }
		public List<Message> messages { get; set; }
	}
}
