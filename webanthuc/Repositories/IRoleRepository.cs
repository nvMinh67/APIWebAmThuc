namespace webanthuc.Repositories
{
    public interface IRoleRepository
    {
        Task<string> createRole (string roleName);
    }
}
