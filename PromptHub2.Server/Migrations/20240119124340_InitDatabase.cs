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
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: true),
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
                values: new object[] { "d392963b-9d5e-4ca3-97f4-bc92e843a909", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e1bf905-4379-44ed-83e5-06370b53e9cb", 0, "0e3207dd-e03a-4045-a1ca-f08d8bfc1079", "Aiyana.Leffler@hotmail.com", false, false, null, "AIYANA.LEFFLER@HOTMAIL.COM", "AIYANA.LEFFLER@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJNvhsP7XA/4PBmEyMtmdYCX83/e5JtojNy13H4Uj3+XNoGQEFwDA/OSk6A8PwVmKg==", null, false, null, "ed7cc3b1-3a87-4e6f-b568-5ecffbb3b54e", false, "Aiyana.Leffler@hotmail.com" },
                    { "35b07873-085f-4dc1-bb82-d8f8d81e3af3", 0, "573e2686-dcd4-46cc-8a4a-20d6723812f6", "America_Kris@yahoo.com", true, false, null, "AMERICA_KRIS@YAHOO.COM", "AMERICA_KRIS@YAHOO.COM", "AQAAAAIAAYagAAAAEOMs3gho1fbJQzK0S9GoBTTdq8t0WEpyJL/YwmMLrSEZUFyjbDKvd3+Gdc5NT4PP2g==", null, false, null, "edbed6e5-c0dd-43b1-8ead-a1d9374b6916", false, "America_Kris@yahoo.com" },
                    { "38343f5e-b8e6-4499-96a7-27a91baade2f", 0, "6843409b-4365-4deb-a08a-e4288ee92133", "Jameson.Davis@hotmail.com", false, false, null, "JAMESON.DAVIS@HOTMAIL.COM", "JAMESON.DAVIS@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHl8QzYegqi1rZ6x9wVzgEK//VjgiI63f/OwWu8EkL39PSU12bMfZovP4WdyheVu0w==", null, false, null, "c8c0c692-bf5f-4a1a-a107-c5ee14d68fee", false, "Jameson.Davis@hotmail.com" },
                    { "3aa16183-949b-4717-b701-97be3bcfb21f", 0, "27f60e83-adb9-4299-bc25-4f3948501179", "Elza_Stracke5@hotmail.com", true, false, null, "ELZA_STRACKE5@HOTMAIL.COM", "ELZA_STRACKE5@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK0sFf5PYODUk9NgDxX6c0bf4w4Bb8voB3UKuiqyFrFAXwap27M9FhVDMLC/UTu6zA==", null, false, null, "7f957a90-5a13-481e-b708-4227ce117a7e", false, "Elza_Stracke5@hotmail.com" },
                    { "6716d7f7-c425-4e56-b666-bdf8a010641b", 0, "679db5ff-927a-432c-827b-9cefc3a89d10", "Braulio_Denesik62@hotmail.com", true, false, null, "BRAULIO_DENESIK62@HOTMAIL.COM", "BRAULIO_DENESIK62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHUtZw/6dMN7We0gSNvhu4ZP0vqeCRonaa1AVVH97EhwJES8MStzu1sNWyVN7I3IrQ==", null, false, null, "73dbb21f-6424-49b3-9216-0257886e7d87", false, "Braulio_Denesik62@hotmail.com" },
                    { "79afbe23-baca-45a8-85d5-d7d849d6fde2", 0, "99c1a884-37ca-461e-a712-17a8302bc4e7", "Evangeline.Hilpert2@yahoo.com", true, false, null, "EVANGELINE.HILPERT2@YAHOO.COM", "EVANGELINE.HILPERT2@YAHOO.COM", "AQAAAAIAAYagAAAAEPOIJcfSTMw6gIJhHFRMcPRFcQOqXvvjg0taaoZuXpIxjKb4COhj3TXdEeCSE3ZpBQ==", null, false, null, "d83299c8-6938-47bb-b1f5-74571f898867", false, "Evangeline.Hilpert2@yahoo.com" },
                    { "904047cc-87e1-434a-bb39-89616947ac79", 0, "9bc8f05d-b17f-4d02-845a-bd39d93dda29", "Koby_Hickle66@yahoo.com", false, false, null, "KOBY_HICKLE66@YAHOO.COM", "KOBY_HICKLE66@YAHOO.COM", "AQAAAAIAAYagAAAAEDmsqWE70xjj6RYPewLHOqm0iX1UuvhRpE0ReE+wZLvuVDgw9HEJGBHW7N+6It/ePg==", null, false, null, "c5365a1e-e896-402b-878b-9da8fd613d76", false, "Koby_Hickle66@yahoo.com" },
                    { "a08a77c1-ed0f-45c2-8333-19e33c6d550c", 0, "af0a6b1a-a2ec-4988-819b-55668b085a49", "Susanna.Rodriguez93@gmail.com", true, false, null, "SUSANNA.RODRIGUEZ93@GMAIL.COM", "SUSANNA.RODRIGUEZ93@GMAIL.COM", "AQAAAAIAAYagAAAAEG8TgdR9BCxt6gl6lz0pNf5O1QbhGMOIUC97Kog9vcfZlLXBJNs8kqLIIRZUTWmYdw==", null, false, null, "44524f00-8e4e-4b25-aced-c0ad55b5b9f7", false, "Susanna.Rodriguez93@gmail.com" },
                    { "b417ab39-3655-43d3-aa3a-aafecfd3fc58", 0, "e91d68c3-8b53-470f-9853-e2f11ba2a1fd", "Nicklaus11@gmail.com", true, false, null, "NICKLAUS11@GMAIL.COM", "NICKLAUS11@GMAIL.COM", "AQAAAAIAAYagAAAAEOB18e2MBVLIvLjZ9qX0VfwsPgpjA/Qau7YT3zUdrXG1nbCQbGIUaHwqUNRXUhZaWQ==", null, false, null, "a7d0fc00-8baf-4b38-944c-1294502a9573", false, "Nicklaus11@gmail.com" },
                    { "d9ef355d-f5df-47ba-85bd-223375cd7028", 0, "5c0bc434-b422-4521-a111-44b5a341affe", "Mitchel_Harber61@hotmail.com", false, false, null, "MITCHEL_HARBER61@HOTMAIL.COM", "MITCHEL_HARBER61@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBRCi9BMeS8IeBmVQGdDh49j6Xn/Rgv15F4Bo/3Hm3uuttUqqb5wCjiHpiTgelcOjA==", null, false, null, "c1061c6b-57ba-4be4-ad2d-a3c021d523d6", false, "Mitchel_Harber61@hotmail.com" },
                    { "fdcdd379-3f30-4e0c-a445-155f03679a87", 0, "13c15246-2e0e-436a-a808-7e9f668cf8bf", "fi.kwiatkowski@gmail.com", true, false, null, "FI.KWIATKOWSKI@GMAIL.COM", "FI.KWIATKOWSKI@GMAIL.COM", "AQAAAAIAAYagAAAAEJ6stnKnHi/EhwEDRnStJ2MEGG+ZMq6j2UC6pKCy9k3+0I5PHkb55f+KLnjktjKPEg==", null, false, null, "98226f2b-4d9d-43ed-96f2-1d6aa7cffb87", false, "fi.kwiatkowski@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d392963b-9d5e-4ca3-97f4-bc92e843a909", "fdcdd379-3f30-4e0c-a445-155f03679a87" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "15c4ef51-ae2d-4e0d-ba03-6ceaf5c8b004", new DateTime(2022, 6, 26, 22, 28, 36, 663, DateTimeKind.Unspecified).AddTicks(1509), "fdcdd379-3f30-4e0c-a445-155f03679a87", null, "Quae est sit. Doloremque in animi enim in nam ex quidem et. Magnam sed rem sed odio est sed. Atque officia tempore illo distinctio vel nam et velit eos. Beatae amet sint voluptates corrupti. Sit quis iste fuga perferendis tempora eos voluptatem distinctio", true, "Reiciendis praesentium voluptate ut aut quia id quia distinctio voluptatibus. Sit molestiae maxime at dignissimos. Ut alias eos", new DateTime(2022, 6, 26, 22, 28, 36, 663, DateTimeKind.Unspecified).AddTicks(1509), "fdcdd379-3f30-4e0c-a445-155f03679a87" },
                    { "1e3c1d3a-2525-47a3-839b-45fb5668a7fc", new DateTime(2023, 12, 18, 22, 40, 49, 96, DateTimeKind.Unspecified).AddTicks(2632), "6716d7f7-c425-4e56-b666-bdf8a010641b", null, "Fugiat libero dolorem. Ex magni voluptatum vero id temporibus quis perspiciatis. Quasi provident reiciendis iusto veritatis aperiam beatae. Iusto sit reprehenderit. Et fugit qui omnis et temporibus.", false, "Nihil exercitationem fugiat. Deserunt aut consectetur autem aspernatur. Cupiditate provident sunt repellat quia voluptatem hic s", new DateTime(2023, 12, 18, 22, 40, 49, 96, DateTimeKind.Unspecified).AddTicks(2632), "6716d7f7-c425-4e56-b666-bdf8a010641b" },
                    { "2c3914f1-837d-47ab-a565-4855d89335ac", new DateTime(2022, 4, 9, 4, 24, 16, 199, DateTimeKind.Unspecified).AddTicks(9689), "a08a77c1-ed0f-45c2-8333-19e33c6d550c", null, "Non dignissimos facere placeat adipisci. Ratione ex impedit rem cumque consequuntur rerum non voluptatibus doloribus. Cum quaerat in possimus sint. Accusamus nulla omnis et quam et excepturi eveniet.", false, "Corporis eos consectetur. Quos tempora quis omnis esse. Pariatur veniam repudiandae enim quae provident atque mollitia sed qui.", new DateTime(2022, 4, 9, 4, 24, 16, 199, DateTimeKind.Unspecified).AddTicks(9689), "a08a77c1-ed0f-45c2-8333-19e33c6d550c" },
                    { "5fed5a78-b2e6-4a68-93ac-151db05b669a", new DateTime(2022, 11, 18, 12, 18, 20, 990, DateTimeKind.Unspecified).AddTicks(2082), "b417ab39-3655-43d3-aa3a-aafecfd3fc58", null, "Provident aut labore ut rerum maxime distinctio veniam optio qui. Sint debitis quam quia tenetur cumque sapiente illo voluptas. Aut quia veritatis corrupti fugit officiis. Dicta eaque ut et est odio voluptates magnam. Vero officia dolores aut et ipsa qui v", false, "Ut in cumque magni placeat. Possimus asperiores labore sed in amet asperiores cupiditate ea. Nostrum eius aut et officiis.", new DateTime(2022, 11, 18, 12, 18, 20, 990, DateTimeKind.Unspecified).AddTicks(2082), "b417ab39-3655-43d3-aa3a-aafecfd3fc58" },
                    { "76f3e457-6698-497d-a58b-c4b11c8670cc", new DateTime(2022, 6, 30, 21, 57, 50, 988, DateTimeKind.Unspecified).AddTicks(6021), "35b07873-085f-4dc1-bb82-d8f8d81e3af3", null, "Accusantium ducimus fuga. Quam quasi sed omnis id ut alias amet. Rerum deserunt at eum corrupti iure. Molestiae sunt aut est beatae accusantium rerum aut incidunt. Voluptatum hic quaerat ab et. Voluptas sed fugiat.", true, "Eum minus impedit deleniti nobis aut voluptas sequi rerum sit. Sunt id vero occaecati. In eaque ratione reprehenderit. Molestias", new DateTime(2022, 6, 30, 21, 57, 50, 988, DateTimeKind.Unspecified).AddTicks(6021), "35b07873-085f-4dc1-bb82-d8f8d81e3af3" },
                    { "b3ee522d-2229-42a1-be6a-2e39498feb23", new DateTime(2023, 3, 20, 13, 1, 25, 954, DateTimeKind.Unspecified).AddTicks(6193), "904047cc-87e1-434a-bb39-89616947ac79", null, "Ipsum debitis fuga ea eos. Cupiditate sit sed voluptates voluptas. Necessitatibus vel deserunt reiciendis cumque qui. Vitae dolore ea aut. Ut nemo laboriosam repellendus.", false, "Voluptatem illo enim modi. Asperiores a quia dolores. Dolores dolorum asperiores. Quibusdam aut neque quod iusto. Natus quis mol", new DateTime(2023, 3, 20, 13, 1, 25, 954, DateTimeKind.Unspecified).AddTicks(6193), "904047cc-87e1-434a-bb39-89616947ac79" },
                    { "b4921aec-fdc4-42bb-9216-3a1a0ccf1ef3", new DateTime(2023, 12, 7, 18, 21, 39, 589, DateTimeKind.Unspecified).AddTicks(8926), "1e1bf905-4379-44ed-83e5-06370b53e9cb", null, "Aut ex est eligendi tenetur rerum voluptatem. Nostrum et non neque ullam harum aliquam qui porro nulla. Beatae consequatur similique neque dolor hic aliquid. Necessitatibus ut unde vero dolores.", false, "Fuga aut labore nobis labore suscipit sapiente. Sint veritatis nisi recusandae cumque. Dolores illum doloribus et veritatis blan", new DateTime(2023, 12, 7, 18, 21, 39, 589, DateTimeKind.Unspecified).AddTicks(8926), "1e1bf905-4379-44ed-83e5-06370b53e9cb" },
                    { "ba5c6683-759f-47ed-8ff8-09867a0df3a0", new DateTime(2023, 12, 30, 14, 50, 36, 554, DateTimeKind.Unspecified).AddTicks(112), "d9ef355d-f5df-47ba-85bd-223375cd7028", null, "Quasi minima enim quam similique sed et. Exercitationem sed earum facilis voluptas repudiandae ut voluptatem adipisci nobis. Iusto labore cumque consequatur optio id cupiditate voluptatum. Deserunt quae expedita nostrum assumenda id doloribus asperiores of", false, "Ut natus non omnis consequatur dolorum omnis vel. Dolor explicabo magnam enim quam. Commodi laborum eos ut perspiciatis consequu", new DateTime(2023, 12, 30, 14, 50, 36, 554, DateTimeKind.Unspecified).AddTicks(112), "d9ef355d-f5df-47ba-85bd-223375cd7028" },
                    { "d0228915-6242-4735-b6fa-6775db709824", new DateTime(2022, 3, 13, 12, 37, 52, 115, DateTimeKind.Unspecified).AddTicks(5992), "3aa16183-949b-4717-b701-97be3bcfb21f", null, "Ipsam consequatur veniam maxime. Eos est incidunt animi. Rem minus illum hic. Eos error ea. Perferendis autem corporis. Earum sit qui a.", true, "Quam eum ut. Qui sunt rerum delectus excepturi voluptate et. Placeat quia et veritatis quas nemo vero. Est repellat voluptas tem", new DateTime(2022, 3, 13, 12, 37, 52, 115, DateTimeKind.Unspecified).AddTicks(5992), "3aa16183-949b-4717-b701-97be3bcfb21f" },
                    { "e2597d0c-7e81-4af9-8583-a3dde03e0fa5", new DateTime(2022, 8, 19, 8, 8, 48, 86, DateTimeKind.Unspecified).AddTicks(924), "79afbe23-baca-45a8-85d5-d7d849d6fde2", null, "Distinctio nemo cumque reprehenderit rerum corrupti. Sed non minus. Nihil nihil facilis dolor quas distinctio. Velit aut quidem non eos est. Omnis aut commodi tempora occaecati.", false, "Veritatis ut ea reiciendis numquam. Aliquam quis officiis error quia autem perferendis sunt pariatur et. Ex molestiae aspernatur", new DateTime(2022, 8, 19, 8, 8, 48, 86, DateTimeKind.Unspecified).AddTicks(924), "79afbe23-baca-45a8-85d5-d7d849d6fde2" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "01458fc7-b568-42ec-82e2-de516f6e285e", new DateTime(2022, 3, 27, 11, 36, 53, 18, DateTimeKind.Unspecified).AddTicks(9453), "3aa16183-949b-4717-b701-97be3bcfb21f", null, "Distinctio molestiae a. Quibusdam quia minus reiciendis. Ut voluptate eligendi vero ea. Expedita itaque rem aut. Quia sint qui omnis impedit et tempore autem dolores sit. Dolor ex excepturi.", false, "[{\"role\":\"assistant\",\"content\":\"Doloribus sed nihil. Fugiat non unde iusto fuga natus voluptatib\"},{\"role\":\"assistant\",\"content\":\"Velit consequatur eum eum. Beatae quos qui cupiditate odit quis\"}]", "gpt-3.5-trubo", "Quis assumenda nobis quis quam praesentium qui voluptas qui at. Nostrum aut reprehenderit dolor fugit commodi qui. Quia est aut.", "d0228915-6242-4735-b6fa-6775db709824", 8032u, new DateTime(2022, 3, 27, 11, 36, 53, 18, DateTimeKind.Unspecified).AddTicks(9453), "3aa16183-949b-4717-b701-97be3bcfb21f" },
                    { "0303ce97-7d8e-426f-8a74-674d44df3a6f", new DateTime(2022, 3, 7, 16, 5, 38, 159, DateTimeKind.Unspecified).AddTicks(6962), "d9ef355d-f5df-47ba-85bd-223375cd7028", null, "Et voluptates alias dolore amet ut quasi aliquam aliquid. Aliquid culpa aut doloremque aperiam minima dolorem. Error nisi fugit. Illum quia accusamus. Est ipsa qui sit fugit cum exercitationem.", true, "[{\"role\":\"system\",\"content\":\"Quod autem sint dolor et mollitia omnis ipsam. Et mollitia dolor\"},{\"role\":\"assistant\",\"content\":\"Doloremque ut quas accusamus qui aspernatur culpa necessitatibus\"},{\"role\":\"system\",\"content\":\"Tempora veritatis unde nulla laboriosam. Ab at et iusto aperiam\"},{\"role\":\"assistant\",\"content\":\"Nam eum ut magni iusto occaecati. Ad labore omnis. Corporis offi\"}]", "gpt-3.5-trubo", "Harum tenetur est. Ut voluptatem eius amet explicabo esse ut harum. Et in et.", "ba5c6683-759f-47ed-8ff8-09867a0df3a0", 11993u, new DateTime(2022, 3, 7, 16, 5, 38, 159, DateTimeKind.Unspecified).AddTicks(6962), "d9ef355d-f5df-47ba-85bd-223375cd7028" },
                    { "089e2bc0-5d39-48ac-bf62-953393a40ef8", new DateTime(2022, 6, 11, 14, 2, 48, 193, DateTimeKind.Unspecified).AddTicks(7813), "6716d7f7-c425-4e56-b666-bdf8a010641b", null, "Et necessitatibus quo aliquid distinctio. Eligendi nam sit nobis sint quae et ea. Quia ex pariatur facilis autem cupiditate ab ab.", false, "[{\"role\":\"system\",\"content\":\"Eos omnis aut commodi nemo autem nihil dolores est. Voluptatem d\"}]", "gpt-4", "Illum temporibus facilis tempora. Assumenda sit est odit quia. Tenetur qui tenetur. Corporis explicabo quis.", "1e3c1d3a-2525-47a3-839b-45fb5668a7fc", 5135u, new DateTime(2022, 6, 11, 14, 2, 48, 193, DateTimeKind.Unspecified).AddTicks(7813), "6716d7f7-c425-4e56-b666-bdf8a010641b" },
                    { "1ccad048-7d57-41aa-8cd6-72cd7b1d2acb", new DateTime(2022, 6, 26, 10, 41, 37, 737, DateTimeKind.Unspecified).AddTicks(9076), "d9ef355d-f5df-47ba-85bd-223375cd7028", null, "Eligendi quos facere labore qui qui sint nesciunt. Voluptate optio fuga quia nesciunt voluptate doloremque ut. Facere tenetur laborum dolores totam. Nihil et consectetur pariatur ea ut magni quia ducimus provident. Saepe sit quis sint sapiente.", true, "[{\"role\":\"assistant\",\"content\":\"Est distinctio neque labore cumque tenetur. Mollitia ab sed beat\"},{\"role\":\"user\",\"content\":\"Odit soluta amet eos et libero a inventore tenetur. Omnis nihil\"},{\"role\":\"assistant\",\"content\":\"Nam deleniti reprehenderit quia inventore optio. Sed alias moles\"},{\"role\":\"assistant\",\"content\":\"Neque inventore nemo beatae aut. Eos occaecati quibusdam necessi\"},{\"role\":\"assistant\",\"content\":\"Quis rerum natus maxime voluptatem quis quo tenetur nihil. Imped\"},{\"role\":\"system\",\"content\":\"Ipsum libero porro nisi quos sunt est aut inventore. Deserunt od\"},{\"role\":\"system\",\"content\":\"Possimus est aut veritatis pariatur in nulla. Et iste est enim a\"}]", "gpt-4", "Enim tempore dolorum quis autem nulla. Eligendi necessitatibus ducimus sint qui voluptatem sint. Nemo ex et cum commodi sint fac", "ba5c6683-759f-47ed-8ff8-09867a0df3a0", 14347u, new DateTime(2022, 6, 26, 10, 41, 37, 737, DateTimeKind.Unspecified).AddTicks(9076), "d9ef355d-f5df-47ba-85bd-223375cd7028" },
                    { "21ea0413-bf72-4abb-8785-d370f6b1d223", new DateTime(2022, 12, 10, 5, 2, 22, 486, DateTimeKind.Unspecified).AddTicks(2162), "6716d7f7-c425-4e56-b666-bdf8a010641b", null, "Dolor aperiam nulla. Totam maiores facilis minima. Quia repellat modi.", true, "[{\"role\":\"assistant\",\"content\":\"Harum esse ut tempora omnis soluta. Quia accusamus officia accus\"},{\"role\":\"assistant\",\"content\":\"Consequatur dolorem corrupti omnis magnam modi aliquam. Maiores\"}]", "gpt-4", "Nostrum sed qui enim eligendi eaque aut repellendus quia quas. Itaque quia mollitia et magnam molestiae. Neque eveniet commodi.", "1e3c1d3a-2525-47a3-839b-45fb5668a7fc", 15858u, new DateTime(2022, 12, 10, 5, 2, 22, 486, DateTimeKind.Unspecified).AddTicks(2162), "6716d7f7-c425-4e56-b666-bdf8a010641b" },
                    { "25b919c6-12f8-4372-9b3a-c78c72a55e07", new DateTime(2022, 10, 29, 6, 22, 52, 317, DateTimeKind.Unspecified).AddTicks(4028), "904047cc-87e1-434a-bb39-89616947ac79", null, "Praesentium minima corrupti voluptatem architecto assumenda exercitationem et nisi quae. Ut consequatur qui a non rem laudantium. Et odio qui doloremque doloremque aut soluta est quas cumque.", false, "[{\"role\":\"assistant\",\"content\":\"Ad quaerat ullam aut earum. Laborum assumenda ex excepturi. Quib\"},{\"role\":\"user\",\"content\":\"Saepe labore tempora ipsa accusamus id enim. Molestias accusanti\"},{\"role\":\"system\",\"content\":\"Perspiciatis nihil beatae est ea. Provident commodi quis nihil e\"},{\"role\":\"user\",\"content\":\"Tenetur et voluptate pariatur iusto non pariatur. Voluptatem ist\"},{\"role\":\"system\",\"content\":\"Vitae nostrum perspiciatis vel. Distinctio aut rerum. Aliquam du\"}]", "gpt-3.5-trubo", "Corporis ipsum fugiat ad. Laboriosam aut ut et sed accusamus. Ut qui eligendi aspernatur consequatur dolore et nulla. Totam non", "b3ee522d-2229-42a1-be6a-2e39498feb23", 3697u, new DateTime(2022, 10, 29, 6, 22, 52, 317, DateTimeKind.Unspecified).AddTicks(4028), "904047cc-87e1-434a-bb39-89616947ac79" },
                    { "2ff2e464-3f8d-408e-bc38-f6345551b8ed", new DateTime(2023, 12, 8, 14, 27, 47, 713, DateTimeKind.Unspecified).AddTicks(8752), "1e1bf905-4379-44ed-83e5-06370b53e9cb", null, "Totam facere sit debitis provident impedit qui qui ipsam voluptas. Neque nihil laudantium deserunt dolorem animi laudantium. Earum delectus suscipit rem. Perspiciatis amet aut similique aliquam autem. Ut veniam rerum voluptatum neque voluptatem quos aut eu", true, "[{\"role\":\"system\",\"content\":\"Officiis voluptatem vitae quo asperiores sequi non ipsum natus.\"},{\"role\":\"user\",\"content\":\"Alias delectus occaecati totam voluptatibus molestias et est qua\"}]", "gpt-4", "Rem modi eos sint. Dolor repellat tempore at. Perferendis delectus velit.", "b4921aec-fdc4-42bb-9216-3a1a0ccf1ef3", 13836u, new DateTime(2023, 12, 8, 14, 27, 47, 713, DateTimeKind.Unspecified).AddTicks(8752), "1e1bf905-4379-44ed-83e5-06370b53e9cb" },
                    { "37a6572f-1c7f-465d-93f3-64d2d17ba1bb", new DateTime(2023, 1, 13, 4, 3, 25, 873, DateTimeKind.Unspecified).AddTicks(1345), "35b07873-085f-4dc1-bb82-d8f8d81e3af3", null, "Voluptates ullam et est quibusdam illum. Quibusdam et repellendus totam voluptates explicabo suscipit asperiores sed. Rerum quas aut voluptatem aut blanditiis doloremque quisquam cumque. Quidem repellat ullam ullam molestias exercitationem dolorem voluptat", true, "[{\"role\":\"user\",\"content\":\"Pariatur perferendis dicta vel facere. Delectus odio quaerat sun\"},{\"role\":\"user\",\"content\":\"Quis nam est. Maiores maxime amet laudantium quis impedit eos al\"},{\"role\":\"user\",\"content\":\"Nihil esse laborum aperiam. Architecto incidunt corporis magni u\"},{\"role\":\"user\",\"content\":\"Quas et eos deleniti beatae ipsa sunt dignissimos cupiditate. Se\"},{\"role\":\"assistant\",\"content\":\"Praesentium voluptatem deserunt sequi eos. Dolorum rerum molesti\"},{\"role\":\"assistant\",\"content\":\"Est aut rerum ut pariatur qui qui beatae explicabo. Dolorem solu\"},{\"role\":\"assistant\",\"content\":\"Repudiandae consequatur necessitatibus. Quia ea nisi illo autem\"}]", "gpt-4", "Accusantium laborum dolor. Dolores voluptatem eius qui molestiae odit. Est sequi hic ullam facilis incidunt blanditiis qui. Quis", "76f3e457-6698-497d-a58b-c4b11c8670cc", 6682u, new DateTime(2023, 1, 13, 4, 3, 25, 873, DateTimeKind.Unspecified).AddTicks(1345), "35b07873-085f-4dc1-bb82-d8f8d81e3af3" },
                    { "3c80bd34-29ad-4cfc-939f-b8d85400d8e2", new DateTime(2023, 1, 24, 1, 54, 32, 782, DateTimeKind.Unspecified).AddTicks(2492), "fdcdd379-3f30-4e0c-a445-155f03679a87", null, "Est cumque nisi doloremque consequatur labore. Id soluta sed tenetur est et consequatur. Reprehenderit dignissimos deserunt impedit ipsum impedit ut vero. Ducimus earum est. Omnis inventore impedit ab qui voluptatem iure eum.", true, "[{\"role\":\"user\",\"content\":\"Esse quae consequatur laborum omnis rerum. Officia sit perspicia\"},{\"role\":\"system\",\"content\":\"Esse enim voluptatem nisi repellendus voluptate. Quo quas quam.\"},{\"role\":\"user\",\"content\":\"Exercitationem qui doloribus quis rerum qui earum omnis perspici\"},{\"role\":\"assistant\",\"content\":\"Tempora possimus a natus accusamus odio porro qui. Nihil dolores\"}]", "gpt-4", "Fugiat in temporibus ipsum dolorem. Modi ducimus enim ducimus in et deserunt. Eos placeat dolores velit expedita atque et ut.", "15c4ef51-ae2d-4e0d-ba03-6ceaf5c8b004", 14141u, new DateTime(2023, 1, 24, 1, 54, 32, 782, DateTimeKind.Unspecified).AddTicks(2492), "fdcdd379-3f30-4e0c-a445-155f03679a87" },
                    { "5e256bcf-5ccc-4444-9a9e-dea922afb709", new DateTime(2022, 2, 8, 23, 50, 52, 65, DateTimeKind.Unspecified).AddTicks(3357), "35b07873-085f-4dc1-bb82-d8f8d81e3af3", null, "Nulla eum qui est quas explicabo est fugit. Eos dicta provident expedita dolore quisquam culpa amet qui. Ducimus itaque sed magni et voluptatem aut suscipit. Earum rerum nesciunt alias vero nobis iste cum voluptas dolores. In est soluta hic occaecati et mo", true, "[{\"role\":\"assistant\",\"content\":\"Aut nulla maiores quis corrupti alias ut. Quia expedita cumque p\"},{\"role\":\"user\",\"content\":\"Accusamus recusandae enim. Exercitationem dolores aut pariatur q\"},{\"role\":\"assistant\",\"content\":\"Cum perspiciatis atque sequi iure placeat voluptas voluptatibus\"},{\"role\":\"system\",\"content\":\"Ipsa voluptas non eaque non. Rerum a esse. Non soluta id natus i\"},{\"role\":\"system\",\"content\":\"In molestiae adipisci. Pariatur voluptatem tenetur. Et rerum eum\"},{\"role\":\"user\",\"content\":\"Repudiandae et aut facilis reprehenderit nihil saepe. Et atque v\"}]", "gpt-3.5-trubo", "Qui magni in fuga pariatur dolor. Voluptas aliquid libero aliquam doloribus et dolorem. Et quaerat eum officia eos. Debitis dolo", "76f3e457-6698-497d-a58b-c4b11c8670cc", 7390u, new DateTime(2022, 2, 8, 23, 50, 52, 65, DateTimeKind.Unspecified).AddTicks(3357), "35b07873-085f-4dc1-bb82-d8f8d81e3af3" },
                    { "720054b1-b29d-4b71-97bb-78c22ee6c4fe", new DateTime(2023, 12, 10, 23, 35, 21, 368, DateTimeKind.Unspecified).AddTicks(446), "b417ab39-3655-43d3-aa3a-aafecfd3fc58", null, "Velit animi qui id modi architecto iste. Eaque dolores qui occaecati totam veniam et in. Explicabo inventore sunt ea maiores reprehenderit iusto. Ea facilis veritatis quos accusamus delectus reprehenderit numquam illo. Incidunt dolorem minima. Quas dolor r", true, "[{\"role\":\"assistant\",\"content\":\"Sint ut aut atque. Molestiae magnam id eum ipsum perspiciatis vo\"},{\"role\":\"assistant\",\"content\":\"Animi sint facere rerum quia suscipit quo asperiores provident d\"},{\"role\":\"user\",\"content\":\"Earum rerum cupiditate dicta doloribus et et. Qui molestiae et v\"},{\"role\":\"system\",\"content\":\"Architecto in sunt nihil similique quaerat. Ut accusantium modi.\"}]", "gpt-3.5-trubo", "Consequuntur dolor enim et molestiae tempora laudantium modi temporibus excepturi. Est error et amet. Voluptatum optio aperiam v", "5fed5a78-b2e6-4a68-93ac-151db05b669a", 12379u, new DateTime(2023, 12, 10, 23, 35, 21, 368, DateTimeKind.Unspecified).AddTicks(446), "b417ab39-3655-43d3-aa3a-aafecfd3fc58" },
                    { "745fa75f-1568-46d6-b857-2426db4b98e7", new DateTime(2022, 10, 12, 6, 12, 20, 29, DateTimeKind.Unspecified).AddTicks(7204), "79afbe23-baca-45a8-85d5-d7d849d6fde2", null, "Laudantium sit quaerat saepe illo saepe sit qui. Reiciendis doloremque illo ut. Enim nesciunt eius et asperiores impedit totam laborum quo. Nulla numquam est. Atque voluptas voluptatem sed temporibus eaque. Ut alias aut alias nobis ullam atque corrupti rep", false, "[{\"role\":\"system\",\"content\":\"Et eos culpa soluta enim eaque quod magnam. Qui doloremque non d\"},{\"role\":\"assistant\",\"content\":\"Labore et ut. Et praesentium id. Consequatur harum perspiciatis\"},{\"role\":\"user\",\"content\":\"Dolor ab tenetur voluptatem et officia perferendis enim deleniti\"},{\"role\":\"user\",\"content\":\"Cum velit aliquid ut autem amet. Iste ex officia nihil. Tenetur\"},{\"role\":\"user\",\"content\":\"Soluta modi omnis laboriosam blanditiis voluptas neque. Reprehen\"},{\"role\":\"assistant\",\"content\":\"Cumque dolorem nemo et. Voluptas magnam distinctio maxime facere\"},{\"role\":\"user\",\"content\":\"Nisi sequi tempore qui et dignissimos doloribus ut ab. Corrupti\"},{\"role\":\"assistant\",\"content\":\"Autem dolorem iure consequatur. Nihil accusantium aut repellat n\"}]", "gpt-3.5-trubo", "Perspiciatis sunt dolorum unde. Sed dolorum iusto. Eum quae cupiditate temporibus dolores assumenda et non.", "e2597d0c-7e81-4af9-8583-a3dde03e0fa5", 4806u, new DateTime(2022, 10, 12, 6, 12, 20, 29, DateTimeKind.Unspecified).AddTicks(7204), "79afbe23-baca-45a8-85d5-d7d849d6fde2" },
                    { "7d294391-8e84-424b-bf47-7c0c61cc18bd", new DateTime(2022, 1, 28, 21, 35, 9, 352, DateTimeKind.Unspecified).AddTicks(2189), "d9ef355d-f5df-47ba-85bd-223375cd7028", null, "Delectus magnam velit voluptatem cumque. Sunt exercitationem beatae commodi occaecati quia. Maxime totam illo ea numquam consequatur. Dolorum aut qui cum quis. Autem dolorem et qui ut.", false, "[{\"role\":\"assistant\",\"content\":\"Molestiae ipsa voluptas laudantium ut eius inventore ut. Vero mi\"},{\"role\":\"assistant\",\"content\":\"Quos alias praesentium nobis consectetur iure. Omnis optio conse\"},{\"role\":\"assistant\",\"content\":\"Numquam voluptas tempore. Accusantium ullam itaque repellat volu\"},{\"role\":\"assistant\",\"content\":\"Qui qui sapiente dolores dicta dolores est perspiciatis aperiam\"},{\"role\":\"assistant\",\"content\":\"Exercitationem explicabo qui dicta enim voluptate. Porro quia co\"}]", "gpt-4", "Ullam enim repellendus. Pariatur unde aut voluptatem expedita. Fugiat aliquam eligendi cupiditate labore. Odio maxime ut aut por", "ba5c6683-759f-47ed-8ff8-09867a0df3a0", 11426u, new DateTime(2022, 1, 28, 21, 35, 9, 352, DateTimeKind.Unspecified).AddTicks(2189), "d9ef355d-f5df-47ba-85bd-223375cd7028" },
                    { "807fe701-ed2c-41c0-b7ac-fbe22369c7fa", new DateTime(2022, 7, 1, 23, 2, 44, 672, DateTimeKind.Unspecified).AddTicks(9890), "a08a77c1-ed0f-45c2-8333-19e33c6d550c", null, "Quo dolores omnis voluptatem ipsum nobis atque quia cum autem. Illo omnis molestias quisquam. Blanditiis consequuntur sunt ratione eum id sed voluptatem. Laudantium corrupti suscipit aut ut asperiores eos. Similique dicta et at repellat est neque recusanda", false, "[{\"role\":\"user\",\"content\":\"Iure ipsam accusantium. Rerum est minima quaerat quisquam neque\"},{\"role\":\"assistant\",\"content\":\"Quos mollitia aut rerum molestiae rerum possimus aut similique.\"}]", "gpt-4", "Aperiam facere dignissimos illum. Repellat ipsa ea harum quasi sit. Omnis maiores libero architecto eos rem velit. Repellat ut s", "2c3914f1-837d-47ab-a565-4855d89335ac", 6159u, new DateTime(2022, 7, 1, 23, 2, 44, 672, DateTimeKind.Unspecified).AddTicks(9890), "a08a77c1-ed0f-45c2-8333-19e33c6d550c" },
                    { "821b3784-29b5-46de-b6f1-2053019410ea", new DateTime(2022, 8, 26, 1, 0, 28, 944, DateTimeKind.Unspecified).AddTicks(8233), "904047cc-87e1-434a-bb39-89616947ac79", null, "Consectetur omnis rerum. Quam ex non reprehenderit dolore ut quam. Quia ut est ea voluptates numquam.", true, "[{\"role\":\"user\",\"content\":\"Eius iste sint qui ipsam iure magni. Odio impedit vel et aliquam\"},{\"role\":\"system\",\"content\":\"Quia ea molestias sequi nihil et. Magni consequatur dolor culpa\"},{\"role\":\"assistant\",\"content\":\"Itaque aut ea. Quis et repellendus tempora et minus necessitatib\"}]", "gpt-4", "Et veritatis ratione sed enim doloremque dicta. Hic enim placeat odio. At voluptates accusantium dicta voluptatem optio minus eo", "b3ee522d-2229-42a1-be6a-2e39498feb23", 5515u, new DateTime(2022, 8, 26, 1, 0, 28, 944, DateTimeKind.Unspecified).AddTicks(8233), "904047cc-87e1-434a-bb39-89616947ac79" },
                    { "8e332a74-8f95-4279-aee5-d6c4a6460d25", new DateTime(2022, 5, 14, 0, 43, 16, 575, DateTimeKind.Unspecified).AddTicks(1422), "b417ab39-3655-43d3-aa3a-aafecfd3fc58", null, "Nostrum laborum dolor magnam voluptatem beatae eveniet. Ea maxime enim repellendus sunt et. Aut qui praesentium. Blanditiis in beatae aut qui. Qui voluptas necessitatibus.", true, "[{\"role\":\"system\",\"content\":\"Est esse nulla. Ut temporibus suscipit facere ut nobis vero. Dol\"}]", "gpt-3.5-trubo", "Placeat ad quas quo ut nihil veritatis esse voluptatem. Ut nisi repudiandae repellendus qui facere vero et est vel. Dicta velit", "5fed5a78-b2e6-4a68-93ac-151db05b669a", 8309u, new DateTime(2022, 5, 14, 0, 43, 16, 575, DateTimeKind.Unspecified).AddTicks(1422), "b417ab39-3655-43d3-aa3a-aafecfd3fc58" },
                    { "9042f5ca-0e83-4080-bdf8-b373d8bbca00", new DateTime(2023, 1, 21, 19, 40, 15, 311, DateTimeKind.Unspecified).AddTicks(4572), "1e1bf905-4379-44ed-83e5-06370b53e9cb", null, "Quaerat aut rerum facere laboriosam maiores enim molestiae nihil. Impedit aliquid omnis et. Dicta animi cumque reprehenderit. Atque distinctio ducimus ducimus aut. Autem iusto officiis non temporibus totam architecto blanditiis. Ut error sit est cumque qui", true, "[{\"role\":\"system\",\"content\":\"Nam a enim. Aperiam fuga et rerum soluta omnis voluptas libero.\"},{\"role\":\"system\",\"content\":\"Error voluptatibus et id qui dolorum qui et et mollitia. Ratione\"},{\"role\":\"user\",\"content\":\"Enim exercitationem unde quis exercitationem ratione architecto\"},{\"role\":\"user\",\"content\":\"Veniam velit sint dicta quas fugiat cum ut et. Natus aperiam qui\"},{\"role\":\"system\",\"content\":\"Exercitationem assumenda asperiores quia. Aut et temporibus veli\"},{\"role\":\"system\",\"content\":\"Laborum consequatur et enim minus explicabo sit quaerat nemo. Mo\"},{\"role\":\"assistant\",\"content\":\"Sunt similique vel vel at quo. Iste sit at tenetur officia inven\"},{\"role\":\"system\",\"content\":\"Ipsam ducimus provident id ut qui praesentium. Facilis odit quas\"},{\"role\":\"assistant\",\"content\":\"Aperiam ea consequuntur voluptatum officiis qui voluptates nulla\"}]", "gpt-3.5-trubo", "Est at earum omnis. Quia dolores rerum totam. Voluptatem dolore exercitationem.", "b4921aec-fdc4-42bb-9216-3a1a0ccf1ef3", 14728u, new DateTime(2023, 1, 21, 19, 40, 15, 311, DateTimeKind.Unspecified).AddTicks(4572), "1e1bf905-4379-44ed-83e5-06370b53e9cb" },
                    { "95bea940-a75e-4d0a-89b1-dff9af8b6eed", new DateTime(2022, 9, 6, 14, 43, 16, 375, DateTimeKind.Unspecified).AddTicks(8859), "fdcdd379-3f30-4e0c-a445-155f03679a87", null, "Molestias vitae ullam aspernatur numquam quis eum hic sed est. Cum quo nulla ducimus quod in. Nostrum animi architecto ipsam error ipsum eius nemo voluptate.", true, "[{\"role\":\"user\",\"content\":\"Nisi ratione autem odit. Qui a dolorum recusandae optio possimus\"}]", "gpt-4", "Dicta quaerat est et rerum. Ducimus maiores atque perferendis quia nam aliquid in quibusdam. Aspernatur ullam cupiditate consequ", "15c4ef51-ae2d-4e0d-ba03-6ceaf5c8b004", 7518u, new DateTime(2022, 9, 6, 14, 43, 16, 375, DateTimeKind.Unspecified).AddTicks(8859), "fdcdd379-3f30-4e0c-a445-155f03679a87" },
                    { "9d711fe4-828e-4cd2-a3d5-c30f61bcb740", new DateTime(2023, 10, 15, 11, 4, 40, 228, DateTimeKind.Unspecified).AddTicks(3543), "3aa16183-949b-4717-b701-97be3bcfb21f", null, "Expedita rem laboriosam ut. Illo cum aperiam ducimus dolorem ipsa quae. Vel aut quae eum blanditiis ducimus quia atque nihil. Laboriosam et occaecati sequi vel fuga accusamus totam qui occaecati. Sed quia in maiores aperiam recusandae ut minus cumque autem", false, "[{\"role\":\"user\",\"content\":\"Accusantium vel iusto adipisci sint nam sunt. Omnis eveniet sed.\"},{\"role\":\"user\",\"content\":\"Beatae ducimus corrupti. Quia totam velit necessitatibus. Impedi\"},{\"role\":\"user\",\"content\":\"Occaecati adipisci consequatur inventore voluptas. Magni quo fug\"}]", "gpt-3.5-trubo", "Rem aperiam ut et. Dolores error ut. In iure libero consectetur quia quia magni rerum error.", "d0228915-6242-4735-b6fa-6775db709824", 8189u, new DateTime(2023, 10, 15, 11, 4, 40, 228, DateTimeKind.Unspecified).AddTicks(3543), "3aa16183-949b-4717-b701-97be3bcfb21f" },
                    { "9e009ccc-34d3-4d26-a603-922869b20622", new DateTime(2023, 8, 24, 20, 6, 34, 63, DateTimeKind.Unspecified).AddTicks(3724), "fdcdd379-3f30-4e0c-a445-155f03679a87", null, "Illum explicabo ut. Debitis est aut eius consequatur qui tenetur et illo. Et in aliquid quia est. Qui laudantium fuga odit inventore voluptas sapiente consequatur. Ratione ducimus animi.", true, "[{\"role\":\"assistant\",\"content\":\"Soluta odit alias exercitationem occaecati reiciendis at. Animi\"}]", "gpt-3.5-trubo", "Quia atque velit officiis consequatur nobis. Odit distinctio numquam perspiciatis ab vel veniam magnam numquam. Cum odio et et i", "15c4ef51-ae2d-4e0d-ba03-6ceaf5c8b004", 12666u, new DateTime(2023, 8, 24, 20, 6, 34, 63, DateTimeKind.Unspecified).AddTicks(3724), "fdcdd379-3f30-4e0c-a445-155f03679a87" },
                    { "a061322b-c3d8-40e3-b1ba-ed8724a32b91", new DateTime(2023, 8, 11, 14, 52, 30, 858, DateTimeKind.Unspecified).AddTicks(404), "a08a77c1-ed0f-45c2-8333-19e33c6d550c", null, "Facilis delectus vero quas accusantium eveniet iure aut. Iste a eaque molestiae unde illum sint iusto. Atque aut dignissimos quis iusto pariatur ad eum. Tenetur quis vitae dolorem.", false, "[{\"role\":\"assistant\",\"content\":\"Repellat nisi eveniet laudantium. Molestiae nihil ea. Modi volup\"},{\"role\":\"system\",\"content\":\"Error sequi distinctio. Optio ullam in distinctio facere. Aliqui\"},{\"role\":\"user\",\"content\":\"Quae velit temporibus et. Voluptates officia omnis laboriosam as\"},{\"role\":\"user\",\"content\":\"Autem quas dolorem molestiae non aliquid assumenda suscipit ut p\"},{\"role\":\"user\",\"content\":\"Totam tempore facilis numquam odio beatae. Sint ut necessitatibu\"},{\"role\":\"assistant\",\"content\":\"Voluptatibus amet voluptate quaerat consequatur laudantium et au\"},{\"role\":\"system\",\"content\":\"Voluptas aut magni et neque animi accusamus vero. Quod occaecati\"},{\"role\":\"user\",\"content\":\"Autem dolorem aliquam omnis ab nobis ratione omnis vel. Iure est\"}]", "gpt-3.5-trubo", "Similique qui quis voluptatum magni magnam possimus iusto. Debitis ut vero. Ea nulla et molestiae. Eum quidem hic rerum tempora", "2c3914f1-837d-47ab-a565-4855d89335ac", 1918u, new DateTime(2023, 8, 11, 14, 52, 30, 858, DateTimeKind.Unspecified).AddTicks(404), "a08a77c1-ed0f-45c2-8333-19e33c6d550c" },
                    { "c2bdc07a-3ee5-4bcb-8fb4-a927e9d614b2", new DateTime(2023, 1, 8, 5, 58, 33, 791, DateTimeKind.Unspecified).AddTicks(4908), "79afbe23-baca-45a8-85d5-d7d849d6fde2", null, "Possimus asperiores sapiente. Voluptatem distinctio temporibus et reprehenderit et. Velit deserunt dolores consectetur velit voluptatibus.", false, "[{\"role\":\"assistant\",\"content\":\"Ea et mollitia accusantium vero id dicta. Ut facilis voluptate v\"},{\"role\":\"user\",\"content\":\"Expedita velit perspiciatis aut molestias at. Et cum similique q\"},{\"role\":\"user\",\"content\":\"Voluptatem ducimus esse quisquam earum officiis id. Dolore quam\"},{\"role\":\"system\",\"content\":\"Quidem id modi architecto reiciendis autem totam. Asperiores cul\"}]", "gpt-3.5-trubo", "Sed qui temporibus sint qui ullam. Enim saepe ullam doloribus maiores odit itaque optio adipisci. Ut sint vel culpa nihil quos c", "e2597d0c-7e81-4af9-8583-a3dde03e0fa5", 5540u, new DateTime(2023, 1, 8, 5, 58, 33, 791, DateTimeKind.Unspecified).AddTicks(4908), "79afbe23-baca-45a8-85d5-d7d849d6fde2" },
                    { "c6ce5537-5601-44a7-a317-4f811ffa8ae3", new DateTime(2023, 9, 5, 18, 32, 16, 516, DateTimeKind.Unspecified).AddTicks(4662), "b417ab39-3655-43d3-aa3a-aafecfd3fc58", null, "Animi exercitationem rerum provident. Aliquam similique qui occaecati. Velit quia quam qui quaerat. Non numquam voluptas ut sint. Omnis est id voluptas officia dicta natus explicabo harum. Suscipit aut eos corrupti fugit ut.", false, "[{\"role\":\"assistant\",\"content\":\"Et consequatur dolor. Ipsum fugiat qui quis dolorum tempore. Sus\"},{\"role\":\"user\",\"content\":\"Eum quia eligendi est deserunt maxime commodi. Voluptatibus inci\"}]", "gpt-4", "Nisi est nulla. Aut nemo reprehenderit suscipit earum sed. Ex consequatur blanditiis. Odio culpa esse quia laboriosam est. Qui l", "5fed5a78-b2e6-4a68-93ac-151db05b669a", 9843u, new DateTime(2023, 9, 5, 18, 32, 16, 516, DateTimeKind.Unspecified).AddTicks(4662), "b417ab39-3655-43d3-aa3a-aafecfd3fc58" },
                    { "e708a462-370e-47f7-aceb-54892e4e7d89", new DateTime(2023, 5, 1, 16, 13, 56, 795, DateTimeKind.Unspecified).AddTicks(7126), "79afbe23-baca-45a8-85d5-d7d849d6fde2", null, "Explicabo fugiat nihil magni nam qui sapiente similique. Ex nulla dicta voluptas deserunt. Dolorum eveniet ducimus est est. Provident qui neque officia in tenetur qui et voluptatem. Consequatur itaque nulla id dolores quis assumenda eligendi maiores.", true, "[{\"role\":\"user\",\"content\":\"Assumenda et aut molestias incidunt cumque ullam. Mollitia solut\"},{\"role\":\"assistant\",\"content\":\"Quas optio placeat accusamus. Pariatur necessitatibus nulla dict\"},{\"role\":\"assistant\",\"content\":\"Cupiditate repudiandae maiores iste dolorem sint soluta placeat.\"},{\"role\":\"system\",\"content\":\"Et alias maxime atque et ex sed consequatur. Quam quaerat assume\"},{\"role\":\"assistant\",\"content\":\"Qui ipsam provident eligendi sit quia deleniti non quis adipisci\"}]", "gpt-3.5-trubo", "Porro ut nobis vel ea sint voluptatem. Quaerat itaque consequatur quia rerum asperiores inventore vero asperiores qui. Expedita", "e2597d0c-7e81-4af9-8583-a3dde03e0fa5", 8662u, new DateTime(2023, 5, 1, 16, 13, 56, 795, DateTimeKind.Unspecified).AddTicks(7126), "79afbe23-baca-45a8-85d5-d7d849d6fde2" },
                    { "eb2c0f0c-5189-40f5-bc1b-34a287faf0c5", new DateTime(2022, 10, 5, 5, 0, 40, 256, DateTimeKind.Unspecified).AddTicks(9996), "a08a77c1-ed0f-45c2-8333-19e33c6d550c", null, "Vel iusto eum laboriosam molestiae similique. Molestiae vero itaque atque animi. Qui commodi soluta non qui accusamus recusandae adipisci.", true, "[{\"role\":\"user\",\"content\":\"Eum ut quia rerum illum et voluptas officiis voluptas nulla. Lab\"}]", "gpt-4", "Eligendi numquam vitae fuga ut itaque voluptas commodi. Suscipit adipisci quisquam. Omnis corrupti omnis similique illo quasi es", "2c3914f1-837d-47ab-a565-4855d89335ac", 3334u, new DateTime(2022, 10, 5, 5, 0, 40, 256, DateTimeKind.Unspecified).AddTicks(9996), "a08a77c1-ed0f-45c2-8333-19e33c6d550c" },
                    { "f311ca0f-ea9c-462e-8243-8aac9f390793", new DateTime(2023, 11, 27, 21, 57, 52, 613, DateTimeKind.Unspecified).AddTicks(6644), "1e1bf905-4379-44ed-83e5-06370b53e9cb", null, "Explicabo blanditiis occaecati aut ut natus facilis. Magnam eius molestiae. Quam tenetur perspiciatis expedita tenetur laborum asperiores illum laudantium quia. Eum ratione ipsa omnis voluptatem molestiae animi culpa molestiae sunt. Modi ullam laudantium q", false, "[{\"role\":\"assistant\",\"content\":\"Omnis distinctio alias earum explicabo autem eius doloribus volu\"},{\"role\":\"assistant\",\"content\":\"Qui labore sit beatae sed expedita molestias nihil nihil. Nesciu\"},{\"role\":\"assistant\",\"content\":\"Saepe qui molestiae nemo perspiciatis odio. Laboriosam vel illo\"},{\"role\":\"assistant\",\"content\":\"Ipsam illum officiis ipsa dolor eos qui vitae et laudantium. Mol\"},{\"role\":\"user\",\"content\":\"Tempora fugiat dignissimos sapiente qui est. Voluptatem omnis ne\"}]", "gpt-3.5-trubo", "Repellendus eos nihil quia vel earum harum. Quo ut debitis. Consequuntur exercitationem enim necessitatibus. Excepturi id nulla", "b4921aec-fdc4-42bb-9216-3a1a0ccf1ef3", 7676u, new DateTime(2023, 11, 27, 21, 57, 52, 613, DateTimeKind.Unspecified).AddTicks(6644), "1e1bf905-4379-44ed-83e5-06370b53e9cb" },
                    { "f42c8be2-33e2-41d5-a2b5-bf9a06bc4af3", new DateTime(2022, 7, 16, 23, 56, 49, 886, DateTimeKind.Unspecified).AddTicks(985), "35b07873-085f-4dc1-bb82-d8f8d81e3af3", null, "Error architecto rerum dolores. Possimus autem molestias quasi est aliquam reprehenderit nesciunt sequi. Quia in voluptates eos. Quod ducimus facilis. Est aspernatur eos qui id suscipit enim totam est temporibus.", true, "[{\"role\":\"assistant\",\"content\":\"Culpa nisi facilis placeat veritatis recusandae molestiae. Natus\"}]", "gpt-3.5-trubo", "Harum laborum incidunt corporis sunt recusandae. Fugiat odio eligendi nisi dolorum non tempore eaque et saepe. Quam explicabo fu", "76f3e457-6698-497d-a58b-c4b11c8670cc", 1272u, new DateTime(2022, 7, 16, 23, 56, 49, 886, DateTimeKind.Unspecified).AddTicks(985), "35b07873-085f-4dc1-bb82-d8f8d81e3af3" },
                    { "f9963ffb-ee32-4aca-b140-5a158e8eb055", new DateTime(2022, 3, 28, 7, 27, 47, 308, DateTimeKind.Unspecified).AddTicks(7620), "904047cc-87e1-434a-bb39-89616947ac79", null, "Aut sit dolores recusandae. Commodi omnis minus est sint nesciunt neque earum repudiandae ipsa. Sint labore voluptates. Labore quis ex pariatur quaerat aut. Autem quibusdam et consequuntur non laboriosam nostrum in. Non praesentium cupiditate et voluptatem", false, "[{\"role\":\"system\",\"content\":\"Voluptatem enim aspernatur illum. Aut aperiam est odio commodi a\"},{\"role\":\"user\",\"content\":\"Veniam dolore vel perspiciatis. Blanditiis accusamus maxime in m\"}]", "gpt-4", "Reprehenderit qui illum quam aspernatur. Et necessitatibus sit qui totam. Unde ab rerum quasi ipsam consequatur. Animi et beatae", "b3ee522d-2229-42a1-be6a-2e39498feb23", 15899u, new DateTime(2022, 3, 28, 7, 27, 47, 308, DateTimeKind.Unspecified).AddTicks(7620), "904047cc-87e1-434a-bb39-89616947ac79" },
                    { "fba8b154-e408-4beb-b493-4cd6f04a1b49", new DateTime(2023, 4, 13, 20, 27, 54, 233, DateTimeKind.Unspecified).AddTicks(9786), "3aa16183-949b-4717-b701-97be3bcfb21f", null, "Aut quod consequatur quos quo ut provident quod et et. Quos et aliquid omnis et sapiente saepe enim eum. Iusto eum veniam et commodi quis consequatur.", false, "[{\"role\":\"assistant\",\"content\":\"Temporibus nesciunt ea provident quia animi labore. Dolorem esse\"},{\"role\":\"user\",\"content\":\"Neque quia enim perferendis ut est voluptatum. Qui architecto ex\"},{\"role\":\"user\",\"content\":\"Quod nisi ipsa voluptatum. Laudantium cupiditate et recusandae i\"},{\"role\":\"user\",\"content\":\"Nihil natus omnis eligendi mollitia fugiat vero accusamus. Quis\"},{\"role\":\"user\",\"content\":\"Illo aut ea officiis ullam quo nulla. Ab eum qui atque molestiae\"}]", "gpt-3.5-trubo", "Officiis et quod distinctio nesciunt quia et voluptas. Unde accusantium illum qui temporibus voluptas est facere. Ut aperiam ea", "d0228915-6242-4735-b6fa-6775db709824", 14566u, new DateTime(2023, 4, 13, 20, 27, 54, 233, DateTimeKind.Unspecified).AddTicks(9786), "3aa16183-949b-4717-b701-97be3bcfb21f" },
                    { "fee91e55-208e-4f3c-a7e5-85104b33dd3e", new DateTime(2023, 8, 20, 21, 30, 19, 286, DateTimeKind.Unspecified).AddTicks(8593), "6716d7f7-c425-4e56-b666-bdf8a010641b", null, "Corporis eos alias est consequuntur et voluptate autem voluptatum libero. Nisi qui praesentium sed. Delectus cumque inventore et sit. Enim beatae non reprehenderit quod. Accusamus et tenetur voluptatem ipsum similique dolor consequuntur distinctio deleniti", true, "[{\"role\":\"user\",\"content\":\"Quia expedita ipsa natus. Quo fuga adipisci cupiditate eos lauda\"},{\"role\":\"assistant\",\"content\":\"Rerum nesciunt suscipit velit ipsum sed. Harum eum aperiam volup\"}]", "gpt-4", "Recusandae a possimus adipisci ullam natus. Corporis nihil quis consequatur id maxime omnis dolorem eum. Omnis voluptatem in cum", "1e3c1d3a-2525-47a3-839b-45fb5668a7fc", 10678u, new DateTime(2023, 8, 20, 21, 30, 19, 286, DateTimeKind.Unspecified).AddTicks(8593), "6716d7f7-c425-4e56-b666-bdf8a010641b" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
