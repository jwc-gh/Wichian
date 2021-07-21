using System;
using System.Collections.Generic;
using System.Text;

namespace SR.Ext
{
    /// <summary>
    /// 钉钉平台
    /// </summary>
    public class DingTalk
    {
        private String cCorpId = "ding28c4a2840834d261ee0f45d8e4f7c288";
        /// <summary>
        /// 企业唯一标识CorpId
        /// </summary>
        public String CorpId {
            get { return cCorpId; }
            set { cCorpId = value; }
        }

        private String cAppId;
        /// <summary>
        /// 应用唯一标识AppId
        /// </summary>
        public String AppId
        {
            get { return cAppId; }
            set { cAppId = value; }
        }

        private String cAppSecret;
        /// <summary>
        /// 个人应用AppSecret
        /// </summary>
        public String AppSecret
        {
            get { return cAppSecret; }
            set { cAppSecret = value; }
        }

        private String cUserId;
        /// <summary>
        /// 企业内每个员工都有唯一的UserId，创建后不可修改。
        /// </summary>
        public String UserId
        {
            get { return cUserId; }
            set { cUserId = value; }
        }

        private String cUnionId;
        /// <summary>
        /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变。
        /// </summary>
        public String UnionId
        {
            get { return cUnionId; }
            set { cUnionId = value; }
        }
    }
}
