using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhatsappApi.Migrations
{
    /// <inheritdoc />
    public partial class removeuniquecontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Messages_Content",
                table: "Messages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Messages_Content",
                table: "Messages",
                column: "Content",
                unique: true);
        }
    }
}
