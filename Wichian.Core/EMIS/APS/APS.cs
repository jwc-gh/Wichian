using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wichian.Core.EMIS.APS
{
    public class APS
    {
        /// <summary>
        /// 编辑版本
        /// 增Insert、删Delete、改Update操作均在该版本进行
        /// </summary>
        private List<Job> editplan;
        /// <summary>
        /// 锁定版本
        /// 初始载入Load和确认提交Submit后才更新此版本
        /// </summary>
        private List<Job> fixedplan;

        private List<Job> plans;
        public APS()
        {
            plans = new List<Job>();
        }
        /// <summary>
        /// 载入计划
        /// </summary>
        public virtual void Load()
        {

        }

        /// <summary>
        /// 提交计划
        /// </summary>
        public virtual void Submit()
        {

        }

        /// <summary>
        /// 复制计划
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual Plan Clone(Job item)
        {
            return null;
        }

        /// <summary>
        /// 插入计划
        /// </summary>
        /// <param name="item"></param>
        public virtual void Insert(Job item)
        {

        }
        /// <summary>
        /// 删除计划
        /// </summary>
        /// <param name="item"></param>
        public virtual void Delete(Job item)
        {

        }
        /// <summary>
        /// 更新计划
        /// </summary>
        /// <param name="item"></param>
        public virtual void Update(Job item) { }
        /// <summary>
        /// 重排计划
        /// </summary>
        /// <param name="mode"></param>
        public virtual void Sort(APSEnum.PlanPriorityMode mode= APSEnum.PlanPriorityMode.Deadline) { }
    }
}
