// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a Run Command.
    /// </summary>
    public partial class RunCommandDocument : RunCommandDocumentBase
    {
        /// <summary>
        /// Initializes a new instance of the RunCommandDocument class.
        /// </summary>
        public RunCommandDocument() { }

        /// <summary>
        /// Initializes a new instance of the RunCommandDocument class.
        /// </summary>
        /// <param name="schema">The VM run command schema.</param>
        /// <param name="id">The VM run command id.</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="label">The VM run command label.</param>
        /// <param name="description">The VM run command description.</param>
        /// <param name="script">The script to be executed.</param>
        /// <param name="parameters">The parameters used by the script.</param>
        public RunCommandDocument(string schema, string id, OperatingSystemTypes osType, string label, string description, IList<string> script, IList<RunCommandParameterDefinition> parameters = default(IList<RunCommandParameterDefinition>))
            : base(schema, id, osType, label, description)
        {
            Script = script;
            Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets the script to be executed.
        /// </summary>
        [JsonProperty(PropertyName = "script")]
        public IList<string> Script { get; set; }

        /// <summary>
        /// Gets or sets the parameters used by the script.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<RunCommandParameterDefinition> Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Script == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Script");
            }
            if (Parameters != null)
            {
                foreach (var element in Parameters)
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

