using GE.BL.Interfaces;

namespace GE.Services.Addresss
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public List<string> GetStateList()
        {
            return _addressRepository.GetStatesList();
        }
    }
}
