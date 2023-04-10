using webanthuc.Entity;
using webanthuc.Request;

namespace webanthuc.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly MyDbContext _context;
        public ContactRepository(MyDbContext context) {
            _context = context;
        }
        async Task<int> IContactRepository.CreateAsync(AddAddress address, int id)
        {
            var city = new City()
            {
                Name = address.city,
            };
            _context.Add(city);
            await _context.SaveChangesAsync();
            var district = new District()
            {
                Name = address.district,
                id_City = city.Id,

            };
            _context.Add(district);
            await _context.SaveChangesAsync();

            var ward = new Ward()
            {
                Name = address.ward,
                id_District = district.Id,

            };
            _context.Add(ward);
            await _context.SaveChangesAsync();

            var contact = new Contact()
            {
                Name = address.address,
                id_Ward = ward.Id,

            };
            _context.Add(contact);
            await _context.SaveChangesAsync();

            var detail_contact = new detailContact()
            {
                id_Contact = contact.Id,
                id_Restaurant1 = id,
            };
            _context.Add(detail_contact);
            await _context.SaveChangesAsync();
            return id;
        }
    }
}
