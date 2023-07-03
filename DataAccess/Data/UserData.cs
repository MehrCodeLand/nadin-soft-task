
using DataAccess.DbCon;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly MyDb _db;
        public UserData(MyDb db)
        {
            _db = db;
        }

        public Task AddUser(User user)
        {
            _db.Users.AddAsync(user);
            return Save();
        }
        private async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
