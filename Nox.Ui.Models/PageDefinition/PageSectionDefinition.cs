namespace Nox.Ui.Models
{
    public class pageSectionDefinition
    {
        public string name { get; set; }

        public pageSectionType type { get; set; }

        public int orderId { get; set; }

        public List<entityDefinition> controlDefinitions { get; set; }
    }
}