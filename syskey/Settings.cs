using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace syskey
{
	public class Settings
	{
		private static Settings _instance;

		private string _dumpLocation;
		private string _settingsFile;

		public SettingsData data;
		//public Messages messages;
		public List<Message> messages;

		/// <summary>
		/// Initialize settings
		/// </summary>
		/// <returns>An instance of settings</returns>
		public static Settings init()
		{
			if (_instance == null)
				_instance = new Settings();

			return _instance;
		}

		public Settings()
		{
			this._dumpLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\fake syskey\";
			this._settingsFile = _dumpLocation + "settings.json";

			if (File.Exists(this._settingsFile))
				this.Load();
			else
				this.Create();
		}

		private void Load()
		{
			using(var reader = new StreamReader(File.Open(this._settingsFile, FileMode.Open, FileAccess.Read)))
			{
				this.data = new JavaScriptSerializer().Deserialize<SettingsData>(reader.ReadToEnd());
			}

			this.LoadMessages();
		}

		private void LoadMessages()
		{
			using(var reader = new StreamReader(File.Open(data.messages, FileMode.Open, FileAccess.Read)))
			{
				this.messages = new JavaScriptSerializer().Deserialize<List<Message>>(reader.ReadToEnd());
			}
		}

		private void Create()
		{
			if (!Directory.Exists(this._dumpLocation))
				Directory.CreateDirectory(this._dumpLocation);

			this.data = new SettingsData(); // temporary. set null later so load will work properly
			this.data.passkeyLogger = this._dumpLocation + "syskey_scammer_passwords.txt";
			this.data.messages = this._dumpLocation + "messages.json";

			// create messages file, set initial message
			using (var writer = new StreamWriter(File.Open(this.data.messages, FileMode.Create, FileAccess.Write)))
			{
				var msg = new Message() { title = "SCAMMER DETECTED", message = string.Format("{0}{1}{2}",
					"You cannot enable syskey dumb scammer! It's disgusting how you lock ",
					"innocent people out of their computers like this. You make me sick. Good luck locking ",
					"me out of my own system! :)")
				};

				var json = new JavaScriptSerializer().Serialize(new List<Message>()
					{
						msg
					});

				writer.Write(json);
			}

			this.Save(data);

			// clear data object and initiate load
			this.data = null;
			this.Load();
		}

		public void Save(SettingsData data = null)
		{
			// delete settings file if exists to prevent fucked up json output
			if (File.Exists(this._settingsFile))
				File.Delete(this._settingsFile);

			using(var writer = new StreamWriter(File.Open(this._settingsFile, FileMode.OpenOrCreate, FileAccess.Write)))
			{
				var json = new JavaScriptSerializer().Serialize(new SettingsData()
					{
						messages = this.data.messages,
						passkeyLogger = this.data.passkeyLogger
					});

				writer.Write(json);
			}
		}
	}
}
