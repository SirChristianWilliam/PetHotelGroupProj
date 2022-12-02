using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetbakery.Migrations
{
    /// <inheritdoc />
    public partial class fixEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "PetOwners",
                newName: "emailAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "emailAddress",
                table: "PetOwners",
                newName: "email");
        }
    }
}
