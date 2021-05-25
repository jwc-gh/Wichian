using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.OMS
{
    /// <summary>
    /// 订单管理枚举类
    /// </summary>
    public class OMSEnum
    {
        /// <summary>
        /// 生产类型
        /// </summary>
        public enum ProductionType
        {
            /// <summary>
            /// Make To Stock - 现货生产
            /// </summary>
            MTS,
            /// <summary>
            /// Make To Order - 订货生产
            /// </summary>
            MTO,
            /// <summary>
            /// Assemble To Order - 订货组装
            /// </summary>
            ATO,
            /// <summary>
            /// Engineer To Order - 工程生产
            /// </summary>
            ETO
        }
    }
}
