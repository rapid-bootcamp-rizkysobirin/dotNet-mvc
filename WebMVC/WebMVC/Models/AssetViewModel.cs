namespace WebMVC.Models;

public class AssetViewModel
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Specification { get; set; }
    public String SerialNumber { get; set; }
    public int PurchaseYear { get; set; }

    public AssetViewModel()
    {
    }

    public AssetViewModel(int id, string name, string specification, string serialNumber, int purchaseYear)
    {
        Id = id;
        Name = name;
        Specification = specification;
        SerialNumber = serialNumber;
        PurchaseYear = purchaseYear;
    }
}