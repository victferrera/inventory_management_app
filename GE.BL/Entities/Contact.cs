namespace GE.BL.Entities
{
    public class Contact
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public Contact()
        {
            Id = Guid.NewGuid();
        }
    }
}
