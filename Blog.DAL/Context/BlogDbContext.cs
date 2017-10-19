using Blog.Models.Passage;
using Blog.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace Blog.DAL.Context
{
    public class BlogDbContext:DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //添加数据库连接字符串
            builder.UseSqlServer(@"Server=.;User id=sa;Password=123;Database=BlogDbContext");
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    //添加FluentAPI配置
        //    var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);

        //    foreach(var type in typesToRegister)
        //    {
        //        dynamic configurationInstance = Activator.CreateInstance(type);
        //        builder.ApplyConfiguration(configurationInstance);
        //    }
        //}
        //User相关表
        public DbSet<User> Users { get; set; }

        //Passage相关表

        public DbSet<Passage> Passages { get; set; }

    }
}
