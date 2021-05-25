using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.CM
{
    /// <summary>
    /// 常量信息
    /// </summary>
    [Table("cm_constant")]
    [Comment("常量信息表")]
    public class Constant : ConstantBase
    {        
        ///// <summary>
        ///// 父项
        ///// </summary>
        //public Constant Parent { get; set; }
        ///// <summary>
        ///// 子项
        ///// </summary>
        //public List<Constant> Childs { get; set; }
    }
}
