using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task AddUser(User user);
    }
}