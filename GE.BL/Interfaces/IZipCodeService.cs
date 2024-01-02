using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IZipCodeService
    {
        Address GetZipCodeInfo(string zipCode);
    }
}
