// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WebServicesOperations operations.
    /// </summary>
    public partial interface IWebServicesOperations
    {
        /// <summary>
        /// Create or update a web service. This call will overwrite an
        /// existing web service. Note that there is no warning or
        /// confirmation. This is a nonrecoverable operation. If your intent is
        /// to create a new web service, call the Get operation first to verify
        /// that it does not exist.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='createOrUpdatePayload'>
        /// The payload that is used to create or update the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string webServiceName, WebServiceInner createOrUpdatePayload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Web Service Definition as specified by a subscription,
        /// resource group, and name. Note that the storage credentials and web
        /// service keys are not returned by this call. To get the web service
        /// access keys, call List Keys.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='region'>
        /// The region for which encrypted credential parameters are valid.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceInner>> GetWithHttpMessagesAsync(string resourceGroupName, string webServiceName, string region = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies an existing web service resource. The PATCH API call is an
        /// asynchronous operation. To determine whether it has completed
        /// successfully, you must perform a Get operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='patchPayload'>
        /// The payload to use to patch the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceInner>> PatchWithHttpMessagesAsync(string resourceGroupName, string webServiceName, WebServiceInner patchPayload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified web service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RemoveWithHttpMessagesAsync(string resourceGroupName, string webServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an encrypted credentials parameter blob for the specified
        /// region. To get the web service from a region other than the region
        /// in which it has been created, you must first call Create Regional
        /// Web Services Properties to create a copy of the encrypted
        /// credential parameter blob in that region. You only need to do this
        /// before the first time that you get the web service in the new
        /// region.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='region'>
        /// The region for which encrypted credential parameters are created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AsyncOperationStatusInner>> CreateRegionalPropertiesWithHttpMessagesAsync(string resourceGroupName, string webServiceName, string region, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the access keys for the specified web service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceKeysInner>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string webServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the web services in the specified resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='skiptoken'>
        /// Continuation token for pagination.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<WebServiceInner>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the web services in the specified subscription.
        /// </summary>
        /// <param name='skiptoken'>
        /// Continuation token for pagination.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<WebServiceInner>>> ListBySubscriptionIdWithHttpMessagesAsync(string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a web service. This call will overwrite an
        /// existing web service. Note that there is no warning or
        /// confirmation. This is a nonrecoverable operation. If your intent is
        /// to create a new web service, call the Get operation first to verify
        /// that it does not exist.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='createOrUpdatePayload'>
        /// The payload that is used to create or update the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceInner>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string webServiceName, WebServiceInner createOrUpdatePayload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies an existing web service resource. The PATCH API call is an
        /// asynchronous operation. To determine whether it has completed
        /// successfully, you must perform a Get operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='patchPayload'>
        /// The payload to use to patch the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WebServiceInner>> BeginPatchWithHttpMessagesAsync(string resourceGroupName, string webServiceName, WebServiceInner patchPayload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified web service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginRemoveWithHttpMessagesAsync(string resourceGroupName, string webServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an encrypted credentials parameter blob for the specified
        /// region. To get the web service from a region other than the region
        /// in which it has been created, you must first call Create Regional
        /// Web Services Properties to create a copy of the encrypted
        /// credential parameter blob in that region. You only need to do this
        /// before the first time that you get the web service in the new
        /// region.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the web service is located.
        /// </param>
        /// <param name='webServiceName'>
        /// The name of the web service.
        /// </param>
        /// <param name='region'>
        /// The region for which encrypted credential parameters are created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AsyncOperationStatusInner>> BeginCreateRegionalPropertiesWithHttpMessagesAsync(string resourceGroupName, string webServiceName, string region, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the web services in the specified resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<WebServiceInner>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the web services in the specified subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<WebServiceInner>>> ListBySubscriptionIdNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
