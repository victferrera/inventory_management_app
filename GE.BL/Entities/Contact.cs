namespace GE.BL.Entities
{
    public class Contact
    {
        public Guid Id { get; private set; }
        public Address Address { get; private set; }
        public string Email { get; private set; }
        public string Phone1 { get; private set; }
        public string Phone2 { get; private set; }

        public Contact(Address address, string email, string phone1, string phone2)
        {
            Id = Guid.NewGuid();
            Address = address;
            Email = email;
            Phone1 = phone1;
            Phone2 = phone2;
        }
    }
}
