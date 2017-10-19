using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Passage
{
    /// <summary>
    /// 文章表
    /// 
    /// 作用：保存文章内容
    /// </summary>
    public class Passage
    {
        //文章编号(主键)
        [Key]
        public long Id{ get; set; }

        //作者编号
        public long UserId { get; set; }

        //标题
        [MaxLength(300)]
        public string Title { get; set; }

        //描述
        [MaxLength(500)]
        public string Description { get; set; }

        //内容
        public string Content { get; set;}

        //发布时间
        [DataType(DataType.DateTime)]
        public DateTime PublishTime { get; set; }

        //最后编辑时间
        [DataType(DataType.DateTime)]
        public DateTime LastEditTime { get; set; }

        //评论权限
        //public bool CommentPermission { get; set; }
    }
}
