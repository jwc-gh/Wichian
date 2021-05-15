using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wichian.Database.Migrations.Migrations
{
    public partial class v012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aps_calendar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记"),
                    BeginDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "开始日期"),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "结束日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_calendar", x => x.Id);
                },
                comment: "日历表");

            migrationBuilder.CreateTable(
                name: "aps_keyevent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_keyevent", x => x.Id);
                },
                comment: "关键事件信息表");

            migrationBuilder.CreateTable(
                name: "aps_order",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记"),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false, comment: "数量"),
                    Deadline = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "交期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_order", x => x.Id);
                },
                comment: "生产订单信息表");

            migrationBuilder.CreateTable(
                name: "aps_processflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_processflow", x => x.Id);
                },
                comment: "生产工序流程信息表");

            migrationBuilder.CreateTable(
                name: "PlanBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    BeginDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "开始日期"),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "结束日期"),
                    Description = table.Column<string>(type: "TEXT", nullable: true, comment: "说明"),
                    PlanBaseId = table.Column<long>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanBase_PlanBase_PlanBaseId",
                        column: x => x.PlanBaseId,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "生产计划信息表");

            migrationBuilder.CreateTable(
                name: "ProductionRecord",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    WorkerCode = table.Column<string>(type: "TEXT", nullable: true),
                    WorkerName = table.Column<string>(type: "TEXT", nullable: true),
                    ProcessCode = table.Column<string>(type: "TEXT", nullable: true),
                    ProcessName = table.Column<string>(type: "TEXT", nullable: true),
                    OccurrenceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JobNo = table.Column<string>(type: "TEXT", nullable: true),
                    ComboCode = table.Column<string>(type: "TEXT", nullable: true),
                    ComboName = table.Column<string>(type: "TEXT", nullable: true),
                    SizeCode = table.Column<string>(type: "TEXT", nullable: true),
                    SizeName = table.Column<string>(type: "TEXT", nullable: true),
                    TagNo = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    Remark = table.Column<string>(type: "TEXT", nullable: true),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aps_job",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    OrderId = table.Column<long>(type: "INTEGER", nullable: true),
                    ProcessFlowId = table.Column<long>(type: "INTEGER", nullable: true),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记"),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "开始时间"),
                    FinishTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "完成时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_job_aps_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "aps_order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_aps_job_aps_processflow_ProcessFlowId",
                        column: x => x.ProcessFlowId,
                        principalTable: "aps_processflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "生产任务单信息表");

            migrationBuilder.CreateTable(
                name: "aps_plan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_plan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_plan_PlanBase_Id",
                        column: x => x.Id,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "生产计划信息表");

            migrationBuilder.CreateTable(
                name: "EquipmentBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    PlanBaseId = table.Column<long>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentBase_PlanBase_PlanBaseId",
                        column: x => x.PlanBaseId,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "生产设备信息表");

            migrationBuilder.CreateTable(
                name: "MaterielBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    Norm = table.Column<string>(type: "TEXT", nullable: true, comment: "品种规格"),
                    Model = table.Column<string>(type: "TEXT", nullable: true, comment: "型号"),
                    PlanBaseId = table.Column<long>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterielBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterielBase_PlanBase_PlanBaseId",
                        column: x => x.PlanBaseId,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "物料生产计划信息表");

            migrationBuilder.CreateTable(
                name: "PersonBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    PlanBaseId = table.Column<long>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonBase_PlanBase_PlanBaseId",
                        column: x => x.PlanBaseId,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "工人信息表");

            migrationBuilder.CreateTable(
                name: "ProcessBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    QRCode = table.Column<string>(type: "TEXT", nullable: true),
                    RFIDCode = table.Column<string>(type: "TEXT", nullable: true),
                    IDCardCode = table.Column<string>(type: "TEXT", nullable: true),
                    PlanBaseId = table.Column<long>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "名称"),
                    CreateId = table.Column<long>(type: "INTEGER", nullable: true, comment: "创建人"),
                    ModifyId = table.Column<long>(type: "INTEGER", nullable: true, comment: "修改人"),
                    CreateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "创建时间"),
                    ModifyTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "修改时间"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessBase_PlanBase_PlanBaseId",
                        column: x => x.PlanBaseId,
                        principalTable: "PlanBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "生产工序信息表");

            migrationBuilder.CreateTable(
                name: "aps_equipment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_equipment_EquipmentBase_Id",
                        column: x => x.Id,
                        principalTable: "EquipmentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "生产设备信息表");

            migrationBuilder.CreateTable(
                name: "aps_materiel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    Type = table.Column<int>(type: "INTEGER", nullable: false, comment: "物料类型"),
                    Loss = table.Column<bool>(type: "INTEGER", nullable: false, comment: "损耗品标记"),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false, comment: "数量"),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false, comment: "重量"),
                    EffectiveDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "生效日期"),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "失效日期"),
                    Substitute = table.Column<string>(type: "TEXT", nullable: true, comment: "替代物")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_materiel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_materiel_MaterielBase_Id",
                        column: x => x.Id,
                        principalTable: "MaterielBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "物料生产计划信息表");

            migrationBuilder.CreateTable(
                name: "aps_worker",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_worker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_worker_PersonBase_Id",
                        column: x => x.Id,
                        principalTable: "PersonBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "工人信息表");

            migrationBuilder.CreateTable(
                name: "aps_process",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键"),
                    Sequence = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProcessFlowId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aps_process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aps_process_aps_processflow_ProcessFlowId",
                        column: x => x.ProcessFlowId,
                        principalTable: "aps_processflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_aps_process_ProcessBase_Id",
                        column: x => x.Id,
                        principalTable: "ProcessBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "生产工序信息表");

            migrationBuilder.CreateIndex(
                name: "IX_aps_job_OrderId",
                table: "aps_job",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_aps_job_ProcessFlowId",
                table: "aps_job",
                column: "ProcessFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_aps_process_ProcessFlowId",
                table: "aps_process",
                column: "ProcessFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentBase_PlanBaseId",
                table: "EquipmentBase",
                column: "PlanBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterielBase_PlanBaseId",
                table: "MaterielBase",
                column: "PlanBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBase_PlanBaseId",
                table: "PersonBase",
                column: "PlanBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanBase_PlanBaseId",
                table: "PlanBase",
                column: "PlanBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessBase_PlanBaseId",
                table: "ProcessBase",
                column: "PlanBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aps_calendar");

            migrationBuilder.DropTable(
                name: "aps_equipment");

            migrationBuilder.DropTable(
                name: "aps_job");

            migrationBuilder.DropTable(
                name: "aps_keyevent");

            migrationBuilder.DropTable(
                name: "aps_materiel");

            migrationBuilder.DropTable(
                name: "aps_plan");

            migrationBuilder.DropTable(
                name: "aps_process");

            migrationBuilder.DropTable(
                name: "aps_worker");

            migrationBuilder.DropTable(
                name: "ProductionRecord");

            migrationBuilder.DropTable(
                name: "EquipmentBase");

            migrationBuilder.DropTable(
                name: "aps_order");

            migrationBuilder.DropTable(
                name: "MaterielBase");

            migrationBuilder.DropTable(
                name: "aps_processflow");

            migrationBuilder.DropTable(
                name: "ProcessBase");

            migrationBuilder.DropTable(
                name: "PersonBase");

            migrationBuilder.DropTable(
                name: "PlanBase");
        }
    }
}
