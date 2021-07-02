using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.ACS
{
    /// <summary>
    /// 访问控制对象
    /// </summary>
    public class ACObject : EmisEntity
    {
        /// <summary>
        /// 对象类型
        /// </summary>
        public int ACOType { get; set; }
        /// <summary>
        /// 对象状态
        /// </summary>
        public int ACOState { get; set; }
        /// <summary>
        /// 规则---扩展从表
        /// </summary>
        public string ACRule { get; set; }
        #region 车对象
        #endregion

        #region 卡对象
        #endregion

        #region 人对象
        /// <summary>
        /// 账号
        /// </summary>
        public String Account { get; set; }
        /// <summary>
        /// 指纹
        /// </summary>
        public String Fingerprint { get; set; }
        /// <summary>
        /// 声纹
        /// </summary>
        public String Voiceprint { get; set; }
        /// <summary>
        /// 人脸图像
        /// </summary>
        public String Facemage { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }
        #endregion
    }
}
