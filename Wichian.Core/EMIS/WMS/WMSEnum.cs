using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.WMS
{
    /*
     库存管理包括物料的存储、收发、使用及计划与控制。
     */
    /// <summary>
    /// 库存类别
    /// </summary>
    enum StorageCategory
    {
        /// <summary>
        /// 价值,如：ABC
        /// </summary>
        Value = 1,
        /// <summary>
        /// 形态，可分为原材料库存、半成品库存、产成品库存
        /// </summary>
        Form = 2,
        /// <summary>
        /// 用途，可分为安全库存、储备库存、在途库存和正常周转库存
        /// </summary>
        Purpose = 3,
        /// <summary>
        /// 需求相关性，可分为独立需求库存和相关需求库存
        /// </summary>
        DemandRelevance = 4
    }
}
