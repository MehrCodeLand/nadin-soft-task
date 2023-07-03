
using DataAccess.DbCon;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class UserData
    {
        private readonly MyDb _db;
        public UserData(MyDb db)
        {
            _db = db;
        }

        public void AddUser(User user)
        {
            var result = ValidateAddUser(user);

            if(result == 100)
            {
                _db.Users.Add(user);
                Save();
            }
        }

        private int ValidateAddUser(User user)
        {
            // some validate 
            return 0;
        }
        private void Save()
        {
            _db.SaveChanges();  
        }
    }
}
