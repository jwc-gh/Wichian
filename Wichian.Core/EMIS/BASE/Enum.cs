using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 未指定
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 男性
        /// </summary>
        Male = 1,
        /// <summary>
        /// 女性
        /// </summary>
        Female = 2
    }
    /// <summary>
    /// 行业类型
    /// </summary>
    public enum IndustryType
    {
        /// <summary>
        /// 农业
        /// </summary>
        Agriculture = 10000,
        /// <summary>
        /// 工业
        /// </summary>
        Industry = 20000,
        /// <summary>
        /// 服务业
        /// </summary>
        ServiceIndustry = 30000
    }
    /// <summary>
    /// 计划类型
    /// </summary>
    public enum PlanType
    {
        /// <summary>
        /// 销售计划
        /// Sales Plan
        /// </summary>
        SP,
        /// <summary>
        /// 主生产计划
        /// Master Production Schedule
        /// </summary>
        MPS,
        /// <summary>
        /// 粗能力计划
        /// Rough-cut Capacity Planning
        /// </summary>
        RCCP,
        /// <summary>
        /// 物料需求计划
        /// Material Requirements Planning
        /// </summary>
        MRP,
        /// <summary>
        /// 能力需求计划 / 细能力计划
        /// Capacity Requirements Planning
        /// </summary>
        CRP
    }
    /// <summary>
    /// 周期类型
    /// </summary>
    public enum PeriodType
    {
        /// <summary>
        /// 年
        /// </summary>
        Year,
        /// <summary>
        /// 季
        /// </summary>
        Season,
        /// <summary>
        /// 月
        /// </summary>
        Month,
        /// <summary>
        /// 周
        /// </summary>
        Week,
        /// <summary>
        /// 日
        /// </summary>
        Day,
        /// <summary>
        /// 时
        /// </summary>
        Hour,
        /// <summary>
        /// 分
        /// </summary>
        Minute
    }
    /// <summary>
    /// 货币类型
    /// </summary>
    public enum CurrencyType
    {
        /// <summary>
        /// 美元
        /// </summary>
        USD,
        /// <summary>
        /// 人民币
        /// </summary>
        CNY,
        /// <summary>
        /// 港币
        /// </summary>
        HKD,
        /// <summary>
        /// 英镑
        /// </summary>
        CBP,
        /// <summary>
        /// 欧元
        /// </summary>
        EUR
    }
    /// <summary>
    /// 资产类型
    /// </summary>
    public enum AssetType
    {
        /// <summary>
        /// 固定资产
        /// </summary>
        Fixed,
        /// <summary>
        /// 无形资产
        /// </summary>
        Intangible,
        /// <summary>
        /// 流动资产
        /// </summary>
        Flow
    }

    #region APS
    /// <summary>
    /// 计划优先模式
    /// </summary>
    public enum PlanPriorityMode
    {
        /// <summary>
        /// 交货期
        /// </summary>
        Deadline,
        /// <summary>
        /// 设备利用率
        /// </summary>
        EquipmentUtilization,
        /// <summary>
        /// 成本
        /// </summary>
        Cost,
        /// <summary>
        /// 生产资源利用率
        /// </summary>
        ResourceUtilization
    }
    #endregion

    #region OMS
    /// <summary>
    /// 生产类型
    /// </summary>
    public enum ProductionType
    {
        /// <summary>
        /// Make To Stock - 现货生产
        /// </summary>
        MTS,
        /// <summary>
        /// Make To Order - 订货生产
        /// </summary>
        MTO,
        /// <summary>
        /// Assemble To Order - 订货组装
        /// </summary>
        ATO,
        /// <summary>
        /// Engineer To Order - 工程生产
        /// </summary>
        ETO
    }
    #endregion
}
