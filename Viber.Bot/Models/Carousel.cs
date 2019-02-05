using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Viber.Bot.Models
{
    /// <summary>
    /// Carousel content
    /// </summary>
    [XmlRoot("carousel")]
    public class Carousel
    {

        /// <summary>
        /// Const value.
        /// </summary>
        [JsonProperty("Type")]
        private const string Type = "rich_media";

        /// <summary>
        /// Backward compatibility text, limited to 7,000 characters
        /// </summary>
        [JsonProperty("alt_text")]
        [XmlAttribute("altText")]
        public string AlternateText { get; set; }

        /// <summary>
        /// Number of columns per carousel content block. Default 6 columns
        /// </summary>
        [JsonProperty("ButtonsGroupColumns")]
        [XmlAttribute("buttonsGroupColumns")]
        public int ButtonsGroupColumns { get; set; }

        /// <summary>
        /// Number of rows per carousel content block. Default 7 rows
        /// </summary>
        [JsonProperty("ButtonsGroupRows")]
        [XmlAttribute("buttonsGroupRows")]
        public int ButtonsGroupRows { get; set; }

        /// <summary>
        /// Array containing all carousel content buttons by order.
        /// </summary>
        [JsonProperty("Buttons")]
        [XmlArray("buttons")]
        [XmlArrayItem("button")]
        public KeyboardButton[] Buttons { get; set; }

        /// <summary>
        /// Background color of the carousel content (valid color HEX value).
        /// </summary>
        [JsonProperty("BgColor")]
        [XmlAttribute("bgColor")]
        public string BackgroundColor { get; set; }
    }
}
