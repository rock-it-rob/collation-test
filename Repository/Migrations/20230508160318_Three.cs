using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_person_first_name_last_name",
                table: "person");

            migrationBuilder.RenameColumn(
                name: "deleted",
                table: "person",
                newName: "active");

            migrationBuilder.CreateIndex(
                name: "ix_person_first_name_last_name",
                table: "person",
                columns: new[] { "first_name", "last_name" },
                unique: true,
                filter: "active");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_person_first_name_last_name",
                table: "person");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "person",
                newName: "deleted");

            migrationBuilder.CreateIndex(
                name: "ix_person_first_name_last_name",
                table: "person",
                columns: new[] { "first_name", "last_name" },
                unique: true,
                filter: "not deleted");
        }
    }
}
