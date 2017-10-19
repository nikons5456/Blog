using Blog.IDAL.IRespository.User;
using Blog.IDAL.Repository.User.Dto.User;

namespace Blog.Service.User
{
    /// <summary>
    /// 
    /// 用户服务实现
    /// 
    /// </summary>
    public class UserAppService : IUserAppService
    {
        public readonly  IUserRespository _userRepository;
        
        //依赖注入
        
        public UserAppService(IUserRespository userRepository)
        {
            _userRepository = userRepository;
        }
        public Models.User.User Login(UserDto input)
        {
            var res = _userRepository.GetUser(input);
            return res;
        }
    }
}
