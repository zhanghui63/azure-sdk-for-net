// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow trigger history filter.
    /// </summary>
    public partial class WorkflowTriggerHistoryFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistoryFilterInner
        /// class.
        /// </summary>
        public WorkflowTriggerHistoryFilterInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistoryFilterInner
        /// class.
        /// </summary>
        /// <param name="status">The status of workflow trigger history.
        /// Possible values include: 'NotSpecified', 'Paused', 'Running',
        /// 'Waiting', 'Succeeded', 'Skipped', 'Suspended', 'Cancelled',
        /// 'Failed', 'Faulted', 'TimedOut', 'Aborted', 'Ignored'</param>
        public WorkflowTriggerHistoryFilterInner(WorkflowStatus? status = default(WorkflowStatus?))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of workflow trigger history. Possible
        /// values include: 'NotSpecified', 'Paused', 'Running', 'Waiting',
        /// 'Succeeded', 'Skipped', 'Suspended', 'Cancelled', 'Failed',
        /// 'Faulted', 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public WorkflowStatus? Status { get; set; }

    }
}
