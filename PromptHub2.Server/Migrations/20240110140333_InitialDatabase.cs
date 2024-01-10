using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromptHub2.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
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
                name: "Prompts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Messages = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Tokens = table.Column<int>(type: "INTEGER", nullable: false),
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
                values: new object[] { "6597dbc4-5604-48fb-bdc7-0f7e3fc5bcff", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04b9de8b-c87d-4c4f-8004-15861cb61bb1", 0, "b12420ac-c76c-4432-8b01-a1ba55494a43", "Jamey.Mante@yahoo.com", false, false, null, "JAMEY.MANTE@YAHOO.COM", "JAMEY.MANTE@YAHOO.COM", "AQAAAAIAAYagAAAAEAHOA54yVYwfuuTYjyHOT/JXQ+f/XcumeQQqCuGPFBak7H/V3zBKHjogJgMmR1tI7Q==", null, false, "77380e25-a701-4217-92c1-5abd6dbce238", false, "Jamey.Mante@yahoo.com" },
                    { "27b9bc04-8b5f-4ec6-847f-fbc8f0464ffa", 0, "28d10d08-56c7-4aea-bf0f-76e3759769de", "Dylan_Streich@gmail.com", false, false, null, "DYLAN_STREICH@GMAIL.COM", "DYLAN_STREICH@GMAIL.COM", "AQAAAAIAAYagAAAAEDPDJAmsnXbyi8M8PYv20xC4d/nOXR+yItXmmsCFevFU+t77Dr6O0a54lTVs6KRKMg==", null, false, "862a9a42-2cdf-42aa-80cb-c7165fd3e942", false, "Dylan_Streich@gmail.com" },
                    { "2bbff763-1693-4f18-973a-eb7ee9b4a57f", 0, "eabb6f49-b9be-4007-83e2-25b8056c074c", "Alene.Beatty69@yahoo.com", false, false, null, "ALENE.BEATTY69@YAHOO.COM", "ALENE.BEATTY69@YAHOO.COM", "AQAAAAIAAYagAAAAEM7Apepycp59YZdavg+dek4Y86L7OkSQ2KcgFJyaonw6SS3K0RURrv4scYs92qVf+g==", null, false, "c115e47e-7b2d-4593-8ac4-f7a5adaf2859", false, "Alene.Beatty69@yahoo.com" },
                    { "3b021dbc-8dc6-49dd-8dc1-06b4296d8803", 0, "6702f612-981f-414f-be2f-ab688fde7a7e", "Aleen.Macejkovic@hotmail.com", false, false, null, "ALEEN.MACEJKOVIC@HOTMAIL.COM", "ALEEN.MACEJKOVIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMUfjOhhi7M6DC82WHGr0BJq+VXpYHxc2f1JFipVuatldSQQhhU+ujXT7UtzqI87tg==", null, false, "f7ed78c5-1170-41cb-aeb7-eacc85085090", false, "Aleen.Macejkovic@hotmail.com" },
                    { "5438b1ff-1d06-40cc-834e-01843181c513", 0, "4ddc7659-3f11-4965-98c2-3ad9a6f13e12", "Bonita.Morissette@hotmail.com", true, false, null, "BONITA.MORISSETTE@HOTMAIL.COM", "BONITA.MORISSETTE@HOTMAIL.COM", "AQAAAAIAAYagAAAAECW6rkU98licon+ucpz1MDTe+V+kR5IxZUOpEwTUm1pNvwB5gNqlCxj0I7CgUWzNjw==", null, false, "c0d5d7e7-eec8-498d-af50-fd7c35ccc728", false, "Bonita.Morissette@hotmail.com" },
                    { "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0", 0, "4a49ad8b-8e6e-4e39-848b-a098ee3cb073", "Santa.Hirthe99@yahoo.com", false, false, null, "SANTA.HIRTHE99@YAHOO.COM", "SANTA.HIRTHE99@YAHOO.COM", "AQAAAAIAAYagAAAAEB899SIq7clU9K7opunOWFv2aw3h1P8R9wA6ur0EHx44nyLkqlWsmfc5lUS8jXwpTw==", null, false, "c18ee14a-e3a3-48dd-9911-19aa765a8896", false, "Santa.Hirthe99@yahoo.com" },
                    { "7feaa095-4b6d-4350-abf6-f0e9a86cb361", 0, "1c4dd337-2991-46b6-b70e-4df1fd9f480e", "Francisca_Sporer@hotmail.com", false, false, null, "FRANCISCA_SPORER@HOTMAIL.COM", "FRANCISCA_SPORER@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOfRZGfrM8d58CQysnwunhQxwFUWzoq9ItjaSBPT1DolfyBIGTSHgia5NeojhBZ93Q==", null, false, "576da3f9-07e6-4d9c-8f2d-44449792480a", false, "Francisca_Sporer@hotmail.com" },
                    { "9476694c-adb9-4d6a-a751-eb692a441014", 0, "d762a250-48b7-4c00-997d-3b8b79e528c2", "Olga.Macejkovic28@gmail.com", true, false, null, "OLGA.MACEJKOVIC28@GMAIL.COM", "OLGA.MACEJKOVIC28@GMAIL.COM", "AQAAAAIAAYagAAAAEOMDfZ4GlULza1NWhrqQ11X+M0f5c4Qjz8OA5Nl0svKMncK8xmxrdnmfHzAiU2SsgQ==", null, false, "5c81b354-0c7c-458b-a036-d55e137c6503", false, "Olga.Macejkovic28@gmail.com" },
                    { "b5855118-18d3-49e8-8b69-dc38a86adf54", 0, "394be578-14da-4898-ade2-2b22dd4f9009", "Austyn53@yahoo.com", true, false, null, "AUSTYN53@YAHOO.COM", "AUSTYN53@YAHOO.COM", "AQAAAAIAAYagAAAAEOF/tYU9Rqc20416uixTTnh/HjGpPfj6iZ7MMOHBODAuHlWg7WkxxQVtVpwnAKn58w==", null, false, "e62c8ca5-862d-48e6-a893-24b121bc62ec", false, "Austyn53@yahoo.com" },
                    { "e7725b7c-4385-4d92-9ecf-cc9a2c8875a4", 0, "d595c3cf-ae3c-45ba-aec0-92fdaf74a31e", "fi.kwiatkowski@gmail.com", true, false, null, "FI.KWIATKOWSKI@GMAIL.COM", "FI.KWIATKOWSKI@GMAIL.COM", "AQAAAAIAAYagAAAAEOAPC7HQGdp0cKf/USsu+9C/ZpNIqA7efUOBMhWA4h7UxqH7mGeCifMkN6nXUyoNnA==", null, false, "78340620-246a-49e9-be39-73ed791997c0", false, "fi.kwiatkowski@gmail.com" },
                    { "f41cfcac-dfb7-46b9-a7c0-5a26903af866", 0, "3ef43e29-dce1-4f7d-af79-31f3c35d1fe6", "Lavonne9@hotmail.com", true, false, null, "LAVONNE9@HOTMAIL.COM", "LAVONNE9@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHvv0YXa+yDq5TdfsAZiPk7C5vDHZ7q+Wl2Td6YXXoaUPoUc+zDF6xgwkf7rRu6iBQ==", null, false, "2513e8b3-c7b6-431b-9788-b1b74968d77b", false, "Lavonne9@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6597dbc4-5604-48fb-bdc7-0f7e3fc5bcff", "e7725b7c-4385-4d92-9ecf-cc9a2c8875a4" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "003e3d8d-d8bc-4dbc-a47b-a0d9b6bf9bbd", new DateTime(2023, 8, 2, 15, 45, 4, 920, DateTimeKind.Unspecified).AddTicks(6257), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Amet alias magnam impedit exercitationem. Sit rerum temporibus sapiente aut repellat itaque explicabo eius qui. Recusandae et omnis consectetur quis voluptas quia est. Nostrum fugiat velit aspernatur sint et cupiditate.", false, "Ut ratione sed aut adipisci in dolor asperiores. Quia voluptatem nesciunt non at. Cumque dignissimos consequatur deserunt. Debit", new DateTime(2023, 8, 2, 15, 45, 4, 920, DateTimeKind.Unspecified).AddTicks(6257), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "09d86378-0536-42f3-8d14-815082d714b2", new DateTime(2023, 2, 2, 21, 53, 44, 733, DateTimeKind.Unspecified).AddTicks(3267), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Sunt qui molestiae et unde odio itaque excepturi. Et ut vitae. Magni a eos rerum occaecati. Sunt mollitia ea molestiae esse earum suscipit quo dolores laboriosam. Qui non accusamus.", false, "Quas architecto eligendi quis eveniet. Amet ea distinctio aut quia quo velit. Et veniam officia libero delectus in molestias mol", new DateTime(2023, 2, 2, 21, 53, 44, 733, DateTimeKind.Unspecified).AddTicks(3267), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "4edf1038-8b44-4069-adff-d0a843bdfca0", new DateTime(2022, 6, 14, 7, 0, 52, 291, DateTimeKind.Unspecified).AddTicks(6443), "f41cfcac-dfb7-46b9-a7c0-5a26903af866", null, "Nisi sunt libero nulla consectetur unde. Voluptas iste reiciendis. Deserunt libero similique. Ipsum dolores possimus sapiente ipsa ea. Sunt quasi assumenda ducimus.", true, "Est harum sit natus dolorum. Fugit aut autem veniam. Maxime nisi ad nam et et non quia quis deleniti. Ut itaque autem omnis ab.", new DateTime(2022, 6, 14, 7, 0, 52, 291, DateTimeKind.Unspecified).AddTicks(6443), "f41cfcac-dfb7-46b9-a7c0-5a26903af866" },
                    { "5b556df5-0579-41ed-a6e5-a5d1e70c44a5", new DateTime(2023, 9, 23, 15, 38, 35, 863, DateTimeKind.Unspecified).AddTicks(2041), "b5855118-18d3-49e8-8b69-dc38a86adf54", null, "Eum neque iure. Rerum consequatur libero ipsa et exercitationem. Molestiae sit veniam voluptas voluptatem ratione est facere expedita deserunt. Maiores dolorem velit quo nihil. Hic adipisci hic culpa libero et sed rem nostrum.", true, "Ex odit fuga. Sed nisi sit aut omnis autem laboriosam et dicta iusto. Quasi corporis aliquid corporis doloribus. Corporis rerum", new DateTime(2023, 9, 23, 15, 38, 35, 863, DateTimeKind.Unspecified).AddTicks(2041), "b5855118-18d3-49e8-8b69-dc38a86adf54" },
                    { "70c2286b-dd63-47cc-8671-4b6000d604fa", new DateTime(2022, 4, 1, 16, 2, 43, 394, DateTimeKind.Unspecified).AddTicks(8024), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0", null, "Voluptas necessitatibus molestiae quis facilis iste. Temporibus aliquam et atque laborum quam voluptas. Hic quae esse quia ut. Dolorem sed et.", false, "Inventore inventore eaque velit voluptatem eos quasi vel vel. Possimus alias hic nisi omnis. Harum aut laborum totam velit illo", new DateTime(2022, 4, 1, 16, 2, 43, 394, DateTimeKind.Unspecified).AddTicks(8024), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0" },
                    { "b765b91e-ca3c-4c2d-bd16-5b95c0187cbd", new DateTime(2022, 11, 24, 22, 16, 51, 889, DateTimeKind.Unspecified).AddTicks(5728), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Consectetur itaque tenetur ea porro laborum rem et aut dolor. Ut labore magnam. Commodi placeat quod animi aut consequuntur vitae eaque. Omnis qui reprehenderit. Quia ipsam commodi quia voluptatem. Doloremque ducimus et tempora commodi enim et.", true, "Quae ut eaque ut voluptatibus. Quas tenetur id laborum qui non placeat sed aliquam. Non laborum fugiat labore iusto eum sunt con", new DateTime(2022, 11, 24, 22, 16, 51, 889, DateTimeKind.Unspecified).AddTicks(5728), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "c3d7b39b-b144-4b4d-ba2f-2b8a74487569", new DateTime(2022, 6, 7, 6, 56, 5, 91, DateTimeKind.Unspecified).AddTicks(8569), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Praesentium quia fuga atque ratione laudantium molestiae unde cum. Aut et repellendus. Rerum corrupti et doloribus. Sed modi deserunt dolore recusandae molestiae culpa provident et fugit.", false, "Asperiores id ut aperiam vero cum quidem sint ratione. Tempora recusandae molestiae sed natus ipsam quis ab. Ducimus et quod aut", new DateTime(2022, 6, 7, 6, 56, 5, 91, DateTimeKind.Unspecified).AddTicks(8569), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "c40f61e1-aac9-49b2-8643-ae4fac8371e7", new DateTime(2023, 12, 19, 3, 34, 31, 676, DateTimeKind.Unspecified).AddTicks(6820), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Eos qui quo earum sunt vero molestiae velit non maiores. Vel atque totam aperiam animi est voluptas. Deserunt ut natus commodi qui odio. Quisquam et deleniti in alias et.", true, "Eum dolore excepturi doloribus nesciunt facilis sed. Aut eos rerum et et libero. Nemo eligendi hic cumque quis.", new DateTime(2023, 12, 19, 3, 34, 31, 676, DateTimeKind.Unspecified).AddTicks(6820), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "cd7e512e-0435-4a18-81f2-15f4bafe9f5f", new DateTime(2022, 7, 23, 4, 42, 15, 88, DateTimeKind.Unspecified).AddTicks(9560), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Quibusdam non voluptas qui modi. Et animi voluptas eaque similique. Cumque maxime minima.", true, "Provident aut dolores quibusdam reprehenderit qui. Iste sit pariatur eos dolor ut consequatur. Est hic ea unde qui.", new DateTime(2022, 7, 23, 4, 42, 15, 88, DateTimeKind.Unspecified).AddTicks(9560), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "eba3fa77-60df-4b41-91cc-d95435fa758f", new DateTime(2023, 4, 24, 12, 11, 52, 800, DateTimeKind.Unspecified).AddTicks(6249), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Qui consequatur nesciunt non reiciendis ea laboriosam autem dolores. Et aut et et saepe consequuntur et non mollitia. Assumenda tenetur consequatur libero inventore expedita quo. Atque laborum et accusantium libero.", false, "Sint est est veniam qui quas facilis qui sed. Delectus nostrum excepturi illo repellat laboriosam minus ipsa. Voluptatem reprehe", new DateTime(2023, 4, 24, 12, 11, 52, 800, DateTimeKind.Unspecified).AddTicks(6249), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "018470f2-15ff-4199-933e-30fc474f99a2", new DateTime(2022, 4, 11, 9, 25, 27, 274, DateTimeKind.Unspecified).AddTicks(5343), "b5855118-18d3-49e8-8b69-dc38a86adf54", null, "Eos neque assumenda sit voluptate aut voluptate. Animi tempore ut qui velit aut porro. Aperiam dolores fuga accusantium consequatur cumque.", true, "[{\"role\":\"user\",\"content\":\"Architecto nulla est quo natus delectus. Dolorem omnis exercitat\"},{\"role\":\"system\",\"content\":\"Voluptatibus asperiores et placeat cumque aut magnam est sed. De\"},{\"role\":\"assistant\",\"content\":\"Mollitia expedita dolores quaerat hic nihil sit et dolores. Prov\"},{\"role\":\"assistant\",\"content\":\"Et deserunt delectus laboriosam non ut. Perferendis dolore enim\"},{\"role\":\"assistant\",\"content\":\"Numquam molestiae vel aut ab. Sit et sint ea nisi. Non pariatur\"},{\"role\":\"user\",\"content\":\"Dolorum quia dolorem iure et. Consequatur asperiores velit et et\"},{\"role\":\"user\",\"content\":\"Porro iste inventore magni voluptatem totam facilis. Autem conse\"}]", "gpt-4", "Ea ex quis quia et quia. Quibusdam voluptatem porro porro at excepturi dicta voluptas facere distinctio. Veritatis et porro recu", "5b556df5-0579-41ed-a6e5-a5d1e70c44a5", 15170, new DateTime(2022, 4, 11, 9, 25, 27, 274, DateTimeKind.Unspecified).AddTicks(5343), "b5855118-18d3-49e8-8b69-dc38a86adf54" },
                    { "0227d229-d533-4a76-9b32-0a1e64701d5f", new DateTime(2022, 4, 3, 17, 45, 6, 382, DateTimeKind.Unspecified).AddTicks(7654), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Repellendus omnis blanditiis quo omnis. Vel rerum suscipit at aspernatur corporis amet ipsam. Velit veritatis corporis facere eius est eveniet qui occaecati.", false, "[{\"role\":\"assistant\",\"content\":\"Qui quia necessitatibus exercitationem. Aut quisquam laborum dol\"},{\"role\":\"user\",\"content\":\"Qui sed molestiae assumenda est totam voluptatem porro. Non magn\"},{\"role\":\"system\",\"content\":\"Sed qui esse corporis voluptates in ut. Voluptatibus sapiente li\"},{\"role\":\"user\",\"content\":\"Eum tempore commodi aut placeat et quo quaerat id asperiores. Ma\"}]", "gpt-3.5-trubo", "Error numquam labore. Et placeat porro velit sed blanditiis. Incidunt molestiae suscipit autem corporis explicabo sequi deserunt", "c40f61e1-aac9-49b2-8643-ae4fac8371e7", 12796, new DateTime(2022, 4, 3, 17, 45, 6, 382, DateTimeKind.Unspecified).AddTicks(7654), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "08ce01a5-602a-4be8-a4bd-10e3498c452b", new DateTime(2023, 9, 23, 4, 58, 20, 533, DateTimeKind.Unspecified).AddTicks(1348), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Animi dolores dolorem nihil aliquid quia. Et nostrum tempore sapiente aspernatur commodi. Ab est velit eaque. Numquam sit explicabo eos.", false, "[{\"role\":\"user\",\"content\":\"At nobis dolores quas accusantium consequatur. Sunt ut est neque\"},{\"role\":\"user\",\"content\":\"Omnis eos molestiae necessitatibus deserunt expedita commodi tem\"},{\"role\":\"system\",\"content\":\"Magni consectetur possimus illo dicta. Sit amet enim aut earum i\"}]", "gpt-3.5-trubo", "Minima dicta nobis ut sapiente rerum libero et. Ea molestiae dicta recusandae quia. Praesentium sint qui eos modi dolorem molest", "09d86378-0536-42f3-8d14-815082d714b2", 9353, new DateTime(2023, 9, 23, 4, 58, 20, 533, DateTimeKind.Unspecified).AddTicks(1348), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "093b200c-1479-482a-8b84-8b369f337131", new DateTime(2023, 1, 17, 11, 37, 14, 230, DateTimeKind.Unspecified).AddTicks(9432), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Ratione perspiciatis assumenda laborum mollitia. Vel accusamus dicta consequatur enim consequuntur consectetur ut. Quisquam et officia nobis voluptatum eaque unde.", true, "[{\"role\":\"assistant\",\"content\":\"Est nostrum et odit non enim molestiae id cum officia. Provident\"},{\"role\":\"assistant\",\"content\":\"Ea illo expedita. Tempore quos dicta. Veritatis quia fugiat et q\"},{\"role\":\"system\",\"content\":\"Hic voluptas recusandae quidem necessitatibus rem. Ut aut ad mag\"},{\"role\":\"user\",\"content\":\"Tenetur sint facere quasi fugiat consequatur quia voluptate. Acc\"},{\"role\":\"system\",\"content\":\"Magnam optio ratione numquam commodi. Dolor ex aspernatur corpor\"},{\"role\":\"user\",\"content\":\"Tempore laboriosam repellendus quibusdam accusantium eius. Est a\"},{\"role\":\"assistant\",\"content\":\"Libero qui sed rem necessitatibus sit sunt. Sed eum alias. Asper\"},{\"role\":\"user\",\"content\":\"In et et sapiente et quasi odit. Harum repellendus quas dolor en\"}]", "gpt-3.5-trubo", "In aut dolorum dolorum. Voluptatem voluptates perferendis id nisi voluptatem labore qui consequatur non. Temporibus fugiat imped", "c40f61e1-aac9-49b2-8643-ae4fac8371e7", 7507, new DateTime(2023, 1, 17, 11, 37, 14, 230, DateTimeKind.Unspecified).AddTicks(9432), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "1a34e83a-d8e4-4e94-9f12-f3800733de6f", new DateTime(2023, 12, 16, 22, 0, 48, 860, DateTimeKind.Unspecified).AddTicks(7938), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0", null, "Expedita magnam occaecati quis cumque laborum minus quos quibusdam. Est tempora nemo. Deleniti rerum et voluptatem magni ratione. Voluptas quis ut amet. Error voluptas qui soluta inventore dolorem est consequatur.", false, "[{\"role\":\"system\",\"content\":\"Officia repellendus sed saepe dolorem fugiat mollitia porro repr\"},{\"role\":\"user\",\"content\":\"Rerum sit laudantium laudantium atque. Earum placeat ut omnis do\"},{\"role\":\"system\",\"content\":\"Ea amet rem autem saepe dolore optio qui et et. Ut nobis consequ\"},{\"role\":\"user\",\"content\":\"Commodi sit asperiores sit non corrupti consequatur quibusdam ip\"},{\"role\":\"system\",\"content\":\"Reprehenderit perspiciatis vitae asperiores aut nemo. Unde volup\"},{\"role\":\"user\",\"content\":\"Iusto molestiae et laborum ea sed non vitae. Dolorum quo at susc\"},{\"role\":\"system\",\"content\":\"Consequatur et non natus et. Voluptatum sed fugit ipsum quos aut\"},{\"role\":\"assistant\",\"content\":\"Explicabo facilis illum. Necessitatibus dolor et. Eum veritatis\"},{\"role\":\"user\",\"content\":\"Reprehenderit veritatis aperiam quae quia laudantium velit recus\"},{\"role\":\"user\",\"content\":\"Dolor omnis ipsa repellat quia. Sed dolores delectus enim quo ex\"}]", "gpt-4", "Impedit porro laboriosam dolores iure repellendus quia. Sint rerum ea quo totam. Dolorum qui dolorem vel et similique sed dolore", "70c2286b-dd63-47cc-8671-4b6000d604fa", 12123, new DateTime(2023, 12, 16, 22, 0, 48, 860, DateTimeKind.Unspecified).AddTicks(7938), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0" },
                    { "23bf3f6d-f31f-400d-ade2-7b77515fc36d", new DateTime(2022, 11, 6, 21, 18, 9, 877, DateTimeKind.Unspecified).AddTicks(4040), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Nam repellat qui nisi. Nihil qui dolores. Eligendi sunt odio perspiciatis. Ut tempore id dolorem. Qui sed ex ipsam atque est nobis.", false, "[{\"role\":\"system\",\"content\":\"Neque doloribus vero est voluptatibus deleniti molestiae recusan\"},{\"role\":\"user\",\"content\":\"Nulla vel et optio doloribus. Fuga enim amet exercitationem ea c\"}]", "gpt-3.5-trubo", "Officiis dolores aliquid voluptas et aspernatur aliquid natus culpa. Aliquam ut nam dolorum et iste et culpa. Sint sed aut volup", "cd7e512e-0435-4a18-81f2-15f4bafe9f5f", 10851, new DateTime(2022, 11, 6, 21, 18, 9, 877, DateTimeKind.Unspecified).AddTicks(4040), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "2b3c507c-b4b3-4c16-936b-916d9b55ef2f", new DateTime(2022, 5, 10, 8, 5, 6, 431, DateTimeKind.Unspecified).AddTicks(8622), "f41cfcac-dfb7-46b9-a7c0-5a26903af866", null, "Dolorem ea corrupti similique aperiam provident id vitae totam. Amet dolores dolorum quaerat ut. Voluptatibus eum enim qui. Commodi eos accusamus sit placeat totam ut.", true, "[{\"role\":\"assistant\",\"content\":\"Ad et dolorum et amet. Inventore consequuntur ut aspernatur itaq\"},{\"role\":\"assistant\",\"content\":\"Ea quasi ipsam consequatur ut provident et et soluta. Omnis est\"},{\"role\":\"assistant\",\"content\":\"Iste recusandae qui. Eum dicta architecto. Praesentium quas pers\"},{\"role\":\"assistant\",\"content\":\"Nobis laudantium repellendus atque cumque ipsam rerum minima sit\"},{\"role\":\"assistant\",\"content\":\"Autem qui omnis delectus blanditiis et at sed velit accusamus. M\"},{\"role\":\"assistant\",\"content\":\"Eligendi est quia commodi. Quis veniam corporis. Sint tempora re\"},{\"role\":\"user\",\"content\":\"Magnam hic dolor et odio vel veritatis. Accusamus architecto mag\"},{\"role\":\"assistant\",\"content\":\"Esse culpa temporibus ex. Nihil nulla enim perspiciatis expedita\"},{\"role\":\"system\",\"content\":\"Perspiciatis et suscipit deleniti provident vel ea. Repudiandae\"}]", "gpt-3.5-trubo", "Est exercitationem cupiditate in aspernatur aspernatur necessitatibus cupiditate. Vitae voluptatibus quis et velit quibusdam aut", "4edf1038-8b44-4069-adff-d0a843bdfca0", 5690, new DateTime(2022, 5, 10, 8, 5, 6, 431, DateTimeKind.Unspecified).AddTicks(8622), "f41cfcac-dfb7-46b9-a7c0-5a26903af866" },
                    { "4110c427-c1c8-4dd9-b277-43d271b4328e", new DateTime(2023, 3, 2, 15, 13, 1, 783, DateTimeKind.Unspecified).AddTicks(6414), "f41cfcac-dfb7-46b9-a7c0-5a26903af866", null, "Maiores non et tempora nesciunt vero voluptatem. Placeat repellat explicabo ut modi accusantium repellat. Soluta explicabo ratione quod eius beatae ut voluptas. Aut ad rerum quia facere quia.", true, "[{\"role\":\"assistant\",\"content\":\"Dicta minima ducimus molestiae suscipit eaque vel aut ipsa corru\"},{\"role\":\"assistant\",\"content\":\"Commodi aut quibusdam mollitia facere. Dolorum excepturi fugit a\"},{\"role\":\"system\",\"content\":\"Earum voluptatibus eius. Modi et harum suscipit veritatis. Sequi\"},{\"role\":\"assistant\",\"content\":\"Dolorem saepe tempore dolore aspernatur aut dolor et. Natus offi\"},{\"role\":\"user\",\"content\":\"Excepturi vitae rerum tempora omnis aperiam est quo expedita tot\"},{\"role\":\"assistant\",\"content\":\"Odit aut quaerat error quidem ratione voluptas eum. Illum facili\"},{\"role\":\"assistant\",\"content\":\"Non similique modi dolorem nisi reprehenderit itaque voluptatibu\"},{\"role\":\"system\",\"content\":\"Unde dolor ullam tempora et. Qui iste et aut odit amet rerum. Au\"},{\"role\":\"user\",\"content\":\"Et ullam qui animi perspiciatis et fugit sint quia. Omnis ut por\"},{\"role\":\"assistant\",\"content\":\"Vitae voluptas rerum molestiae. Rerum eos sint. Aperiam consequa\"}]", "gpt-3.5-trubo", "Quos amet amet consectetur odit sit et. Qui ipsa quia dignissimos asperiores magni exercitationem debitis. Error possimus eum vo", "4edf1038-8b44-4069-adff-d0a843bdfca0", 5565, new DateTime(2023, 3, 2, 15, 13, 1, 783, DateTimeKind.Unspecified).AddTicks(6414), "f41cfcac-dfb7-46b9-a7c0-5a26903af866" },
                    { "41190984-c234-47df-9878-2eae37f587f0", new DateTime(2022, 8, 17, 17, 58, 1, 815, DateTimeKind.Unspecified).AddTicks(7551), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Praesentium voluptate ut. Quibusdam ducimus vitae voluptatem ut doloremque. Rerum aut cum totam architecto ipsam. Consequatur qui consectetur saepe atque. Nemo voluptate provident fugiat harum beatae veniam.", true, "[{\"role\":\"user\",\"content\":\"Illum sed et fugiat quod sequi magnam aspernatur ratione eius. T\"},{\"role\":\"user\",\"content\":\"Corporis occaecati est eius ab ut explicabo vel occaecati. Incid\"}]", "gpt-4", "Eum qui occaecati cupiditate molestias aut. Rerum porro molestiae. Nostrum placeat saepe et voluptatem eum.", "c3d7b39b-b144-4b4d-ba2f-2b8a74487569", 14660, new DateTime(2022, 8, 17, 17, 58, 1, 815, DateTimeKind.Unspecified).AddTicks(7551), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "439668cb-3e9b-4fb2-8011-ca8e0250eeb3", new DateTime(2023, 1, 20, 4, 14, 36, 629, DateTimeKind.Unspecified).AddTicks(560), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Molestiae explicabo temporibus voluptatem et aperiam repudiandae. Laboriosam quod dolorem temporibus neque. Ut expedita eum eaque. Sapiente voluptatem autem magni eveniet pariatur placeat ipsam. Doloribus quidem omnis nemo ut distinctio dolor eveniet.", true, "[{\"role\":\"assistant\",\"content\":\"Magni aut ut vitae autem velit placeat excepturi voluptatibus so\"},{\"role\":\"assistant\",\"content\":\"Consequatur omnis rem eius laudantium fugiat. Voluptatem beatae\"},{\"role\":\"system\",\"content\":\"Porro quae animi possimus. Rerum delectus mollitia vero. Volupta\"}]", "gpt-3.5-trubo", "Ducimus illo fuga maxime doloribus temporibus. Quaerat accusantium eos et iusto minus magnam quo dignissimos laudantium. Illum a", "003e3d8d-d8bc-4dbc-a47b-a0d9b6bf9bbd", 6718, new DateTime(2023, 1, 20, 4, 14, 36, 629, DateTimeKind.Unspecified).AddTicks(560), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "45c3362e-220c-48c8-9656-1caf7da76cbd", new DateTime(2023, 9, 9, 21, 29, 10, 290, DateTimeKind.Unspecified).AddTicks(8145), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Aut laudantium maiores et inventore doloribus excepturi. Sapiente et quasi quidem sed voluptatem animi. In similique autem. At ipsam et in est culpa et assumenda. Sunt aut sed dolorem est nulla qui. Neque est repellat ut recusandae aliquam suscipit et sit.", true, "[{\"role\":\"assistant\",\"content\":\"Nemo facilis totam voluptatem ea sunt ut. Omnis magnam qui volup\"},{\"role\":\"system\",\"content\":\"Ea cum reiciendis labore odit modi reiciendis assumenda. Officia\"},{\"role\":\"user\",\"content\":\"Illum minima quasi sit cumque maiores enim totam. Voluptatem cup\"},{\"role\":\"system\",\"content\":\"Ut et autem porro totam iure facilis tempore. Rem quibusdam corp\"}]", "gpt-3.5-trubo", "Voluptatem dolorum aut itaque molestiae. Dolore quos velit omnis. Voluptatem omnis sint.", "c40f61e1-aac9-49b2-8643-ae4fac8371e7", 12809, new DateTime(2023, 9, 9, 21, 29, 10, 290, DateTimeKind.Unspecified).AddTicks(8145), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "4655dfa9-e80a-41b8-9bc4-ce14ced63c1f", new DateTime(2022, 4, 4, 23, 36, 21, 966, DateTimeKind.Unspecified).AddTicks(2391), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Veritatis sint aperiam tempore. Dolorum quia autem sequi sit id corporis. Fugiat omnis tempore nobis voluptatem fugiat quia voluptate. Enim ratione nesciunt voluptates et tempora dolorum voluptate.", false, "[{\"role\":\"assistant\",\"content\":\"Excepturi distinctio ut voluptatem amet dignissimos quam sapient\"},{\"role\":\"assistant\",\"content\":\"Corrupti est voluptatum et ullam labore. Dignissimos et illo ass\"},{\"role\":\"system\",\"content\":\"Velit quia et dolorum voluptate quidem. Est neque corporis tenet\"}]", "gpt-4", "Non excepturi unde explicabo doloribus. Labore iste omnis voluptatem dolorem dolor nisi quibusdam. Et illo accusantium sit aut v", "c3d7b39b-b144-4b4d-ba2f-2b8a74487569", 4721, new DateTime(2022, 4, 4, 23, 36, 21, 966, DateTimeKind.Unspecified).AddTicks(2391), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "489b1282-bf79-4215-95f1-88ee1188a5df", new DateTime(2022, 2, 24, 9, 42, 51, 814, DateTimeKind.Unspecified).AddTicks(7632), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Facere quis tenetur laborum suscipit quos repudiandae eligendi non. Ea ut architecto fuga quis enim voluptatem. Sit perspiciatis dolorum sunt saepe et quod. Est dolor aperiam qui iste non quae.", false, "[{\"role\":\"user\",\"content\":\"Hic tempora magni sit facere deleniti porro. Doloremque quia err\"},{\"role\":\"user\",\"content\":\"Et sit at repellat laudantium odio qui. Repellendus cum ipsum iu\"},{\"role\":\"system\",\"content\":\"Deserunt ipsam sunt repudiandae molestiae rem sed quam suscipit\"},{\"role\":\"system\",\"content\":\"Et quibusdam eos hic aspernatur rerum aperiam. Sint ex iure vel\"},{\"role\":\"assistant\",\"content\":\"Illo a quisquam et. Quia earum omnis assumenda ullam odit aliqui\"},{\"role\":\"system\",\"content\":\"Corporis reprehenderit corporis molestias expedita sed laudantiu\"},{\"role\":\"user\",\"content\":\"Hic similique et blanditiis iure itaque deleniti dignissimos. Su\"},{\"role\":\"system\",\"content\":\"Eum aut est. Optio libero sed aut qui omnis sint illum aut. Sit\"},{\"role\":\"user\",\"content\":\"Similique repudiandae minus. Qui dolorem error hic repudiandae s\"}]", "gpt-4", "Molestias est est omnis accusantium et vel optio quae nostrum. Impedit est aut expedita consequatur corrupti. Ex placeat velit.", "eba3fa77-60df-4b41-91cc-d95435fa758f", 15137, new DateTime(2022, 2, 24, 9, 42, 51, 814, DateTimeKind.Unspecified).AddTicks(7632), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "58575b18-01e2-481a-9151-f2fbec594dc7", new DateTime(2023, 12, 8, 13, 58, 3, 74, DateTimeKind.Unspecified).AddTicks(8847), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Sit libero ut incidunt unde harum. Veritatis officiis quo itaque odit. Voluptatibus ratione laudantium omnis sint molestiae et neque porro aut. Qui libero sed voluptas quia molestiae fugit.", false, "[{\"role\":\"user\",\"content\":\"Iste aut blanditiis nisi eos dolores esse vel consequatur assume\"},{\"role\":\"assistant\",\"content\":\"Perspiciatis quo tempora incidunt ea veniam. Aut mollitia velit\"},{\"role\":\"assistant\",\"content\":\"Facere sed reiciendis quaerat ut. Perferendis numquam natus ab d\"},{\"role\":\"assistant\",\"content\":\"Voluptates nam autem reiciendis nesciunt. Recusandae voluptas re\"},{\"role\":\"user\",\"content\":\"Vitae eos consequatur. Et eum asperiores molestiae omnis qui. Ea\"},{\"role\":\"system\",\"content\":\"Est in ut ipsam aut hic sint deserunt quis. Deleniti debitis arc\"},{\"role\":\"assistant\",\"content\":\"Excepturi sapiente dolore voluptatem fugit. Et in quis fugit per\"},{\"role\":\"system\",\"content\":\"Temporibus quis veniam. Cum atque deserunt sunt dolore consectet\"},{\"role\":\"assistant\",\"content\":\"Nobis fuga ut qui quae optio provident quia omnis dolores. Quasi\"}]", "gpt-4", "Delectus voluptatem occaecati amet velit nihil. Fugiat sit ex sed earum quaerat laboriosam fugit. Soluta aut repellat consequatu", "eba3fa77-60df-4b41-91cc-d95435fa758f", 3551, new DateTime(2023, 12, 8, 13, 58, 3, 74, DateTimeKind.Unspecified).AddTicks(8847), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "5a6e82a3-d9f5-482c-846c-df5f6cf65c93", new DateTime(2022, 8, 31, 2, 53, 29, 923, DateTimeKind.Unspecified).AddTicks(3865), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Maiores voluptatum qui est. Error culpa vero illo amet. Qui quo repellat qui id excepturi facere minima ut ut. Assumenda rem impedit ut. Laborum fuga odio rem. Eius numquam explicabo et ea.", false, "[{\"role\":\"assistant\",\"content\":\"Doloribus voluptatem quae voluptates dolorem aut sunt. Nesciunt\"},{\"role\":\"system\",\"content\":\"Distinctio ipsam voluptate et provident esse et laboriosam conse\"},{\"role\":\"assistant\",\"content\":\"Consequatur tempore ab eum voluptatem. Adipisci sunt similique r\"},{\"role\":\"user\",\"content\":\"Non sit veritatis voluptatem architecto. Eos ipsum omnis consequ\"},{\"role\":\"system\",\"content\":\"In error sequi. Ratione voluptatibus ut harum autem. Modi cumque\"}]", "gpt-4", "Eius dolorem modi iure ea. Animi consequatur provident et omnis cum consequatur sed et. Vel non consequatur ipsa ea dolorem in o", "b765b91e-ca3c-4c2d-bd16-5b95c0187cbd", 2060, new DateTime(2022, 8, 31, 2, 53, 29, 923, DateTimeKind.Unspecified).AddTicks(3865), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "62b16ddd-6eab-4652-8385-6244e4377b97", new DateTime(2023, 7, 5, 3, 30, 56, 23, DateTimeKind.Unspecified).AddTicks(765), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Rem quam vitae facilis voluptatem est nostrum ducimus adipisci dolores. Aut est dolorum sint et tempora rerum commodi quos qui. Aliquam mollitia non id. Aut magnam blanditiis. Voluptatem et molestias autem.", false, "[{\"role\":\"user\",\"content\":\"Autem deserunt provident. Molestias recusandae dolores libero ut\"},{\"role\":\"assistant\",\"content\":\"Dicta provident ex maiores eos excepturi aut dignissimos. Qui la\"},{\"role\":\"assistant\",\"content\":\"Quaerat et quia quis est nisi adipisci exercitationem pariatur s\"},{\"role\":\"system\",\"content\":\"Eum corrupti sequi quia qui iste ut. Qui a officia earum a dolor\"},{\"role\":\"assistant\",\"content\":\"Est consequuntur porro dolore sit doloremque voluptate corrupti.\"}]", "gpt-4", "Libero modi nihil. Nihil voluptatibus minus non at eum velit dolorum et culpa. Ipsum adipisci sit et repudiandae sed aut rerum c", "cd7e512e-0435-4a18-81f2-15f4bafe9f5f", 10020, new DateTime(2023, 7, 5, 3, 30, 56, 23, DateTimeKind.Unspecified).AddTicks(765), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "7f7a2853-5d5b-4529-8691-a458f76122b9", new DateTime(2023, 3, 27, 0, 7, 49, 943, DateTimeKind.Unspecified).AddTicks(6224), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0", null, "Rerum unde nihil inventore blanditiis officiis possimus perspiciatis in. Architecto sed et dolores natus qui alias alias est. Ut placeat modi possimus odio alias corporis voluptas.", false, "[{\"role\":\"user\",\"content\":\"Qui ab tempore quibusdam nemo nihil quod debitis aut eaque. Volu\"},{\"role\":\"assistant\",\"content\":\"Ea repellat distinctio animi eos labore. Nesciunt ut illum qui n\"},{\"role\":\"system\",\"content\":\"Impedit ullam voluptas impedit id dolorem ex. Voluptatibus illo\"},{\"role\":\"system\",\"content\":\"Cupiditate beatae aut doloremque impedit molestiae perspiciatis\"},{\"role\":\"system\",\"content\":\"Atque ea omnis illum repellendus ullam ullam reprehenderit. Dolo\"}]", "gpt-3.5-trubo", "Esse vitae qui possimus officia omnis doloribus distinctio dolores quibusdam. Unde dignissimos et at explicabo. Culpa non porro", "70c2286b-dd63-47cc-8671-4b6000d604fa", 6328, new DateTime(2023, 3, 27, 0, 7, 49, 943, DateTimeKind.Unspecified).AddTicks(6224), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0" },
                    { "7fe4bb5d-aee8-42cf-a162-06b7a15c59eb", new DateTime(2023, 11, 18, 7, 24, 37, 724, DateTimeKind.Unspecified).AddTicks(6792), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Illum nihil fugit vitae ea consequatur sunt incidunt qui ut. Modi rerum in accusamus ipsam et animi animi. Facilis repudiandae eius ut aut. Qui nihil id facere est et sapiente. Assumenda ratione reprehenderit deserunt praesentium aut aut.", true, "[{\"role\":\"system\",\"content\":\"Totam ipsam molestiae. Voluptatem est eius fuga. Asperiores volu\"},{\"role\":\"system\",\"content\":\"Cupiditate omnis est ut natus iste. Quia consequatur dolorum neq\"},{\"role\":\"system\",\"content\":\"Ullam veritatis expedita harum nam eveniet. Ad accusantium aliqu\"}]", "gpt-3.5-trubo", "Aut error praesentium earum consequatur mollitia nihil dignissimos. Excepturi itaque commodi velit aut id suscipit. Possimus qua", "003e3d8d-d8bc-4dbc-a47b-a0d9b6bf9bbd", 4457, new DateTime(2023, 11, 18, 7, 24, 37, 724, DateTimeKind.Unspecified).AddTicks(6792), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "85ed189c-a7dc-432e-a4ac-909db19b016a", new DateTime(2023, 5, 15, 9, 50, 17, 673, DateTimeKind.Unspecified).AddTicks(7530), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Aperiam sed quos eius reiciendis eveniet distinctio. Error est sit. Aut voluptas corrupti aut ut repellendus ab aut assumenda molestiae. Et veniam ea porro autem. Suscipit ad itaque ipsa nam doloremque.", true, "[{\"role\":\"assistant\",\"content\":\"Et accusamus illo et quo accusamus quibusdam odio. Asperiores do\"},{\"role\":\"assistant\",\"content\":\"Et at maiores ut vel recusandae fuga impedit ipsa. Excepturi fug\"},{\"role\":\"user\",\"content\":\"Delectus dolor maiores optio. In blanditiis praesentium. Harum i\"},{\"role\":\"user\",\"content\":\"Rerum autem veniam molestias delectus iure et ipsum et. Rerum eu\"},{\"role\":\"system\",\"content\":\"Ipsam rerum ratione et. Cumque sit dolorum nobis iure repellat t\"},{\"role\":\"system\",\"content\":\"Excepturi sunt et voluptate error quod iste eos. Nisi perspiciat\"},{\"role\":\"user\",\"content\":\"Tenetur eos magni consequuntur deserunt. Repellendus reprehender\"},{\"role\":\"user\",\"content\":\"Est officia consequuntur at asperiores. Suscipit neque dolorem a\"},{\"role\":\"assistant\",\"content\":\"Velit voluptas dolores dicta optio rerum. Ipsa voluptatem non en\"}]", "gpt-4", "Quo eaque sunt maiores et veniam amet sint nam perferendis. Porro officiis et perspiciatis consequatur earum consequatur eos sun", "09d86378-0536-42f3-8d14-815082d714b2", 7629, new DateTime(2023, 5, 15, 9, 50, 17, 673, DateTimeKind.Unspecified).AddTicks(7530), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "9b7850fd-26eb-4e05-80e6-fe8d23393cc9", new DateTime(2023, 7, 5, 11, 1, 27, 219, DateTimeKind.Unspecified).AddTicks(8099), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Perspiciatis delectus aut placeat exercitationem optio. Est ipsam vel voluptatem eius ipsam sapiente error. Ad mollitia corrupti sed. Praesentium dolorum delectus quam sit eum aut. Numquam beatae et et blanditiis non qui eos.", true, "[{\"role\":\"system\",\"content\":\"Perferendis omnis impedit quo neque modi dicta. Aperiam et ullam\"},{\"role\":\"user\",\"content\":\"Similique illum sunt laudantium et repellat. Molestias dolore ap\"},{\"role\":\"system\",\"content\":\"Deserunt ullam sed facere mollitia esse et. Officiis soluta dolo\"},{\"role\":\"user\",\"content\":\"Distinctio eveniet ut expedita iusto cumque impedit rerum sed po\"},{\"role\":\"system\",\"content\":\"Provident ullam nemo amet eos voluptas ab. Voluptatem et suscipi\"},{\"role\":\"user\",\"content\":\"Aliquid officiis velit et. Aut odio soluta omnis. Numquam quia r\"},{\"role\":\"system\",\"content\":\"Eum eos dolorem recusandae. Dolorem quidem distinctio odio tenet\"},{\"role\":\"user\",\"content\":\"Et vel quia totam. Consequatur non sunt placeat quo dolorem inve\"},{\"role\":\"assistant\",\"content\":\"Ut vel quia et temporibus nam et. Et eum quis possimus dolores a\"}]", "gpt-3.5-trubo", "A totam rerum qui facilis sint rerum alias. Earum sapiente nostrum. Consequuntur sed et exercitationem nihil eaque. Placeat veli", "cd7e512e-0435-4a18-81f2-15f4bafe9f5f", 5498, new DateTime(2023, 7, 5, 11, 1, 27, 219, DateTimeKind.Unspecified).AddTicks(8099), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "9cb102c1-14ec-4644-a8c4-25a77ef78649", new DateTime(2023, 10, 7, 23, 3, 30, 99, DateTimeKind.Unspecified).AddTicks(2947), "b5855118-18d3-49e8-8b69-dc38a86adf54", null, "Earum illo neque beatae nostrum pariatur. Commodi in perspiciatis molestias quibusdam enim voluptatem. Sit quia autem mollitia officiis labore ad debitis mollitia.", false, "[{\"role\":\"assistant\",\"content\":\"Iusto et dolores qui. Temporibus officiis expedita odit eum omni\"},{\"role\":\"user\",\"content\":\"Fuga id in iste rerum aliquid aliquam. Rem aperiam eaque recusan\"},{\"role\":\"system\",\"content\":\"Et sapiente cupiditate reprehenderit sit in perspiciatis dolorem\"},{\"role\":\"user\",\"content\":\"Et saepe cum maxime. Nihil assumenda facilis. Nihil voluptatem p\"},{\"role\":\"assistant\",\"content\":\"Aut non enim voluptas qui. A ea fuga soluta. Omnis officiis aut\"},{\"role\":\"assistant\",\"content\":\"In quo excepturi doloribus. Fugit quam minima assumenda odio ips\"},{\"role\":\"user\",\"content\":\"Id ex culpa sit voluptas quis quaerat excepturi ratione. Nihil a\"},{\"role\":\"user\",\"content\":\"Fuga fugiat sit labore est et. Nesciunt voluptates sit veniam en\"},{\"role\":\"user\",\"content\":\"Quaerat consequatur ducimus consequatur nemo. Est earum qui ea c\"}]", "gpt-4", "Ipsum quo porro alias. Velit nulla totam repellat incidunt quia deleniti a nesciunt quis. Quasi earum sit soluta omnis reiciendi", "5b556df5-0579-41ed-a6e5-a5d1e70c44a5", 3128, new DateTime(2023, 10, 7, 23, 3, 30, 99, DateTimeKind.Unspecified).AddTicks(2947), "b5855118-18d3-49e8-8b69-dc38a86adf54" },
                    { "a114b715-d002-4ba6-a015-8b9157574e75", new DateTime(2023, 3, 8, 0, 47, 27, 338, DateTimeKind.Unspecified).AddTicks(5510), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "At quas et cum repellat commodi qui et labore ea. Et voluptas consequatur velit officia. Et ratione numquam. Consequatur mollitia sapiente quo.", true, "[{\"role\":\"assistant\",\"content\":\"Fugiat vel et. Commodi id id placeat natus aut. Aliquam doloribu\"}]", "gpt-3.5-trubo", "Cumque fugiat et eos. Qui beatae voluptates odit unde quod sapiente necessitatibus corrupti. Tenetur enim sit repudiandae quam.", "c3d7b39b-b144-4b4d-ba2f-2b8a74487569", 3754, new DateTime(2023, 3, 8, 0, 47, 27, 338, DateTimeKind.Unspecified).AddTicks(5510), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "bc6f9df0-4c34-4680-bad7-57e72f45f294", new DateTime(2023, 9, 29, 12, 7, 13, 567, DateTimeKind.Unspecified).AddTicks(2082), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Dolor illum eius laboriosam molestias sit est. Et est aut delectus veniam tempore non iure. Consequatur distinctio aspernatur totam dicta eveniet est sed.", false, "[{\"role\":\"system\",\"content\":\"Eveniet et quisquam ut. Sint dolorum omnis quia dolor amet solut\"},{\"role\":\"user\",\"content\":\"Et assumenda earum odio voluptate nihil id aperiam dolorem provi\"},{\"role\":\"user\",\"content\":\"Et nisi dicta saepe et reiciendis. Consequatur qui ut quod optio\"},{\"role\":\"system\",\"content\":\"Sequi ea autem tempore vel dolorem repudiandae voluptatibus. Ill\"},{\"role\":\"assistant\",\"content\":\"Aut eius rerum quam aliquid magni. Consequatur mollitia non. Rat\"},{\"role\":\"system\",\"content\":\"Provident eos molestiae. Consequatur similique optio autem aut n\"},{\"role\":\"assistant\",\"content\":\"Cumque aut et dolorem. Autem vitae placeat. Officia autem molest\"}]", "gpt-3.5-trubo", "Eum non nihil voluptatibus. Esse dolore assumenda quasi expedita alias ipsum deleniti quo amet. Reprehenderit temporibus et.", "b765b91e-ca3c-4c2d-bd16-5b95c0187cbd", 8903, new DateTime(2023, 9, 29, 12, 7, 13, 567, DateTimeKind.Unspecified).AddTicks(2082), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "c5e05622-5a5e-45f2-8d57-bcccd0ad6f01", new DateTime(2022, 10, 11, 17, 19, 32, 961, DateTimeKind.Unspecified).AddTicks(8514), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Eum praesentium possimus. Tenetur ipsa et veniam voluptas. Adipisci soluta non accusantium autem aut.", true, "[{\"role\":\"user\",\"content\":\"Eum odit reprehenderit non atque tempore. Qui et repellendus a c\"},{\"role\":\"system\",\"content\":\"Ut deleniti et et suscipit cupiditate ut quaerat voluptate. Id a\"},{\"role\":\"user\",\"content\":\"Corporis voluptatem quo. Amet facere ut laborum maiores. Cum par\"},{\"role\":\"user\",\"content\":\"Repellendus quos non deleniti sunt laudantium eaque repudiandae\"},{\"role\":\"user\",\"content\":\"Corporis dolores alias enim nam velit impedit. Rem voluptate dol\"},{\"role\":\"assistant\",\"content\":\"Sit velit saepe libero eum consectetur. Ut nemo quam est cupidit\"},{\"role\":\"system\",\"content\":\"Assumenda distinctio culpa praesentium vel ducimus in sint excep\"},{\"role\":\"system\",\"content\":\"Rerum fuga et praesentium est nihil temporibus natus odio volupt\"},{\"role\":\"user\",\"content\":\"Quis praesentium veniam est est amet dignissimos consequatur quo\"}]", "gpt-4", "Minima ducimus qui reprehenderit fugit dicta et minus reiciendis error. Sunt id et veniam. Voluptatem exercitationem tempore ess", "003e3d8d-d8bc-4dbc-a47b-a0d9b6bf9bbd", 3244, new DateTime(2022, 10, 11, 17, 19, 32, 961, DateTimeKind.Unspecified).AddTicks(8514), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "c64333f3-1f5b-4cf0-b707-37c36b86a4a7", new DateTime(2023, 1, 24, 7, 0, 17, 915, DateTimeKind.Unspecified).AddTicks(5073), "7feaa095-4b6d-4350-abf6-f0e9a86cb361", null, "Ut voluptatem id laborum cupiditate consectetur. Asperiores eos non autem voluptas. Consectetur dignissimos asperiores.", false, "[{\"role\":\"user\",\"content\":\"Qui et voluptate ea. Quidem perspiciatis minus et consequuntur n\"},{\"role\":\"system\",\"content\":\"Voluptate beatae sed ut nam officiis veritatis pariatur alias de\"},{\"role\":\"assistant\",\"content\":\"Labore eum sit illum ea similique quibusdam assumenda omnis est.\"},{\"role\":\"user\",\"content\":\"Quae ut autem sunt architecto consequatur amet dolores voluptate\"},{\"role\":\"user\",\"content\":\"Cumque tempora voluptatum quaerat esse nihil deleniti minus id.\"},{\"role\":\"system\",\"content\":\"Voluptatum nihil itaque. Cupiditate eligendi soluta voluptatibus\"},{\"role\":\"system\",\"content\":\"Voluptate aspernatur et debitis. Labore nulla fugiat est sit bea\"}]", "gpt-4", "Quaerat qui ut doloribus accusantium aut sapiente ad et voluptates. Doloremque rerum dolor commodi aut in possimus. Blanditiis q", "eba3fa77-60df-4b41-91cc-d95435fa758f", 11947, new DateTime(2023, 1, 24, 7, 0, 17, 915, DateTimeKind.Unspecified).AddTicks(5073), "7feaa095-4b6d-4350-abf6-f0e9a86cb361" },
                    { "c66e5c99-796c-41e5-ae30-023940b47d1f", new DateTime(2023, 5, 19, 13, 45, 46, 180, DateTimeKind.Unspecified).AddTicks(7881), "04b9de8b-c87d-4c4f-8004-15861cb61bb1", null, "Rem dolores esse rerum rerum. Magni tempora ex et deserunt facere eligendi a qui repellat. Tenetur quia harum doloribus cupiditate. Aut expedita non saepe laboriosam.", true, "[{\"role\":\"system\",\"content\":\"Dolore non nisi impedit ut error nobis. Earum velit temporibus n\"},{\"role\":\"system\",\"content\":\"Rerum perspiciatis blanditiis eum facere perferendis fugiat magn\"},{\"role\":\"system\",\"content\":\"Voluptatibus qui fugit qui ut. Accusantium est quam ipsa ex susc\"},{\"role\":\"assistant\",\"content\":\"Repudiandae odit maxime aut animi. Vitae quo quo vero accusamus\"},{\"role\":\"system\",\"content\":\"Sunt debitis et excepturi. Qui perspiciatis perspiciatis. Magni\"},{\"role\":\"user\",\"content\":\"Sunt et et aut assumenda ab et numquam sapiente. Quam quisquam e\"},{\"role\":\"system\",\"content\":\"Molestiae est ducimus enim est adipisci. Vel deserunt omnis omni\"}]", "gpt-4", "Modi corporis rerum illum. Est veritatis autem excepturi eius magnam consequatur. Ipsa praesentium officiis quidem expedita beat", "b765b91e-ca3c-4c2d-bd16-5b95c0187cbd", 708, new DateTime(2023, 5, 19, 13, 45, 46, 180, DateTimeKind.Unspecified).AddTicks(7881), "04b9de8b-c87d-4c4f-8004-15861cb61bb1" },
                    { "d6ed6ec4-e557-48fb-873d-db7c47b12dd1", new DateTime(2023, 10, 16, 12, 40, 48, 603, DateTimeKind.Unspecified).AddTicks(9099), "b5855118-18d3-49e8-8b69-dc38a86adf54", null, "Soluta vel ut voluptatem sed sed culpa aut. Et corporis harum ut id consequatur sit deleniti inventore. Officia officia et autem iusto dolor qui laudantium excepturi. Quis beatae aut harum qui et illum nihil. Ea qui sunt similique est excepturi cum. Libero", false, "[{\"role\":\"assistant\",\"content\":\"Doloribus expedita maiores dolorem vel velit et. Quia repellat c\"},{\"role\":\"assistant\",\"content\":\"Amet voluptatem saepe temporibus praesentium velit. Et consequat\"},{\"role\":\"assistant\",\"content\":\"Et qui natus quis impedit aliquam est qui animi nobis. Ex simili\"},{\"role\":\"assistant\",\"content\":\"Iste ipsam omnis porro enim eos quia et. Non quos est illum. Nih\"},{\"role\":\"system\",\"content\":\"Non totam expedita libero asperiores possimus maxime. Ut aut qui\"},{\"role\":\"assistant\",\"content\":\"Est fugit inventore nobis quam. Molestiae facilis eius nam rem r\"},{\"role\":\"assistant\",\"content\":\"Assumenda id officia ut aliquam. Ut aspernatur ut rerum sunt ut\"},{\"role\":\"user\",\"content\":\"Et qui harum ut ipsa sed fugiat et debitis. Explicabo laudantium\"},{\"role\":\"system\",\"content\":\"Et nihil in et dolorum tenetur veniam. Sit deleniti dolores beat\"}]", "gpt-4", "Hic fuga doloribus iusto odit. Dolorum eos aut sit aspernatur et aut id illum quia. Dolor nemo porro. Qui a perferendis velit iu", "5b556df5-0579-41ed-a6e5-a5d1e70c44a5", 11879, new DateTime(2023, 10, 16, 12, 40, 48, 603, DateTimeKind.Unspecified).AddTicks(9099), "b5855118-18d3-49e8-8b69-dc38a86adf54" },
                    { "dc4f6d96-4f77-46d4-ad17-8fd53e72b25d", new DateTime(2022, 2, 10, 6, 30, 36, 143, DateTimeKind.Unspecified).AddTicks(6626), "2bbff763-1693-4f18-973a-eb7ee9b4a57f", null, "Corporis recusandae nemo praesentium praesentium facilis quia. Facere voluptatem unde odio qui veritatis totam dolorum nulla dolores. Nemo quia maiores ullam perspiciatis sit tempora. Magnam cumque pariatur. Ad cupiditate ut. Commodi omnis id libero.", false, "[{\"role\":\"system\",\"content\":\"Ratione neque quaerat. Consequuntur laborum est repellat est rer\"},{\"role\":\"assistant\",\"content\":\"Blanditiis qui porro. Et sit provident tenetur quo dolore. Sunt\"},{\"role\":\"assistant\",\"content\":\"Optio non quos maiores sed eum. Praesentium et rerum facere qui\"},{\"role\":\"system\",\"content\":\"Velit blanditiis quasi possimus tenetur. Explicabo voluptate exp\"},{\"role\":\"system\",\"content\":\"Ipsam dolore vel vero quaerat sit illo culpa harum doloremque. A\"}]", "gpt-3.5-trubo", "Perferendis reiciendis est omnis dolorem. Est corporis non porro nulla quo natus qui dolorem. Nihil modi quis dolorem hic conseq", "09d86378-0536-42f3-8d14-815082d714b2", 1465, new DateTime(2022, 2, 10, 6, 30, 36, 143, DateTimeKind.Unspecified).AddTicks(6626), "2bbff763-1693-4f18-973a-eb7ee9b4a57f" },
                    { "f0699fe1-4603-4803-8057-4093a178a076", new DateTime(2023, 2, 11, 0, 40, 47, 85, DateTimeKind.Unspecified).AddTicks(5948), "f41cfcac-dfb7-46b9-a7c0-5a26903af866", null, "Libero praesentium dolore aut eius. Eos quia ut quasi ad ut nemo et placeat facilis. Sapiente repellendus dignissimos id id adipisci fugiat neque. Rem libero cupiditate quis sunt. Animi modi quibusdam beatae et ea placeat nostrum quas optio.", false, "[{\"role\":\"user\",\"content\":\"Voluptas facilis unde ducimus consectetur et in. Corporis ipsa d\"},{\"role\":\"user\",\"content\":\"Dolor sed facere. Accusamus dolores est quam. Velit itaque velit\"},{\"role\":\"user\",\"content\":\"Id explicabo recusandae eaque voluptatem excepturi consequuntur\"},{\"role\":\"user\",\"content\":\"Iusto inventore ipsum qui eum labore. Perspiciatis voluptates ea\"},{\"role\":\"user\",\"content\":\"Quisquam molestias cumque eius explicabo vel illum. Voluptatem q\"},{\"role\":\"system\",\"content\":\"Sint enim magnam nemo et. Sit doloribus in maxime voluptatem. De\"}]", "gpt-4", "Dicta qui aut recusandae et nemo voluptas veniam aut quos. Fugiat quis repellendus ut animi dicta quibusdam nesciunt perferendis", "4edf1038-8b44-4069-adff-d0a843bdfca0", 6972, new DateTime(2023, 2, 11, 0, 40, 47, 85, DateTimeKind.Unspecified).AddTicks(5948), "f41cfcac-dfb7-46b9-a7c0-5a26903af866" },
                    { "fe5aba04-825b-47f2-b91e-cd093b0b9b4b", new DateTime(2023, 7, 5, 6, 21, 57, 9, DateTimeKind.Unspecified).AddTicks(4844), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0", null, "Dolor est suscipit assumenda qui omnis et officia. Eius ut temporibus enim quaerat dolor repellat dolorem. Quisquam et voluptas provident fugit velit non vero eaque. Minima vitae est et at praesentium dolor qui. Enim soluta molestiae delectus sapiente sed", true, "[{\"role\":\"system\",\"content\":\"Qui ipsam eligendi perferendis velit et neque. Voluptas et facil\"},{\"role\":\"assistant\",\"content\":\"Laudantium reprehenderit placeat inventore eos. Et est quibusdam\"},{\"role\":\"system\",\"content\":\"Maiores earum corrupti facilis. Illum facere eum sunt officia do\"}]", "gpt-4", "Et beatae non assumenda ipsa nostrum et voluptatem. Qui ullam a iure ullam. Voluptas officia harum voluptatem et ullam doloribus", "70c2286b-dd63-47cc-8671-4b6000d604fa", 9310, new DateTime(2023, 7, 5, 6, 21, 57, 9, DateTimeKind.Unspecified).AddTicks(4844), "591bb8cb-4443-4b50-bb0b-36c90ae4e5f0" }
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
