using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 物料生产计划
    /// </summary>
    public class Materiel : MaterielBase
    {
        /// <summary>
        /// 物料类型
        /// </summary>
        [Comment("物料类型")]
        public int Type { get; set; }
        /// <summary>
        /// 损耗品标记
        /// </summary>
        [Comment("损耗品标记")]
        public bool Loss { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Comment("数量")]
        public int Quantity { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        [Comment("重量")]
        public decimal Weight { get; set; }
        /// <summary>
        /// 子物料集合
        /// </summary>
        public List<Materiel> Materials;
        /// <summary>
        /// 生效日期
        /// </summary>
        [Comment("生效日期")]
        public DateTime EffectiveDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        [Comment("失效日期")]
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// 替代物
        /// </summary>
        [Comment("替代物")]
        public string Substitute { get; set; }
    }
}
