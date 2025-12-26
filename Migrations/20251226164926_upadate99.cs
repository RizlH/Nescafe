using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nescafe.Migrations
{
    /// <inheritdoc />
    public partial class upadate99 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Members_memberId",
                table: "Balances");

            migrationBuilder.DropIndex(
                name: "IX_Balances_memberId",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "memberId",
                table: "Balances");

            migrationBuilder.RenameColumn(
                name: "updateOn",
                table: "Balances",
                newName: "UpdateOn");

            migrationBuilder.RenameColumn(
                name: "transactionName",
                table: "Balances",
                newName: "TransactionName");

            migrationBuilder.RenameColumn(
                name: "flow",
                table: "Balances",
                newName: "Flow");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Balances",
                newName: "Amount");

            migrationBuilder.AddColumn<decimal>(
                name: "AdminFee",
                table: "Savings",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedOn",
                table: "Savings",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Savings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DueDate",
                table: "Savings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Savings",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KkPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KtpPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SlipGajiPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Savings",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MemberCode",
                table: "Balances",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminFee",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "ApprovedOn",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "KkPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "KtpPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "SlipGajiPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "MemberCode",
                table: "Balances");

            migrationBuilder.RenameColumn(
                name: "UpdateOn",
                table: "Balances",
                newName: "updateOn");

            migrationBuilder.RenameColumn(
                name: "TransactionName",
                table: "Balances",
                newName: "transactionName");

            migrationBuilder.RenameColumn(
                name: "Flow",
                table: "Balances",
                newName: "flow");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Balances",
                newName: "amount");

            migrationBuilder.AddColumn<int>(
                name: "memberId",
                table: "Balances",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Balances_memberId",
                table: "Balances",
                column: "memberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_Members_memberId",
                table: "Balances",
                column: "memberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
