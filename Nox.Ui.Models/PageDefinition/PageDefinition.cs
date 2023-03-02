namespace Nox.Ui.Models
{
    public class pageDefinition
    {
        public string name { get; set; }
        public string pageId { get; set; }
        public  bool isDefault { get; set; }
        public List<pageSectionDefinition> pageSections { get; set; }   
    }
}