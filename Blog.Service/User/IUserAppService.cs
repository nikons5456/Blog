using Blog.IDAL.Repository.User.Dto.User;

namespace Blog.Service.User
{
    /// <summary>
    /// 
    /// 定义用户服务接口
    /// 
    /// </summary>
    public interface IUserAppService
    {
        //登陆 
        Models.User.User Login(UserDto input);
    }
}
