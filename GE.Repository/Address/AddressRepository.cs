using GE.BL.Interfaces;

namespace GE.Repository.Addresss
{
    public class AddressRepository : IAddressRepository
    {
        private readonly List<string>_states;

        public AddressRepository()
        {
            _states = new List<string>() 
            { 
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR",
                "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            };
        }
        public List<string> GetStatesList()
        {
            return _states;
        }
    }
}
