using Microsoft.Extensions.Configuration;
using Nox.Ui.Models;
using YamlDotNet.Serialization;

namespace Nox.Ui.Data
{
    public static class PageDefinitionHelper
    {
        public static List<pageDefinition>? GetPageDefinitions(string inputConfiguration)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var rtn = deserializer.Deserialize<rootDefinition>(inputConfiguration);
            return rtn.pageDefinition;
        }

        public static pageDefinition? GetSpecificPageDefinition(string inputConfiguration, string pageId)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var deserialized = deserializer.Deserialize<rootDefinition>(inputConfiguration).pageDefinition;

            if (deserialized != null)
            {
                if (String.IsNullOrWhiteSpace(pageId))
                {
                    var rtnDefault = deserialized.FirstOrDefault(x => x.isDefault = true);
                    if (rtnDefault != null)
                    {
                        return rtnDefault;
                    }
                }
                else
                {
                    var rtn = deserialized.FirstOrDefault(x => x.pageId.ToLower().Trim() == pageId.ToLower().Trim());
                    if (rtn != null)
                    {
                        return rtn;
                    }
                }
            }           

            return null;
        }

    }
}

