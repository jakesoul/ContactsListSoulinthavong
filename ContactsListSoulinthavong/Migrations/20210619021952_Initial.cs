using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsListSoulinthavong.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "imarquezlopez@bankerstrust.com", "Iridian", "Lopez", 5151234567L });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, "jsoulinthavong@yahoo.com", "Jason", "Soulinthavong", 5159876543L });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3, "nellie.soul@gmail.com", "Penelope", "Soulinthavong", 5150001111L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
