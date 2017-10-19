using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.IDAL.Repository.User.Dto.User
{
    /// <summary>
    /// 
    /// 登陆时，传向前台的Dto类型
    /// 
    /// </summary>
    public class UserDto
    {
        [DisplayName("邮箱地址"), Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [DisplayName("密码"),Required]
        [MaxLength(16)]
        public string Password { get; set; }
    }
}
