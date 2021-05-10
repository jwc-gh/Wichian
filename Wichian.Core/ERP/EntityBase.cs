using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Wichian.Core.ERP
{
    /// <summary>
    /// 基础实体类
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [Comment("Id主键")]
        public virtual int Id { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        [Comment("编码")]
        public virtual string Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Comment("名称")]
        public virtual string Name { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Comment("创建人")]
        public virtual string Creater { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [Comment("修改人")]
        public string Modifier { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Comment("创建时间")]
        public virtual DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Comment("修改时间")]
        public virtual DateTime ModifyTime { get; set; }
    }
}
