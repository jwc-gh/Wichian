using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.ACS
{
    /// <summary>
    /// 车辆
    /// </summary>
    public class Vehicle : EmisEntity
    {
        /// <summary>
        /// 车辆类型
        /// </summary>
        public int VehicleType { get; set; }
        /// <summary>
        /// 车辆状态
        /// </summary>
        public int VehicleState { get; set; }
        /// <summary>
        /// 车牌号
        /// Car License Plate Number
        /// </summary>
        public String CarPLNo { get; set; }
        /// <summary>
        /// 车辆角色
        /// </summary>
        int VehicleRole { get; set; }
        /// <summary>
        /// 车辆品牌
        /// </summary>
        String VehicleBrand { get; set; }
    }
}
