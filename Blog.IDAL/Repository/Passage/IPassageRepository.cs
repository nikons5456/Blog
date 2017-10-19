using Blog.IDAL.IRespository;
using System.Collections.Generic;

namespace Blog.IDAL.Repository.Passage
{
    public interface IPassageRepository:IRespository<Models.Passage.Passage>
    {
        //获取所有文章
        IList<Models.Passage.Passage> GetAllPassages();

        Models.Passage.Passage GetPassage(long passageId);

        IList<Models.Passage.Passage> GetAllByUserId(long userId);
    }
}
