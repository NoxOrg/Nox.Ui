using Microsoft.Extensions.Configuration;
using Nox.Ui.Models;
using System.Numerics;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Nox.Ui.Data
{
    public static class GlobalDefinitionHelper
    {
        public static globalDefinition? GetGlobalDefinition(string inputConfiguration)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var rtn = deserializer.Deserialize<rootDefinition>(inputConfiguration);
            return rtn.globalDefinition;
        }

    }
}

