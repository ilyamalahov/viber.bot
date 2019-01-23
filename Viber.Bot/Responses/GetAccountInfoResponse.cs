using System.Collections.Generic;
using Newtonsoft.Json;
using Viber.Bot.Enums;
using Viber.Bot.Interfaces;
using Viber.Bot.Models;

namespace Viber.Bot
{
	/// <summary>
	/// Get Account Info response.
	/// </summary>
	internal class GetAccountInfoResponse : ApiResponseBase, IAccountInfo
	{
        /// <summary>
        /// Unique numeric id of the account.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique URI of the Account.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Account icon URL.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Conversation background URL.
        /// </summary>
        [JsonProperty("background")]
        public string Background { get; set; }

        /// <summary>
        /// Account category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Account sub-category.
        /// </summary>
        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// List of event types you will receive a callback for. Should return the same values sent in the request.
        /// </summary>
        [JsonProperty("event_types")]
        public ICollection<EventType> EventTypes { get; set; }

        /// <summary>
        /// Account location (coordinates). Will be used for finding accounts near me.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Account country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Account registered webhook.
        /// </summary>
        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        /// <summary>
        /// Number of subscribers.
        /// </summary>
        [JsonProperty("subscribers_count")]
        public long SubscribersCount { get; set; }

        /// <summary>
        /// Public Chat members. Public Accounts only.
        /// </summary>
        [JsonProperty("members")]
        public ICollection<ChatMember> Members { get; set; }
    }
}