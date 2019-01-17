using System;

using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Picture message.
	/// </summary>
	public class PictureMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PictureMessage"/> class.
		/// </summary>
		public PictureMessage() : base(MessageType.Picture)
		{
			Text = string.Empty;
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// URL of the image (JPEG).
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }

		/// <summary>
		/// URL of a reduced size image (JPEG).
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

        /// <summary>
        /// Picture file name
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }
    }
}