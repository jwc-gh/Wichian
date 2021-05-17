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
    public class Plan : PlanBase
    {
        
    }
}
