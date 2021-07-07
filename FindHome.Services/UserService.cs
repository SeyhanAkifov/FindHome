using FindHome.Data;
using FindHome.Services.Arhitecture;

namespace FindHome.Services
{
    public class UserService : IUserService
    {
        private readonly FindHomeDbContext db;

        public UserService(FindHomeDbContext db)
        {
            this.db = db;
        }


    }
}
