using Microsoft.EntityFrameworkCore.Migrations;

namespace Trivia.Migrations
{
    public partial class UserAnswerCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_AspNetUsers_UserId1",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_UserId1",
                table: "UserAnswer");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserAnswer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_UserId",
                table: "UserAnswer",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_AspNetUsers_UserId",
                table: "UserAnswer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_AspNetUsers_UserId",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_UserId",
                table: "UserAnswer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserAnswer",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserAnswer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_UserId1",
                table: "UserAnswer",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_AspNetUsers_UserId1",
                table: "UserAnswer",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
