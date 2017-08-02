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
    /// Subnet information as returned by the Microsoft.Network API.
    /// </summary>
    public partial class ExternalSubnetFragment
    {
        /// <summary>
        /// Initializes a new instance of the ExternalSubnetFragment class.
        /// </summary>
        public ExternalSubnetFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExternalSubnetFragment class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier.</param>
        /// <param name="name">Gets or sets the name.</param>
        public ExternalSubnetFragment(string id = default(string), string name = default(string))
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
