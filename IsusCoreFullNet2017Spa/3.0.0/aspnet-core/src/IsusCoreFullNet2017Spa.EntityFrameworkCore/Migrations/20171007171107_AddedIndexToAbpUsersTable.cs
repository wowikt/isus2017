using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.Migrations
{
    public partial class AddedIndexToAbpUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_IsusUserId",
                table: "AbpUsers",
                newName: "IX_Users_IsusUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Users_IsusUsers",
                table: "AbpUsers",
                newName: "IX_AbpUsers_IsusUserId");
        }
    }
}
