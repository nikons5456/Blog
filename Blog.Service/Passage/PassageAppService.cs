using Blog.IDAL.Repository.Passage;
using Blog.IDAL.Repository.Passage.Dto.Passage;
using System.Collections.Generic;

namespace Blog.Service.Passage
{
    public class PassageAppService : IPassageAppService
    {
        //定义仓储
        private readonly IPassageRepository _passageRepository;

        public PassageAppService(IPassageRepository passageRepository)
        {
            //依赖注入
            _passageRepository = passageRepository;
        }

        //添加新文章

        public void Add(PassageDto dto, long userId)
        {
            var thePassage = dto.MapTo<Models.Passage.Passage>();
            thePassage.PublishTime = System.DateTime.Now;
            thePassage.LastEditTime = System.DateTime.Now;
            thePassage.UserId = userId;
            _passageRepository.Insert(thePassage);
        }


        //删除
        public void Delete(long passageId)
        {
            var deletedPassage = _passageRepository.GetPassage(passageId);
            _passageRepository.Delete(deletedPassage);
        }

        //根据文章ID获取

        public Models.Passage.Passage GetPassageById(long passageId)
        {
            return _passageRepository.GetPassage(passageId);
        }

        //获取所有文章

        public IList<Models.Passage.Passage> GetAll()
        {
            return _passageRepository.GetAllPassages();
        }

        //通过用户获取文章
        public IList<Models.Passage.Passage> GetAllByUserId(long userId)
        {
            return _passageRepository.GetAllByUserId(userId);
        }

        //更新
        public void Change(Models.Passage.Passage passage)
        {
            _passageRepository.Update(passage);
        }
    }
}
