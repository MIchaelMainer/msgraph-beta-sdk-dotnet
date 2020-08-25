// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ChatMembersCollectionRequest.
    /// </summary>
    public partial class ChatMembersCollectionRequest : BaseRequest, IChatMembersCollectionRequest
    {
        /// <summary>
        /// Constructs a new ChatMembersCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ChatMembersCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <returns>The created ConversationMember.</returns>
        public System.Threading.Tasks.Task<ConversationMember> AddAsync(ConversationMember conversationMember)
        {
            return this.AddAsync(conversationMember, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationMember.</returns>
        public System.Threading.Tasks.Task<ConversationMember> AddAsync(ConversationMember conversationMember, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            conversationMember.ODataType = string.Concat("#", StringHelper.ConvertTypeToLowerCamelCase(conversationMember.GetType().FullName));
            return this.SendAsync<ConversationMember>(conversationMember, cancellationToken);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        public System.Threading.Tasks.Task<IChatMembersCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IChatMembersCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<ChatMembersCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }

                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Expand(Expression<Func<ConversationMember, object>> expandExpression)
        {
            if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Select(Expression<Func<ConversationMember, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMembersCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
