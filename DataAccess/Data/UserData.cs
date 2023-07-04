
using DataAccess.DbCon;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

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


        public void DeleteUser(int id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            _db.Users.Remove(user);
            Save();

        }

        public async Task<IList<User>> GetAllUser()
        {
            return await _db.Users.ToListAsync();
        }

        #region private Method

        private async Task Save()
        {
            await _db.SaveChangesAsync();
        }


    	#endregion
    }
}
