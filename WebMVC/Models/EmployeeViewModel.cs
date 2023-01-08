namespace WebMVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Position { get; set; }
        public String Email { get; set; }
        public String Number { get; set; }
        public String Address { get; set; }

        public EmployeeViewModel(int id, string name, string position, string email, string number, string address)
        {
            Id = id;
            Name = name;
            Position = position;
            Email = email;
            Number = number;
            Address = address;
        }

        public EmployeeViewModel()
        {
        }
    }
}
