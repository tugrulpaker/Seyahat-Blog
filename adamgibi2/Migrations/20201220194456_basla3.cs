﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace adamgibi2.Migrations
{
    public partial class basla3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Blogs_BlogID",
                table: "Yorumlars");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Yorumlars",
                newName: "Blogid");

            migrationBuilder.RenameIndex(
                name: "IX_Yorumlars_BlogID",
                table: "Yorumlars",
                newName: "IX_Yorumlars_Blogid");

            migrationBuilder.AlterColumn<int>(
                name: "Blogid",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Blogs_Blogid",
                table: "Yorumlars",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Blogs_Blogid",
                table: "Yorumlars");

            migrationBuilder.RenameColumn(
                name: "Blogid",
                table: "Yorumlars",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Yorumlars_Blogid",
                table: "Yorumlars",
                newName: "IX_Yorumlars_BlogID");

            migrationBuilder.AlterColumn<int>(
                name: "BlogID",
                table: "Yorumlars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Blogs_BlogID",
                table: "Yorumlars",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
