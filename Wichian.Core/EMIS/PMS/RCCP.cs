using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.PMS
{
    /// <summary>
    /// 粗能力计划
    /// </summary>
    public class RCCP : C2Entity//PlanBase
    {
        /// <summary>
        /// 工作中心
        /// 建议使用组织架构代码
        /// </summary>
        public string WorkCenter { get; set; }
    }
}
