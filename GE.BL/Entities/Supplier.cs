namespace GE.BL.Entities
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public bool Status { get; set; }
        public Contact Contact { get; set; }

        public Supplier()
        {
            Id = Guid.NewGuid();
        }
    }
}
