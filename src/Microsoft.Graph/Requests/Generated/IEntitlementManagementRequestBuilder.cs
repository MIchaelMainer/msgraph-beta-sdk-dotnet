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
    /// The interface IEntitlementManagementRequestBuilder.
    /// </summary>
    public partial interface IEntitlementManagementRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEntitlementManagementRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEntitlementManagementRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AccessPackageCatalogs.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageCatalogsCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageCatalogsCollectionRequestBuilder AccessPackageCatalogs { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageResources.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder AccessPackageResources { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRequests.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourceRequestsCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageResourceRequestsCollectionRequestBuilder AccessPackageResourceRequests { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRoleScopes.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourceRoleScopesCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageResourceRoleScopesCollectionRequestBuilder AccessPackageResourceRoleScopes { get; }

        /// <summary>
        /// Gets the request builder for AccessPackages.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackagesCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackagesCollectionRequestBuilder AccessPackages { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentPolicies.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentPoliciesCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageAssignmentPoliciesCollectionRequestBuilder AccessPackageAssignmentPolicies { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignments.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder AccessPackageAssignments { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentRequests.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder AccessPackageAssignmentRequests { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentResourceRoles.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentResourceRolesCollectionRequestBuilder"/>.</returns>
        IEntitlementManagementAccessPackageAssignmentResourceRolesCollectionRequestBuilder AccessPackageAssignmentResourceRoles { get; }
    
    }
}
