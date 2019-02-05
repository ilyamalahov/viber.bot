using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Viber.Bot.Enums;
using Viber.Bot.Models;

namespace Viber.Bot.Messages
{
    /// <summary>
    /// Carousel message
    /// </summary>
    public class CarouselMessage : MessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselMessage"/> class.
        /// </summary>
        public CarouselMessage() : base(MessageType.CarouselContent)
        {
        }

        /// <summary>
        /// Rich media
        /// </summary>
        [JsonProperty("rich_media")]
        public Carousel CarouselContent { get; set; }
    }
}
