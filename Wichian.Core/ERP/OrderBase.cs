using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.ERP
{
    /// <summary>
    /// 基础订单类
    /// </summary>
    public abstract class OrderBase : EntityBase
    {
        /// <summary>
        /// 数量
        /// </summary>
        [Comment("数量")]
        public virtual int Quantity { get; set; }
        /// <summary>
        /// 交期
        /// </summary>
        [Comment("交期")]
        public virtual DateTime Deadline { get; set; }
    }
}
