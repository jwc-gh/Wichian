using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础工序类
    /// </summary>
    public abstract class ProcessBase : C2Entity
    {
        /// <summary>
        /// 类型
        /// </summary>
        public virtual int Type { get; set; }
        /// <summary>
        /// 用时
        /// </summary>
        public virtual decimal Time { get; set; }
    }
}
