using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 基础物料类
    /// </summary>
    public abstract class MaterielBase : C2Entity
    {
        /// <summary>
        /// 品种规格
        /// </summary>
        [Comment("品种规格")]
        public virtual string Norm { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        [Comment("型号")]
        public virtual string Model { get; set; }
    }
}
