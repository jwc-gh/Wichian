using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.PMS
{
    /// <summary>
    /// 主生产计划
    /// </summary>
    public class MPS : PlanBase
    {
        /// <summary>
        /// 工作中心
        /// 建议使用组织架构代码
        /// </summary>
        public string WorkCenter { get; set; }
        /// <summary>
        /// 产品
        /// 建议使用产品代码
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// 周期类型，年/季/月
        /// </summary>
        public PeriodType PeriodType { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
