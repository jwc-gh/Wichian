using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 生产计划
    /// </summary>
    [Table("aps_plan")]
    [Comment("生产计划信息表")]
    public class Plan : C2Entity//PlanBase
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
