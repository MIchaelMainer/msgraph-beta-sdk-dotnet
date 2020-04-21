// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementReportsRequestBuilder.
    /// </summary>
    public partial class DeviceManagementReportsRequestBuilder : EntityRequestBuilder, IDeviceManagementReportsRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementReportsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementReportsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceManagementReportsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceManagementReportsRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementReportsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CachedReportConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsCachedReportConfigurationsCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementReportsCachedReportConfigurationsCollectionRequestBuilder CachedReportConfigurations
        {
            get
            {
                return new DeviceManagementReportsCachedReportConfigurationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("cachedReportConfigurations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ExportJobs.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsExportJobsCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementReportsExportJobsCollectionRequestBuilder ExportJobs
        {
            get
            {
                return new DeviceManagementReportsExportJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("exportJobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ReportSchedules.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsReportSchedulesCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementReportsReportSchedulesCollectionRequestBuilder ReportSchedules
        {
            get
            {
                return new DeviceManagementReportsReportSchedulesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("reportSchedules"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetDeviceNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetDeviceNonComplianceReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetDeviceNonComplianceReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getDeviceNonComplianceReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetPolicyNonComplianceReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getPolicyNonComplianceReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceMetadata.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceMetadataRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetPolicyNonComplianceMetadataRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getPolicyNonComplianceMetadata"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getPolicyNonComplianceSummaryReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetSettingNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetSettingNonComplianceReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetSettingNonComplianceReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getSettingNonComplianceReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetHistoricalReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetHistoricalReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetHistoricalReportRequestBuilder GetHistoricalReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetHistoricalReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getHistoricalReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetCachedReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetCachedReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetCachedReportRequestBuilder GetCachedReport(
            string id = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null)
        {
            return new DeviceManagementReportsGetCachedReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getCachedReport"),
                this.Client,
                id,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetWindowsUpdateAlertSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetWindowsUpdateAlertSummaryReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetWindowsUpdateAlertSummaryReportRequestBuilder GetWindowsUpdateAlertSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetWindowsUpdateAlertSummaryReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getWindowsUpdateAlertSummaryReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder"/>.</returns>
        public IDeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsUpdateAlertsPerPolicyPerDeviceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null)
        {
            return new DeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getWindowsUpdateAlertsPerPolicyPerDeviceReport"),
                this.Client,
                name,
                select,
                search,
                groupBy,
                orderBy,
                skip,
                top,
                sessionId,
                filter);
        }
    
    }
}
