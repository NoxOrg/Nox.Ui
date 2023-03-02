namespace Nox.Ui.Models
{
    public class entityAttributeDefinition
    {
        public string name { get; set; }
        public string description { get; set; }
        public  bool isPrimaryKey { get; set; }
        public entityAttributeType type { get; set; }
        public bool canFilter { get; set; }
        public bool canSort { get; set; }
        public bool isRequired { get; set; }
        public int minWidth { get; set; }
        public int maxWidth { get; set; }
        public bool isUnicode { get; set; }
        public int precision { get; set; }
    }
}