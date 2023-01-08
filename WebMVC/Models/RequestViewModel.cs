namespace WebMVC.Models
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public int IdAsset { get; set; }
        public String PicId { get; set; }
        public String SpecificationReq { get; set; }
        public String Necessary { get; set; } 

        public RequestViewModel()
        {
            
        }

        public RequestViewModel(int id, int idAsset, string picId, string specificationReq, string necessary)
        {
            Id = id;
            IdAsset = idAsset;
            PicId = picId;
            SpecificationReq = specificationReq;
            Necessary = necessary;
        }
    }
}