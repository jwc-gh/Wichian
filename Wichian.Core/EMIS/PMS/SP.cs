using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.PMS
{
    /// <summary>
    /// 销售计划
    /// </summary>
    public class SP : C2Entity//PlanBase
    {
        /// <summary>
        /// 销售中心
        /// 建议使用组织架构代码
        /// </summary>
        public string SaleCenter { get; set; }
        /// <summary>
        /// 周期类型，年/季/月
        /// </summary>
        public PeriodType PeriodType { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amounts { get; set; }
        /// <summary>
        /// 货币类型
        /// </summary>
        public CurrencyType CurrencyType { get; set; }
    }
}
