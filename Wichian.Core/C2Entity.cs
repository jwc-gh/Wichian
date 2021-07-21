using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Furion.DatabaseAccessor;
using System.Text.Json.Serialization;

namespace Wichian.Core
{
    /// <summary>
    /// 通用实体类：Id、编码、名称、说明、创建人、修改人、创建时间、修改时间、软删除标记
    /// </summary>
    public abstract class C2Entity : C2Entity<long, MasterDbContextLocator>
    {
    }

    public abstract class C2Entity<TKey> : C2Entity<TKey, MasterDbContextLocator>
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
        where TDbContextLocator4 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
        where TDbContextLocator4 : class, IDbContextLocator
        where TDbContextLocator5 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
        where TDbContextLocator4 : class, IDbContextLocator
        where TDbContextLocator5 : class, IDbContextLocator
        where TDbContextLocator6 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6, TDbContextLocator7> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
        where TDbContextLocator4 : class, IDbContextLocator
        where TDbContextLocator5 : class, IDbContextLocator
        where TDbContextLocator6 : class, IDbContextLocator
        where TDbContextLocator7 : class, IDbContextLocator
    {
    }

    public abstract class C2Entity<TKey, TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6, TDbContextLocator7, TDbContextLocator8> : PrivateC2Entity<TKey>
        where TDbContextLocator1 : class, IDbContextLocator
        where TDbContextLocator2 : class, IDbContextLocator
        where TDbContextLocator3 : class, IDbContextLocator
        where TDbContextLocator4 : class, IDbContextLocator
        where TDbContextLocator5 : class, IDbContextLocator
        where TDbContextLocator6 : class, IDbContextLocator
        where TDbContextLocator7 : class, IDbContextLocator
        where TDbContextLocator8 : class, IDbContextLocator
    {
    }

    /// <summary>
    /// 基础实体类
    /// </summary>
    public abstract class PrivateC2Entity<TKey> : IPrivateEntity
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [Comment("Id主键")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TKey Id { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        [Comment("编码")]
        [Required, MaxLength(50)]
        public virtual string Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Comment("名称")]
        [Required, MaxLength(50)]
        public virtual string Name { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        [Comment("说明")]
        [Required, MaxLength(250)]
        public virtual string Description { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Comment("创建人")]
        public virtual long? CreateId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [Comment("修改人")]
        public virtual long? ModifyId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Comment("创建时间")]
        public virtual DateTimeOffset? CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Comment("修改时间")]
        public virtual DateTimeOffset? ModifyTime { get; set; }
        /// <summary>
        /// 软删除
        /// </summary>
        [JsonIgnore]
        [Comment("软删除标记")]
        public virtual bool IsDeleted { get; set; } = false;
    }
}
