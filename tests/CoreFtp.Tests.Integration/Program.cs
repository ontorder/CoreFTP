﻿using CoreFtp.Tests.Integration.Logger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using Xunit.Abstractions;

namespace CoreFtp.Tests.Integration;

public static class Program
{
    public static FtpConfiguration FtpConfiguration;
    public static ILoggerFactory LoggerFactory;

    public static void Main() => Initialise();

    public static void Initialise(ITestOutputHelper outputHelper = null)
    {
        LoggerFactory = new LoggerFactory()
            .AddXunitConsole(outputHelper, LogLevel.Debug)
            .AddDebug(LogLevel.Error);

        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", true, true);

        var configuration = builder.Build();

        var services = new ServiceCollection();
        services.Configure<FtpConfiguration>(configuration.GetSection("FtpCredentials"));
        services.AddOptions();

        var serviceProvider = services.BuildServiceProvider();

        FtpConfiguration = serviceProvider.GetService<IOptions<FtpConfiguration>>().Value;
    }
}
