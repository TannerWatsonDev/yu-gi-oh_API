using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YuGiOhApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCardNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Cards");
        }
    }
}
