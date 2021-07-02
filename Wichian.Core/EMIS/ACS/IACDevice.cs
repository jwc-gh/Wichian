using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 访问控制系统(AccessControl System)
/// </summary>
namespace Wichian.Core.EMIS.ACS
{
    /// <summary>
    /// 门禁设备
    /// </summary>
    interface IACDevice
    {
        /// <summary>
        /// 开启
        /// </summary>
        void Open();
        /// <summary>
        /// 关闭
        /// </summary>
        void Close();
        /// <summary>
        /// 挂起/锁死
        /// </summary>
        void Hang();
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="fPara"></param>
        /// <returns></returns>
        int Verify(String fPara);

        /// <summary>
        /// 计算滞留时间
        /// </summary>
        void Caculate();
        /// <summary>
        /// 报警
        /// </summary>
        /// <returns></returns>
        int Alarm();
    }
}
