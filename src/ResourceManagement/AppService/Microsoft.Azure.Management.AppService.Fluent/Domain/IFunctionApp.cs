// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.AppService.Fluent.FunctionApp.Update;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Storage.Fluent;

    /// <summary>
    /// An immutable client-side representation of an Azure Function App.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in
    /// future releases, including removal, regardless of any compatibility expectations set by the containing library
    /// version number.).
    /// </remarks>
    public interface IFunctionApp  :
        Microsoft.Azure.Management.AppService.Fluent.IWebAppBase,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.AppService.Fluent.IFunctionApp>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IUpdatable<FunctionApp.Update.IUpdate>
    {
        /// <return>The master key for the function app.</return>
        string GetMasterKey();

        /// <return>The master key for the function app.</return>
        Task<string> GetMasterKeyAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the storage account associated with the function app.
        /// </summary>
        Microsoft.Azure.Management.Storage.Fluent.IStorageAccount StorageAccount { get; }
    }
}