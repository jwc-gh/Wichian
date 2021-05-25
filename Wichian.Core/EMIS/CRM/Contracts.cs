using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.CRM
{
    /// <summary>
    /// 客户联系人信息
    /// </summary>
    public class Contracts : PersonBase
    {
        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 固话号码
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮寄地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
