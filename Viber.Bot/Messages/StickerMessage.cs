﻿using Newtonsoft.Json;
using Viber.Bot.Enums;

namespace Viber.Bot.Messages
{
	/// <summary>
	/// Sticker message.
	/// </summary>
	public class StickerMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StickerMessage"/> class.
		/// </summary>
		public StickerMessage()
			: base(MessageType.Sticker)
		{
		}

		/// <summary>
		/// Unique Viber sticker ID.
		/// </summary>
		[JsonProperty("sticker_id")]
		public string StickerId { get; set; }
	}
}