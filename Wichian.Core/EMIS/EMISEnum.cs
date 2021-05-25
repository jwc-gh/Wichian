using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 枚举类
    /// </summary>
    public class EMISEnum
    {
        /// <summary>
        /// 性别
        /// </summary>
        public enum Gender
        {
            /// <summary>
            /// 未指定
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// 男性
            /// </summary>
            Male = 1,
            /// <summary>
            /// 女性
            /// </summary>
            Female = 2
        }

        /// <summary>
        /// 行业类型
        /// </summary>
        public enum IndustryType
        {
            /// <summary>
            /// 农业
            /// </summary>
            Agriculture = 10000,
            /// <summary>
            /// 工业
            /// </summary>
            Industry = 20000,
            /// <summary>
            /// 服务业
            /// </summary>
            ServiceIndustry = 30000
        }
    }
}
