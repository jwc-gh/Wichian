using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 生产工序流程
    /// </summary>
    [Table("aps_processflow")]
    [Comment("生产工序流程信息表")]
    public class ProcessFlow : C1Entity
    {
        /// <summary>
        /// 工序集合
        /// </summary>
        public virtual List<Process> Processes { get; set; }
    }
}
