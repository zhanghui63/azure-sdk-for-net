// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a cost threshold item.
    /// </summary>
    public partial class CostThresholdProperties
    {
        /// <summary>
        /// Initializes a new instance of the CostThresholdProperties class.
        /// </summary>
        public CostThresholdProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CostThresholdProperties class.
        /// </summary>
        /// <param name="thresholdId">The ID of the cost threshold
        /// item.</param>
        /// <param name="percentageThreshold">The value of the percentage cost
        /// threshold.</param>
        /// <param name="displayOnChart">Indicates whether this threshold will
        /// be displayed on cost charts. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="sendNotificationWhenExceeded">Indicates whether
        /// notifications will be sent when this threshold is exceeded.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="notificationSent">Indicates the datetime when
        /// notifications were last sent for this threshold.</param>
        public CostThresholdProperties(string thresholdId = default(string), PercentageCostThresholdProperties percentageThreshold = default(PercentageCostThresholdProperties), string displayOnChart = default(string), string sendNotificationWhenExceeded = default(string), string notificationSent = default(string))
        {
            ThresholdId = thresholdId;
            PercentageThreshold = percentageThreshold;
            DisplayOnChart = displayOnChart;
            SendNotificationWhenExceeded = sendNotificationWhenExceeded;
            NotificationSent = notificationSent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the cost threshold item.
        /// </summary>
        [JsonProperty(PropertyName = "thresholdId")]
        public string ThresholdId { get; set; }

        /// <summary>
        /// Gets or sets the value of the percentage cost threshold.
        /// </summary>
        [JsonProperty(PropertyName = "percentageThreshold")]
        public PercentageCostThresholdProperties PercentageThreshold { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this threshold will be displayed on
        /// cost charts. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "displayOnChart")]
        public string DisplayOnChart { get; set; }

        /// <summary>
        /// Gets or sets indicates whether notifications will be sent when this
        /// threshold is exceeded. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "sendNotificationWhenExceeded")]
        public string SendNotificationWhenExceeded { get; set; }

        /// <summary>
        /// Gets or sets indicates the datetime when notifications were last
        /// sent for this threshold.
        /// </summary>
        [JsonProperty(PropertyName = "NotificationSent")]
        public string NotificationSent { get; set; }

    }
}
