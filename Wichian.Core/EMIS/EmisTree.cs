using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS
{
    /// <summary>
    /// 树型
    /// </summary>
    public class EmisTree : EmisEntity
    {
        /// <summary>
        /// 父节点
        /// </summary>
        public long ParentObjID { get; set; }
        /// <summary>
        /// 节点层级
        /// </summary>
        public int NodeLevel { get; set; }
        /// <summary>
        /// 节点顺序号
        /// </summary>
        public int TreeSON { get; set; }
        /// <summary>
        /// 扩展关系类型
        /// 1-库位关系
        /// 2-物品关系
        /// 3-库位与物品关系
        /// </summary>
        public int ExtType { get; set; }
    }
}
