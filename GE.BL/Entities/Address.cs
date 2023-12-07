namespace GE.BL.Entities
{
    public record Address(Guid Id, string ZipCode, string Street, string Neighborhood, string City, string State, int HouseNumber);
}
