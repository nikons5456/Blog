using Blog.IDAL.Repository.User.Dto.User;

namespace Blog.IDAL.IRespository.User
{
    public interface IUserRespository : IRespository<Models.User.User>
    {
       Models.User.User GetUser(UserDto input);
    }
}
