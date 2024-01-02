using GE.BL.Entities;
using GE.BL.Interfaces;

namespace GE.Repository.Contacts
{
    public class ContactRepository : IContactRepository
    {
        private List<Contact> _contacts;

        public ContactRepository()
        {
            _contacts = new List<Contact>();
        }
        public void Save(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
