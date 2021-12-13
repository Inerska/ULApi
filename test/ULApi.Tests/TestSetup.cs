// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using ULApi.BusinessLayer;
using ULApi.Controllers;

namespace ULApi.Test;
public class TestSetup
{
    public ServiceProvider ServiceProvider { get; private set; }
    public TestSetup()
    {
        var serviceCollection = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile(
                                       path: "appsettings.json",
                                       optional: false,
                                       reloadOnChange: true)
                                .Build();

        serviceCollection
                         .AddSingleton(typeof(GraphBusinessFetcherService<>))
                         .AddTransient<NewsController, NewsController>()
                         ;

        ServiceProvider = serviceCollection.BuildServiceProvider();
    }
}
