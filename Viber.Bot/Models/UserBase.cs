using Newtonsoft.Json;

namespace Viber.Bot.Models
{
	/// <summary>
	/// Base user info.
	/// </summary>
	public class UserBase
	{
		/// <inheritdoc />
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <inheritdoc />
		[JsonProperty("avatar")]
		public string Avatar { get; set; }
	}
}