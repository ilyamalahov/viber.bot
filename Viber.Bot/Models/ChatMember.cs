using Newtonsoft.Json;
using Viber.Bot.Enums;

namespace Viber.Bot.Models
{
	/// <summary>
	/// Chat member.
	/// </summary>
	public class ChatMember : UserBase
	{
		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Chat member role.
		/// </summary>
		[JsonProperty("role")]
		public ChatMemberRole Role { get; set; }
	}
}