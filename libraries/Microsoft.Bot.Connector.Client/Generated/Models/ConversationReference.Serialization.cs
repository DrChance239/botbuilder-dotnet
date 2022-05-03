// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class ConversationReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId");
                writer.WriteStringValue(ActivityId);
            }
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user");
                writer.WriteObjectValue(User);
            }
            if (Optional.IsDefined(Bot))
            {
                writer.WritePropertyName("bot");
                writer.WriteObjectValue(Bot);
            }
            if (Optional.IsDefined(Conversation))
            {
                writer.WritePropertyName("conversation");
                writer.WriteObjectValue(Conversation);
            }
            if (Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId");
                writer.WriteStringValue(ChannelId);
            }
            if (Optional.IsDefined(ServiceUrl))
            {
                writer.WritePropertyName("serviceUrl");
                writer.WriteStringValue(ServiceUrl);
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale");
                writer.WriteStringValue(Locale);
            }
            writer.WriteEndObject();
        }
    }
}
