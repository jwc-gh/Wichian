using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 生产工序流程
    /// </summary>
    public class ProcessFlow
    {
        /// <summary>
        /// 工序集合
        /// </summary>
        public virtual List<Process> Processes { get; set; }
    }
}
