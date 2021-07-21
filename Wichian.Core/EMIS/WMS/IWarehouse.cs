using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.WMS
{
    public interface IWarehouse
    {
        /// <summary>
        /// 入库
        /// </summary>
        void Input();
        /// <summary>
        /// 出库
        /// </summary>
        void Output();
        /// <summary>
        /// 移库
        /// </summary>
        void Move();
        /// <summary>
        /// 库存初始化
        /// </summary>
        void Init();
        /// <summary>
        /// 库存盘点
        /// </summary>
        void Inventory();
        /// <summary>
        /// 库存修正
        /// </summary>
        void Modify();
    }
}
