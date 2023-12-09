using System.Text.Json.Serialization;

namespace GE.BL.Entities
{
    public class Address
    {
        public Guid Id { get; set; }

        [JsonPropertyName("cep")]
        public string ZipCode { get; set; }
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
        [JsonPropertyName("bairro")]
        public string Neighborhood { get; set; }
        [JsonPropertyName("localidade")]
        public string City { get; set; }
        [JsonPropertyName("uf")]
        public string State { get; set; }
        public int HouseNumber { get; set; }

        public Address(string zipCode, string street, string neighborhood, string city, string state, int houseNumber)
        {
            Id = Guid.NewGuid();
            ZipCode = zipCode;
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            HouseNumber = houseNumber;
        }
    }
}
