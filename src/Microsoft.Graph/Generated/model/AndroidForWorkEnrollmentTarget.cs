// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidForWorkEnrollmentTarget.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidForWorkEnrollmentTarget
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// All
        /// </summary>
        All = 1,
	
        /// <summary>
        /// Targeted
        /// </summary>
        Targeted = 2,
	
        /// <summary>
        /// Targeted As Enrollment Restrictions
        /// </summary>
        TargetedAsEnrollmentRestrictions = 3,
	
    }
}
