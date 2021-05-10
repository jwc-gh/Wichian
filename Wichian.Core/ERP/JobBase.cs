using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.ERP
{
    /// <summary>
    /// 基础任务单类
    /// </summary>
    public abstract class JobBase : EntityBase
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [Comment("开始时间")]
        public virtual DateTime StartTime { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        [Comment("完成时间")]
        public virtual DateTime FinishTime { get; set; }
    }
}
