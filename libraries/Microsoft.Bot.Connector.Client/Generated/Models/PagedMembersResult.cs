// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> Page of members. </summary>
    public partial class PagedMembersResult
    {
        /// <summary> Initializes a new instance of PagedMembersResult. </summary>
        internal PagedMembersResult()
        {
            Members = new ChangeTrackingList<ChannelAccount>();
        }

        /// <summary> Initializes a new instance of PagedMembersResult. </summary>
        /// <param name="continuationToken"> Paging token. </param>
        /// <param name="members"> The Channel Accounts. </param>
        internal PagedMembersResult(string continuationToken, IReadOnlyList<ChannelAccount> members)
        {
            ContinuationToken = continuationToken;
            Members = members;
        }

        /// <summary> Paging token. </summary>
        public string ContinuationToken { get; }
        /// <summary> The Channel Accounts. </summary>
        public IReadOnlyList<ChannelAccount> Members { get; }
    }
}
