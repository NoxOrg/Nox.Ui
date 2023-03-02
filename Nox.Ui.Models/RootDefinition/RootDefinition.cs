namespace Nox.Ui.Models
{
    public class rootDefinition //used to safely ingest sections of yaml config
    {
        public globalDefinition? globalDefinition { get; set; }
        public List<navigationDefinition>? navigationDefinition { get; set; }
        public List<pageDefinition>? pageDefinition { get; set; }
    }
}