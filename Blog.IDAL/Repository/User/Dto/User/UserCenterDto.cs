using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.IDAL.Repository.User.Dto.User
{

    /// <summary>
    /// 
    /// 用户编辑信息时的Dto类
    /// 
    /// </summary>
    public class UserCenterDto
    {
        [DisplayName("用户名")]
        [MaxLength(30), Required]
        public string UserName { get; set; }

        [DisplayName("密码")]
        [MaxLength(16), DataType(DataType.Password), Required]
        public string Password { get; set; }

        [DisplayName("邮箱地址")]
        [MaxLength(50), DataType(DataType.EmailAddress), Required]
        public string EmailAddress { get; }
        
        [DisplayName("注册时间")]
        [DataType(DataType.DateTime)]
        public DateTime RegistDate { get; }
    }
}
