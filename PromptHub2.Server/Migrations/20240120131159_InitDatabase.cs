using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromptHub2.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    Expires = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedByIp = table.Column<string>(type: "TEXT", nullable: true),
                    Revoked = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RevokedByIp = table.Column<string>(type: "TEXT", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "TEXT", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prompts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Messages = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Tokens = table.Column<uint>(type: "INTEGER", nullable: false),
                    ProjectId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prompts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prompts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prompts_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prompts_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f56ae94b-4f26-4178-88a5-7282628e7be6", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d037c9a-9b01-487c-8716-6917064d4a31", 0, "79586dbb-120d-470f-ba44-2f647680a58e", "Osborne61@hotmail.com", false, false, null, "OSBORNE61@HOTMAIL.COM", "OSBORNE61@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPbh+jbT0TNEl9Uq1tQZnovwMqOXuukqow8Vp8ytTCJjXkHnrvF59ZS2SRgZ2Gu8dQ==", null, false, "570f8db3-b345-44d4-a1e3-ed2290f79c7d", false, "Osborne61@hotmail.com" },
                    { "48dace1e-520d-4ad6-843b-113385672a6f", 0, "27956011-e918-4911-a9d0-2467644f2971", "Dante84@gmail.com", false, false, null, "DANTE84@GMAIL.COM", "DANTE84@GMAIL.COM", "AQAAAAIAAYagAAAAEIBtQjAPnnRFCAsAE2vk8CuHutmCRHqfT8rT6Js8Yp0bT5rkiJ6jmYlcx1cQ8wk3XQ==", null, false, "c2a3aacc-e91d-4c82-a35e-9afa6d4174f9", false, "Dante84@gmail.com" },
                    { "5956c7b1-e8fd-4975-821d-21a99f345031", 0, "4a3df613-c46b-4606-8416-34a44a105015", "Sheridan.Schmitt41@yahoo.com", false, false, null, "SHERIDAN.SCHMITT41@YAHOO.COM", "SHERIDAN.SCHMITT41@YAHOO.COM", "AQAAAAIAAYagAAAAEEBrikqCTvf25Y1psxJUv7GvD7Hk+5mZZ9tEzzcYxQ7O7zTOX3Waz5k+tRY9szuSVg==", null, false, "f5ef306b-8841-4c6b-8bc2-5ba265a5053b", false, "Sheridan.Schmitt41@yahoo.com" },
                    { "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", 0, "94a2fb22-2418-4adc-95ba-8672a36b84ba", "Gustave94@hotmail.com", false, false, null, "GUSTAVE94@HOTMAIL.COM", "GUSTAVE94@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMzscIhi2hl3Wn7neWI+j0+ynfMXm8bfzqZFely5SbOFf28ER0XBOkVcVw/NcUolvQ==", null, false, "e7289d2c-1bb8-4acb-b08e-10a559ccd664", false, "Gustave94@hotmail.com" },
                    { "8f3a233d-e5e6-46a4-aaab-a585076b75b9", 0, "1e8c9d16-886e-4bdb-9a6c-740c88e68e45", "Francesco.Sauer@gmail.com", false, false, null, "FRANCESCO.SAUER@GMAIL.COM", "FRANCESCO.SAUER@GMAIL.COM", "AQAAAAIAAYagAAAAENhl5fsjb20GflfxnZkKlL9FwB4Z4VRAG45HdstRxYwMS/TXPA36rJ6enx6eDjn4lQ==", null, false, "0cbf1a2c-20ac-4bbc-abfa-6a2040eb0562", false, "Francesco.Sauer@gmail.com" },
                    { "90dbe091-1672-47c3-a098-a904b4e107a4", 0, "bd5d2bb7-5a29-4406-b4c2-10082edbbaf8", "Adelle.Morissette@yahoo.com", true, false, null, "ADELLE.MORISSETTE@YAHOO.COM", "ADELLE.MORISSETTE@YAHOO.COM", "AQAAAAIAAYagAAAAECZViHuINk8C3paNIRw0ANNeOVtuVppAF3FLisxM5FOU68K/Toq10IWl/co6PLMuEQ==", null, false, "4139fe77-36d0-478d-8150-572f21f500b2", false, "Adelle.Morissette@yahoo.com" },
                    { "ac381953-c4e6-414b-a10b-30ab9e315221", 0, "f00253db-aa45-40b4-887d-f75e25fee40e", "fi.kwiatkowski@gmail.com", true, false, null, "FI.KWIATKOWSKI@GMAIL.COM", "FI.KWIATKOWSKI@GMAIL.COM", "AQAAAAIAAYagAAAAEBc176SgLSNGPdgqFTdXsAyooM8dIlwuwQ5eMPg/tD6uUW4SnlQ49JTD0Aw7mekMVw==", null, false, "82084d25-538d-4852-8afa-85e7584726b5", false, "fi.kwiatkowski@gmail.com" },
                    { "ba311d54-24d0-4b36-816f-61b1294f4e95", 0, "33bf98b1-be5e-494f-8a7b-ab9468ff4064", "Erica18@gmail.com", true, false, null, "ERICA18@GMAIL.COM", "ERICA18@GMAIL.COM", "AQAAAAIAAYagAAAAECZCm+wIksub2OtCnpakTD+NxDzqZxpqcG0emrFtwqExBjdQ/8LDiObyy53S8RrViw==", null, false, "930bea28-14dd-4c56-acc7-7658020100e1", false, "Erica18@gmail.com" },
                    { "c406ab39-3ac4-4bf3-ae7b-73498494efc2", 0, "330a45c7-2dd7-4578-99df-6e5d2d8ddf8c", "Kennedi_Tillman@gmail.com", false, false, null, "KENNEDI_TILLMAN@GMAIL.COM", "KENNEDI_TILLMAN@GMAIL.COM", "AQAAAAIAAYagAAAAEEj9T/xHsx7hN+pU9iPy8eMpMIJuZVZgeroWnh28naGFcaFBPZTTJgnBgxfVDdoXMA==", null, false, "6cffef8d-8769-4c21-9cbd-d1fb39efd368", false, "Kennedi_Tillman@gmail.com" },
                    { "d225fcb2-59e7-494b-98d6-b76e7238955e", 0, "01d41dfc-e115-43a3-8f94-36a344f8441c", "Retha_Pagac@gmail.com", false, false, null, "RETHA_PAGAC@GMAIL.COM", "RETHA_PAGAC@GMAIL.COM", "AQAAAAIAAYagAAAAENEsHux2qtO1LbO8JF3Aj2YwEB+ZadgkdW6TNVJVyU6dsv3Zup0Mf7ytEEKZkq9BLw==", null, false, "6327b31c-1b18-4074-814d-04410a739d47", false, "Retha_Pagac@gmail.com" },
                    { "da2e60f6-953e-4717-b566-cd7be191d643", 0, "b3776c02-fc42-4999-89dc-319b5cf83b70", "Kamille_Rodriguez@yahoo.com", false, false, null, "KAMILLE_RODRIGUEZ@YAHOO.COM", "KAMILLE_RODRIGUEZ@YAHOO.COM", "AQAAAAIAAYagAAAAEDogtinM7c1wbXFRC1nuAyZZZaPD6f+PyjqlMaZ8M7u7+jl+ubQrAHoMHtohuWMKvQ==", null, false, "1b956b44-626c-4ff8-af4b-61433f9e6d2b", false, "Kamille_Rodriguez@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f56ae94b-4f26-4178-88a5-7282628e7be6", "ac381953-c4e6-414b-a10b-30ab9e315221" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "441af70e-17f9-4258-84ae-9d20b7945d90", new DateTime(2023, 3, 23, 19, 43, 53, 22, DateTimeKind.Unspecified).AddTicks(1473), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Dicta corrupti alias quas at consequatur delectus quod. Est vitae quod ab beatae iure sunt eius et. Eligendi qui consequatur deleniti officia iusto unde id animi fugit. Labore consequatur tempora ut quae modi. Commodi quia perspiciatis quibusdam corrupti b", false, "Voluptate cum sint. Quas quia ab ducimus consequatur omnis voluptatem cumque. Dolore animi alias soluta architecto dolorum velit", new DateTime(2023, 3, 23, 19, 43, 53, 22, DateTimeKind.Unspecified).AddTicks(1473), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "4a9b9a81-8dd6-4ced-9f59-8a505692b977", new DateTime(2022, 8, 23, 0, 22, 9, 949, DateTimeKind.Unspecified).AddTicks(4780), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Necessitatibus non et esse vel quas nihil. Qui fugit hic provident ad. Et voluptates facilis quidem consectetur omnis nulla veniam explicabo. Harum illo molestiae et dolorem cupiditate tempora voluptas.", true, "Magnam incidunt fugiat expedita perferendis optio. Vero numquam aliquid consequatur suscipit beatae praesentium quisquam dolores", new DateTime(2022, 8, 23, 0, 22, 9, 949, DateTimeKind.Unspecified).AddTicks(4780), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "6dc74f3a-8533-4067-b947-8100278d82a2", new DateTime(2023, 2, 24, 11, 3, 18, 399, DateTimeKind.Unspecified).AddTicks(7081), "48dace1e-520d-4ad6-843b-113385672a6f", null, "Eum et est qui sint sunt iure. Unde animi voluptatibus quam quidem. Quia ratione ea officia et quis qui delectus eveniet ullam. Debitis modi sunt saepe voluptatem qui natus. Cum nulla quisquam earum porro minus aut consequatur libero.", false, "Voluptas doloribus corrupti. Et explicabo voluptatem nemo ratione facilis veritatis consequatur. Sapiente rerum repudiandae libe", new DateTime(2023, 2, 24, 11, 3, 18, 399, DateTimeKind.Unspecified).AddTicks(7081), "48dace1e-520d-4ad6-843b-113385672a6f" },
                    { "88ef8443-8f95-4ead-a037-a12f7930332c", new DateTime(2023, 4, 24, 13, 7, 15, 46, DateTimeKind.Unspecified).AddTicks(1080), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Velit ut illum exercitationem quia temporibus autem et aut. Qui sequi dolore. Expedita quam illum sed aut repudiandae natus mollitia dignissimos aperiam. Non veritatis ut adipisci ut quia fugit exercitationem. Cumque provident ex.", false, "Iure et eligendi nemo rerum cupiditate beatae. Ipsa numquam voluptatem nihil voluptas harum nulla. Possimus veritatis assumenda.", new DateTime(2023, 4, 24, 13, 7, 15, 46, DateTimeKind.Unspecified).AddTicks(1080), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "a1c12838-f9d8-4c79-b8fd-fb2dca21be8f", new DateTime(2023, 1, 1, 15, 41, 25, 528, DateTimeKind.Unspecified).AddTicks(6600), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Rerum delectus occaecati natus deleniti ad labore facere nesciunt. Sit consequuntur amet eos quos expedita expedita natus ut. Laborum eaque ipsam quasi iusto sunt. Aspernatur ducimus aut ut et aut. Distinctio aut voluptatem delectus itaque. Veritatis conse", false, "Quasi placeat dolor asperiores et aut et. Aut praesentium minus cupiditate rem quas ullam vitae voluptas ipsa. Placeat cumque de", new DateTime(2023, 1, 1, 15, 41, 25, 528, DateTimeKind.Unspecified).AddTicks(6600), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "a9e5e9fe-c398-4a70-a76e-2beb7e69f035", new DateTime(2023, 3, 22, 0, 28, 10, 308, DateTimeKind.Unspecified).AddTicks(8123), "90dbe091-1672-47c3-a098-a904b4e107a4", null, "Aut eligendi culpa laudantium tenetur animi rerum quidem culpa reprehenderit. Dolor unde et deserunt qui unde illo corporis. Repellat sed hic ut.", true, "Magnam et rerum dolores at nisi aut perspiciatis rerum. Et accusantium unde aspernatur. Omnis voluptatem voluptatum ea debitis u", new DateTime(2023, 3, 22, 0, 28, 10, 308, DateTimeKind.Unspecified).AddTicks(8123), "90dbe091-1672-47c3-a098-a904b4e107a4" },
                    { "ade9d51b-4d7a-4efb-9cd7-ceb70b4ba005", new DateTime(2022, 10, 22, 9, 14, 26, 551, DateTimeKind.Unspecified).AddTicks(4310), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Assumenda facilis recusandae. Eius accusamus sunt unde corporis iste sed quidem. Quas rerum repellat quaerat. Molestiae aliquam fuga tempore cumque provident autem omnis.", true, "Nostrum libero doloremque enim ipsum vero et. Facere est laudantium qui commodi eius dolore maiores non expedita. Ea aut cumque", new DateTime(2022, 10, 22, 9, 14, 26, 551, DateTimeKind.Unspecified).AddTicks(4310), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "aff1ee00-cb61-4fde-8eff-7d52696c7d5b", new DateTime(2023, 6, 19, 2, 24, 43, 496, DateTimeKind.Unspecified).AddTicks(2594), "da2e60f6-953e-4717-b566-cd7be191d643", null, "Nihil fugiat optio veritatis omnis blanditiis. Neque ut est aspernatur molestiae nam quo pariatur. Facilis adipisci eos error. Est ipsum sed accusantium.", false, "Ea et eaque. Debitis omnis odit vitae sed placeat eos. Et repellendus esse doloremque qui ut eius porro. Incidunt itaque vero. S", new DateTime(2023, 6, 19, 2, 24, 43, 496, DateTimeKind.Unspecified).AddTicks(2594), "da2e60f6-953e-4717-b566-cd7be191d643" },
                    { "c25a0a6b-ebd6-4cd0-90d8-6413a0063882", new DateTime(2023, 5, 17, 13, 41, 12, 334, DateTimeKind.Unspecified).AddTicks(9718), "d225fcb2-59e7-494b-98d6-b76e7238955e", null, "Voluptate quia ad ea perspiciatis tenetur. Eius est est sed similique. Exercitationem consequatur fugiat blanditiis animi molestias.", false, "Qui dolor et maiores veritatis sed. Iusto at quia in cum quod. A dignissimos iusto blanditiis impedit occaecati corporis aut rep", new DateTime(2023, 5, 17, 13, 41, 12, 334, DateTimeKind.Unspecified).AddTicks(9718), "d225fcb2-59e7-494b-98d6-b76e7238955e" },
                    { "ef170b5d-85dc-45ff-8c02-6e80217b12f4", new DateTime(2023, 3, 19, 13, 7, 57, 9, DateTimeKind.Unspecified).AddTicks(9473), "3d037c9a-9b01-487c-8716-6917064d4a31", null, "Quam voluptates sed vel maiores laudantium doloribus magnam odio. Occaecati quaerat ut. Ratione id fuga voluptatum vel ut et eos ut. Corporis esse perspiciatis. Aut et maiores delectus qui nulla.", false, "Voluptatem aspernatur deserunt deserunt quod ex molestiae. Veniam totam voluptatem. Vel qui voluptatum ut adipisci deserunt. Qua", new DateTime(2023, 3, 19, 13, 7, 57, 9, DateTimeKind.Unspecified).AddTicks(9473), "3d037c9a-9b01-487c-8716-6917064d4a31" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "0c8e093b-407a-41eb-bd49-0b2c7466b041", new DateTime(2023, 7, 5, 3, 2, 24, 635, DateTimeKind.Unspecified).AddTicks(3146), "3d037c9a-9b01-487c-8716-6917064d4a31", null, "Dolorum quia praesentium similique amet quibusdam iure iste asperiores dolorem. Ut repellat sed. Quae molestiae ut tempore unde eum omnis. Neque nam cum porro ipsam ducimus quod quam autem perspiciatis. Ex ut sunt quod aut sapiente id.", false, "[{\"role\":\"system\",\"content\":\"Odit ut quis non voluptatem vitae sit exercitationem. Cum quas c\"},{\"role\":\"user\",\"content\":\"Natus nulla aliquid qui nisi sequi. Autem omnis et sed iusto dol\"},{\"role\":\"system\",\"content\":\"Et inventore atque. Fuga repellat quia ducimus rerum quidem. Nos\"},{\"role\":\"system\",\"content\":\"Non impedit aut. Hic quia consequuntur porro. Inventore id illo\"}]", "gpt-3.5-trubo", "Officia nihil enim magnam voluptatem eum sed quae aut. Perspiciatis eum excepturi facilis. Pariatur molestiae ut et. Ullam ipsam", "ef170b5d-85dc-45ff-8c02-6e80217b12f4", 8294u, new DateTime(2023, 7, 5, 3, 2, 24, 635, DateTimeKind.Unspecified).AddTicks(3146), "3d037c9a-9b01-487c-8716-6917064d4a31" },
                    { "0e61f2a2-526e-4665-b179-20d15f92926d", new DateTime(2022, 3, 22, 6, 1, 7, 390, DateTimeKind.Unspecified).AddTicks(1480), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Qui est nihil culpa cum quo ea nihil delectus ut. Et eum dolorem inventore in rem error illo qui. Aut quidem eveniet voluptas porro et. Sunt dolores illum possimus totam. Expedita ut nesciunt cupiditate.", false, "[{\"role\":\"system\",\"content\":\"Corporis perferendis qui. Odit sint quibusdam possimus illum rei\"},{\"role\":\"system\",\"content\":\"Rerum iure tempore voluptate nemo minus harum maiores. Deserunt\"}]", "gpt-4", "Explicabo repellat in. Sed ut nobis. Saepe consequatur labore dolorem. Sed saepe cumque cumque dolor et repudiandae quae eum.", "4a9b9a81-8dd6-4ced-9f59-8a505692b977", 7380u, new DateTime(2022, 3, 22, 6, 1, 7, 390, DateTimeKind.Unspecified).AddTicks(1480), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "0f4ceb70-6aa3-40ae-a4e3-e6198e2956b2", new DateTime(2022, 5, 12, 17, 54, 56, 914, DateTimeKind.Unspecified).AddTicks(9594), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Repellat doloremque ut qui. Libero eos labore reiciendis omnis itaque est laborum sit. Autem illum sint explicabo pariatur. Voluptatem sed in minus et. Odit numquam est est delectus laboriosam repellendus qui consequuntur.", false, "[{\"role\":\"system\",\"content\":\"Quis voluptatem enim voluptatum itaque. Id impedit consequatur i\"},{\"role\":\"user\",\"content\":\"Possimus eos molestias consequatur omnis eum quibusdam. Amet ear\"},{\"role\":\"assistant\",\"content\":\"Et id omnis id debitis exercitationem sapiente sint. Occaecati a\"},{\"role\":\"system\",\"content\":\"Sint a aut ratione. Impedit ratione nisi nostrum mollitia blandi\"},{\"role\":\"system\",\"content\":\"Exercitationem dolores est recusandae vel atque. Quia iure vitae\"}]", "gpt-3.5-trubo", "Porro sint quaerat molestiae ut molestiae fugit est eaque. Tempore consequuntur nostrum. Voluptatum non nostrum. Porro repellend", "441af70e-17f9-4258-84ae-9d20b7945d90", 10025u, new DateTime(2022, 5, 12, 17, 54, 56, 914, DateTimeKind.Unspecified).AddTicks(9594), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "0f9d4f43-1a21-4020-a7eb-aa6ead93160c", new DateTime(2023, 3, 11, 16, 47, 26, 595, DateTimeKind.Unspecified).AddTicks(8062), "48dace1e-520d-4ad6-843b-113385672a6f", null, "Nostrum eveniet iure nulla quisquam voluptatibus maxime iusto. Eos possimus sunt. Et et ipsa corrupti placeat tenetur enim. Assumenda quia dolor sed. Facere ut aut iste quasi possimus voluptatibus voluptates dignissimos. Voluptatibus impedit error est aute", true, "[{\"role\":\"system\",\"content\":\"Rem aut asperiores ut est cupiditate et accusantium. Expedita ma\"},{\"role\":\"assistant\",\"content\":\"Rerum modi quo et dolor sit assumenda. Cupiditate ex commodi vol\"},{\"role\":\"system\",\"content\":\"Facere minus voluptatem ut. Quia molestiae eius qui ut. Culpa la\"}]", "gpt-3.5-trubo", "Velit consequatur voluptatem autem ut quas quam. Ipsum est et quo voluptas sequi alias id saepe. Iusto aut voluptatibus. Aliquid", "6dc74f3a-8533-4067-b947-8100278d82a2", 12087u, new DateTime(2023, 3, 11, 16, 47, 26, 595, DateTimeKind.Unspecified).AddTicks(8062), "48dace1e-520d-4ad6-843b-113385672a6f" },
                    { "173f214e-d296-4ae8-af37-c79f798f6cad", new DateTime(2022, 12, 17, 13, 37, 52, 253, DateTimeKind.Unspecified).AddTicks(6515), "d225fcb2-59e7-494b-98d6-b76e7238955e", null, "Aut rerum laborum. Exercitationem mollitia sit eius ut inventore ab excepturi atque. Quod nemo repellendus quasi labore autem et sit. Alias et minus quasi officiis non ex enim.", true, "[{\"role\":\"assistant\",\"content\":\"Veritatis nesciunt voluptatem dolorum quas est distinctio et. Vo\"},{\"role\":\"system\",\"content\":\"Nobis quos voluptatem est laudantium reiciendis hic tempore a no\"},{\"role\":\"assistant\",\"content\":\"Quia labore culpa. Debitis sed tempora atque nobis perferendis q\"}]", "gpt-4", "Quaerat nihil doloremque quibusdam ipsum quas. Aut reprehenderit aut corporis. Quo facilis officiis consectetur nam sint nihil e", "c25a0a6b-ebd6-4cd0-90d8-6413a0063882", 8491u, new DateTime(2022, 12, 17, 13, 37, 52, 253, DateTimeKind.Unspecified).AddTicks(6515), "d225fcb2-59e7-494b-98d6-b76e7238955e" },
                    { "175c1b1b-025c-45db-91d0-12c2ffa34976", new DateTime(2023, 2, 5, 23, 52, 0, 800, DateTimeKind.Unspecified).AddTicks(1650), "d225fcb2-59e7-494b-98d6-b76e7238955e", null, "Suscipit expedita est dolor. Expedita ullam beatae expedita. Magnam iure pariatur atque dignissimos iste autem et corporis. Tempora aut occaecati. Sunt debitis qui eius. Ipsam ducimus pariatur.", true, "[{\"role\":\"assistant\",\"content\":\"Magnam et magnam velit non et earum culpa quam. Illum sint volup\"},{\"role\":\"system\",\"content\":\"Atque deserunt incidunt fugiat amet nihil omnis beatae modi. Nes\"},{\"role\":\"assistant\",\"content\":\"Molestiae ducimus aut voluptatibus molestias. Temporibus hic qui\"},{\"role\":\"assistant\",\"content\":\"Excepturi dicta et enim. Voluptatum soluta est tempore similique\"},{\"role\":\"system\",\"content\":\"Fuga eos sed facilis aut eaque. Asperiores occaecati at fugiat s\"}]", "gpt-3.5-trubo", "Dignissimos corporis ut assumenda eius fuga fugit quaerat necessitatibus. Omnis voluptatibus rerum repudiandae. Autem molestiae", "c25a0a6b-ebd6-4cd0-90d8-6413a0063882", 2145u, new DateTime(2023, 2, 5, 23, 52, 0, 800, DateTimeKind.Unspecified).AddTicks(1650), "d225fcb2-59e7-494b-98d6-b76e7238955e" },
                    { "3c7609a5-854c-46d0-8e71-6ac62c983434", new DateTime(2023, 1, 3, 5, 57, 45, 6, DateTimeKind.Unspecified).AddTicks(51), "da2e60f6-953e-4717-b566-cd7be191d643", null, "Suscipit voluptas animi eligendi labore maiores sit non. Sapiente alias numquam sed. Voluptatum est exercitationem illo nesciunt in quae.", false, "[{\"role\":\"system\",\"content\":\"Harum molestiae aut quisquam ratione et. Sint cum magnam non nih\"},{\"role\":\"user\",\"content\":\"Enim et voluptatem. Quam suscipit laboriosam qui expedita quis r\"},{\"role\":\"assistant\",\"content\":\"Aut expedita eius et debitis consequatur. Non sunt voluptatem qu\"},{\"role\":\"system\",\"content\":\"Aliquam assumenda qui excepturi dolor fugiat facere. Delectus re\"},{\"role\":\"system\",\"content\":\"Asperiores ratione amet reprehenderit repellendus. Cupiditate cu\"},{\"role\":\"assistant\",\"content\":\"Facere illo dolor impedit dolorem omnis sunt. Quasi laudantium t\"},{\"role\":\"system\",\"content\":\"Dolor omnis qui et non quos voluptates illum. Consequatur libero\"},{\"role\":\"assistant\",\"content\":\"Cumque fugit nesciunt. Ea ab aut non voluptatum asperiores nobis\"},{\"role\":\"assistant\",\"content\":\"Veritatis commodi quia rerum accusantium velit. Nihil sit illo p\"}]", "gpt-4", "Sit placeat est natus deleniti quis adipisci voluptatibus veritatis qui. Et perspiciatis molestias. Ad assumenda odit impedit au", "aff1ee00-cb61-4fde-8eff-7d52696c7d5b", 7368u, new DateTime(2023, 1, 3, 5, 57, 45, 6, DateTimeKind.Unspecified).AddTicks(51), "da2e60f6-953e-4717-b566-cd7be191d643" },
                    { "4cd0cc47-451b-4510-b4d2-9e3c5a4a08bc", new DateTime(2022, 10, 2, 19, 10, 16, 964, DateTimeKind.Unspecified).AddTicks(3319), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Voluptatem nesciunt numquam cum exercitationem minima adipisci ea quia fugiat. Sint fuga iure ratione maiores et. Molestias voluptatem assumenda impedit. Reiciendis vel reiciendis reprehenderit consequatur nobis fuga reprehenderit. Sit praesentium praesent", false, "[{\"role\":\"assistant\",\"content\":\"Ducimus et corporis qui in. Quis qui amet et facilis omnis neces\"},{\"role\":\"user\",\"content\":\"Nostrum magni et consequatur eaque expedita. Ipsam repellat aliq\"},{\"role\":\"assistant\",\"content\":\"Omnis nostrum sit. Eum deserunt sunt ut adipisci explicabo porro\"},{\"role\":\"assistant\",\"content\":\"Nihil officiis incidunt accusantium accusantium. Ab nihil expedi\"},{\"role\":\"assistant\",\"content\":\"Voluptatem laboriosam voluptas aspernatur sequi qui itaque. Volu\"},{\"role\":\"assistant\",\"content\":\"Vel id neque repellat id. Assumenda praesentium aliquid et. Volu\"},{\"role\":\"assistant\",\"content\":\"Ea dolor nihil molestiae quia earum rerum est distinctio. Quos a\"},{\"role\":\"system\",\"content\":\"Quos error veniam numquam eos. Quam alias quasi blanditiis bland\"},{\"role\":\"assistant\",\"content\":\"Commodi et officiis. Est incidunt et laboriosam aut officiis eiu\"},{\"role\":\"user\",\"content\":\"Aspernatur est molestiae sit aut autem consequuntur perferendis.\"}]", "gpt-4", "Nisi minima neque assumenda nihil debitis architecto itaque. Dolor illo ut laudantium saepe molestiae voluptates sint totam arch", "a1c12838-f9d8-4c79-b8fd-fb2dca21be8f", 14461u, new DateTime(2022, 10, 2, 19, 10, 16, 964, DateTimeKind.Unspecified).AddTicks(3319), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "53b003a6-e32a-466e-93ec-2cba2afec6e4", new DateTime(2022, 6, 3, 11, 57, 35, 840, DateTimeKind.Unspecified).AddTicks(804), "90dbe091-1672-47c3-a098-a904b4e107a4", null, "Dicta cupiditate perferendis eaque porro et eligendi est laudantium ullam. Quia ab perspiciatis adipisci eligendi corporis. Temporibus aspernatur quibusdam perspiciatis ullam et minima dolore molestiae. Nobis est aperiam explicabo eaque ullam atque debitis", false, "[{\"role\":\"assistant\",\"content\":\"Totam quo debitis tenetur quasi fugit. Possimus recusandae dolor\"},{\"role\":\"assistant\",\"content\":\"Veritatis nam dolorem nesciunt vel soluta id blanditiis. Autem q\"},{\"role\":\"assistant\",\"content\":\"Nisi sint sunt tenetur molestiae voluptatum. Omnis saepe porro u\"},{\"role\":\"system\",\"content\":\"Similique consequatur dolorum dignissimos maiores sed dolorem ve\"},{\"role\":\"assistant\",\"content\":\"Dolore at iste quia quidem vitae. Rerum quidem tenetur delectus\"},{\"role\":\"system\",\"content\":\"Tenetur quae quis suscipit dolorem voluptatem labore in qui. Dol\"},{\"role\":\"system\",\"content\":\"Tenetur placeat et omnis similique. Tempore id ea consequatur ve\"},{\"role\":\"user\",\"content\":\"Repudiandae et officia aut quis omnis. Quia ducimus incidunt ips\"}]", "gpt-4", "Praesentium et inventore vitae architecto. Quas ea doloribus repudiandae. Rerum esse hic facilis sed rerum delectus animi et vel", "a9e5e9fe-c398-4a70-a76e-2beb7e69f035", 31u, new DateTime(2022, 6, 3, 11, 57, 35, 840, DateTimeKind.Unspecified).AddTicks(804), "90dbe091-1672-47c3-a098-a904b4e107a4" },
                    { "54fbbeba-938c-472e-a707-d6381c3d49f3", new DateTime(2022, 11, 29, 2, 9, 49, 404, DateTimeKind.Unspecified).AddTicks(845), "48dace1e-520d-4ad6-843b-113385672a6f", null, "Dicta et itaque. Repellat hic voluptatem aperiam voluptatem et numquam sed quis. Iste et fugit necessitatibus amet omnis iure iusto maxime.", false, "[{\"role\":\"user\",\"content\":\"Magnam amet eveniet. Provident voluptatem odit odit ut. Cum non\"},{\"role\":\"assistant\",\"content\":\"Doloremque voluptatem qui numquam libero excepturi molestias ut.\"},{\"role\":\"system\",\"content\":\"Voluptates qui fugiat. Cumque sit sunt atque. Qui ad rem aliquam\"},{\"role\":\"system\",\"content\":\"Commodi aut magnam et labore. Voluptatem sunt explicabo. Placeat\"},{\"role\":\"assistant\",\"content\":\"Quis exercitationem optio minus exercitationem. At occaecati eni\"},{\"role\":\"system\",\"content\":\"Odit quia natus. Possimus doloribus voluptate. Ipsam facilis odi\"},{\"role\":\"system\",\"content\":\"Molestiae cumque quo eos impedit. Qui culpa dolore qui adipisci.\"},{\"role\":\"user\",\"content\":\"Blanditiis earum aliquam atque. Sit explicabo sit enim deleniti\"},{\"role\":\"system\",\"content\":\"Itaque ullam ratione sint atque sit sunt qui dolore possimus. Ar\"}]", "gpt-4", "Nulla eius quis. Excepturi officia temporibus et cupiditate. Corrupti et id hic. Quasi dolor debitis et est qui. Est ut earum qu", "6dc74f3a-8533-4067-b947-8100278d82a2", 4745u, new DateTime(2022, 11, 29, 2, 9, 49, 404, DateTimeKind.Unspecified).AddTicks(845), "48dace1e-520d-4ad6-843b-113385672a6f" },
                    { "574c3afa-cd26-459f-acb0-d025c6a7a3b8", new DateTime(2022, 3, 10, 8, 2, 30, 646, DateTimeKind.Unspecified).AddTicks(8850), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Quod recusandae maxime et alias non consequatur. In quibusdam nulla voluptatum omnis sint. In at est expedita est expedita necessitatibus corrupti reprehenderit eum. A eos officiis unde saepe ut quis pariatur. Sed ut molestias et et sit est.", false, "[{\"role\":\"assistant\",\"content\":\"Quo fugiat velit quas pariatur amet occaecati quisquam et volupt\"}]", "gpt-3.5-trubo", "Vel fugiat rerum totam quas eum debitis temporibus consequatur. At voluptate tempore vel molestias. Nulla itaque sint consequatu", "a1c12838-f9d8-4c79-b8fd-fb2dca21be8f", 5018u, new DateTime(2022, 3, 10, 8, 2, 30, 646, DateTimeKind.Unspecified).AddTicks(8850), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "67fb454d-0e37-4470-8cd7-9207dd29e678", new DateTime(2022, 2, 9, 2, 33, 22, 43, DateTimeKind.Unspecified).AddTicks(9531), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Dolor nobis et perferendis. Nihil voluptatem nostrum qui minima placeat ducimus modi facere. Excepturi dolore nisi distinctio et id officiis et.", false, "[{\"role\":\"user\",\"content\":\"Nihil pariatur est amet pariatur. Adipisci et qui est cupiditate\"},{\"role\":\"system\",\"content\":\"Rerum cumque et ut tempore quas excepturi consequatur. Reiciendi\"},{\"role\":\"user\",\"content\":\"Voluptas et aliquam et consequuntur aliquid earum culpa. Est quo\"},{\"role\":\"user\",\"content\":\"Qui deserunt facilis tempora necessitatibus et non molestias. Po\"},{\"role\":\"system\",\"content\":\"Voluptatem magni aliquid perferendis atque reprehenderit sit ips\"},{\"role\":\"system\",\"content\":\"Nam est ab est tempore. Qui provident dolorem qui corporis autem\"},{\"role\":\"user\",\"content\":\"Assumenda ab voluptatem sit. Explicabo explicabo aut asperiores.\"},{\"role\":\"user\",\"content\":\"Officiis est quas consequatur aut odio deserunt. Id sunt quas no\"}]", "gpt-3.5-trubo", "Repellat amet et et magni. Vel repellendus veritatis voluptas. Nesciunt eos cupiditate quos iure ullam rerum voluptatum. Consect", "88ef8443-8f95-4ead-a037-a12f7930332c", 13630u, new DateTime(2022, 2, 9, 2, 33, 22, 43, DateTimeKind.Unspecified).AddTicks(9531), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "73d2640b-0f23-443c-a6db-d5ed87c5eedd", new DateTime(2023, 2, 19, 15, 7, 13, 285, DateTimeKind.Unspecified).AddTicks(5134), "3d037c9a-9b01-487c-8716-6917064d4a31", null, "Dolores quia et consequatur molestiae et iusto autem numquam. Ut et laborum voluptas numquam sit id voluptas ut voluptas. Aut cumque error aut provident. Maiores et porro dolore quibusdam reprehenderit.", true, "[{\"role\":\"user\",\"content\":\"Non saepe doloribus saepe modi eum perspiciatis est. Assumenda v\"},{\"role\":\"system\",\"content\":\"Dolorem qui saepe ipsum et in dicta molestiae veritatis nobis. D\"},{\"role\":\"system\",\"content\":\"Qui enim eos architecto eum. Cum facere sequi nisi perferendis m\"},{\"role\":\"system\",\"content\":\"Sit totam autem aut dicta non sit. Labore consequuntur impedit s\"},{\"role\":\"user\",\"content\":\"Consequatur et cupiditate ex repellendus qui et optio. Debitis a\"},{\"role\":\"assistant\",\"content\":\"Illo sed deserunt provident perferendis aut cupiditate qui accus\"},{\"role\":\"system\",\"content\":\"Repudiandae aut quo voluptatum. Provident fugit dolores sint. Ea\"},{\"role\":\"user\",\"content\":\"Quo adipisci placeat alias sint eos. Accusamus tempora eius qui\"}]", "gpt-4", "Consequuntur et et. Totam dolore culpa. Qui perspiciatis occaecati aut maxime repellat eum dolor necessitatibus aliquam. Et faci", "ef170b5d-85dc-45ff-8c02-6e80217b12f4", 3002u, new DateTime(2023, 2, 19, 15, 7, 13, 285, DateTimeKind.Unspecified).AddTicks(5134), "3d037c9a-9b01-487c-8716-6917064d4a31" },
                    { "7643aefb-7dc5-4af2-aa95-4837a82d0e05", new DateTime(2023, 2, 14, 6, 15, 29, 928, DateTimeKind.Unspecified).AddTicks(8887), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Et qui est non temporibus consectetur eius modi beatae sed. Eum accusamus praesentium nihil amet non. Est eius ipsam. Perspiciatis nihil aut non vel rerum aut amet quia tempore. Praesentium iusto perspiciatis.", true, "[{\"role\":\"system\",\"content\":\"Quidem voluptates repudiandae. Fugiat quia omnis iste asperiores\"},{\"role\":\"assistant\",\"content\":\"Veritatis id ipsum sunt repellendus aut eligendi adipisci. Adipi\"},{\"role\":\"user\",\"content\":\"Dignissimos fuga labore. Autem odit ut dolores. Repellendus opti\"}]", "gpt-3.5-trubo", "Soluta labore minus ut tempora quos enim quia. Explicabo quia harum provident optio similique praesentium vitae non. Fugit qui a", "ade9d51b-4d7a-4efb-9cd7-ceb70b4ba005", 12518u, new DateTime(2023, 2, 14, 6, 15, 29, 928, DateTimeKind.Unspecified).AddTicks(8887), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "775af60d-6804-461d-8d62-e7f6ef108017", new DateTime(2022, 10, 11, 19, 44, 6, 40, DateTimeKind.Unspecified).AddTicks(359), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Blanditiis placeat ipsam voluptas illum. Quia dicta atque voluptatem natus rerum. Harum magnam sit corporis aspernatur aut qui.", false, "[{\"role\":\"assistant\",\"content\":\"Ratione voluptas quas ad numquam pariatur quo reiciendis. Quasi\"},{\"role\":\"user\",\"content\":\"Omnis nemo porro sint consequatur ut voluptas. Nostrum commodi f\"},{\"role\":\"assistant\",\"content\":\"Voluptates est suscipit et sed officiis cupiditate soluta iure a\"},{\"role\":\"system\",\"content\":\"Exercitationem est voluptatem. Quo similique veniam maiores quam\"}]", "gpt-3.5-trubo", "Sint impedit alias numquam facilis excepturi ducimus. Omnis architecto aut cumque veniam illum ut. Est quia dolor illo quia. Vit", "4a9b9a81-8dd6-4ced-9f59-8a505692b977", 14949u, new DateTime(2022, 10, 11, 19, 44, 6, 40, DateTimeKind.Unspecified).AddTicks(359), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "7fd883d9-818b-4a1d-8aeb-5e2a734c1581", new DateTime(2022, 3, 27, 13, 30, 51, 984, DateTimeKind.Unspecified).AddTicks(7723), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Dolorum non doloremque voluptatem perspiciatis voluptas. Fugiat beatae minima repellat. Et velit alias deserunt tenetur sequi.", true, "[{\"role\":\"assistant\",\"content\":\"Praesentium corporis non corporis molestias. Ut nemo earum ab in\"},{\"role\":\"system\",\"content\":\"Delectus quis quis non qui omnis est animi. Quam minima incidunt\"},{\"role\":\"assistant\",\"content\":\"Assumenda distinctio qui pariatur. Laudantium aut tempora dolore\"},{\"role\":\"user\",\"content\":\"Ab laboriosam necessitatibus nihil ut deleniti rerum veritatis.\"},{\"role\":\"assistant\",\"content\":\"Occaecati molestias eligendi. Adipisci distinctio culpa alias do\"},{\"role\":\"system\",\"content\":\"Porro consectetur ipsam. Labore temporibus et officia dolores od\"},{\"role\":\"system\",\"content\":\"Tempora corrupti dolorem doloribus et. Blanditiis cum sint sit q\"},{\"role\":\"assistant\",\"content\":\"Assumenda non autem est vitae earum pariatur nostrum. Neque sed\"},{\"role\":\"assistant\",\"content\":\"Dolores a tempore temporibus nam libero id. Beatae ut iusto eum\"},{\"role\":\"assistant\",\"content\":\"Error voluptatem autem. In error placeat pariatur velit pariatur\"}]", "gpt-3.5-trubo", "Provident est est. Esse est laudantium velit aut numquam id. Vitae quaerat ea quod sit amet sequi vero. Assumenda blanditiis vol", "ade9d51b-4d7a-4efb-9cd7-ceb70b4ba005", 518u, new DateTime(2022, 3, 27, 13, 30, 51, 984, DateTimeKind.Unspecified).AddTicks(7723), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "88976991-3f02-4a73-aada-db563f05fb53", new DateTime(2023, 10, 16, 8, 39, 21, 356, DateTimeKind.Unspecified).AddTicks(2083), "48dace1e-520d-4ad6-843b-113385672a6f", null, "Optio rem laborum quis tenetur molestias aut. Sunt libero aut ea. Nisi labore omnis sit expedita veritatis et voluptas aut. Et et quia magni quibusdam facere saepe et. Sequi tenetur id est itaque ut sit in. Dolore veniam possimus commodi cumque laboriosam", true, "[{\"role\":\"system\",\"content\":\"Maiores blanditiis qui rerum ut omnis recusandae rerum molestias\"},{\"role\":\"system\",\"content\":\"Velit impedit in et dolorem a. Maiores praesentium eum eius. Pro\"}]", "gpt-4", "Necessitatibus maxime eos et. Omnis tenetur doloremque aliquid dolorem ipsam debitis et et quasi. Quaerat modi et quam sint et q", "6dc74f3a-8533-4067-b947-8100278d82a2", 12126u, new DateTime(2023, 10, 16, 8, 39, 21, 356, DateTimeKind.Unspecified).AddTicks(2083), "48dace1e-520d-4ad6-843b-113385672a6f" },
                    { "a984ba4d-82d0-4422-8f11-584ad58e5704", new DateTime(2023, 4, 29, 6, 33, 52, 965, DateTimeKind.Unspecified).AddTicks(3980), "3d037c9a-9b01-487c-8716-6917064d4a31", null, "Aspernatur facilis maxime et sit illo amet commodi in nulla. Odio autem perspiciatis omnis. Facilis occaecati reprehenderit nulla quae. Pariatur labore sequi nemo numquam non saepe qui hic. Voluptatem ea sit sed et at quas numquam aut.", false, "[{\"role\":\"system\",\"content\":\"Odit aperiam itaque molestias inventore odio cupiditate rerum qu\"},{\"role\":\"system\",\"content\":\"Non asperiores minus eius et et quisquam molestias. Rem praesent\"},{\"role\":\"system\",\"content\":\"Unde magnam temporibus repellendus in quia sequi id provident. N\"},{\"role\":\"user\",\"content\":\"Quis eum ullam. Ducimus est voluptate debitis eum distinctio et\"},{\"role\":\"assistant\",\"content\":\"Aut similique deserunt distinctio consequatur eveniet facilis. Q\"},{\"role\":\"system\",\"content\":\"Architecto non minus nam ea quasi et. Pariatur sunt nesciunt in\"},{\"role\":\"system\",\"content\":\"Eum et aut velit vel inventore. Iure voluptatem libero perferend\"}]", "gpt-3.5-trubo", "Ut perspiciatis dolorem eius. Repellendus est expedita voluptas dolorem tempora cum sunt officiis. Nisi facilis natus eos aliqua", "ef170b5d-85dc-45ff-8c02-6e80217b12f4", 12195u, new DateTime(2023, 4, 29, 6, 33, 52, 965, DateTimeKind.Unspecified).AddTicks(3980), "3d037c9a-9b01-487c-8716-6917064d4a31" },
                    { "ac7679e3-af52-494c-8cf3-0aa267a05f62", new DateTime(2022, 10, 20, 7, 28, 29, 697, DateTimeKind.Unspecified).AddTicks(6026), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Ad illo et quibusdam quia nam illum. Dolorum ex ducimus aut qui vel dolore. Rerum aspernatur amet eius sunt perspiciatis dicta quia laborum libero.", true, "[{\"role\":\"user\",\"content\":\"Aut illo deleniti sunt veritatis molestiae vitae. Consequatur ar\"},{\"role\":\"user\",\"content\":\"Architecto nemo eos rerum. Qui velit labore praesentium quo aut\"},{\"role\":\"user\",\"content\":\"Voluptatem odit iusto. Natus ad sequi autem aliquam quas expedit\"},{\"role\":\"system\",\"content\":\"Officia quis sint inventore adipisci qui quod facere. Excepturi\"},{\"role\":\"assistant\",\"content\":\"Magnam quia nulla et vero rem magni quos modi. Sapiente cumque l\"},{\"role\":\"assistant\",\"content\":\"Voluptatem explicabo qui eum ad ullam a fugiat. Voluptatem eaque\"},{\"role\":\"system\",\"content\":\"Culpa distinctio corrupti facilis excepturi itaque. Ipsam recusa\"},{\"role\":\"assistant\",\"content\":\"Est soluta quas aspernatur eum. Ut officiis quia ratione delenit\"}]", "gpt-3.5-trubo", "Minus ut itaque repellendus. Aut voluptates temporibus a qui velit. Doloribus et placeat debitis non modi fugiat. Aut animi aut.", "441af70e-17f9-4258-84ae-9d20b7945d90", 14367u, new DateTime(2022, 10, 20, 7, 28, 29, 697, DateTimeKind.Unspecified).AddTicks(6026), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "ad61a8b4-9f8f-414f-9445-da5bd06346f4", new DateTime(2023, 8, 24, 19, 20, 19, 87, DateTimeKind.Unspecified).AddTicks(5381), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Optio laboriosam et quia tempore voluptatem eaque doloribus eos. Vitae est alias vel sit doloribus et veniam occaecati. Quis laborum et sed velit.", false, "[{\"role\":\"assistant\",\"content\":\"Nemo culpa cum sit et laboriosam minima sequi blanditiis. Et con\"},{\"role\":\"system\",\"content\":\"Quaerat dolores facere. Recusandae voluptatem eum repellat quia\"},{\"role\":\"system\",\"content\":\"Omnis nesciunt dicta optio modi odit. Voluptatem deleniti quo nu\"},{\"role\":\"system\",\"content\":\"Ea ut nisi. Cupiditate labore impedit. Aut odio natus eum qui ra\"},{\"role\":\"assistant\",\"content\":\"Exercitationem vero qui voluptatibus et voluptatem rerum omnis.\"}]", "gpt-3.5-trubo", "Harum voluptates perspiciatis praesentium. Est incidunt rem est neque ut vel. Eos nisi sed deserunt. Possimus delectus quo itaqu", "a1c12838-f9d8-4c79-b8fd-fb2dca21be8f", 4143u, new DateTime(2023, 8, 24, 19, 20, 19, 87, DateTimeKind.Unspecified).AddTicks(5381), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" },
                    { "c7ba4b46-f3c8-4f09-ac22-cdfa7e2ba297", new DateTime(2022, 6, 24, 21, 52, 54, 976, DateTimeKind.Unspecified).AddTicks(8359), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Corporis aliquid corrupti ipsum eum eum. Tempore enim qui in. Eum voluptatem aliquam.", false, "[{\"role\":\"assistant\",\"content\":\"Qui consequatur corporis ducimus. Et ut iste laboriosam. Quis ex\"},{\"role\":\"assistant\",\"content\":\"Ex ut quia quia et. Aut nihil aut. Repudiandae reprehenderit ess\"},{\"role\":\"assistant\",\"content\":\"Error deleniti et omnis praesentium dolorem non minus. Officia l\"},{\"role\":\"user\",\"content\":\"Quisquam et quia explicabo. Eius sit illo. Autem nam omnis recus\"}]", "gpt-4", "Id iste similique ut magni. Qui dolore ab ullam quae aspernatur. Maxime et numquam recusandae voluptatem repudiandae accusantium", "4a9b9a81-8dd6-4ced-9f59-8a505692b977", 3480u, new DateTime(2022, 6, 24, 21, 52, 54, 976, DateTimeKind.Unspecified).AddTicks(8359), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "d7c8e96e-f2a9-4ccc-a348-e78e4d140e39", new DateTime(2023, 9, 24, 18, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(2210), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Nulla blanditiis non repellat ad ratione quaerat saepe. Ipsa ducimus dolor omnis quo ea velit dolorem placeat ratione. Vel suscipit odio.", true, "[{\"role\":\"user\",\"content\":\"Sed repellat dolore impedit nisi hic. Id dolorum nesciunt. Quis\"},{\"role\":\"system\",\"content\":\"Necessitatibus asperiores quis rerum. Est assumenda dolores in m\"},{\"role\":\"user\",\"content\":\"Necessitatibus ut id porro. Excepturi quos officia sapiente nesc\"},{\"role\":\"user\",\"content\":\"Quo natus repellat quaerat rerum ut. Dolor magni optio nobis asp\"},{\"role\":\"user\",\"content\":\"Quia asperiores sit laboriosam nam quas hic omnis. Sed et ut sit\"}]", "gpt-4", "Ea qui voluptatibus iusto odit reprehenderit. Deserunt nesciunt quibusdam. Quo tempora quod voluptatem dignissimos. Praesentium", "ade9d51b-4d7a-4efb-9cd7-ceb70b4ba005", 5826u, new DateTime(2023, 9, 24, 18, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(2210), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "d7dc1cd9-6d5b-4de2-8e9f-4273f7b220ab", new DateTime(2023, 2, 27, 4, 53, 20, 330, DateTimeKind.Unspecified).AddTicks(9076), "90dbe091-1672-47c3-a098-a904b4e107a4", null, "Perferendis atque nihil beatae quisquam autem omnis. Temporibus dicta fugit provident pariatur est. Soluta ut ut magnam voluptates animi corporis. Quo ullam voluptas ut rerum expedita.", true, "[{\"role\":\"user\",\"content\":\"Voluptas doloremque dolor alias quibusdam qui perspiciatis. Sed\"},{\"role\":\"assistant\",\"content\":\"Ullam qui molestias dolores voluptatem impedit vel exercitatione\"},{\"role\":\"user\",\"content\":\"Voluptatem voluptas doloribus deleniti omnis magnam. Qui esse su\"},{\"role\":\"system\",\"content\":\"Cumque dicta molestias iste alias magnam enim doloremque. Soluta\"},{\"role\":\"assistant\",\"content\":\"Voluptatem perspiciatis voluptas porro quisquam architecto et su\"},{\"role\":\"system\",\"content\":\"Nam exercitationem doloribus voluptatem. Hic in eligendi et ut s\"},{\"role\":\"assistant\",\"content\":\"Ut nulla ipsam cupiditate provident aut est corrupti. Aut at eum\"},{\"role\":\"system\",\"content\":\"Omnis odit ab quod. Voluptates quam sit sit. Quis commodi facili\"},{\"role\":\"user\",\"content\":\"Minus iste ad qui saepe dignissimos omnis. Enim quia illo eaque\"},{\"role\":\"assistant\",\"content\":\"Et aut eius qui eum. Quo a mollitia accusantium qui recusandae v\"}]", "gpt-4", "Consequatur officiis vero illum rerum et inventore quisquam minima aut. Et eveniet voluptates fugiat commodi saepe minus. Quia v", "a9e5e9fe-c398-4a70-a76e-2beb7e69f035", 4928u, new DateTime(2023, 2, 27, 4, 53, 20, 330, DateTimeKind.Unspecified).AddTicks(9076), "90dbe091-1672-47c3-a098-a904b4e107a4" },
                    { "da52bcb5-5e04-4deb-89e2-07f1cb06e9da", new DateTime(2022, 5, 5, 17, 19, 7, 430, DateTimeKind.Unspecified).AddTicks(4980), "90dbe091-1672-47c3-a098-a904b4e107a4", null, "Quis iste nesciunt laudantium nisi. Sed aut nobis sint voluptatem. Aut velit sint aperiam totam aliquid nulla rem aspernatur. Rem quaerat eum repellat impedit vel iusto sint asperiores sit. Est qui voluptatem doloribus neque vitae.", false, "[{\"role\":\"assistant\",\"content\":\"Labore autem eos voluptas et esse est illo deserunt. Nemo et qui\"},{\"role\":\"user\",\"content\":\"Sed et vero earum facilis sunt omnis quia voluptatem eum. Id iur\"},{\"role\":\"system\",\"content\":\"Quidem quam sequi autem. Molestiae eum nihil dolorum a dicta rep\"},{\"role\":\"assistant\",\"content\":\"Doloribus dolor id non. Nihil odit dolores in esse aut harum por\"},{\"role\":\"user\",\"content\":\"Sed minus voluptatem sint magnam. Eos voluptatibus culpa volupta\"},{\"role\":\"assistant\",\"content\":\"Quia est eligendi cum enim consectetur nihil debitis reiciendis.\"},{\"role\":\"user\",\"content\":\"Molestiae tenetur quisquam vel modi. Ad sit omnis consequatur ha\"},{\"role\":\"user\",\"content\":\"Quam laudantium ea. Aut commodi voluptatem rerum velit qui quas\"},{\"role\":\"system\",\"content\":\"Nobis sint vel non nulla doloribus quis. Mollitia id officia ani\"},{\"role\":\"system\",\"content\":\"Optio ducimus enim. Consequuntur iste ratione quis. Et corporis\"}]", "gpt-4", "Architecto placeat est ipsum facilis. Qui velit et. Modi cumque est necessitatibus omnis qui adipisci et.", "a9e5e9fe-c398-4a70-a76e-2beb7e69f035", 11824u, new DateTime(2022, 5, 5, 17, 19, 7, 430, DateTimeKind.Unspecified).AddTicks(4980), "90dbe091-1672-47c3-a098-a904b4e107a4" },
                    { "dd1e767a-64a1-4d75-9a88-a501cabdede3", new DateTime(2022, 8, 12, 20, 38, 20, 893, DateTimeKind.Unspecified).AddTicks(6266), "d225fcb2-59e7-494b-98d6-b76e7238955e", null, "Est soluta aut velit quisquam quam. Eligendi fugit quasi rerum dolor voluptatibus. Placeat placeat nam nisi officia nulla nesciunt asperiores. Commodi ullam consequatur repellendus quod ullam molestiae. Quia voluptatem debitis nemo reprehenderit dolores na", true, "[{\"role\":\"system\",\"content\":\"Earum commodi iusto consequuntur vel optio. Accusamus eveniet ni\"},{\"role\":\"user\",\"content\":\"Magnam voluptatem aliquam odio quaerat possimus soluta est labor\"}]", "gpt-3.5-trubo", "Repellat et dignissimos qui nostrum. Quis eum facilis occaecati qui. Soluta sequi rerum at aut quo qui error quis quis. Deleniti", "c25a0a6b-ebd6-4cd0-90d8-6413a0063882", 8970u, new DateTime(2022, 8, 12, 20, 38, 20, 893, DateTimeKind.Unspecified).AddTicks(6266), "d225fcb2-59e7-494b-98d6-b76e7238955e" },
                    { "e74d1e86-8f02-4b8b-ac03-7d78c0857b23", new DateTime(2022, 2, 2, 5, 53, 25, 826, DateTimeKind.Unspecified).AddTicks(1641), "da2e60f6-953e-4717-b566-cd7be191d643", null, "Sapiente officia quo ipsam consequatur facilis et. Quidem quam ut vel commodi voluptatem sunt earum facere. Qui suscipit sint ea reiciendis molestiae et provident. Occaecati et saepe ut molestiae ut sint doloremque nisi. Praesentium libero quis vero ut sap", false, "[{\"role\":\"system\",\"content\":\"Est dolor quasi magni voluptatibus. Dolorem voluptatem iure ipsu\"},{\"role\":\"system\",\"content\":\"Reprehenderit delectus sed et. Reprehenderit iste ut et dolore q\"},{\"role\":\"assistant\",\"content\":\"Natus rerum omnis pariatur. Vel nesciunt omnis perferendis aut q\"},{\"role\":\"user\",\"content\":\"Voluptate qui modi ea sit odio et molestiae ipsa quasi. Esse sit\"},{\"role\":\"user\",\"content\":\"Omnis ipsam velit et qui magnam placeat sunt fuga. Porro quo lab\"},{\"role\":\"assistant\",\"content\":\"Quaerat non quam sint consequatur molestias. Occaecati corrupti\"},{\"role\":\"assistant\",\"content\":\"Facilis et ut et quo. Et aliquid tenetur repellat praesentium ip\"},{\"role\":\"assistant\",\"content\":\"Nostrum libero eligendi maxime voluptas nulla sequi. Corrupti vo\"},{\"role\":\"system\",\"content\":\"Et dolorum voluptates qui tempora et occaecati esse aut. Exercit\"}]", "gpt-4", "Nobis soluta laudantium optio quidem aliquam sed ut. Et voluptatum ut voluptatum a fuga dolorem. Illum ea dignissimos sunt eveni", "aff1ee00-cb61-4fde-8eff-7d52696c7d5b", 13387u, new DateTime(2022, 2, 2, 5, 53, 25, 826, DateTimeKind.Unspecified).AddTicks(1641), "da2e60f6-953e-4717-b566-cd7be191d643" },
                    { "ebc101af-38cc-4701-bc6d-08279abe8ab3", new DateTime(2022, 11, 13, 2, 1, 40, 681, DateTimeKind.Unspecified).AddTicks(8834), "da2e60f6-953e-4717-b566-cd7be191d643", null, "Voluptas dolorem tenetur. Dignissimos at quam quis cum qui et. Est et et ea esse quisquam. Aut rerum impedit dignissimos. Distinctio voluptas eius sit quae numquam. Libero eaque cupiditate.", true, "[{\"role\":\"user\",\"content\":\"Totam aspernatur porro minus consectetur ut similique. Est disti\"},{\"role\":\"system\",\"content\":\"Aspernatur non vel ipsum voluptas amet. Sit omnis recusandae aut\"},{\"role\":\"system\",\"content\":\"Doloribus itaque dolore aut. Est molestiae maxime aut eos sapien\"},{\"role\":\"assistant\",\"content\":\"Officiis sit voluptas. Est corporis vitae accusantium enim. Eos\"},{\"role\":\"user\",\"content\":\"Numquam odio quia rerum qui error doloribus qui sint id. Optio r\"},{\"role\":\"assistant\",\"content\":\"Dolores facilis voluptatum non minus blanditiis sint. Deleniti d\"}]", "gpt-4", "Aut corporis id fugit maxime numquam laborum. Non deleniti accusantium corporis voluptas non cupiditate quasi est. Et repellendu", "aff1ee00-cb61-4fde-8eff-7d52696c7d5b", 10590u, new DateTime(2022, 11, 13, 2, 1, 40, 681, DateTimeKind.Unspecified).AddTicks(8834), "da2e60f6-953e-4717-b566-cd7be191d643" },
                    { "f27cc901-4fe2-4b54-bb21-8c5189184fc1", new DateTime(2022, 9, 3, 0, 10, 16, 283, DateTimeKind.Unspecified).AddTicks(3008), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Non earum corrupti adipisci rerum tempora. Ipsam repellendus ratione. Aspernatur accusantium optio quibusdam. Quisquam incidunt facere dolor adipisci. Fugit dolorum nihil eveniet dolorem illo. Saepe dolorem dolorem sit odio hic iure neque quam.", false, "[{\"role\":\"assistant\",\"content\":\"Qui voluptatem aut sit officia. Vel similique sint qui autem vel\"}]", "gpt-3.5-trubo", "Et quia eos repellendus debitis ab autem labore. Doloribus officiis et eveniet. In adipisci odio quia culpa. Maiores accusamus q", "88ef8443-8f95-4ead-a037-a12f7930332c", 15341u, new DateTime(2022, 9, 3, 0, 10, 16, 283, DateTimeKind.Unspecified).AddTicks(3008), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "fbfe4548-9598-4153-a560-dfd1adfbb5cb", new DateTime(2022, 3, 3, 4, 25, 34, 40, DateTimeKind.Unspecified).AddTicks(9682), "ac381953-c4e6-414b-a10b-30ab9e315221", null, "Deserunt exercitationem quia harum quod quo voluptas mollitia tenetur. Dolores cumque enim tenetur eaque ea autem accusantium facilis corporis. Sed sed quidem. Dolorem quod libero iste et soluta maiores. Pariatur soluta non dignissimos omnis iste eaque min", false, "[{\"role\":\"system\",\"content\":\"Quibusdam dolor tenetur laboriosam labore beatae qui accusamus v\"},{\"role\":\"system\",\"content\":\"Ipsam deleniti aut aut doloremque. Aut beatae quidem eveniet mai\"},{\"role\":\"assistant\",\"content\":\"Praesentium et harum facilis necessitatibus. Molestiae quam nihi\"},{\"role\":\"assistant\",\"content\":\"Veniam nihil nesciunt nulla quam. Excepturi deleniti et sit volu\"},{\"role\":\"user\",\"content\":\"Repellat culpa blanditiis non distinctio iste perspiciatis. Volu\"},{\"role\":\"system\",\"content\":\"Possimus veritatis est saepe cupiditate omnis unde. Veniam qui v\"},{\"role\":\"user\",\"content\":\"A neque libero cum delectus consequatur et. Illo quis reprehende\"},{\"role\":\"system\",\"content\":\"Nobis esse sit ducimus. Ut in assumenda. Voluptatem quo tempore\"}]", "gpt-4", "Accusamus odit nisi nulla minima dolorum. Sit enim ipsum quos totam. Quia dolores ea iusto. Sunt odio autem et. Aliquid aut volu", "88ef8443-8f95-4ead-a037-a12f7930332c", 530u, new DateTime(2022, 3, 3, 4, 25, 34, 40, DateTimeKind.Unspecified).AddTicks(9682), "ac381953-c4e6-414b-a10b-30ab9e315221" },
                    { "fd3e50dd-0833-43a6-8e99-4a90b2eb6eee", new DateTime(2022, 8, 6, 3, 54, 6, 618, DateTimeKind.Unspecified).AddTicks(3563), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7", null, "Dolorem quis voluptatem quaerat corrupti. Error sunt nam. Et mollitia fuga ratione nobis ratione voluptatem occaecati reiciendis. Qui et nulla omnis sed sed at. Corrupti quas ab rerum dicta autem et vel. Perspiciatis facilis quod sunt harum doloremque volu", false, "[{\"role\":\"assistant\",\"content\":\"Voluptates quod cum tempore commodi earum. Et non velit eum vel\"},{\"role\":\"assistant\",\"content\":\"Iste culpa dolorem saepe vel fuga molestias. Molestiae culpa qui\"},{\"role\":\"user\",\"content\":\"Est deserunt dolor porro ab accusantium aut. Cupiditate quia aut\"},{\"role\":\"user\",\"content\":\"Eum ipsa odio autem error. Voluptatem quia voluptatem quam volup\"}]", "gpt-4", "Aliquid voluptas sapiente. Nam et vero nihil quam inventore sapiente. Modi iusto dolores. Aliquid exercitationem amet eius labor", "441af70e-17f9-4258-84ae-9d20b7945d90", 13028u, new DateTime(2022, 8, 6, 3, 54, 6, 618, DateTimeKind.Unspecified).AddTicks(3563), "86edebdf-aad8-4245-8e11-fb3a2ef2afc7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedById",
                table: "Projects",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UpdatedById",
                table: "Projects",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Prompts_CreatedById",
                table: "Prompts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Prompts_ProjectId",
                table: "Prompts",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Prompts_UpdatedById",
                table: "Prompts",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Prompts");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
