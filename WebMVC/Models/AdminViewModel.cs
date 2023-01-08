namespace WebMVC.Models{

    public class AdminViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Role { get; set; }
        public String Email { get; set; }
        public int IdAudit { get; set; }

        public AdminViewModel()
        {
        }

        public AdminViewModel(int id, string name, int role, string email, int idAudit)
        {
            Id = id;
            Name = name;
            Role = role;
            Email = email;
            IdAudit = idAudit;
        }
    }
}