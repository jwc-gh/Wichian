using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 生产工序
    /// </summary>
    public class Process : ProcessBase
    {
        /// <summary>
        /// 顺序号
        /// </summary>
        public decimal Sequence { get; set; }
    }
}
