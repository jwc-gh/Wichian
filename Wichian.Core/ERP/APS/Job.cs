using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 生产任务单
    /// </summary>
    public class Job : JobBase
    {
        /// <summary>
        /// 生产订单
        /// </summary>
        public virtual Order Order { get; set; }
        /// <summary>
        /// 生产工序流程
        /// </summary>
        public virtual ProcessFlow ProcessFlow { get; set; }
    }
}
