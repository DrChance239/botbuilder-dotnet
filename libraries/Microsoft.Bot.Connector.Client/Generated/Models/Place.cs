// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> Place (entity type: &quot;https://schema.org/Place&quot;). </summary>
    internal partial class Place
    {
        /// <summary> Initializes a new instance of Place. </summary>
        internal Place()
        {
        }

        /// <summary> Address of the place (may be `string` or complex object of type `PostalAddress`). </summary>
        public object Address { get; }
        /// <summary> Geo coordinates of the place (may be complex object of type `GeoCoordinates` or `GeoShape`). </summary>
        public object Geo { get; }
        /// <summary> Map to the place (may be `string` (URL) or complex object of type `Map`). </summary>
        public object HasMap { get; }
        /// <summary> The type of the thing. </summary>
        public string Type { get; }
        /// <summary> The name of the thing. </summary>
        public string Name { get; }
    }
}
