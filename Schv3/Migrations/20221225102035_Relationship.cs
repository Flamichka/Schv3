using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schv3.Migrations
{
    /// <inheritdoc />
    public partial class Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_teacher",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Group_Code",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "Id_Teacher",
                table: "Classes",
                newName: "Id_TeacherId");

            migrationBuilder.RenameColumn(
                name: "Id_Subject",
                table: "Classes",
                newName: "Id_SubjectId");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Teachers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Groups",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SubjectId",
                table: "Teachers",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ClassId",
                table: "Groups",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Id_SubjectId",
                table: "Classes",
                column: "Id_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Id_TeacherId",
                table: "Classes",
                column: "Id_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Subjects_Id_SubjectId",
                table: "Classes",
                column: "Id_SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_Id_TeacherId",
                table: "Classes",
                column: "Id_TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Subjects_Id_SubjectId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_Id_TeacherId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SubjectId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ClassId",
                table: "Groups");
            
            migrationBuilder.DropIndex(
                name: "IX_Classes_Id_SubjectId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Id_TeacherId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "Id_TeacherId",
                table: "Classes",
                newName: "Id_Teacher");

            migrationBuilder.RenameColumn(
                name: "Id_SubjectId",
                table: "Classes",
                newName: "Id_Subject");

            migrationBuilder.AddColumn<int>(
                name: "Id_teacher",
                table: "Subjects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Group_Code",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
