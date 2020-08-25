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
    /// The interface IAccessPackageAssignmentResourceRoleRequestBuilder.
    /// </summary>
    public partial interface IAccessPackageAssignmentResourceRoleRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentResourceRoleRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentResourceRoleRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AccessPackageResourceScope.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageResourceScopeRequestBuilder"/>.</returns>
        IAccessPackageResourceScopeRequestBuilder AccessPackageResourceScope { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRole.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageResourceRoleRequestBuilder"/>.</returns>
        IAccessPackageResourceRoleRequestBuilder AccessPackageResourceRole { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageSubject.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageSubjectRequestBuilder"/>.</returns>
        IAccessPackageSubjectRequestBuilder AccessPackageSubject { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignments.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentResourceRoleAccessPackageAssignmentsCollectionRequestBuilder"/>.</returns>
        IAccessPackageAssignmentResourceRoleAccessPackageAssignmentsCollectionRequestBuilder AccessPackageAssignments { get; }
    
        
    
    }
}
