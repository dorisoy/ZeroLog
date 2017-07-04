﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Jil;
using ZeroLog.Appenders.Builders;
using ZeroLog.ConfigResolvers;

namespace ZeroLog.Config
{
    public static class Configurator
    {
        public static (RootDefinition rootDefinition, IList<LoggerDefinition> loggersDefinition, IList<AppenderDefinition> appendersDefinition, LogManagerConfiguration configuration) LoadFromJson(string jsonConfiguration)
        {
            var config = JSONExtensions.DeserializeOrDefault(jsonConfiguration, new ZeroLogConfiguration());
            var legacyConfiguration = new LogManagerConfiguration
            {
                Level = config.Root.DefaultLevel,
                LogEventPoolExhaustionStrategy = config.Root.DefaultLogEventPoolExhaustionStrategy,
                LogEventBufferSize = config.Root.LogEventBufferSize,
                LogEventQueueSize = config.Root.LogEventQueueSize
            };

            return (config.Root, config.Loggers, config.Appenders, legacyConfiguration);
        }

        public static void FillResolver(IAppenderFactory factory, HierarchicalResolver hierarchicalResolver, RootDefinition rootDefinition, IList<LoggerDefinition> loggersDefinition, IList<AppenderDefinition> appendersDefinition)
        {
            var appenders = appendersDefinition.ToDictionary(x => x.Name, factory.BuildAppender);

            hierarchicalResolver.AddNode("", rootDefinition.AppenderReferences.Select(x => appenders[x]), rootDefinition.DefaultLevel, false, rootDefinition.DefaultLogEventPoolExhaustionStrategy);

            foreach (var loggerDefinition in loggersDefinition)
            {
                hierarchicalResolver.AddNode(loggerDefinition.Name, loggerDefinition.AppenderReferences.Select(x => appenders[x]), loggerDefinition.Level, loggerDefinition.IncludeParentAppenders, loggerDefinition.LogEventPoolExhaustionStrategy);
            }

            hierarchicalResolver.Build();
        }

        public static void ConfigureResolver(IAppenderFactory factory, string filepath, HierarchicalResolver resolver)
        {
            var fullpath = Path.GetFullPath(filepath);
            var filecontent = SafeRead(filepath);
            var (r, l, a, c) = LoadFromJson(filecontent);

            FillResolver(factory, resolver, r, l, a);
        }

        private static string SafeRead(string filepath)
        {
            const int numberOfRetries = 3;
            const int delayOnRetry = 1000;

            for (var i = 0; i < numberOfRetries; i++)
            {
                try
                {
                    return File.ReadAllText(filepath);
                }
                catch (IOException)
                {
                    Thread.Sleep(delayOnRetry);
                }
            }

            return null;
        }

        public static ILogManager ConfigureAndWatch(IAppenderFactory factory, string filepath)
        {
            var fullpath = Path.GetFullPath(filepath);
            var filecontent = File.Exists(filepath) ? File.ReadAllText(filepath) : "";
            var (r, l, a, c) = LoadFromJson(filecontent);
            var resolver = new HierarchicalResolver();

            var watcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(fullpath),
                NotifyFilter = NotifyFilters.LastWrite,
                EnableRaisingEvents = true
            };
            watcher.Changed += (sender, args) =>
            {
                if (string.Equals(args.FullPath, fullpath, StringComparison.InvariantCultureIgnoreCase))
                    ConfigureResolver(factory, filepath, resolver);
            };

            FillResolver(factory, resolver, r, l, a);
            return LogManager.Initialize(resolver, c);
        }
    }
}
