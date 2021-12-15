// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using ULApi.BusinessLayer.Services;

namespace ULApi.BusinessLayer;

/// <summary>
/// Static class which is containing extension method to be added inside the dependency injection container.
/// </summary>
public static class Setup
{
    /// <summary>
    /// Extension method to add Api services to the dependency injection container.
    /// </summary>
    /// <param name="services">Collection of services to be added.</param>
    /// <returns>An <see cref="IServiceCollection"/> class which is collecting services to be injected.</returns>
    public static IServiceCollection AddUlApiServices(this IServiceCollection services)
        => services.AddSingleton(typeof(IBusinessFetcherService<>), typeof(GraphBusinessFetcherService<>));
}
