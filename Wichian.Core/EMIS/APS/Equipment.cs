using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 生产设备
    /// </summary>
    [Table("aps_equipment")]
    [Comment("生产设备信息表")]
    public class Equipment : EquipmentBase
    {
    }
}
