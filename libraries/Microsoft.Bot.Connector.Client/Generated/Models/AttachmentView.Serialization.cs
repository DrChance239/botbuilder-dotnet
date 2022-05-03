// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class AttachmentView
    {
        internal static AttachmentView DeserializeAttachmentView(JsonElement element)
        {
            Optional<string> viewId = default;
            Optional<int> size = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("viewId"))
                {
                    viewId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    size = property.Value.GetInt32();
                    continue;
                }
            }
            return new AttachmentView(viewId.Value, Optional.ToNullable(size));
        }
    }
}
