namespace GE.BL.Entities
{
    public class Supplier
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Cnpj { get; private set; }
        public bool Status { get; private set; }
        public Contact Contact { get; private set; }

        public Supplier(string name, string cnpj, bool status, Contact contact)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cnpj = cnpj;
            Status = status;
            Contact = contact;
        }
    }
}
