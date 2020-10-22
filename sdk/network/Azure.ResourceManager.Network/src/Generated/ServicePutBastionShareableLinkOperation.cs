// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
    public partial class ServicePutBastionShareableLinkOperation : Operation<AsyncPageable<BastionShareableLink>>, IOperationSource<AsyncPageable<BastionShareableLink>>
    {
        private readonly ArmOperationHelpers<AsyncPageable<BastionShareableLink>> _operation;
        private readonly Func<string, Task<Response>> _nextPageFunc;
        internal ServicePutBastionShareableLinkOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response, Func<string, Task<Response>> nextPageFunc)
        {
            _operation = new ArmOperationHelpers<AsyncPageable<BastionShareableLink>>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServicePutBastionShareableLinkOperation");
            _nextPageFunc = nextPageFunc;
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AsyncPageable<BastionShareableLink> Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AsyncPageable<BastionShareableLink>>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AsyncPageable<BastionShareableLink>>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AsyncPageable<BastionShareableLink> IOperationSource<AsyncPageable<BastionShareableLink>>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            BastionShareableLinkListResult firstPageResult;
            using var document = JsonDocument.Parse(response.ContentStream);
            firstPageResult = BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            Page<BastionShareableLink> firstPage = Page.FromValues(firstPageResult.Value, firstPageResult.NextLink, response);

            return PageableHelpers.CreateAsyncEnumerable(_ => Task.FromResult(firstPage), (nextLink, _) => GetNextPage(nextLink, cancellationToken));
        }

        async ValueTask<AsyncPageable<BastionShareableLink>> IOperationSource<AsyncPageable<BastionShareableLink>>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            BastionShareableLinkListResult firstPageResult;
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            firstPageResult = BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            Page<BastionShareableLink> firstPage = Page.FromValues(firstPageResult.Value, firstPageResult.NextLink, response);

            return PageableHelpers.CreateAsyncEnumerable(_ => Task.FromResult(firstPage), (nextLink, _) => GetNextPage(nextLink, cancellationToken));
        }

        private async Task<Page<BastionShareableLink>> GetNextPage(string nextLink, CancellationToken cancellationToken)
        {
            Response response = await _nextPageFunc(nextLink).ConfigureAwait(false);
            BastionShareableLinkListResult nextPageResult;
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            nextPageResult = BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            return Page.FromValues(nextPageResult.Value, nextPageResult.NextLink, response);
        }
    }
}