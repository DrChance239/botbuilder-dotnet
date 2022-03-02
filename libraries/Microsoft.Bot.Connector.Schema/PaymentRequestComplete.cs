﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;

namespace Microsoft.Bot.Connector.Schema
{
    /// <summary>
    /// Payload delivered when completing a payment request.
    /// </summary>
    [Obsolete("Bot Framework no longer supports payments.")]
    public partial class PaymentRequestComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplete"/> class.
        /// </summary>
        public PaymentRequestComplete()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplete"/> class.
        /// </summary>
        /// <param name="id">Payment request ID.</param>
        /// <param name="paymentRequest">Initial payment request.</param>
        /// <param name="paymentResponse">Corresponding payment
        /// response.</param>
        public PaymentRequestComplete(string id = default, PaymentRequest paymentRequest = default, PaymentResponse paymentResponse = default)
        {
            Id = id;
            PaymentRequest = paymentRequest;
            PaymentResponse = paymentResponse;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets payment request ID.
        /// </summary>
        /// <value>The payment request ID.</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets initial payment request.
        /// </summary>
        /// <value>The initial payment request.</value>
        [JsonPropertyName("paymentRequest")]
        public PaymentRequest PaymentRequest { get; set; }

        /// <summary>
        /// Gets or sets corresponding payment response.
        /// </summary>
        /// <value>The payment reesponse.</value>
        [JsonPropertyName("paymentResponse")]
        public PaymentResponse PaymentResponse { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
