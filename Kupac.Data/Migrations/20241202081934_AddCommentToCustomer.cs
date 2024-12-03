using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kupac.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Customer");
        }
    }
}
