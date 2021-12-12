// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace ULApi.Services;

/// <summary>
/// Interface of server fetcher business layer.
/// </summary>
/// <typeparam name="TItem">Fetcher item to retrieve.</typeparam>
public interface IBusinessFetcherService<TItem>
{
    /// <summary>
    /// Synchronous fetching data method.
    /// </summary>
    /// <returns>Nullable fetching entity referenced as model.</returns>
    TItem? Fetch();

    /// <summary>
    /// Asynchronous fetching data method.
    /// </summary>
    /// <returns>Task of a fetching entity referenced as model.</returns>
    Task<TItem> FetchAsync();
}

