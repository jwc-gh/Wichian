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
    public class CalendarBase : C1Entity
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [Comment("开始时间")]
        public virtual DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [Comment("结束时间")]
        public virtual DateTime EndTime { get; set; }
    }
}
