using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.IDAL.Repository.Passage.Dto.Passage
{
    public class PassageDto
    {

        //标题
        [DisplayName("标题"),Required]
        [MaxLength(300)]
        public string Title { get; set; }

        //描述
        [DisplayName("描述"),Required]
        [MaxLength(500)]
        public string Description { get; set; }

        //内容
        [DisplayName("内容"),Required]
        public string Content { get; set; }
    }
}
