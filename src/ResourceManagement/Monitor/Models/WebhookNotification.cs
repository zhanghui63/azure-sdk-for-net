// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Webhook notification of an autoscale event.
    /// </summary>
    public partial class WebhookNotification
    {
        /// <summary>
        /// Initializes a new instance of the WebhookNotification class.
        /// </summary>
        public WebhookNotification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookNotification class.
        /// </summary>
        /// <param name="serviceUri">the service address to receive the
        /// notification.</param>
        /// <param name="properties">a property bag of settings. This value can
        /// be empty.</param>
        public WebhookNotification(string serviceUri = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            ServiceUri = serviceUri;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service address to receive the notification.
        /// </summary>
        [JsonProperty(PropertyName = "serviceUri")]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Gets or sets a property bag of settings. This value can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

    }
}
