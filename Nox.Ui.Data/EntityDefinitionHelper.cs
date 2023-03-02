using Microsoft.Extensions.Configuration;
using Nox.Ui.Models;
using System.Numerics;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Nox.Ui.Data
{
    public static class EntityDefinitionHelper
    {
        public static entityDefinition? GetEntityDefinition(string inputConfiguration)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var rtn = deserializer.Deserialize<entityDefinition>(inputConfiguration);
            return rtn;
        }
    }
}

