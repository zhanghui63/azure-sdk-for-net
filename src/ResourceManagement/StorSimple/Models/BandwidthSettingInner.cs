// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The bandwidth setting.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BandwidthSettingInner : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the BandwidthSettingInner class.
        /// </summary>
        public BandwidthSettingInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BandwidthSettingInner class.
        /// </summary>
        /// <param name="schedules">The schedules.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="kind">The Kind of the object. Currently only
        /// Series8000 is supported. Possible values include:
        /// 'Series8000'</param>
        /// <param name="volumeCount">The number of volumes that uses the
        /// bandwidth setting.</param>
        public BandwidthSettingInner(IList<BandwidthSchedule> schedules, string id = default(string), string name = default(string), string type = default(string), Kind? kind = default(Kind?), int? volumeCount = default(int?))
            : base(id, name, type, kind)
        {
            Schedules = schedules;
            VolumeCount = volumeCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schedules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schedules")]
        public IList<BandwidthSchedule> Schedules { get; set; }

        /// <summary>
        /// Gets the number of volumes that uses the bandwidth setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeCount")]
        public int? VolumeCount { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schedules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedules");
            }
            if (Schedules != null)
            {
                foreach (var element in Schedules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
