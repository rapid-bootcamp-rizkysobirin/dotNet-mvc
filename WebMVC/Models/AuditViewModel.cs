namespace WebMVC.Models
{
    public class AuditViewModel
    {
        public int Id { get; set; }
        public int IdAsset { get; set; }
        public bool AntiVirus { get; set; }
        public bool WindowsLicense { get; set; }
        public bool OfficeLicense { get; set; }
        public String Condition { get; set; }
        public String Validation { get;set; }

        public AuditViewModel()
        {
        }

        public AuditViewModel(int id, int idAsset, bool antiVirus, bool windowsLicense, bool officeLicense, string condition, string validation)
        {
            Id = id;
            IdAsset = idAsset;
            AntiVirus = antiVirus;
            WindowsLicense = windowsLicense;
            OfficeLicense = officeLicense;
            Condition = condition;
            Validation = validation;
        }
    }
    
    
}

