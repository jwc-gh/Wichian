using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core
{
    /// <summary>
    /// 采集器类
    /// </summary>
    public abstract class Collector
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// MAC地址
        /// </summary>
        public string MAC { get; set; }
        /// <summary>
        /// 服务端地址
        /// </summary>
        public string ServiceURI { get; set; }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userid"></param>
        public abstract void Login(string userid);
        /// <summary>
        /// 输入
        /// 条形码/二维码/RFID/IDCard/电子秤
        /// </summary>
        /// <param name="item"></param>
        public abstract void Input(string item);
        /// <summary>
        /// 锁定
        /// </summary>
        public abstract void Lock();
        /// <summary>
        /// 解锁
        /// </summary>
        public abstract void Unlock();
    }
}
