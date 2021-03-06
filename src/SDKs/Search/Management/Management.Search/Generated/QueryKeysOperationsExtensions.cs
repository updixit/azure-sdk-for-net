// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for QueryKeysOperations.
    /// </summary>
    public static partial class QueryKeysOperationsExtensions
    {
            /// <summary>
            /// Generates a new query key for the specified Search service. You can create
            /// up to 50 query keys per service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the new query API key.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static QueryKey Create(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IQueryKeysOperations)s).CreateAsync(resourceGroupName, searchServiceName, name, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a new query key for the specified Search service. You can create
            /// up to 50 query keys per service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the new query API key.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<QueryKey> CreateAsync(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, searchServiceName, name, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of query API keys for the given Azure Search service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static System.Collections.Generic.IEnumerable<QueryKey> ListBySearchService(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IQueryKeysOperations)s).ListBySearchServiceAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of query API keys for the given Azure Search service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<QueryKey>> ListBySearchServiceAsync(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListBySearchServiceWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified query key. Unlike admin keys, query keys are not
            /// regenerated. The process for regenerating a query key is to delete and
            /// then recreate it.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='key'>
            /// The query key to be deleted. Query keys are identified by value, not by
            /// name.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, string key, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IQueryKeysOperations)s).DeleteAsync(resourceGroupName, searchServiceName, key, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified query key. Unlike admin keys, query keys are not
            /// regenerated. The process for regenerating a query key is to delete and
            /// then recreate it.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='key'>
            /// The query key to be deleted. Query keys are identified by value, not by
            /// name.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IQueryKeysOperations operations, string resourceGroupName, string searchServiceName, string key, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, searchServiceName, key, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
