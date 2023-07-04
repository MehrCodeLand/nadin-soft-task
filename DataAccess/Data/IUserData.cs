using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task AddUser(User user);
        Task<IList<User>> GetAllUser();
        void DeleteUser(int id);
    }
}