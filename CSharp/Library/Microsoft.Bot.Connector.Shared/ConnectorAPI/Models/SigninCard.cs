// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A card representing a request to sign in
    /// </summary>
    public partial class SigninCard
    {
        /// <summary>
        /// Initializes a new instance of the SigninCard class.
        /// </summary>
        public SigninCard() { }

        /// <summary>
        /// Initializes a new instance of the SigninCard class.
        /// </summary>
        public SigninCard(string text = default(string), IList<CardAction> buttons = default(IList<CardAction>))
        {
            Text = text;
            Buttons = buttons;
        }

        /// <summary>
        /// Text for signin request
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Action to use to perform signin
        /// </summary>
        [JsonProperty(PropertyName = "buttons")]
        public IList<CardAction> Buttons { get; set; }

    }
}
