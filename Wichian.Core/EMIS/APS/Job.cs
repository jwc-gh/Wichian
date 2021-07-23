using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 生产任务单
    /// </summary>
    [Table("aps_job")]
    [Comment("生产任务单信息表")]
    public class Job : C2Entity//JobBase
    {
        /// <summary>
        /// 生产订单
        /// </summary>
        public virtual Order Order { get; set; }
        /// <summary>
        /// 生产工序流程
        /// </summary>
        public virtual ProcessFlow ProcessFlow { get; set; }
    }
}
