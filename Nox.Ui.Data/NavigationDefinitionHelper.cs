using Microsoft.Extensions.Configuration;
using Nox.Ui.Models;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Nox.Ui.Data
{
    public static class NavigationDefinitionHelper
    {
        public static List<navigationDefinition>? GetNavigationDefinitions(string inputConfiguration)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var rtn = deserializer.Deserialize<rootDefinition>(inputConfiguration);
            return rtn.navigationDefinition;
        }
    }
}

