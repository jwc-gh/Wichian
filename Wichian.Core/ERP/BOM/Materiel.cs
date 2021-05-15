using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wichian.Core.ERP.BOM
{
    /// <summary>
    /// 清单物料
    /// </summary>
    [Table("bom_materiel")]
    [Comment("物料信息表")]
    public class Materiel : MaterielBase
    {
    }
}
