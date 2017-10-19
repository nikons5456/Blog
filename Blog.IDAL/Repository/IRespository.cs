using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.IDAL.IRespository
{
    /// <summary>
    /// 
    /// 定义通用仓储接口
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRespository<T>where T:class
    {
        //插入
        void Insert(T t,bool IsSave=true);

        //删除
        void Delete(T t,bool IsSave=true);

        //更新
        void Update(T t, bool IsSave=true);

        //查找
        IEnumerable<T> GetAll(Expression<Func<T,bool>> expression);
    }
}
