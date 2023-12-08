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
                values: new object[] { "4c41eb97-bb9b-4fa6-8441-7778e074943d", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26f01e2f-a4ee-4d00-9fa9-aa2a42236e76", 0, "d8c85498-6575-4863-a929-5d92ec5a831f", "Johnpaul_Wilderman22@hotmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEDQ42U4G9IKfyzfW/aAeYCRmdOwtpCcPEWUyfEF2jG/wdkybTmyPVAavC7gRo9+Xwg==", null, false, "bb43f38b-000e-4675-ab56-1988e1e9fceb", false, "Johnpaul_Wilderman22@hotmail.com" },
                    { "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c", 0, "85cf98fa-6515-4ca0-a454-27fd0bc49d55", "Troy38@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEL/vh3dsdq9VY++3hyl8VSNBwj6pH1jMrTenDusfhwruSjT20EOY6kzmwDdBb9SqPQ==", null, false, "bb94c201-87ef-4991-bc1f-45b4237107ef", false, "Troy38@gmail.com" },
                    { "495c866f-e116-41df-9eec-f00de3632a70", 0, "7da22a25-01bf-4a3e-a1b2-759c31384105", "Marlen35@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEBKqXSbud9a07fvBV1ZGdCoXfnOt6bwKBnBzVlkE75zYd89NPoH6N2wS5RLHNLWsvA==", null, false, "48ccd901-4b72-4746-99a8-3416ad21f28c", false, "Marlen35@gmail.com" },
                    { "6898091e-acdc-4188-8b0b-b3061ef86eca", 0, "28b9c1a1-61e3-4bf6-8c46-53313eca504d", "Reba29@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJxud/lXW5ea19i0R9aGVRbNCJZKRnlWFnrasDZk+fJm+eifsuZN65TUS+o1fuEHxg==", null, false, "f1d0578e-d406-468d-8a2c-29db62e31063", false, "Reba29@gmail.com" },
                    { "84fafafa-39b6-493d-b21d-1d2ef41e5ab7", 0, "85ba0e04-c40f-4058-ab37-f22cc5281436", "Theresia39@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEGa+wS11ACUn6bqzsCGt5vt1qXbTPT66cL6nsmxBAYeG8/7UGZb10kDWCBJFGrYYdg==", null, false, "d9136975-3550-49e3-803c-115ef5243d9d", false, "Theresia39@gmail.com" },
                    { "a6566d50-7ce0-438c-9027-fe7ab1652f3d", 0, "9b59043f-35b0-4652-a894-d3ec2281e7bd", "Justina60@hotmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEFHh9lIZt7+HEhaneuMFcdz7GmvODnN4TGHrBHi0sqjItvz7KzcugMu1eDRS4hkrSw==", null, false, "dac3988c-73c8-4175-a0cc-ddc560fe3978", false, "Justina60@hotmail.com" },
                    { "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae", 0, "7feba9e1-b3af-4eeb-bdd2-ab9ab58ee2b3", "fi.kwiatkowski@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEGQqxlB72bCfMQMrZykMr7TNTMwlVz9VjgIBSu3AMbaKohIAdO2bq8p4iC+8SBvq3A==", null, false, "8d96140b-ef6f-4596-90da-98e3ae4821d2", false, "fi.kwiatkowski@gmail.com" },
                    { "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", 0, "b9ac9be2-2b90-4e3f-bc6d-20dc62f815ed", "Lizeth_Schultz@yahoo.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEP5cVIR+2rgoEFcOX1ll9LAxHDbrEY+8OH7wHCGgYxHWTClqE51XIcvwSfKk6mp6RQ==", null, false, "83b907cc-a7bc-4305-958c-eb9ec782cb05", false, "Lizeth_Schultz@yahoo.com" },
                    { "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b", 0, "e5f53874-5f6b-4936-98fd-0ceaf630a9a4", "Mekhi.Halvorson@yahoo.com", true, false, null, null, null, "AQAAAAIAAYagAAAAELnld599zLVXHrnivjVaih5N5wDixaFnSPPwTvszULMOjPkU+HqKnbdILVgYcoRIDQ==", null, false, "7ccde637-a904-4eba-b010-0d5c839be053", false, "Mekhi.Halvorson@yahoo.com" },
                    { "e4fd178b-e47f-4109-af87-b67d5c97cd16", 0, "8cd6004e-478b-4399-9c82-f694ca31cf23", "Aileen_Towne95@yahoo.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEG7Sb17AT27baoUHIjihJ5hW8MBPGLrfR2HInmXrny8LZZuoyzGpT0+IQQdhLoZHyw==", null, false, "261d537a-5e5c-40f7-b77e-ebedd57a3077", false, "Aileen_Towne95@yahoo.com" },
                    { "f86cb396-292c-43ad-aefa-7d24da569f67", 0, "5fd4e52b-7211-4430-8723-8dd00dc95790", "Autumn_Dicki91@hotmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEl9SRHrQus6vqNZmCKXykP0MfihQ4QGMY994SdCPQw0PeWbUi7VQskQ78fTJlmJ5A==", null, false, "d4cbaeec-50e9-454e-b44d-7e3a04edce4b", false, "Autumn_Dicki91@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4c41eb97-bb9b-4fa6-8441-7778e074943d", "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "0c8fc336-7bdf-411c-8cbc-4254073fe40f", new DateTime(2022, 5, 9, 1, 48, 10, 372, DateTimeKind.Unspecified).AddTicks(2797), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae", null, "Minus quis sit ab vel. Ut libero quas incidunt in laboriosam voluptatem delectus. Accusamus doloremque impedit et similique. Aspernatur non officiis consequatur et. Illo necessitatibus enim error ut voluptates quaerat eligendi animi. Illo quas in occaecati", false, "Ut veritatis quasi magni aut cumque earum. Quis quas aspernatur vero soluta. Optio dolor quod sed velit fugit sed.", new DateTime(2022, 5, 9, 1, 48, 10, 372, DateTimeKind.Unspecified).AddTicks(2797), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" },
                    { "12a9ea74-0412-455d-b656-e8d55cb1f131", new DateTime(2022, 9, 1, 12, 5, 26, 119, DateTimeKind.Unspecified).AddTicks(4785), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Distinctio quia maiores iusto voluptatibus. Non vitae occaecati distinctio est repellat dolorum ea impedit tenetur. Consectetur nihil ut qui in fugiat possimus. Tenetur error odio labore quod et eum. Quaerat omnis placeat.", true, "Non sint iste harum aliquid minima minima neque quasi. Et quasi voluptatem. Quas qui quos beatae tempora dolorum mollitia occaec", new DateTime(2022, 9, 1, 12, 5, 26, 119, DateTimeKind.Unspecified).AddTicks(4785), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "1e49f1f1-5daa-48c8-8e3c-7049566488a0", new DateTime(2022, 4, 18, 14, 50, 7, 800, DateTimeKind.Unspecified).AddTicks(8558), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c", null, "Porro perspiciatis culpa. Odio rerum eligendi. Architecto consequatur sed voluptas enim laboriosam non dolorem. Cupiditate odio cupiditate aut cumque. Consequatur qui voluptatem enim vitae assumenda molestiae et. Qui minus neque est est.", false, "Facilis quia dolor. Repellat laudantium fugiat. Incidunt quos quisquam dolores sint nihil soluta illum ad vitae. Eveniet rerum u", new DateTime(2022, 4, 18, 14, 50, 7, 800, DateTimeKind.Unspecified).AddTicks(8558), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c" },
                    { "44b871b7-9bc2-4a30-8390-9270af131356", new DateTime(2023, 3, 10, 19, 39, 33, 38, DateTimeKind.Unspecified).AddTicks(7820), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Asperiores unde reiciendis necessitatibus. Magnam animi accusamus impedit sed ut quis nihil velit harum. Pariatur sapiente eius sequi in doloremque. Minus nemo magni veritatis est accusamus. Est repudiandae aut maiores. Dolore fugiat earum dolores minus es", true, "Nisi et aut perspiciatis. Soluta quas corporis aliquam vel dolorum. Possimus est qui fuga sit placeat. Non corporis sed voluptat", new DateTime(2023, 3, 10, 19, 39, 33, 38, DateTimeKind.Unspecified).AddTicks(7820), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "5c41ed1d-f74a-4888-9849-cbd154493f66", new DateTime(2022, 6, 7, 10, 8, 31, 422, DateTimeKind.Unspecified).AddTicks(6840), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b", null, "Repellendus odit doloremque officia odio officia. Dicta ut fuga animi quas. Dolor omnis quam eos.", true, "Fuga ut rem occaecati. Saepe omnis dolorum optio omnis ipsum nihil illum fugiat rerum. Dolores libero aut consequatur atque non", new DateTime(2022, 6, 7, 10, 8, 31, 422, DateTimeKind.Unspecified).AddTicks(6840), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b" },
                    { "795e0f6f-dd93-4ee8-bbf1-4abd94ebe1b0", new DateTime(2022, 2, 5, 3, 49, 0, 960, DateTimeKind.Unspecified).AddTicks(5867), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Dolorem veritatis dolor dicta sit omnis. Possimus adipisci id cupiditate quo cumque aut. Ab voluptates cum autem voluptatem amet nemo.", false, "Labore aut expedita eos saepe et esse. Consectetur aut impedit sint. Officiis cupiditate et odit occaecati voluptates voluptatem", new DateTime(2022, 2, 5, 3, 49, 0, 960, DateTimeKind.Unspecified).AddTicks(5867), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "a7c8bf84-db3a-47b8-bab5-b009b9720256", new DateTime(2023, 3, 7, 1, 6, 45, 411, DateTimeKind.Unspecified).AddTicks(9024), "a6566d50-7ce0-438c-9027-fe7ab1652f3d", null, "Repellendus voluptatibus esse labore nisi delectus architecto sit error. Quod id molestiae voluptatibus nobis. Adipisci beatae officiis sit temporibus. Repudiandae dolore magni quia. Totam dolores laboriosam odit nemo quibusdam.", true, "Dolorem tempore sint molestias. Dicta reprehenderit maxime quo. Occaecati consectetur suscipit incidunt aliquid cumque nemo. Mai", new DateTime(2023, 3, 7, 1, 6, 45, 411, DateTimeKind.Unspecified).AddTicks(9024), "a6566d50-7ce0-438c-9027-fe7ab1652f3d" },
                    { "d6fe20f9-1ce2-44f9-9569-d5ecb72b3378", new DateTime(2023, 6, 20, 11, 58, 11, 844, DateTimeKind.Unspecified).AddTicks(4656), "495c866f-e116-41df-9eec-f00de3632a70", null, "Officiis dolorum ipsa et similique cumque quisquam laboriosam. Quas totam animi. Eaque nihil nemo similique consequuntur est corrupti necessitatibus. Impedit fugit officia.", false, "Officiis quia quo occaecati nisi voluptatem enim aut. Fugiat eos alias saepe delectus. Sapiente odit deleniti inventore similiqu", new DateTime(2023, 6, 20, 11, 58, 11, 844, DateTimeKind.Unspecified).AddTicks(4656), "495c866f-e116-41df-9eec-f00de3632a70" },
                    { "e1c1c4b1-1917-496f-84ec-c7c200e00954", new DateTime(2023, 10, 30, 17, 55, 35, 121, DateTimeKind.Unspecified).AddTicks(3032), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Rerum fuga vitae dolorem ab molestiae a molestias. Id nisi aperiam rerum voluptas consectetur harum. Aut mollitia quidem culpa consequatur voluptatibus ipsam autem. Soluta fugiat amet consectetur et pariatur quae. Doloremque voluptate sunt eos expedita min", true, "Modi omnis voluptatem. Occaecati temporibus aut et voluptate. Eaque quis temporibus et aut.", new DateTime(2023, 10, 30, 17, 55, 35, 121, DateTimeKind.Unspecified).AddTicks(3032), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "e97b5a64-3819-4135-b7e1-c99fa5aa5410", new DateTime(2022, 1, 6, 16, 21, 11, 124, DateTimeKind.Unspecified).AddTicks(3015), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Omnis nemo iure perferendis. Odit et repellat voluptatem voluptatum. Cupiditate facere odit quidem officiis nihil similique qui.", false, "Delectus accusantium officia voluptatem aspernatur voluptas veritatis sapiente. Et ipsum ipsam deserunt culpa ut optio voluptate", new DateTime(2022, 1, 6, 16, 21, 11, 124, DateTimeKind.Unspecified).AddTicks(3015), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "08e69251-ccdc-404b-97be-90f3db2f1f3c", new DateTime(2022, 7, 3, 21, 30, 36, 54, DateTimeKind.Unspecified).AddTicks(4054), "495c866f-e116-41df-9eec-f00de3632a70", null, "Distinctio illum asperiores est fugit eos. Quia quos fugit non. Illum pariatur inventore ut. Architecto nihil dolor repellat. Voluptas rerum illum.", true, "[{\"Role\":\"assistant\",\"Content\":\"Cum reprehenderit natus. Omnis ut dicta iste fugit vel magni. Ex\"},{\"Role\":\"system\",\"Content\":\"Qui qui repellat. Nihil sit deleniti molestias. Beatae ut aut sa\"},{\"Role\":\"system\",\"Content\":\"Odio ut occaecati aspernatur et dolor sit. Natus aut aliquid nos\"},{\"Role\":\"user\",\"Content\":\"Quo ipsa non cumque rerum aut et esse et. Quidem maxime cum aut\"},{\"Role\":\"user\",\"Content\":\"In sit dicta ratione qui harum. Saepe repellat dignissimos quam\"},{\"Role\":\"assistant\",\"Content\":\"Nobis molestiae ducimus dolore rerum voluptatibus deleniti. Dolo\"}]", "gpt-4", "Dolorem dolor veritatis eum nobis quam. Magnam esse consectetur qui officia occaecati rerum saepe quis. Et occaecati illum volup", "d6fe20f9-1ce2-44f9-9569-d5ecb72b3378", 11718, new DateTime(2022, 7, 3, 21, 30, 36, 54, DateTimeKind.Unspecified).AddTicks(4054), "495c866f-e116-41df-9eec-f00de3632a70" },
                    { "0fb0496f-f50a-4df9-bdbd-147135ebff06", new DateTime(2022, 3, 28, 7, 52, 3, 609, DateTimeKind.Unspecified).AddTicks(3368), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Perspiciatis eum dolor exercitationem non dignissimos. Accusantium hic non laboriosam quas maiores repudiandae. Ad et ut explicabo ut vel delectus natus ducimus. Fugiat laboriosam consequatur accusantium provident. Vel et expedita consectetur laboriosam qu", true, "[{\"Role\":\"system\",\"Content\":\"Temporibus rerum sed placeat enim ipsa. Illum corporis veniam mo\"},{\"Role\":\"system\",\"Content\":\"Voluptatibus nulla voluptatum quos qui beatae recusandae quaerat\"},{\"Role\":\"assistant\",\"Content\":\"Laboriosam maiores eligendi modi quis possimus in nam est error.\"},{\"Role\":\"system\",\"Content\":\"Tempore id corporis sunt nulla sapiente consequuntur. Et officii\"},{\"Role\":\"assistant\",\"Content\":\"Aut voluptate ab quis sint deleniti sit quos. Qui ut saepe volup\"},{\"Role\":\"system\",\"Content\":\"Eos deserunt ut iure voluptatibus ullam quo. Recusandae dolores\"},{\"Role\":\"user\",\"Content\":\"Ea doloremque suscipit sit quasi. Eveniet eum consectetur debiti\"},{\"Role\":\"system\",\"Content\":\"Praesentium iusto non odit. Assumenda accusamus et sit unde expe\"}]", "gpt-3.5-trubo", "Quas dolores ut quia eum incidunt doloribus. Autem explicabo vero ipsum quas rerum perspiciatis. Animi quia ipsam dicta ut deser", "e1c1c4b1-1917-496f-84ec-c7c200e00954", 7920, new DateTime(2022, 3, 28, 7, 52, 3, 609, DateTimeKind.Unspecified).AddTicks(3368), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "16535893-dee8-4110-9b93-d734f60b0df6", new DateTime(2022, 2, 10, 18, 17, 13, 149, DateTimeKind.Unspecified).AddTicks(8670), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Soluta rem ut tenetur voluptas vel sequi animi. Earum nisi similique sed et sit sit. Dolores cupiditate voluptatem aspernatur ab non. Dolor tempore sit saepe voluptatem amet aliquam repellendus consequatur.", true, "[{\"Role\":\"system\",\"Content\":\"Consequatur et rerum dolore ducimus iusto quia quasi aut. Ipsum\"},{\"Role\":\"assistant\",\"Content\":\"Doloremque est ratione et suscipit ut. Qui ducimus magnam vero q\"},{\"Role\":\"assistant\",\"Content\":\"Aliquam odit voluptatem et culpa. Id eum commodi doloremque. Mol\"},{\"Role\":\"user\",\"Content\":\"Voluptas enim ipsam tempore. Similique rerum et nisi fugiat offi\"},{\"Role\":\"system\",\"Content\":\"Maxime ipsa ut. Laborum quo est explicabo quia ducimus. Accusant\"},{\"Role\":\"system\",\"Content\":\"Ipsum veniam doloremque ullam. Minima velit voluptate accusamus\"},{\"Role\":\"assistant\",\"Content\":\"Magnam est consequatur commodi veritatis eveniet minima ducimus.\"}]", "gpt-3.5-trubo", "Et illo numquam. Aut maiores in quaerat doloribus. Vero quia autem dolor eos nihil. Ratione assumenda et amet unde. Perspiciatis", "e1c1c4b1-1917-496f-84ec-c7c200e00954", 8189, new DateTime(2022, 2, 10, 18, 17, 13, 149, DateTimeKind.Unspecified).AddTicks(8670), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "179d6076-e873-49be-b234-91c95ca08d14", new DateTime(2023, 1, 29, 13, 25, 42, 816, DateTimeKind.Unspecified).AddTicks(6612), "a6566d50-7ce0-438c-9027-fe7ab1652f3d", null, "Quaerat consequatur repellat. Consequuntur exercitationem tenetur qui necessitatibus ex iure id similique. Nihil modi consequatur fuga officiis qui et omnis aut. Cupiditate saepe quaerat distinctio consequatur omnis perspiciatis illo est.", false, "[{\"Role\":\"system\",\"Content\":\"Vitae dolorem beatae ut aliquid sit sed. Quam quis ullam volupta\"},{\"Role\":\"assistant\",\"Content\":\"Neque expedita et. Aut necessitatibus a quo maiores voluptatem.\"},{\"Role\":\"assistant\",\"Content\":\"Cumque ut dolorum dolorem. Blanditiis fugiat magni iste autem co\"},{\"Role\":\"system\",\"Content\":\"Optio assumenda facilis. Aliquid deleniti delectus sed exercitat\"},{\"Role\":\"user\",\"Content\":\"Voluptas omnis quia qui modi soluta commodi quam voluptas. Aliqu\"}]", "gpt-4", "Similique perferendis necessitatibus. Quia totam nihil et possimus quasi itaque modi modi qui. Earum ut nostrum quia quia dicta.", "a7c8bf84-db3a-47b8-bab5-b009b9720256", 10941, new DateTime(2023, 1, 29, 13, 25, 42, 816, DateTimeKind.Unspecified).AddTicks(6612), "a6566d50-7ce0-438c-9027-fe7ab1652f3d" },
                    { "1fe9fbb7-380a-492d-bbcb-e01094d5b19f", new DateTime(2022, 10, 16, 18, 11, 44, 726, DateTimeKind.Unspecified).AddTicks(235), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Nam odit possimus laudantium enim sit. Ipsum tenetur error impedit non est aliquid. Ut consequatur nulla dolores quam sit fugiat corporis. Illo minus ducimus. Sed iste numquam nam at aut ducimus.", false, "[{\"Role\":\"assistant\",\"Content\":\"Enim officia sunt ut necessitatibus et non fugit. Quidem cupidit\"},{\"Role\":\"system\",\"Content\":\"Nisi sunt aut debitis. Sint occaecati dolores consequuntur. Modi\"},{\"Role\":\"user\",\"Content\":\"Aut voluptatem repudiandae. Quod sint facere quis eaque exceptur\"},{\"Role\":\"assistant\",\"Content\":\"Accusamus minima quo omnis consequuntur qui. Ad beatae qui asper\"},{\"Role\":\"assistant\",\"Content\":\"Et non odio ipsum quis sapiente. Facilis et quisquam dolorem non\"}]", "gpt-3.5-trubo", "Eius ullam non tempora debitis voluptate reprehenderit sunt iure. Officiis sint officia. Voluptate quos amet consequatur ut rem.", "12a9ea74-0412-455d-b656-e8d55cb1f131", 3217, new DateTime(2022, 10, 16, 18, 11, 44, 726, DateTimeKind.Unspecified).AddTicks(235), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "299a981c-a699-4a72-adfd-29994b406f56", new DateTime(2023, 10, 18, 22, 39, 7, 469, DateTimeKind.Unspecified).AddTicks(5987), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Repellendus vitae optio totam explicabo. Inventore labore itaque inventore veniam. Et fuga et dolor deserunt ut magni eligendi.", false, "[{\"Role\":\"assistant\",\"Content\":\"Dolorum cumque eaque eum veniam vitae aut fugit id ipsam. Odio p\"},{\"Role\":\"system\",\"Content\":\"Occaecati suscipit provident inventore saepe porro placeat. Ipsu\"},{\"Role\":\"assistant\",\"Content\":\"Rerum et nulla cupiditate earum dolores consequatur. Sint odio v\"},{\"Role\":\"system\",\"Content\":\"Sed iste dolorum ullam qui est omnis qui. Quo aliquid alias in r\"},{\"Role\":\"system\",\"Content\":\"Ex explicabo libero velit aspernatur facere eligendi iusto accus\"},{\"Role\":\"user\",\"Content\":\"Eveniet aut est ab ullam in. Et non ea laborum rerum exercitatio\"},{\"Role\":\"user\",\"Content\":\"Aliquid cum beatae molestiae ut sunt ut libero laborum impedit.\"},{\"Role\":\"assistant\",\"Content\":\"Laudantium deserunt velit sit cum. Aut commodi in aperiam dolore\"},{\"Role\":\"assistant\",\"Content\":\"Et nostrum praesentium quis qui incidunt quo. Consectetur et dol\"}]", "gpt-4", "Repudiandae ipsum eos animi quo tempore neque. Delectus sapiente perferendis possimus commodi distinctio dolore. In sit molestia", "e97b5a64-3819-4135-b7e1-c99fa5aa5410", 14188, new DateTime(2023, 10, 18, 22, 39, 7, 469, DateTimeKind.Unspecified).AddTicks(5987), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "2c4a5d6f-61c5-4fc1-8095-3ea302e7c13a", new DateTime(2023, 12, 1, 15, 12, 13, 122, DateTimeKind.Unspecified).AddTicks(2118), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae", null, "Hic temporibus quae ducimus quia. Officiis in quo vero corrupti vitae. Officiis et hic. Voluptas recusandae eum neque qui. Enim quos ad et beatae est saepe voluptas et optio. Eaque nisi id sit veritatis impedit quae dignissimos sit.", false, "[{\"Role\":\"user\",\"Content\":\"Dicta facere nesciunt. Ut aspernatur enim aut error. Labore impe\"},{\"Role\":\"user\",\"Content\":\"Est eius molestias necessitatibus in expedita sed aut. Atque qui\"},{\"Role\":\"system\",\"Content\":\"Sunt deleniti autem adipisci saepe illo officiis dolorem. Adipis\"},{\"Role\":\"assistant\",\"Content\":\"Vitae enim reprehenderit numquam atque aliquid dolor nobis eum v\"},{\"Role\":\"system\",\"Content\":\"Voluptatem nobis culpa quas. Dolor molestias et corporis soluta\"},{\"Role\":\"assistant\",\"Content\":\"Iusto aliquam officiis officiis aspernatur animi perspiciatis an\"},{\"Role\":\"assistant\",\"Content\":\"Et natus velit voluptate. Et voluptatem ut laboriosam voluptatem\"},{\"Role\":\"user\",\"Content\":\"Doloribus et qui id quasi et. Reprehenderit sint vel. Eius sequi\"}]", "gpt-4", "Quae hic facere repellat vitae aliquam neque. Doloremque aut rerum rerum molestiae culpa molestiae quod dolores. Asperiores sunt", "0c8fc336-7bdf-411c-8cbc-4254073fe40f", 3662, new DateTime(2023, 12, 1, 15, 12, 13, 122, DateTimeKind.Unspecified).AddTicks(2118), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" },
                    { "31cd3be1-fe33-4df3-a126-5bb31e1948ed", new DateTime(2023, 8, 29, 15, 25, 21, 377, DateTimeKind.Unspecified).AddTicks(3122), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae", null, "Modi distinctio aut qui repudiandae aperiam est. Hic voluptatibus impedit corporis et sed nesciunt aut. Ducimus illum et delectus.", true, "[{\"Role\":\"system\",\"Content\":\"Qui incidunt delectus et dolor. Ex nam id. Corrupti eaque et vol\"},{\"Role\":\"user\",\"Content\":\"Aliquid occaecati sequi quia nesciunt alias aliquam qui. Quibusd\"},{\"Role\":\"assistant\",\"Content\":\"Quaerat et voluptatum aperiam aut est ut autem sed. Voluptas con\"},{\"Role\":\"assistant\",\"Content\":\"Aliquam officia autem enim voluptas qui laudantium. Voluptas exp\"},{\"Role\":\"assistant\",\"Content\":\"Distinctio est provident neque eum occaecati dolore voluptas lab\"},{\"Role\":\"system\",\"Content\":\"Totam tempora fugit magnam facilis eaque. In cum pariatur exerci\"},{\"Role\":\"user\",\"Content\":\"Repellat architecto totam quo. Labore nihil omnis qui vel labore\"}]", "gpt-3.5-trubo", "Nobis dolor id soluta debitis aut suscipit. Qui porro odio iusto non saepe sint. Non tempora vel magnam molestiae cumque atque e", "0c8fc336-7bdf-411c-8cbc-4254073fe40f", 802, new DateTime(2023, 8, 29, 15, 25, 21, 377, DateTimeKind.Unspecified).AddTicks(3122), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" },
                    { "4216605b-1579-411d-9dff-d86446839054", new DateTime(2022, 12, 11, 7, 3, 50, 115, DateTimeKind.Unspecified).AddTicks(8789), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Voluptatibus sit rem possimus excepturi qui et ut odit unde. Ut aut neque autem aperiam libero maxime rem. Molestiae eos ut.", true, "[{\"Role\":\"user\",\"Content\":\"Aut et excepturi esse voluptatem hic dolores quae. Blanditiis iu\"},{\"Role\":\"system\",\"Content\":\"Eos quo et debitis cum et. Nostrum quod aut perferendis libero e\"},{\"Role\":\"assistant\",\"Content\":\"Autem id velit omnis accusantium eaque reiciendis pariatur. Quid\"},{\"Role\":\"assistant\",\"Content\":\"Nulla deserunt corporis. Maxime illum nostrum commodi et repella\"},{\"Role\":\"system\",\"Content\":\"Quae deserunt corporis ducimus consequuntur. Doloremque culpa ip\"},{\"Role\":\"system\",\"Content\":\"Nemo veritatis voluptatem totam omnis quo culpa. Sit eum vero. E\"},{\"Role\":\"assistant\",\"Content\":\"Qui eius consequatur. Velit velit mollitia rerum architecto face\"},{\"Role\":\"user\",\"Content\":\"Iure voluptas in consequuntur enim illum accusantium facere illu\"},{\"Role\":\"system\",\"Content\":\"Qui quos vitae ipsa eum doloribus tenetur. Amet earum quia bland\"},{\"Role\":\"system\",\"Content\":\"Atque omnis eveniet sunt veritatis omnis ipsum. Id corporis repe\"}]", "gpt-3.5-trubo", "Dolores eum voluptatem vel vitae quisquam ducimus. Vero inventore hic sunt. Minus velit quae autem perferendis incidunt doloribu", "795e0f6f-dd93-4ee8-bbf1-4abd94ebe1b0", 9525, new DateTime(2022, 12, 11, 7, 3, 50, 115, DateTimeKind.Unspecified).AddTicks(8789), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "48b8a8b8-9ac4-4d4c-aa33-1908b5e54cc7", new DateTime(2022, 3, 13, 7, 54, 19, 933, DateTimeKind.Unspecified).AddTicks(8026), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Saepe autem nihil nostrum. Et modi sint nobis et dolore atque. Consequatur ratione voluptatem. Est vero quam.", false, "[{\"Role\":\"user\",\"Content\":\"Ut culpa quidem exercitationem inventore et. Sunt quaerat rerum\"},{\"Role\":\"user\",\"Content\":\"Aut impedit voluptas. Eaque rerum et. Saepe maiores non dolorem\"},{\"Role\":\"system\",\"Content\":\"Quibusdam tempora animi delectus. Dicta qui dolor in similique e\"},{\"Role\":\"system\",\"Content\":\"Dolorum facilis quis sint qui veniam dolore maxime. Inventore do\"},{\"Role\":\"user\",\"Content\":\"Explicabo soluta et expedita molestias consectetur consectetur e\"}]", "gpt-3.5-trubo", "Consequatur illo in tenetur magni ad. Dolorem nihil facilis laborum dicta dolorem delectus veritatis eveniet. Odio dolor animi u", "12a9ea74-0412-455d-b656-e8d55cb1f131", 8754, new DateTime(2022, 3, 13, 7, 54, 19, 933, DateTimeKind.Unspecified).AddTicks(8026), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "4a07c497-2d06-4434-a1e9-5aba943dcbc2", new DateTime(2023, 1, 14, 7, 37, 59, 499, DateTimeKind.Unspecified).AddTicks(4538), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Eveniet voluptate fuga ipsa culpa reprehenderit voluptatem rem. Error alias blanditiis autem qui. Quia eos veritatis rerum non.", false, "[{\"Role\":\"assistant\",\"Content\":\"Beatae deserunt sint rerum. Fuga tempora magnam nulla neque volu\"},{\"Role\":\"system\",\"Content\":\"Velit ut provident inventore sit voluptatibus veritatis maiores\"}]", "gpt-4", "Et voluptatem sed tenetur sit in libero iure. Iste placeat est. Asperiores est quia.", "795e0f6f-dd93-4ee8-bbf1-4abd94ebe1b0", 13523, new DateTime(2023, 1, 14, 7, 37, 59, 499, DateTimeKind.Unspecified).AddTicks(4538), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "4d40effc-8c96-41c9-aa14-823b4e1eadf9", new DateTime(2023, 9, 23, 15, 45, 15, 946, DateTimeKind.Unspecified).AddTicks(3443), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Voluptatibus sint qui consequatur ut. Dolorum ipsam fugit praesentium quis est. Cupiditate dolor est corrupti omnis occaecati perspiciatis consequatur.", false, "[{\"Role\":\"assistant\",\"Content\":\"Iste sunt ut natus architecto nihil. Inventore in aut est. Dolor\"},{\"Role\":\"user\",\"Content\":\"Quaerat mollitia debitis. Commodi amet adipisci qui atque eos vo\"},{\"Role\":\"assistant\",\"Content\":\"Aliquam molestiae est. Ut amet et velit necessitatibus sit. Quae\"},{\"Role\":\"system\",\"Content\":\"Ipsa et hic quam qui rem est esse velit sint. Repellat vitae nul\"},{\"Role\":\"assistant\",\"Content\":\"Ex rerum repellat consequuntur. Qui eligendi et. Quod quia simil\"},{\"Role\":\"user\",\"Content\":\"Possimus eveniet qui modi nisi praesentium omnis. Rerum laudanti\"},{\"Role\":\"assistant\",\"Content\":\"Ea iste nulla sit. Aliquid reprehenderit pariatur sed quia. Et q\"},{\"Role\":\"user\",\"Content\":\"Qui possimus nostrum expedita optio unde laudantium qui ut. Simi\"},{\"Role\":\"system\",\"Content\":\"Pariatur itaque molestiae quasi repellendus voluptatem iste. Sit\"}]", "gpt-3.5-trubo", "Exercitationem debitis sint. Accusantium est quos quisquam vitae ullam sed qui quo est. Non officia omnis non voluptatem unde la", "e1c1c4b1-1917-496f-84ec-c7c200e00954", 11235, new DateTime(2023, 9, 23, 15, 45, 15, 946, DateTimeKind.Unspecified).AddTicks(3443), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "51d4e1d4-f4fe-4f82-b7c5-41e054a27092", new DateTime(2023, 7, 1, 0, 8, 10, 836, DateTimeKind.Unspecified).AddTicks(7969), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Velit assumenda animi. Nostrum eveniet et praesentium. Autem tempora in temporibus error.", false, "[{\"Role\":\"system\",\"Content\":\"Libero quia odit quae eum. Repellat numquam iure eos neque. Modi\"},{\"Role\":\"user\",\"Content\":\"Modi voluptatem vero quo qui ullam. Est iure earum exercitatione\"},{\"Role\":\"assistant\",\"Content\":\"Ea expedita eveniet ab quia iure eius. Minima libero aut non ess\"},{\"Role\":\"assistant\",\"Content\":\"Quam distinctio sed rem et nobis eveniet porro dicta aliquid. Vo\"},{\"Role\":\"user\",\"Content\":\"Quia incidunt sed. Et libero est ex quia molestias adipisci libe\"},{\"Role\":\"system\",\"Content\":\"Esse officiis quaerat labore delectus ullam. Eum voluptas minus\"},{\"Role\":\"system\",\"Content\":\"Nihil ipsam hic qui nesciunt blanditiis placeat aliquid minus si\"},{\"Role\":\"user\",\"Content\":\"Dicta possimus omnis accusantium nemo impedit. Rerum id omnis qu\"}]", "gpt-4", "Quisquam qui ratione est et. Et consequuntur officiis labore iste omnis ea ea ipsam. Aliquid aut et quis natus consequatur quam", "44b871b7-9bc2-4a30-8390-9270af131356", 9823, new DateTime(2023, 7, 1, 0, 8, 10, 836, DateTimeKind.Unspecified).AddTicks(7969), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "64e35bfd-6dba-4d29-9507-de58197f22e7", new DateTime(2022, 8, 15, 1, 8, 34, 391, DateTimeKind.Unspecified).AddTicks(2065), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Delectus explicabo dolorem quia ut hic. Qui corporis blanditiis cupiditate quasi ut vel reprehenderit in. Laborum nam quis illo quam.", false, "[{\"Role\":\"system\",\"Content\":\"Magni sit architecto. Dolores voluptatem aut blanditiis quis qua\"},{\"Role\":\"system\",\"Content\":\"Ex modi est omnis vel perspiciatis. Dolore aut maxime. Maiores e\"},{\"Role\":\"system\",\"Content\":\"Asperiores quia est aut iure velit molestias sapiente ut volupta\"}]", "gpt-3.5-trubo", "Dolore aut optio necessitatibus et blanditiis veritatis. Optio delectus incidunt illo voluptatem suscipit culpa voluptas eius. V", "e97b5a64-3819-4135-b7e1-c99fa5aa5410", 13525, new DateTime(2022, 8, 15, 1, 8, 34, 391, DateTimeKind.Unspecified).AddTicks(2065), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "6b20be3a-8ea0-4d58-9bd4-53346b310e1a", new DateTime(2022, 9, 1, 15, 16, 19, 12, DateTimeKind.Unspecified).AddTicks(7889), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Veritatis qui est. Quo ipsam voluptatem nihil aut numquam similique omnis facilis ipsam. Ut nostrum cumque accusamus maxime itaque eum in magnam. Aut voluptate nihil repudiandae. Dolores sit iure ab.", false, "[{\"Role\":\"system\",\"Content\":\"Nihil et quia nesciunt voluptatum maxime eligendi inventore null\"},{\"Role\":\"user\",\"Content\":\"Nihil error facere. Deserunt laboriosam qui. Molestias reprehend\"},{\"Role\":\"system\",\"Content\":\"Qui et dolor labore libero illum similique neque. Sunt voluptatu\"},{\"Role\":\"system\",\"Content\":\"Laudantium eum ad magni ab laboriosam doloremque dolorum digniss\"}]", "gpt-4", "Accusantium voluptatem aliquam ex vel laborum ut. Impedit aut magnam hic impedit. Molestiae rerum assumenda. Expedita sequi inve", "e97b5a64-3819-4135-b7e1-c99fa5aa5410", 14172, new DateTime(2022, 9, 1, 15, 16, 19, 12, DateTimeKind.Unspecified).AddTicks(7889), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "6d3d237a-bcea-4c9c-81e2-5a24d3b98592", new DateTime(2023, 3, 3, 10, 38, 13, 410, DateTimeKind.Unspecified).AddTicks(1795), "495c866f-e116-41df-9eec-f00de3632a70", null, "Expedita perferendis quos eius et enim ipsum aut possimus non. Quod labore quia eos debitis earum autem sequi. Ea illum omnis nisi enim porro officiis provident nisi dolores.", false, "[{\"Role\":\"system\",\"Content\":\"Voluptas aliquam et similique veritatis sint. Eaque eos voluptat\"},{\"Role\":\"system\",\"Content\":\"Vero sequi labore. Soluta dolorum earum labore harum quo. Qui de\"},{\"Role\":\"system\",\"Content\":\"Vel dolorem id. In dolores asperiores est ducimus in vel volupta\"},{\"Role\":\"assistant\",\"Content\":\"Vitae atque nostrum autem quibusdam. Voluptatem rerum consequatu\"},{\"Role\":\"system\",\"Content\":\"Amet suscipit consequatur voluptatum id. Corporis tempora ullam\"},{\"Role\":\"system\",\"Content\":\"Et molestias deserunt hic ut itaque ad sed. Est tenetur et. Enim\"},{\"Role\":\"assistant\",\"Content\":\"Dolor quia voluptas blanditiis cumque commodi sequi sequi. Quod\"},{\"Role\":\"user\",\"Content\":\"Distinctio enim autem quisquam esse asperiores in veniam. Fuga i\"},{\"Role\":\"assistant\",\"Content\":\"Sunt aliquid officiis quisquam veniam architecto animi natus min\"},{\"Role\":\"user\",\"Content\":\"Fuga nesciunt inventore illum temporibus. Quis deserunt eius qui\"}]", "gpt-3.5-trubo", "Eveniet aut provident. Saepe aut minus minus error iusto. Eaque quae iusto explicabo aut consectetur.", "d6fe20f9-1ce2-44f9-9569-d5ecb72b3378", 9663, new DateTime(2023, 3, 3, 10, 38, 13, 410, DateTimeKind.Unspecified).AddTicks(1795), "495c866f-e116-41df-9eec-f00de3632a70" },
                    { "77a21d0e-f1b8-4f6f-8d89-142df38106fb", new DateTime(2022, 10, 13, 12, 53, 3, 255, DateTimeKind.Unspecified).AddTicks(5701), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b", null, "Aut ea dolorem distinctio dicta dolorum sint saepe. Excepturi ratione ratione perferendis ipsum cumque consequuntur nemo. Rem alias ut exercitationem. Autem ad quis quia autem amet repellat quaerat architecto. Et quidem quia. Quaerat in incidunt culpa dolo", false, "[{\"Role\":\"system\",\"Content\":\"Fugit id qui eius corporis. Dolorum eos quia quidem voluptatum q\"},{\"Role\":\"assistant\",\"Content\":\"Animi eum error dolorem ex ex adipisci nihil ex commodi. Ut dolo\"},{\"Role\":\"system\",\"Content\":\"Sapiente accusantium rerum ea aut sit praesentium aliquam quis.\"}]", "gpt-3.5-trubo", "Eos nobis et eum illum qui. Qui odio impedit sunt voluptate ut sint facere. Illo eum vitae accusamus minima praesentium. Volupta", "5c41ed1d-f74a-4888-9849-cbd154493f66", 2871, new DateTime(2022, 10, 13, 12, 53, 3, 255, DateTimeKind.Unspecified).AddTicks(5701), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b" },
                    { "79e12f36-54f7-48ce-a78a-779eae276df0", new DateTime(2023, 6, 13, 14, 13, 39, 525, DateTimeKind.Unspecified).AddTicks(2762), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b", null, "Consectetur consequuntur velit in quam sed eum. Voluptates quia debitis ea voluptatem velit veniam sed provident. Numquam blanditiis rem rem. Consequatur minus veritatis. Ducimus eos eaque iure. Necessitatibus dolores voluptatem odit necessitatibus.", true, "[{\"Role\":\"system\",\"Content\":\"Explicabo ducimus rerum eius eveniet consequatur minima quaerat.\"}]", "gpt-3.5-trubo", "Tenetur dolor rerum sed qui necessitatibus. Quia ad quos ut. Velit aut incidunt similique repellat quaerat fuga explicabo.", "5c41ed1d-f74a-4888-9849-cbd154493f66", 8926, new DateTime(2023, 6, 13, 14, 13, 39, 525, DateTimeKind.Unspecified).AddTicks(2762), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b" },
                    { "7cc6adf8-22e0-4df3-b936-7be14a6ddbb5", new DateTime(2022, 3, 26, 21, 44, 3, 355, DateTimeKind.Unspecified).AddTicks(9925), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c", null, "Sunt rerum quaerat expedita blanditiis explicabo sit accusantium ut voluptatem. Rerum id quae earum veritatis rerum. Saepe sit velit voluptatem aperiam facere aut voluptatum autem ex. Ratione dolor dolore repellendus id omnis neque omnis eaque sunt. Totam", true, "[{\"Role\":\"system\",\"Content\":\"Numquam est eaque maxime earum. Et quasi voluptatem. Est magni v\"},{\"Role\":\"user\",\"Content\":\"Aut illum quia omnis similique quas aut ipsa. Incidunt et ex et\"},{\"Role\":\"system\",\"Content\":\"Iure minima accusantium necessitatibus rerum fuga inventore qui\"},{\"Role\":\"system\",\"Content\":\"Et fugiat fuga dignissimos optio. Saepe quo eligendi suscipit. V\"},{\"Role\":\"system\",\"Content\":\"Dolores cupiditate reprehenderit amet. Minima harum enim dolorum\"},{\"Role\":\"user\",\"Content\":\"Eligendi ullam fugiat atque rerum accusantium saepe dicta conseq\"},{\"Role\":\"system\",\"Content\":\"Qui libero repellat quaerat deleniti dolor ut alias accusamus ea\"}]", "gpt-4", "Voluptatem odit ut id consequatur sapiente voluptatem. Odit qui ab consequatur aliquam qui. Voluptate inventore aperiam blanditi", "1e49f1f1-5daa-48c8-8e3c-7049566488a0", 1698, new DateTime(2022, 3, 26, 21, 44, 3, 355, DateTimeKind.Unspecified).AddTicks(9925), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c" },
                    { "934c9a19-2b41-4cb8-9018-7605d02f6b45", new DateTime(2022, 10, 7, 8, 38, 44, 485, DateTimeKind.Unspecified).AddTicks(3483), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Dolor aliquam aperiam quis nihil commodi quia quibusdam. Impedit quasi voluptatem praesentium enim. Ratione aliquam asperiores qui velit aperiam cupiditate libero eligendi. Laboriosam accusamus tempore ut hic quia ea.", false, "[{\"Role\":\"assistant\",\"Content\":\"Incidunt enim vitae. Eum omnis ratione velit quisquam est iure l\"}]", "gpt-3.5-trubo", "Dignissimos placeat quia omnis repellendus vel beatae repellat dignissimos. Eos sint quos iure eos dolores eos qui autem enim. S", "12a9ea74-0412-455d-b656-e8d55cb1f131", 9637, new DateTime(2022, 10, 7, 8, 38, 44, 485, DateTimeKind.Unspecified).AddTicks(3483), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "93b59c19-97bb-4b5f-9201-867ab7549464", new DateTime(2023, 11, 4, 15, 23, 37, 978, DateTimeKind.Unspecified).AddTicks(2560), "a6566d50-7ce0-438c-9027-fe7ab1652f3d", null, "Qui in voluptatem provident sunt sed cum. Aut ab occaecati. Aut consequuntur ut.", true, "[{\"Role\":\"assistant\",\"Content\":\"Sed aut voluptate. Voluptates rem qui quae qui. Et esse earum vo\"},{\"Role\":\"user\",\"Content\":\"Odio exercitationem natus totam. Ullam sit officiis similique te\"},{\"Role\":\"system\",\"Content\":\"Molestiae eaque est quis et et magnam laudantium sit. Non ipsa a\"},{\"Role\":\"system\",\"Content\":\"Nesciunt laboriosam vero blanditiis sit qui pariatur expedita re\"},{\"Role\":\"user\",\"Content\":\"Voluptate sapiente est ad autem. Eligendi voluptatem ea doloribu\"}]", "gpt-3.5-trubo", "Itaque id reprehenderit consequuntur qui aliquid. Dolor recusandae qui. Soluta consequatur dolorem.", "a7c8bf84-db3a-47b8-bab5-b009b9720256", 13749, new DateTime(2023, 11, 4, 15, 23, 37, 978, DateTimeKind.Unspecified).AddTicks(2560), "a6566d50-7ce0-438c-9027-fe7ab1652f3d" },
                    { "98a0d557-4808-4255-a893-efed6bd5229c", new DateTime(2022, 8, 21, 6, 45, 41, 316, DateTimeKind.Unspecified).AddTicks(1083), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae", null, "Voluptatem modi aliquam. Suscipit enim soluta in dolore non earum dolorem aut. Esse odit hic at. Unde culpa sunt quos asperiores est est dolorum.", true, "[{\"Role\":\"system\",\"Content\":\"Dolores ut amet aut alias. Autem aut et ab consequatur quam simi\"},{\"Role\":\"assistant\",\"Content\":\"Molestiae ut quaerat perferendis quis dignissimos voluptas possi\"},{\"Role\":\"assistant\",\"Content\":\"Illum consectetur soluta libero et rerum distinctio ad. Quia qui\"}]", "gpt-4", "Atque tenetur modi quasi omnis autem quas aut. Sint laudantium nihil quisquam. Necessitatibus sint omnis vero. Ut soluta impedit", "0c8fc336-7bdf-411c-8cbc-4254073fe40f", 8680, new DateTime(2022, 8, 21, 6, 45, 41, 316, DateTimeKind.Unspecified).AddTicks(1083), "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" },
                    { "99b3f995-6cda-4d73-97b4-ef621b863285", new DateTime(2022, 12, 4, 13, 27, 49, 261, DateTimeKind.Unspecified).AddTicks(9215), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8", null, "Itaque veniam est. Maiores deserunt repellat ut occaecati necessitatibus aperiam magnam. Qui cum et.", true, "[{\"Role\":\"assistant\",\"Content\":\"Sit et temporibus voluptatem fugiat. Doloremque velit nostrum. E\"},{\"Role\":\"assistant\",\"Content\":\"Eos molestias nam est enim fuga. Quia tempora vero optio neque s\"},{\"Role\":\"user\",\"Content\":\"Eum modi et harum id dicta. Cumque repudiandae reprehenderit qui\"},{\"Role\":\"user\",\"Content\":\"Laudantium libero quae quia nulla. Veniam deleniti sunt non aut.\"},{\"Role\":\"user\",\"Content\":\"Labore cum ad corrupti quia natus nobis nihil necessitatibus arc\"},{\"Role\":\"user\",\"Content\":\"Amet aliquid mollitia vero dicta numquam adipisci ab et veniam.\"},{\"Role\":\"assistant\",\"Content\":\"Facere dolores reiciendis ipsum reprehenderit et omnis et simili\"}]", "gpt-4", "Et excepturi velit aut quis. Eum porro distinctio voluptatem. Nostrum quibusdam voluptas eum. Fuga laborum est omnis nemo expedi", "795e0f6f-dd93-4ee8-bbf1-4abd94ebe1b0", 9494, new DateTime(2022, 12, 4, 13, 27, 49, 261, DateTimeKind.Unspecified).AddTicks(9215), "be4a836c-b3f8-4433-a0cb-4dff5a8575c8" },
                    { "a87235d6-7d93-4c07-bee3-1eb3239106a3", new DateTime(2023, 4, 4, 9, 6, 44, 843, DateTimeKind.Unspecified).AddTicks(1840), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c", null, "Iure delectus maiores et laudantium beatae excepturi voluptas vel. Eius atque omnis omnis dignissimos alias consectetur inventore ea. Facere autem tempora consequatur neque. Quis sed aut enim placeat. Neque reiciendis sed sapiente est.", true, "[{\"Role\":\"assistant\",\"Content\":\"Tempora fugit sunt vel qui vero nisi sequi. Consequatur nobis re\"},{\"Role\":\"user\",\"Content\":\"Quo vero quasi totam sapiente vero quisquam et eum sunt. Dolorem\"},{\"Role\":\"system\",\"Content\":\"Aut asperiores sint praesentium quam. Asperiores autem est nobis\"},{\"Role\":\"assistant\",\"Content\":\"Nisi omnis enim quia est. Quaerat ullam voluptas voluptatem id i\"},{\"Role\":\"system\",\"Content\":\"Doloremque minima ipsum hic repellat ipsam est. Numquam sunt quo\"}]", "gpt-3.5-trubo", "Architecto aut aut blanditiis. Soluta doloribus vitae sint nihil asperiores voluptatem eveniet ut. Deleniti quidem illum ipsa ne", "1e49f1f1-5daa-48c8-8e3c-7049566488a0", 240, new DateTime(2023, 4, 4, 9, 6, 44, 843, DateTimeKind.Unspecified).AddTicks(1840), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c" },
                    { "d203d3a8-a7dc-4bdb-b794-9a2ee99dcb9a", new DateTime(2023, 4, 26, 4, 57, 31, 557, DateTimeKind.Unspecified).AddTicks(2258), "495c866f-e116-41df-9eec-f00de3632a70", null, "Molestias deleniti voluptates cumque nisi impedit libero amet. Voluptatem ex molestiae vitae numquam inventore et rerum. Dolore consequatur voluptatibus iusto omnis voluptas. Quia et ut vitae asperiores occaecati. Ut temporibus tempore et voluptatem volupt", true, "[{\"Role\":\"assistant\",\"Content\":\"Ipsum sunt dignissimos ipsam soluta porro. Facilis rerum qui qua\"},{\"Role\":\"system\",\"Content\":\"Et expedita vitae est animi alias odit. Illum tempora corrupti v\"},{\"Role\":\"system\",\"Content\":\"Necessitatibus autem eum quod. Ut qui cumque qui dolorem volupta\"},{\"Role\":\"assistant\",\"Content\":\"Quam dolorum veritatis asperiores ut voluptas eligendi aut beata\"},{\"Role\":\"user\",\"Content\":\"Et quisquam est qui neque est velit. Occaecati natus aut consequ\"}]", "gpt-3.5-trubo", "Saepe quibusdam culpa facilis quidem. Fuga eaque mollitia alias neque ut. Explicabo autem inventore. Quaerat dolores nisi aspern", "d6fe20f9-1ce2-44f9-9569-d5ecb72b3378", 6488, new DateTime(2023, 4, 26, 4, 57, 31, 557, DateTimeKind.Unspecified).AddTicks(2258), "495c866f-e116-41df-9eec-f00de3632a70" },
                    { "ded9df69-512b-4bf3-986d-d0f05df7b6e4", new DateTime(2022, 1, 20, 17, 43, 52, 939, DateTimeKind.Unspecified).AddTicks(1282), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Incidunt nam numquam necessitatibus nam impedit animi aperiam. Iusto rerum ipsum dolor neque at aut laudantium et praesentium. Eum ut voluptas est et dicta neque inventore vitae. Dolor enim modi ab in veniam aut. Voluptatem enim ut omnis quod.", true, "[{\"Role\":\"assistant\",\"Content\":\"Eum cumque fugiat corrupti non adipisci pariatur tempore volupta\"},{\"Role\":\"user\",\"Content\":\"Et neque non consequuntur debitis quo id provident modi officiis\"},{\"Role\":\"user\",\"Content\":\"Tempora libero dolor neque. Dolorem vel molestiae autem officiis\"}]", "gpt-3.5-trubo", "Sed quam voluptatibus eveniet. Ab sed quibusdam quaerat voluptatum neque. Reprehenderit aut dolores est rerum. Sint et voluptas", "44b871b7-9bc2-4a30-8390-9270af131356", 11301, new DateTime(2022, 1, 20, 17, 43, 52, 939, DateTimeKind.Unspecified).AddTicks(1282), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "ed3e794c-953d-4820-bec4-ea2c2f69c426", new DateTime(2023, 9, 23, 16, 5, 39, 800, DateTimeKind.Unspecified).AddTicks(9340), "f86cb396-292c-43ad-aefa-7d24da569f67", null, "Est voluptates eius autem aut adipisci. Explicabo sunt est ut quo rerum quia placeat. Excepturi aut voluptas. Qui quas qui cumque aliquam ut deserunt iure. Ipsum modi dolorem temporibus rem earum sapiente dolores velit.", false, "[{\"Role\":\"user\",\"Content\":\"Ut aliquid iusto quis perspiciatis eligendi. Quis voluptatem des\"},{\"Role\":\"user\",\"Content\":\"Non corporis sit vel maxime tenetur rerum commodi doloribus. Ape\"},{\"Role\":\"user\",\"Content\":\"Ad ea et. Illo voluptatibus perspiciatis reiciendis non sed. Ut\"},{\"Role\":\"system\",\"Content\":\"Et tempora id cum corporis distinctio sapiente magnam consequatu\"},{\"Role\":\"assistant\",\"Content\":\"Architecto fugiat rem ad vero. Iure voluptatibus omnis repellend\"},{\"Role\":\"user\",\"Content\":\"Quaerat sequi praesentium consequuntur eius incidunt. Et dicta s\"},{\"Role\":\"user\",\"Content\":\"Similique eius doloremque libero non veritatis ut optio quod. Im\"},{\"Role\":\"user\",\"Content\":\"Sed unde eveniet magnam non quo dolorem exercitationem. Et facer\"},{\"Role\":\"system\",\"Content\":\"Odit et nesciunt commodi ut atque. Assumenda occaecati qui tempo\"}]", "gpt-4", "Culpa est cumque explicabo sit officia odit. Non dolore rem. Sit perferendis omnis sed vel fugiat voluptatem et qui. Rerum ea ab", "44b871b7-9bc2-4a30-8390-9270af131356", 2532, new DateTime(2023, 9, 23, 16, 5, 39, 800, DateTimeKind.Unspecified).AddTicks(9340), "f86cb396-292c-43ad-aefa-7d24da569f67" },
                    { "fb0141f5-44c8-4c31-9623-5d1ac9c216a3", new DateTime(2023, 7, 19, 20, 48, 49, 172, DateTimeKind.Unspecified).AddTicks(7658), "a6566d50-7ce0-438c-9027-fe7ab1652f3d", null, "Alias sequi autem. Dolores ut nihil praesentium laborum ipsum corrupti et. Voluptatem praesentium facere quia veniam. Dolorum necessitatibus et eveniet tempore nisi incidunt quaerat quia. Harum quia eaque minus aut dolorem ut placeat soluta. Omnis aliquid", false, "[{\"Role\":\"system\",\"Content\":\"Tempore fugiat est illum expedita accusantium. Id laborum quae n\"},{\"Role\":\"assistant\",\"Content\":\"Optio qui inventore. Vel ut id amet reprehenderit quos. Consequa\"}]", "gpt-4", "Sint a odio et perspiciatis ipsa officia. Dolores et consequatur ab qui minima mollitia quaerat iure sapiente. Deserunt explicab", "a7c8bf84-db3a-47b8-bab5-b009b9720256", 9523, new DateTime(2023, 7, 19, 20, 48, 49, 172, DateTimeKind.Unspecified).AddTicks(7658), "a6566d50-7ce0-438c-9027-fe7ab1652f3d" },
                    { "fbf338bc-be4a-4f03-a507-016cdce0a15f", new DateTime(2023, 11, 12, 23, 56, 45, 908, DateTimeKind.Unspecified).AddTicks(5562), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c", null, "Accusamus nihil est et sunt libero nisi harum voluptate. Tempora et reiciendis maxime ut est. Similique soluta minima. Voluptatibus aspernatur et et aut est quo enim. Sapiente enim aperiam et maiores quaerat magni.", false, "[{\"Role\":\"user\",\"Content\":\"Animi quidem rerum corrupti soluta beatae velit doloribus distin\"},{\"Role\":\"user\",\"Content\":\"Ipsa et provident exercitationem ab. Consequuntur voluptatum qua\"},{\"Role\":\"assistant\",\"Content\":\"Enim aut officiis quia eum sunt omnis molestiae quasi. Praesenti\"},{\"Role\":\"assistant\",\"Content\":\"Voluptate velit in placeat porro fugiat corrupti iusto. Voluptat\"}]", "gpt-3.5-trubo", "Magnam nihil numquam expedita consectetur placeat. Id quia velit placeat neque suscipit voluptatem non. Dicta veniam architecto", "1e49f1f1-5daa-48c8-8e3c-7049566488a0", 7619, new DateTime(2023, 11, 12, 23, 56, 45, 908, DateTimeKind.Unspecified).AddTicks(5562), "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c" },
                    { "ff16ae4e-9ae8-4fd6-b45a-530a1543e823", new DateTime(2022, 4, 2, 15, 4, 23, 684, DateTimeKind.Unspecified).AddTicks(8576), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b", null, "Consequatur sit voluptas voluptatem nihil. Debitis quos id molestiae. Qui natus voluptatibus quia aut blanditiis molestiae dicta ullam. Reprehenderit consequatur animi ex fugit.", true, "[{\"Role\":\"assistant\",\"Content\":\"Rerum et architecto debitis occaecati beatae voluptas natus illu\"}]", "gpt-4", "Quibusdam dolorem voluptatem iusto. Non ea harum ut ipsam sequi hic qui. Non in molestiae. Ipsam soluta distinctio repudiandae i", "5c41ed1d-f74a-4888-9849-cbd154493f66", 7596, new DateTime(2022, 4, 2, 15, 4, 23, 684, DateTimeKind.Unspecified).AddTicks(8576), "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b" }
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
