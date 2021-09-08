namespace Demo3.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public override string ToString() => $"{FirstName} {LastName}: {Phone}";
    }
}