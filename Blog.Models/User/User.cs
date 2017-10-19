using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.User
{

    /// <summary>
    /// 用户类
    /// 
    /// 作用：保存用户信息，所有用户共用
    /// 
    /// </summary>
    //public enum Type
    //{
    //    Visitor, Normal
    //};

    public class User
    {
        //用户编号(自增长主键)
        [Key]
        public long UserId { get; set; }

        //用户名(必填项)
        [MaxLength(30),Required]
        public string UserName { get; set; }

        //密码(必填项)
        [MaxLength(16),DataType(DataType.Password),Required]
        public string Password { get; set; }

        //电子邮箱(必填项)
        [MaxLength(50),DataType(DataType.EmailAddress),Required]
        public string EmailAddress { get; set; }

        //是否认证
        //public Type  UserType  { get; set; }

        //注册时间
        [DataType(DataType.DateTime)]
        public DateTime RegistDate { get; set; }
}
}
