using Blog.DAL.Context;
using Blog.Models.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Blog.DAL
{
    public static class SeedData
    {
        /// <summary>
        /// 
        /// 配置Seed
        /// 
        /// </summary>
        public static void Initialize(IServiceProvider app)
        {
            var _dbContext= app.GetRequiredService<BlogDbContext>();

            //如果已经有数据就直接返回
            if (_dbContext.Users.Any())
            {
                return;
            }

            try {
                //添加User Seed
                _dbContext.Users.Add(new User { UserName = "Niko", Password = "123", EmailAddress = "123@qq.com",  RegistDate = System.DateTime.Now });


                _dbContext.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }


        }
    }
}
