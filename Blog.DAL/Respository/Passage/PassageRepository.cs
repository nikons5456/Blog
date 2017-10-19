using Blog.IDAL.Repository.Passage;
using Blog.DAL.Context;
using System.Collections.Generic;
using System.Linq;
using Blog.Models.Passage;

namespace Blog.DAL.Respository.Passage
{
    /// <summary>
    /// 
    /// Passage仓储
    /// 
    /// </summary>
    public class PassageRepository : Respository<Models.Passage.Passage>,IPassageRepository
    {      
        private readonly BlogDbContext _dbContext;
        //构造函数
        public PassageRepository(BlogDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public IList<Models.Passage.Passage> GetAllByUserId(long userId)
        {
            return _dbContext.Passages.Where(t => t.UserId == userId).ToList() ;
        }

        public IList<Models.Passage.Passage> GetAllPassages()
        {
            return _dbContext.Passages.ToList();
        }

        public Models.Passage.Passage GetPassage(long passageId)
        {
            return _dbContext.Passages.FirstOrDefault(t => t.Id == passageId);
        }

    }
}
