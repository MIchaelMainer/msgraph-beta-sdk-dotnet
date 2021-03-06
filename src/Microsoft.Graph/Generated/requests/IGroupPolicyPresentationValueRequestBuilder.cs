// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGroupPolicyPresentationValueRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyPresentationValueRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupPolicyPresentationValueRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupPolicyPresentationValueRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DefinitionValue.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionValueWithReferenceRequestBuilder"/>.</returns>
        IGroupPolicyDefinitionValueWithReferenceRequestBuilder DefinitionValue { get; }

        /// <summary>
        /// Gets the request builder for Presentation.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyPresentationWithReferenceRequestBuilder"/>.</returns>
        IGroupPolicyPresentationWithReferenceRequestBuilder Presentation { get; }
    
    }
}
