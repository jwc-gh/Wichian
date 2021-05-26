using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.MES
{
    /// <summary>
    /// 生产工序
    /// </summary>
    public class Process : ProcessBase
    {
        /// <summary>
        /// 状态
        /// 0-启用
        /// 1-停用
        /// </summary>
        public virtual int State { get; set; }
        /// <summary>
        /// 分组类型
        /// 0-个人计件
        /// 1-分组计件/集体计件
        /// </summary>
        public virtual int GroupType { get; set; }
        /// <summary>
        /// 计薪类型
        /// -1-未指定
        /// 0-不计薪
        /// 1-计数量
        /// 2-计重量
        /// 3-计时间
        /// </summary>
        public virtual int SalaryType { get; set; }
        /// <summary>
        /// 计价类型
        /// -1-未指定
        /// 0-不计价
        /// 1-
        /// </summary>
        public virtual int PriceType { get; set; }
        /// <summary>
        /// 控制模式
        /// -1-未指定
        /// 0-不限制
        /// 1-控制数量
        /// 2-控制重量
        /// 4-控制时间
        /// </summary>
        public virtual int ControlMode { get; set; }
        /// <summary>
        /// 标准数量
        /// </summary>
        public virtual decimal StdQuantity { get; set; }
        /// <summary>
        /// 标准重量
        /// </summary>
        public virtual decimal StdWeight { get; set; }
        /// <summary>
        /// 标准时间
        /// </summary>
        public virtual decimal StdTime { get; set; }
    }
}
