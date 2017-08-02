// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AnalysisServices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AnalysisServices;
    using Microsoft.Azure.Management.AnalysisServices.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provision request specification
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AnalysisServicesServerUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AnalysisServicesServerUpdateParametersInner class.
        /// </summary>
        public AnalysisServicesServerUpdateParametersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AnalysisServicesServerUpdateParametersInner class.
        /// </summary>
        /// <param name="sku">The SKU of the Analysis Services
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional provisioning
        /// properties.</param>
        /// <param name="asAdministrators">A collection of AS server
        /// administrators</param>
        /// <param name="backupBlobContainerUri">The container URI of backup
        /// blob.</param>
        public AnalysisServicesServerUpdateParametersInner(ResourceSku sku = default(ResourceSku), IDictionary<string, string> tags = default(IDictionary<string, string>), ServerAdministrators asAdministrators = default(ServerAdministrators), string backupBlobContainerUri = default(string))
        {
            Sku = sku;
            Tags = tags;
            AsAdministrators = asAdministrators;
            BackupBlobContainerUri = backupBlobContainerUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the Analysis Services resource.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of additional provisioning properties.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets a collection of AS server administrators
        /// </summary>
        [JsonProperty(PropertyName = "properties.asAdministrators")]
        public ServerAdministrators AsAdministrators { get; set; }

        /// <summary>
        /// Gets or sets the container URI of backup blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupBlobContainerUri")]
        public string BackupBlobContainerUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
