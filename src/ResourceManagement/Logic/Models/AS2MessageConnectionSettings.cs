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
    /// The AS2 agreement message connection settings.
    /// </summary>
    public partial class AS2MessageConnectionSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2MessageConnectionSettings
        /// class.
        /// </summary>
        public AS2MessageConnectionSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2MessageConnectionSettings
        /// class.
        /// </summary>
        /// <param name="ignoreCertificateNameMismatch">The value indicating
        /// whether to ignore mismatch in certificate name.</param>
        /// <param name="supportHttpStatusCodeContinue">The value indicating
        /// whether to support HTTP status code 'CONTINUE'.</param>
        /// <param name="keepHttpConnectionAlive">The value indicating whether
        /// to keep the connection alive.</param>
        /// <param name="unfoldHttpHeaders">The value indicating whether to
        /// unfold the HTTP headers.</param>
        public AS2MessageConnectionSettings(bool ignoreCertificateNameMismatch, bool supportHttpStatusCodeContinue, bool keepHttpConnectionAlive, bool unfoldHttpHeaders)
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to ignore mismatch in
        /// certificate name.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreCertificateNameMismatch")]
        public bool IgnoreCertificateNameMismatch { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to support HTTP status
        /// code 'CONTINUE'.
        /// </summary>
        [JsonProperty(PropertyName = "supportHttpStatusCodeContinue")]
        public bool SupportHttpStatusCodeContinue { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to keep the connection
        /// alive.
        /// </summary>
        [JsonProperty(PropertyName = "keepHttpConnectionAlive")]
        public bool KeepHttpConnectionAlive { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to unfold the HTTP
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "unfoldHttpHeaders")]
        public bool UnfoldHttpHeaders { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
