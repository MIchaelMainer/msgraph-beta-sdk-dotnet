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
    /// The enum ContactRelationship.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ContactRelationship
    {
    
        /// <summary>
        /// Parent
        /// </summary>
        Parent = 0,
	
        /// <summary>
        /// Relative
        /// </summary>
        Relative = 1,
	
        /// <summary>
        /// Aide
        /// </summary>
        Aide = 2,
	
        /// <summary>
        /// Doctor
        /// </summary>
        Doctor = 3,
	
        /// <summary>
        /// Guardian
        /// </summary>
        Guardian = 4,
	
        /// <summary>
        /// Child
        /// </summary>
        Child = 5,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 6,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}