﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.EMIS.APS
{
    /// <summary>
    /// 工人
    /// </summary>
    [Table("aps_worker")]
    [Comment("工人信息表")]
    public class Worker : C2Entity//PersonBase
    {
    }
}
