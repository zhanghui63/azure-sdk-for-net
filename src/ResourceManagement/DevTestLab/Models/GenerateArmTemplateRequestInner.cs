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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for generating an ARM template for deploying artifacts.
    /// </summary>
    public partial class GenerateArmTemplateRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the GenerateArmTemplateRequestInner
        /// class.
        /// </summary>
        public GenerateArmTemplateRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateArmTemplateRequestInner
        /// class.
        /// </summary>
        /// <param name="virtualMachineName">The resource name of the virtual
        /// machine.</param>
        /// <param name="parameters">The parameters of the ARM
        /// template.</param>
        /// <param name="location">The location of the virtual machine.</param>
        /// <param name="fileUploadOptions">Options for uploading the files for
        /// the artifact. UploadFilesAndGenerateSasTokens is the default value.
        /// Possible values include: 'UploadFilesAndGenerateSasTokens',
        /// 'None'</param>
        public GenerateArmTemplateRequestInner(string virtualMachineName = default(string), IList<ParameterInfo> parameters = default(IList<ParameterInfo>), string location = default(string), string fileUploadOptions = default(string))
        {
            VirtualMachineName = virtualMachineName;
            Parameters = parameters;
            Location = location;
            FileUploadOptions = fileUploadOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineName")]
        public string VirtualMachineName { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<ParameterInfo> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the location of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets options for uploading the files for the artifact.
        /// UploadFilesAndGenerateSasTokens is the default value. Possible
        /// values include: 'UploadFilesAndGenerateSasTokens', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "fileUploadOptions")]
        public string FileUploadOptions { get; set; }

    }
}
