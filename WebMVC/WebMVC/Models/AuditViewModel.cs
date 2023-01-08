namespace WebMVC.Models
{
    public class AudiViewModel
    {
        public int Id { get; set; }
        public int IdAsset { get; set; }
        public bool AntiVirus { get; set; }
        public bool WindowsLicense { get; set; }
        public String Condition { get; set; }
        public String Validation { get;set; }

        public AudiViewModel()
        {
        }

        public AudiViewModel(int id, int idAsset, bool antiVirus, bool windowsLicense, string condition, string validation)
        {
            Id = id;
            IdAsset = idAsset;
            AntiVirus = antiVirus;
            WindowsLicense = windowsLicense;
            Condition = condition;
            Validation = validation;
        }
    }
    
    
}

