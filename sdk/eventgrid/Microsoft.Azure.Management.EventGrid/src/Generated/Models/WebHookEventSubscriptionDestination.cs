// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the webhook destination for an event subscription.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebHook")]
    [Rest.Serialization.JsonTransformation]
    public partial class WebHookEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebHookEventSubscriptionDestination class.
        /// </summary>
        public WebHookEventSubscriptionDestination()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebHookEventSubscriptionDestination class.
        /// </summary>
        /// <param name="endpointUrl">The URL that represents the endpoint of
        /// the destination of an event subscription.</param>
        /// <param name="endpointBaseUrl">The base URL that represents the
        /// endpoint of the destination of an event subscription.</param>
        /// <param name="maxEventsPerBatch">Maximum number of events per
        /// batch.</param>
        /// <param name="preferredBatchSizeInKilobytes">Preferred batch size in
        /// Kilobytes.</param>
        /// <param name="azureActiveDirectoryTenantId">The Azure Active
        /// Directory Tenant ID to get the access token that will be included
        /// as the bearer token in delivery requests.</param>
        /// <param name="azureActiveDirectoryApplicationIdOrUri">The Azure
        /// Active Directory Application ID or URI to get the access token that
        /// will be included as the bearer token in delivery requests.</param>
        public WebHookEventSubscriptionDestination(string endpointUrl = default(string), string endpointBaseUrl = default(string), int? maxEventsPerBatch = default(int?), int? preferredBatchSizeInKilobytes = default(int?), string azureActiveDirectoryTenantId = default(string), string azureActiveDirectoryApplicationIdOrUri = default(string))
        {
            EndpointUrl = endpointUrl;
            EndpointBaseUrl = endpointBaseUrl;
            MaxEventsPerBatch = maxEventsPerBatch;
            PreferredBatchSizeInKilobytes = preferredBatchSizeInKilobytes;
            AzureActiveDirectoryTenantId = azureActiveDirectoryTenantId;
            AzureActiveDirectoryApplicationIdOrUri = azureActiveDirectoryApplicationIdOrUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL that represents the endpoint of the
        /// destination of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointUrl")]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets the base URL that represents the endpoint of the destination
        /// of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointBaseUrl")]
        public string EndpointBaseUrl { get; private set; }

        /// <summary>
        /// Gets or sets maximum number of events per batch.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxEventsPerBatch")]
        public int? MaxEventsPerBatch { get; set; }

        /// <summary>
        /// Gets or sets preferred batch size in Kilobytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.preferredBatchSizeInKilobytes")]
        public int? PreferredBatchSizeInKilobytes { get; set; }

        /// <summary>
        /// Gets or sets the Azure Active Directory Tenant ID to get the access
        /// token that will be included as the bearer token in delivery
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureActiveDirectoryTenantId")]
        public string AzureActiveDirectoryTenantId { get; set; }

        /// <summary>
        /// Gets or sets the Azure Active Directory Application ID or URI to
        /// get the access token that will be included as the bearer token in
        /// delivery requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureActiveDirectoryApplicationIdOrUri")]
        public string AzureActiveDirectoryApplicationIdOrUri { get; set; }

    }
}
