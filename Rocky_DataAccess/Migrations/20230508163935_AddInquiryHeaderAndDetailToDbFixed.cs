using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky_DataAccess.Migrations
{
    public partial class AddInquiryHeaderAndDetailToDbFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InquiryData",
                table: "InquiryHeader",
                newName: "InquiryDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InquiryDate",
                table: "InquiryHeader",
                newName: "InquiryData");
        }
    }
}
