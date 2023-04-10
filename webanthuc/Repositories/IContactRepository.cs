using webanthuc.Request;

namespace webanthuc.Repositories
{
    public interface IContactRepository
    {
       Task<int> CreateAsync(AddAddress address,int id);
    }
}
