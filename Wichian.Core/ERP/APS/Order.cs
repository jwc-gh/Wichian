using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.ERP.APS
{
    /// <summary>
    /// 生产订单
    /// </summary>
    [Table("aps_order")]
    [Comment("生产订单信息表")]
    public class Order : OrderBase
    {        
    }
}
