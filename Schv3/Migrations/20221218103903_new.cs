using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schv3.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_8Class",
                table: "Schedules",
                newName: "Id_8ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_7Class",
                table: "Schedules",
                newName: "Id_7ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_6Class",
                table: "Schedules",
                newName: "Id_6ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_5Class",
                table: "Schedules",
                newName: "Id_5ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_4Class",
                table: "Schedules",
                newName: "Id_4ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_3Class",
                table: "Schedules",
                newName: "Id_3ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_2Class",
                table: "Schedules",
                newName: "Id_2ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_1Class",
                table: "Schedules",
                newName: "Id_1ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_1ClassId",
                table: "Schedules",
                column: "Id_1ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_2ClassId",
                table: "Schedules",
                column: "Id_2ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_3ClassId",
                table: "Schedules",
                column: "Id_3ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_4ClassId",
                table: "Schedules",
                column: "Id_4ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_5ClassId",
                table: "Schedules",
                column: "Id_5ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_6ClassId",
                table: "Schedules",
                column: "Id_6ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_7ClassId",
                table: "Schedules",
                column: "Id_7ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_8ClassId",
                table: "Schedules",
                column: "Id_8ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_1ClassId",
                table: "Schedules",
                column: "Id_1ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_2ClassId",
                table: "Schedules",
                column: "Id_2ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_3ClassId",
                table: "Schedules",
                column: "Id_3ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_4ClassId",
                table: "Schedules",
                column: "Id_4ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_5ClassId",
                table: "Schedules",
                column: "Id_5ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_6ClassId",
                table: "Schedules",
                column: "Id_6ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_7ClassId",
                table: "Schedules",
                column: "Id_7ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_8ClassId",
                table: "Schedules",
                column: "Id_8ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_1ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_2ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_3ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_4ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_5ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_6ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_7ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_8ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_1ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_2ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_3ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_4ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_5ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_6ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_7ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_8ClassId",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "Id_8ClassId",
                table: "Schedules",
                newName: "Id_8Class");

            migrationBuilder.RenameColumn(
                name: "Id_7ClassId",
                table: "Schedules",
                newName: "Id_7Class");

            migrationBuilder.RenameColumn(
                name: "Id_6ClassId",
                table: "Schedules",
                newName: "Id_6Class");

            migrationBuilder.RenameColumn(
                name: "Id_5ClassId",
                table: "Schedules",
                newName: "Id_5Class");

            migrationBuilder.RenameColumn(
                name: "Id_4ClassId",
                table: "Schedules",
                newName: "Id_4Class");

            migrationBuilder.RenameColumn(
                name: "Id_3ClassId",
                table: "Schedules",
                newName: "Id_3Class");

            migrationBuilder.RenameColumn(
                name: "Id_2ClassId",
                table: "Schedules",
                newName: "Id_2Class");

            migrationBuilder.RenameColumn(
                name: "Id_1ClassId",
                table: "Schedules",
                newName: "Id_1Class");
        }
    }
}
