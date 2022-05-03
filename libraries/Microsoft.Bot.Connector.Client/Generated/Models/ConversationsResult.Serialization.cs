// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class ConversationsResult
    {
        internal static ConversationsResult DeserializeConversationsResult(JsonElement element)
        {
            Optional<string> continuationToken = default;
            Optional<IReadOnlyList<ConversationMembers>> conversations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuationToken"))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conversations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConversationMembers> array = new List<ConversationMembers>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationMembers.DeserializeConversationMembers(item));
                    }
                    conversations = array;
                    continue;
                }
            }
            return new ConversationsResult(continuationToken.Value, Optional.ToList(conversations));
        }
    }
}
