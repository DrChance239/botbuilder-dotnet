// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> A Hero card (card with a single, large image). </summary>
    internal partial class HeroCard
    {
        /// <summary> Initializes a new instance of HeroCard. </summary>
        internal HeroCard()
        {
            Images = new ChangeTrackingList<CardImage>();
            Buttons = new ChangeTrackingList<CardAction>();
        }

        /// <summary> Title of the card. </summary>
        public string Title { get; }
        /// <summary> Subtitle of the card. </summary>
        public string Subtitle { get; }
        /// <summary> Text for the card. </summary>
        public string Text { get; }
        /// <summary> Array of images for the card. </summary>
        public IReadOnlyList<CardImage> Images { get; }
        /// <summary> Set of actions applicable to the current card. </summary>
        public IReadOnlyList<CardAction> Buttons { get; }
        /// <summary> This action will be activated when user taps on the card itself. </summary>
        public CardAction Tap { get; }
    }
}
