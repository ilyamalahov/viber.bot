using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Viber.Bot.Enums;
using Viber.Bot.Models;

namespace Viber.Bot.Interfaces
{
    public interface IAccountInfo
    {
        /// <summary>
        /// Unique numeric id of the account.
        /// </summary>
        [JsonProperty("id")]
        string Id { get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }

        /// <summary>
        /// Unique URI of the Account.
        /// </summary>
        [JsonProperty("uri")]
        string Uri { get; set; }

        /// <summary>
        /// Account icon URL.
        /// </summary>
        [JsonProperty("icon")]
        string Icon { get; set; }

        /// <summary>
        /// Conversation background URL.
        /// </summary>
        [JsonProperty("background")]
        string Background { get; set; }

        /// <summary>
        /// Account category.
        /// </summary>
        [JsonProperty("category")]
        string Category { get; set; }

        /// <summary>
        /// Account sub-category.
        /// </summary>
        [JsonProperty("subcategory")]
        string Subcategory { get; set; }

        /// <summary>
        /// List of event types you will receive a callback for. Should return the same values sent in the request.
        /// </summary>
        [JsonProperty("event_types")]
        ICollection<EventType> EventTypes { get; set; }

        /// <summary>
        /// Account location (coordinates). Will be used for finding accounts near me.
        /// </summary>
        [JsonProperty("location")]
        Location Location { get; set; }

        /// <summary>
        /// Account country.
        /// </summary>
        [JsonProperty("country")]
        string Country { get; set; }

        /// <summary>
        /// Account registered webhook.
        /// </summary>
        [JsonProperty("webhook")]
        string Webhook { get; set; }

        /// <summary>
        /// Number of subscribers.
        /// </summary>
        [JsonProperty("subscribers_count")]
        long SubscribersCount { get; set; }

        /// <summary>
        /// Public Chat members. Public Accounts only.
        /// </summary>
        [JsonProperty("members")]
        ICollection<ChatMember> Members { get; set; }
    }
}
