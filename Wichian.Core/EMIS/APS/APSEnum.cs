using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 计划排程枚举
    /// </summary>
    public class APSEnum
    {
        /// <summary>
        /// 计划优先模式
        /// </summary>
        public enum PlanPriorityMode
        {
            /// <summary>
            /// 交货期
            /// </summary>
            Deadline,
            /// <summary>
            /// 设备利用率
            /// </summary>
            EquipmentUtilization,
            /// <summary>
            /// 成本
            /// </summary>
            Cost,
            /// <summary>
            /// 生产资源利用率
            /// </summary>
            ResourceUtilization
        }
    }
}
