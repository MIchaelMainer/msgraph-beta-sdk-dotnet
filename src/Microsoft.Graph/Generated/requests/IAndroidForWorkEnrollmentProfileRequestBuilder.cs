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
    /// The interface IAndroidForWorkEnrollmentProfileRequestBuilder.
    /// </summary>
    public partial interface IAndroidForWorkEnrollmentProfileRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAndroidForWorkEnrollmentProfileRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAndroidForWorkEnrollmentProfileRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AndroidForWorkEnrollmentProfileCreateToken.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkEnrollmentProfileCreateTokenRequestBuilder"/>.</returns>
        IAndroidForWorkEnrollmentProfileCreateTokenRequestBuilder CreateToken(
            Int32 tokenValidityInSeconds);

        /// <summary>
        /// Gets the request builder for AndroidForWorkEnrollmentProfileRevokeToken.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkEnrollmentProfileRevokeTokenRequestBuilder"/>.</returns>
        IAndroidForWorkEnrollmentProfileRevokeTokenRequestBuilder RevokeToken();
    
    }
}
