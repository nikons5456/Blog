#使用说明

## 开发工具 ##

Vs2017 Community

SqlServer2017 Development

##操作说明

* 修改 `Blog.DAL-BlogDbContext.cs` 文件中OnConfiguring重载函数中数据库配置,以及 `Blog.Web-appsetting.json` 数据库配置

* 修改 `Blog.DAL-SeedData.cs` (初始化用户),默认用户 `123@qq.com` 密码 `123`

* 主页展示所有文章

* 写文章按钮登陆之后才能操作，使用Markdown语法

* 点击用户名进入文章管理中心，选择相关文章，点进去，进行操作
