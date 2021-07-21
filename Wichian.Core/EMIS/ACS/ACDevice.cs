using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.ACS
{
    /// <summary>
    /// 访问控制设备
    /// </summary>
    public class ACDevice : EmisEntity
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        public int ACDType { get; set; }
        /// <summary>
        /// 设备状态
        /// </summary>
        public int ACDState { get; set; }
    }
}
