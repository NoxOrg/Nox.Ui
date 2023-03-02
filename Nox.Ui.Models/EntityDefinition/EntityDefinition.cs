namespace Nox.Ui.Models
{
    public class entityDefinition
    {
        public string name { get; set; }

        public string description { get; set; }

        public string pluralName { get; set; }

        public List<entityAttributeDefinition> attributes { get; set; }
    }
}