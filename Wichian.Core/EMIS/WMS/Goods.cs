using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.WMS
{
    /// <summary>
    /// 货物
    /// </summary>
    class Goods
    {
        /// <summary>
        /// 重量
        /// </summary>
        [Column(TypeName = ("decimal(18,4)"))]
        Decimal Weight { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Column(TypeName = ("decimal(18,4)"))]
        Decimal Quantity { get; set; }
        /// <summary>
        /// 容量/体积
        /// </summary>
        [Column(TypeName = ("decimal(18,4)"))]
        Decimal Volume { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        [Column(TypeName = ("decimal(18,2)"))]
        Decimal Length { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        [Column(TypeName = ("decimal(18,2)"))]
        Decimal Width { get; set; }
        /// <summary>
        /// 高度
        /// </summary>
        [Column(TypeName = ("decimal(18,2)"))]
        Decimal Height { get; set; }
    }
}
