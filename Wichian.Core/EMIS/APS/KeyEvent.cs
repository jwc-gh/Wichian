using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 关键事件
    /// </summary>
    [Table("aps_keyevent")]
    [Comment("关键事件信息表")]
    public class KeyEvent : C2Entity
    {
    }
}
