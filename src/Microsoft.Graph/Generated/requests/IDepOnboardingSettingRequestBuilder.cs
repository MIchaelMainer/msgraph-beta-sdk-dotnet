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
    /// The interface IDepOnboardingSettingRequestBuilder.
    /// </summary>
    public partial interface IDepOnboardingSettingRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDepOnboardingSettingRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDepOnboardingSettingRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DefaultIosEnrollmentProfile.
        /// </summary>
        /// <returns>The <see cref="IDepIOSEnrollmentProfileWithReferenceRequestBuilder"/>.</returns>
        IDepIOSEnrollmentProfileWithReferenceRequestBuilder DefaultIosEnrollmentProfile { get; }

        /// <summary>
        /// Gets the request builder for DefaultMacOsEnrollmentProfile.
        /// </summary>
        /// <returns>The <see cref="IDepMacOSEnrollmentProfileWithReferenceRequestBuilder"/>.</returns>
        IDepMacOSEnrollmentProfileWithReferenceRequestBuilder DefaultMacOsEnrollmentProfile { get; }

        /// <summary>
        /// Gets the request builder for EnrollmentProfiles.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder"/>.</returns>
        IDepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder EnrollmentProfiles { get; }

        /// <summary>
        /// Gets the request builder for ImportedAppleDeviceIdentities.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder"/>.</returns>
        IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder ImportedAppleDeviceIdentities { get; }
    
        /// <summary>
        /// Gets the request builder for DepOnboardingSettingGenerateEncryptionPublicKey.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingGenerateEncryptionPublicKeyRequestBuilder"/>.</returns>
        IDepOnboardingSettingGenerateEncryptionPublicKeyRequestBuilder GenerateEncryptionPublicKey();

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingUploadDepToken.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingUploadDepTokenRequestBuilder"/>.</returns>
        IDepOnboardingSettingUploadDepTokenRequestBuilder UploadDepToken(
            string appleId = null,
            string depToken = null);

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingSyncWithAppleDeviceEnrollmentProgram.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingSyncWithAppleDeviceEnrollmentProgramRequestBuilder"/>.</returns>
        IDepOnboardingSettingSyncWithAppleDeviceEnrollmentProgramRequestBuilder SyncWithAppleDeviceEnrollmentProgram();

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingShareForSchoolDataSyncService.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingShareForSchoolDataSyncServiceRequestBuilder"/>.</returns>
        IDepOnboardingSettingShareForSchoolDataSyncServiceRequestBuilder ShareForSchoolDataSyncService();

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingUnshareForSchoolDataSyncService.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingUnshareForSchoolDataSyncServiceRequestBuilder"/>.</returns>
        IDepOnboardingSettingUnshareForSchoolDataSyncServiceRequestBuilder UnshareForSchoolDataSyncService();

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingGetEncryptionPublicKey.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingGetEncryptionPublicKeyRequestBuilder"/>.</returns>
        IDepOnboardingSettingGetEncryptionPublicKeyRequestBuilder GetEncryptionPublicKey();
    
    }
}
