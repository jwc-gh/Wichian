using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础常量类
    /// </summary>
    public class ConstantBase : C2Entity
    {
        /// <summary>
        /// 分组
        /// </summary>
        [Comment("分组")]
        public virtual string Group { get; set; }
    }
}
