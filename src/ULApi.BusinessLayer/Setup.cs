// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using ULApi.BusinessLayer.Services;

namespace ULApi.BusinessLayer;

public static class Setup
{
    public static IServiceCollection AddUlApiServices(this IServiceCollection services)
        => services.AddSingleton(typeof(IBusinessFetcherService<>), typeof(GraphBusinessFetcherService<>));
}
