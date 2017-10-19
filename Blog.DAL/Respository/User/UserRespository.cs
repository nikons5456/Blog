using Blog.DAL.Context;
using Blog.IDAL.IRespository.User;
using Blog.IDAL.Repository.User.Dto.User;
using Blog.Models.User;
using System.Linq;

namespace Blog.DAL.Respository.User
{
    public class UserRespository:Respository<Models.User.User>,IUserRespository
    {
        public BlogDbContext _dbContext;

        public UserRespository(BlogDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.User.User GetUser(UserDto input)
        {
            return _dbContext.Users.FirstOrDefault(t => t.EmailAddress == input.EmailAddress && t.Password == input.Password);
        }
    }
}
