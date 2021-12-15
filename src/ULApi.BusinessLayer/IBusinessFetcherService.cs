// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using ULApi.BusinessLayer.Mappings;

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
    /// <returns>Task of a fetching entity referenced as model.</returns>
    Task<TItem> FetchAsync(GraphMapping query);
}

