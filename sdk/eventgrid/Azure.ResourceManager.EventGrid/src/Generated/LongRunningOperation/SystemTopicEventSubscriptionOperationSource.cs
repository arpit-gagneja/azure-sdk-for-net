// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventGrid
{
    internal class SystemTopicEventSubscriptionOperationSource : IOperationSource<SystemTopicEventSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal SystemTopicEventSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SystemTopicEventSubscriptionResource IOperationSource<SystemTopicEventSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventSubscriptionData.DeserializeEventSubscriptionData(document.RootElement);
            return new SystemTopicEventSubscriptionResource(_client, data);
        }

        async ValueTask<SystemTopicEventSubscriptionResource> IOperationSource<SystemTopicEventSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventSubscriptionData.DeserializeEventSubscriptionData(document.RootElement);
            return new SystemTopicEventSubscriptionResource(_client, data);
        }
    }
}
