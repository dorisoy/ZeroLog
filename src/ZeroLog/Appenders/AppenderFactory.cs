﻿using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZeroLog.Config;

namespace ZeroLog.Appenders
{
    public class AppenderFactory
    {
        public static IAppender CreateAppender(AppenderDefinition definition)
        {
            var appenderType = GetAppenderType(definition) ?? throw new InvalidOperationException($"Appender type not found: {definition.AppenderTypeName}");

            var appender = (IAppender)Activator.CreateInstance(appenderType)!;
            appender.Name = definition.Name;

            var appenderParameterType = GetAppenderParameterType(appenderType);
            if (appenderParameterType != null)
            {
                var appenderParameters = GetAppenderParameters(definition, appenderParameterType);

                var configureMethod = appenderType.GetMethod(nameof(IAppender<object>.Configure), new[] { appenderParameterType });
                configureMethod?.Invoke(appender, new[] { appenderParameters });
            }

            return appender;
        }

        private static Type? GetAppenderType(AppenderDefinition definition)
        {
            if (string.IsNullOrEmpty(definition.AppenderTypeName))
                return null;

            // Check if we have an assembly-qualified name of a type
            if (definition.AppenderTypeName!.Contains(","))
                return Type.GetType(definition.AppenderTypeName, true, false);

            return AppDomain.CurrentDomain.GetAssemblies()
                            .Select(x => x.GetType(definition.AppenderTypeName))
                            .FirstOrDefault(x => x != null);
        }

        internal static object? GetAppenderParameters(AppenderDefinition definition, Type appenderParameterType)
        {
            switch (definition.AppenderJsonConfig)
            {
                case null:
                    return null;

                case JObject jObject:
                    var json = jObject.ToString(Formatting.None);
                    return JsonConvert.DeserializeObject(json, appenderParameterType);

                case object obj:
                    return appenderParameterType.IsInstanceOfType(obj)
                        ? obj
                        : null;
            }
        }

        private static Type? GetAppenderParameterType(Type? appenderType)
        {
            if (appenderType is null)
                return null;

            var implementedInterfaceTypes = appenderType.GetInterfaces();

            foreach (var interfaceType in implementedInterfaceTypes)
            {
                if (interfaceType.IsGenericType && interfaceType.GetGenericTypeDefinition() == typeof(IAppender<>))
                    return interfaceType.GetGenericArguments()[0];
            }

            return null;
        }
    }
}
