using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Collations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:CollationDefinition:uca-strength-primary", "en-u-ks-level1,en-u-ks-level1,icu,False");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "person",
                type: "text",
                nullable: false,
                collation: "uca-strength-primary",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "person",
                type: "text",
                nullable: false,
                collation: "uca-strength-primary",
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:CollationDefinition:uca-strength-primary", "en-u-ks-level1,en-u-ks-level1,icu,False");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldCollation: "uca-strength-primary");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldCollation: "uca-strength-primary");
        }
    }
}
