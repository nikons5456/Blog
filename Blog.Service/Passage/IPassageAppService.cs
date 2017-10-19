using Blog.IDAL.Repository.Passage.Dto.Passage;
using System.Collections.Generic;

namespace Blog.Service.Passage
{

    /// <summary>
    /// 
    /// Passage服务接口
    /// 
    /// </summary>
    public interface IPassageAppService
    {

        void Add(PassageDto dto,long userId);

        void Change(Models.Passage.Passage passage);

        void Delete(long passageId);

        Models.Passage.Passage GetPassageById(long passageId);

        IList<Models.Passage.Passage> GetAll();

        IList<Models.Passage.Passage> GetAllByUserId(long userId);
    }
}
