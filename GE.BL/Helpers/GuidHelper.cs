using GE.BL.Exceptions;
using GE.BL.Messages;

namespace GE.BL.Helpers
{
    public static class GuidHelper
    {
        public static Guid TryParse(string guid)
        {
            try
            {
                return Guid.Parse(guid);
            }catch(ArgumentNullException)
            {
                throw new GuidParseException(ErrorMessages.argumentNull);
            }catch(FormatException)
            {
                throw new GuidParseException(ErrorMessages.invalidFormat);
            }
        }
    }
}
