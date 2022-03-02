﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// Messaging extension Actions (Only when type is auth or config).
    /// </summary>
    public partial class MessagingExtensionSuggestedAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingExtensionSuggestedAction"/> class.
        /// </summary>
        public MessagingExtensionSuggestedAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingExtensionSuggestedAction"/> class.
        /// </summary>
        /// <param name="actions">Actions.</param>
        public MessagingExtensionSuggestedAction(IList<CardAction> actions = default(IList<CardAction>))
        {
            Actions = actions;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets actions.
        /// </summary>
        /// <value>The actions.</value>
        [JsonPropertyName("actions")]
#pragma warning disable CA2227 // Collection properties should be read only (we can't change this without breaking compat).
        public IList<CardAction> Actions { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
