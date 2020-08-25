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
    /// The interface IEventRequestBuilder.
    /// </summary>
    public partial interface IEventRequestBuilder : IOutlookItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEventRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEventRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ExceptionOccurrences.
        /// </summary>
        /// <returns>The <see cref="IEventExceptionOccurrencesCollectionRequestBuilder"/>.</returns>
        IEventExceptionOccurrencesCollectionRequestBuilder ExceptionOccurrences { get; }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IEventAttachmentsCollectionRequestBuilder"/>.</returns>
        IEventAttachmentsCollectionRequestBuilder Attachments { get; }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IEventSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IEventSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IEventMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IEventMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder Calendar { get; }

        /// <summary>
        /// Gets the request builder for Instances.
        /// </summary>
        /// <returns>The <see cref="IEventInstancesCollectionRequestBuilder"/>.</returns>
        IEventInstancesCollectionRequestBuilder Instances { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IEventExtensionsCollectionRequestBuilder"/>.</returns>
        IEventExtensionsCollectionRequestBuilder Extensions { get; }
    
        /// <summary>
        /// Gets the request builder for EventDismissReminder.
        /// </summary>
        /// <returns>The <see cref="IEventDismissReminderRequestBuilder"/>.</returns>
        IEventDismissReminderRequestBuilder DismissReminder();

        /// <summary>
        /// Gets the request builder for EventSnoozeReminder.
        /// </summary>
        /// <returns>The <see cref="IEventSnoozeReminderRequestBuilder"/>.</returns>
        IEventSnoozeReminderRequestBuilder SnoozeReminder(
            DateTimeTimeZone NewReminderTime);

        /// <summary>
        /// Gets the request builder for EventForward.
        /// </summary>
        /// <returns>The <see cref="IEventForwardRequestBuilder"/>.</returns>
        IEventForwardRequestBuilder Forward(
            IEnumerable<Recipient> ToRecipients = null,
            string Comment = null);

        /// <summary>
        /// Gets the request builder for EventAccept.
        /// </summary>
        /// <returns>The <see cref="IEventAcceptRequestBuilder"/>.</returns>
        IEventAcceptRequestBuilder Accept(
            string Comment = null,
            bool? SendResponse = null);

        /// <summary>
        /// Gets the request builder for EventDecline.
        /// </summary>
        /// <returns>The <see cref="IEventDeclineRequestBuilder"/>.</returns>
        IEventDeclineRequestBuilder Decline(
            string Comment = null,
            bool? SendResponse = null);

        /// <summary>
        /// Gets the request builder for EventTentativelyAccept.
        /// </summary>
        /// <returns>The <see cref="IEventTentativelyAcceptRequestBuilder"/>.</returns>
        IEventTentativelyAcceptRequestBuilder TentativelyAccept(
            string Comment = null,
            bool? SendResponse = null);

        /// <summary>
        /// Gets the request builder for EventCancel.
        /// </summary>
        /// <returns>The <see cref="IEventCancelRequestBuilder"/>.</returns>
        IEventCancelRequestBuilder Cancel(
            string Comment = null);
    
    }
}
