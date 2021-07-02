using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 列表
    /// </summary>
    public class EmisList : EmisEntity
    {
        /// <summary>
        /// 分组
        /// </summary>
        public String Group { get; set; }
        /// <summary>
        /// 组内项编码
        /// </summary>
        public string GroupItemCode { get; set; }
        /// <summary>
        /// 组内项名称
        /// </summary>
        public string GroupItemName { get; set; }
        /// <summary>
        /// 组内项值
        /// </summary>
        public string GroupItemValue { get; set; }
        /// <summary>
        /// 组内项顺序
        /// SON - Sort Order No.
        /// </summary>
        public int GroupItemSON { get; set; }
        /// <summary>
        /// 组内项类型
        /// </summary>
        public ListItemType GroupItemType { get; set; }
    }

    public enum ListItemType
    {

    }
}
