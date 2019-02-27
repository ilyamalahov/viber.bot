using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Viber.Bot.Models
{
	/// <summary>
	/// Location (coordinates).
	/// </summary>
	public class Location
	{
		/// <summary>
		/// Longitude of the <see cref="Location"/>.
		/// </summary>
		[JsonProperty("lon")]
		[XmlElement("lon")]
		public double Lon { get; set; }

		/// <summary>
		/// Latitude of the <see cref="Location"/>.
		/// </summary>
		[JsonProperty("lat")]
		[XmlElement("lat")]
		public double Lat { get; set; }
	}
}