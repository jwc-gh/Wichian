using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础人员类
    /// </summary>
    public abstract class PersonBase : C2Entity
    {
        /// <summary>
        /// 居民身份证号,Resident identification number
        /// </summary>
        public string RIM { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public decimal Height { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public decimal Weight { get; set; }
    }
}
