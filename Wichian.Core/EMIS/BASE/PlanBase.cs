using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础计划类
    /// </summary>
    public class PlanBase : C2Entity
    {
        /// <summary>
        /// 计划类型
        /// </summary>
        public virtual PlanType PlanType { get; set; }

        
    }
}
