using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wichian.Core.EMIS;
namespace Wichian.Core.Textile.MES
{
    public class ProductionRecord : C1Entity
    {
        /// <summary>
        /// 工人编号
        /// </summary>
        public string WorkerCode { get; set; }
        /// <summary>
        /// 工人姓名
        /// </summary>
        public string WorkerName { get; set; }
        /// <summary>
        /// 工序编码
        /// </summary>
        public string ProcessCode { get; set; }
        /// <summary>
        /// 工序名称
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// 发生日期
        /// </summary>
        public DateTime OccurrenceDate { get; set; }
        /// <summary>
        /// 生产任务单号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 色组编码
        /// </summary>
        public string ComboCode { get; set; }
        /// <summary>
        /// 色组名称
        /// </summary>
        public string ComboName { get; set; }
        /// <summary>
        /// 尺寸编码
        /// </summary>
        public string SizeCode { get; set; }
        /// <summary>
        /// 尺寸名称
        /// </summary>
        public string SizeName { get; set; }
        /// <summary>
        /// 牌号
        /// </summary>
        public string TagNo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
