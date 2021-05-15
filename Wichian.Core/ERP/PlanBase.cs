using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.ERP
{
    /// <summary>
    /// 基础计划类
    /// </summary>
    public abstract class PlanBase : C2Entity
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [Comment("开始日期")]
        public virtual DateTime BeginDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        [Comment("结束日期")]
        public virtual DateTime EndDate { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        [Comment("说明")]
        public virtual string Description { get; set; }

        /// <summary>
        /// 子计划集合
        /// </summary>
        public virtual List<PlanBase> Plans { get; set; }
        /// <summary>
        /// 人员集合
        /// </summary>
        public virtual List<PersonBase> Staffs { get; set; }
        /// <summary>
        /// 工序集合
        /// </summary>
        public virtual List<ProcessBase> Processes { get; set; }
        /// <summary>
        /// 设备集合
        /// </summary>
        public virtual List<EquipmentBase> Equipments { get; set; }
        /// <summary>
        /// 物料集合
        /// </summary>
        public virtual List<MaterielBase> Materiels { get; set; }
    }
}
