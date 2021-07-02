using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
namespace Wichian.Core.EMIS
{
    public class EmisEntity : IEntity
    {
        /// <summary>
        /// 标识
        /// </summary>
        [Key]
        [Column("ObjectID")]
        [Display(Name="标识")]
        public virtual long ObjectID { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        [Column("Code")]
        [Display(Name = "编码")]
        public virtual string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Column("Name")]
        [Display(Name = "名称")]
        public virtual string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Column("Desc")]
        [Display(Name = "描述")]
        public virtual string Desc { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [Column("CreatedUser")]
        [Display(Name = "创建者")]
        public string CreatedUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("CreatedTime")]
        [Display(Name = "创建时间")]
        public DateTimeOffset CreatedTime { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        [Column("ModifiedUser")]
        [Display(Name = "修改者")]
        public string ModifiedUser { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("ModifiedTime")]
        [Display(Name = "修改时间")]
        public DateTimeOffset ModifiedTime { get; set; }
    }
}
