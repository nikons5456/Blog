using Blog.DAL.Context;
using Blog.IDAL.IRespository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.DAL.Respository
{
    public class Respository<T> : IRespository<T> where T : class
    {    /// <summary>
         /// 
         /// 实体仓库
         /// 
         /// </summary>
            private readonly BlogDbContext _context;
            private DbSet<T> _entities;

            #region 构造函数
            public Respository(BlogDbContext context)
            {
                _context = context;
            }
            #endregion

            #region 属性
            protected virtual DbSet<T> Entities
            {
                get
                {
                    if (_entities == null)
                    {
                        _entities = _context.Set<T>();
                    }
                    return _entities;
                }
            }

            public virtual IQueryable<T> Table
            {
                get
                {
                    return Entities;
                }
            }
            #endregion


            #region 增删改查

            //删除
            public void Delete(T entity, bool IsSave = true)
            {
                if (entity == null) throw new NotImplementedException("未赋值实体");

                this._context.Remove(entity);

                if (IsSave == true)
                {
                   this._context.SaveChanges();
                }
            }

            //Linq查询
            public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate) => this.Table.Where(predicate);


            //添加
            public void Insert(T entity, bool IsSave = true)
            {
                if (entity == null) throw new NotImplementedException("未赋值实体");

                this._context.Add(entity);
                if (IsSave)
                {
                  this._context.SaveChanges();
                }
            }

            //更新
            public void Update(T entity, bool IsSave = true)
            {
                if (entity == null) throw new NotImplementedException("实体为空");
                this._context.Update<T>(entity);

                if (IsSave)
                {
                  this._context.SaveChanges();
                }
            }
            #endregion
        }
}
