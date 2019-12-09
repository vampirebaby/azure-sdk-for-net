// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{

    /// <summary>
    /// Defines values for ResourceDiscoveryMode.
    /// </summary>
    public static class ResourceDiscoveryMode
    {
        /// <summary>
        /// Remediate resources that are already known to be non-compliant.
        /// </summary>
        public const string ExistingNonCompliant = "ExistingNonCompliant";
        /// <summary>
        /// Re-evaluate the compliance state of resources and then remediate
        /// the resources found to be non-compliant.
        /// </summary>
        public const string ReEvaluateCompliance = "ReEvaluateCompliance";
    }
}