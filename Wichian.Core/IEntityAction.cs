using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core
{
    public interface IEntityAction
    {
        /// <summary>
        /// 新增
        /// </summary>
        void InsertItem();
        /// <summary>
        /// 删除
        /// </summary>
        void DeleteItem();
        /// <summary>
        /// 修改
        /// </summary>
        void UpdateItem();
        /// <summary>
        /// 获取单项
        /// </summary>
        /// <returns></returns>
        object GetItem(long id);
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <returns></returns>
        object GetSet();
    }
}
