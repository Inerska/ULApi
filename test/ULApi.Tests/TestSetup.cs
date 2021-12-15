// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using ULApi.BusinessLayer.Services;
using ULApi.Controllers;

namespace ULApi.Test;

/// <summary>
/// Test initializer class, containing a Dependency Injection container to inject dependencies through all test classes.
/// </summary>
public class TestSetup
{
    /// <summary>
    /// Service provider from the test initializer.
    /// </summary>
    public ServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    /// Fixure class which is containing the dependency injection container and the dependencies ready to be injected.
    /// </summary>
    public TestSetup()
    {
        var serviceCollection = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile(
                                       "appsettings.json",
                                       optional: false,
                                       reloadOnChange: true)
                                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                                .AddUserSecrets<NewsController>()
                                .AddEnvironmentVariables()
                                // ReSharper disable once TooManyChainedReferences
                                // Dependency injection container contains a lot of services to be injected.
                                .Build();

        serviceCollection
                         .AddSingleton<IConfiguration>(configuration)
                         .AddSingleton(typeof(GraphBusinessFetcherService<>))
                         .AddTransient<NewsController, NewsController>()
                         ;

        ServiceProvider = serviceCollection.BuildServiceProvider();
    }
}
