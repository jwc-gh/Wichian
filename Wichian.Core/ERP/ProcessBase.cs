using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wichian.Core.ERP
{
    /// <summary>
    /// 基础工序类
    /// </summary>
    public abstract class ProcessBase : EntityBase
    {
        /// <summary>
        /// 类型
        /// </summary>
        public virtual int Type { get; set; }
        /// <summary>
        /// 条形码值
        /// </summary>
        public virtual string Barcode { get; set; }
        /// <summary>
        /// 二维码值
        /// </summary>
        public virtual string QRCode { get; set; }
        /// <summary>
        /// RFID值
        /// </summary>
        public virtual string RFIDCode { get; set; }
        /// <summary>
        /// IDCard值
        /// </summary>
        public virtual string IDCardCode { get; set; }
    }
}
