// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace ULApi.BusinessLayer;

/// <summary>
/// Interface of server fetcher business layer.
/// </summary>
/// <typeparam name="TItem">Fetched item type to retrieve.</typeparam>
public interface IBusinessFetcherService<TItem>
{
    /// <summary>
    /// Asynchronous fetching data method.
    /// </summary>
    /// <param name="query">Query to send to fetch datas.</param>
    /// <returns>Task of a fetching entity referenced as model.</returns>
    Task<TItem> FetchAsync(string query);
}

