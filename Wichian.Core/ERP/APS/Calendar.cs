using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 日历
    /// </summary>
    [Table("aps_calendar")]
    [Comment("日历表")]
    public class Calendar : CalendarBase
    {
    }
}
