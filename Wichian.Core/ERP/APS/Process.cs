using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 生产工序
    /// </summary>
    [Table("aps_process")]
    [Comment("生产工序信息表")]
    public class Process : ProcessBase
    {
        /// <summary>
        /// 顺序号
        /// </summary>
        public decimal Sequence { get; set; }
    }
}
