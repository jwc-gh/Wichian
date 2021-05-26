using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础日历类
    /// </summary>
    public abstract class CalendarBase : C1Entity
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [Comment("开始日期")]
        public virtual DateTime BeginDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        [Comment("结束日期")]
        public virtual DateTime EndDate { get; set; }
    }
}
