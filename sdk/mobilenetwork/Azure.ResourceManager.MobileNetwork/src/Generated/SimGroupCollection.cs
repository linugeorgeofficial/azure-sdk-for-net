// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="SimGroupResource" /> and their operations.
    /// Each <see cref="SimGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SimGroupCollection" /> instance call the GetSimGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SimGroupCollection : ArmCollection, IEnumerable<SimGroupResource>, IAsyncEnumerable<SimGroupResource>
    {
        private readonly ClientDiagnostics _simGroupClientDiagnostics;
        private readonly SimGroupsRestOperations _simGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="SimGroupCollection"/> class for mocking. </summary>
        protected SimGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SimGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SimGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _simGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", SimGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SimGroupResource.ResourceType, out string simGroupApiVersion);
            _simGroupRestClient = new SimGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, simGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SimGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string simGroupName, SimGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _simGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<SimGroupResource>(new SimGroupOperationSource(Client), _simGroupClientDiagnostics, Pipeline, _simGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SimGroupResource> CreateOrUpdate(WaitUntil waitUntil, string simGroupName, SimGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _simGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<SimGroupResource>(new SimGroupOperationSource(Client), _simGroupClientDiagnostics, Pipeline, _simGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual async Task<Response<SimGroupResource>> GetAsync(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _simGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual Response<SimGroupResource> Get(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _simGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the SIM groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SimGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SimGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _simGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _simGroupRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SimGroupResource(Client, SimGroupData.DeserializeSimGroupData(e)), _simGroupClientDiagnostics, Pipeline, "SimGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the SIM groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SimGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SimGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _simGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _simGroupRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SimGroupResource(Client, SimGroupData.DeserializeSimGroupData(e)), _simGroupClientDiagnostics, Pipeline, "SimGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _simGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _simGroupClientDiagnostics.CreateScope("SimGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _simGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SimGroupResource> IEnumerable<SimGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SimGroupResource> IAsyncEnumerable<SimGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
