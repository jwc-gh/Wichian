using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础法人团体类
    /// </summary>
    public class CorporationBase : C2Entity
    {
        /// <summary>
        /// 行业
        /// </summary>
        public IndustryType IndustryType { get; set; }
        /// <summary>
        /// 业务范围
        /// </summary>
        public string BusinessScope { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContractDetails { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
