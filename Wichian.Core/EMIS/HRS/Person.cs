using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.HRS
{
    public class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        DateTime Birthdate { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        int Sex { get; set; }
    }
}
