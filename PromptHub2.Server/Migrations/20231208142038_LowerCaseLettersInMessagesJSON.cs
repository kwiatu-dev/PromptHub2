using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromptHub2.Server.Migrations
{
    /// <inheritdoc />
    public partial class LowerCaseLettersInMessagesJSON : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c41eb97-bb9b-4fa6-8441-7778e074943d", "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26f01e2f-a4ee-4d00-9fa9-aa2a42236e76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6898091e-acdc-4188-8b0b-b3061ef86eca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84fafafa-39b6-493d-b21d-1d2ef41e5ab7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4fd178b-e47f-4109-af87-b67d5c97cd16");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "08e69251-ccdc-404b-97be-90f3db2f1f3c");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "0fb0496f-f50a-4df9-bdbd-147135ebff06");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "16535893-dee8-4110-9b93-d734f60b0df6");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "179d6076-e873-49be-b234-91c95ca08d14");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "1fe9fbb7-380a-492d-bbcb-e01094d5b19f");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "299a981c-a699-4a72-adfd-29994b406f56");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "2c4a5d6f-61c5-4fc1-8095-3ea302e7c13a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "31cd3be1-fe33-4df3-a126-5bb31e1948ed");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "4216605b-1579-411d-9dff-d86446839054");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "48b8a8b8-9ac4-4d4c-aa33-1908b5e54cc7");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "4a07c497-2d06-4434-a1e9-5aba943dcbc2");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "4d40effc-8c96-41c9-aa14-823b4e1eadf9");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "51d4e1d4-f4fe-4f82-b7c5-41e054a27092");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "64e35bfd-6dba-4d29-9507-de58197f22e7");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6b20be3a-8ea0-4d58-9bd4-53346b310e1a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6d3d237a-bcea-4c9c-81e2-5a24d3b98592");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "77a21d0e-f1b8-4f6f-8d89-142df38106fb");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "79e12f36-54f7-48ce-a78a-779eae276df0");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "7cc6adf8-22e0-4df3-b936-7be14a6ddbb5");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "934c9a19-2b41-4cb8-9018-7605d02f6b45");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "93b59c19-97bb-4b5f-9201-867ab7549464");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "98a0d557-4808-4255-a893-efed6bd5229c");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "99b3f995-6cda-4d73-97b4-ef621b863285");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "a87235d6-7d93-4c07-bee3-1eb3239106a3");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "d203d3a8-a7dc-4bdb-b794-9a2ee99dcb9a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ded9df69-512b-4bf3-986d-d0f05df7b6e4");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ed3e794c-953d-4820-bec4-ea2c2f69c426");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "fb0141f5-44c8-4c31-9623-5d1ac9c216a3");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "fbf338bc-be4a-4f03-a507-016cdce0a15f");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ff16ae4e-9ae8-4fd6-b45a-530a1543e823");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c41eb97-bb9b-4fa6-8441-7778e074943d");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "0c8fc336-7bdf-411c-8cbc-4254073fe40f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "12a9ea74-0412-455d-b656-e8d55cb1f131");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1e49f1f1-5daa-48c8-8e3c-7049566488a0");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "44b871b7-9bc2-4a30-8390-9270af131356");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "5c41ed1d-f74a-4888-9849-cbd154493f66");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "795e0f6f-dd93-4ee8-bbf1-4abd94ebe1b0");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a7c8bf84-db3a-47b8-bab5-b009b9720256");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "d6fe20f9-1ce2-44f9-9569-d5ecb72b3378");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "e1c1c4b1-1917-496f-84ec-c7c200e00954");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "e97b5a64-3819-4135-b7e1-c99fa5aa5410");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a5b43bb-bbc7-4326-9fc8-5c9cd7751f4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "495c866f-e116-41df-9eec-f00de3632a70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6566d50-7ce0-438c-9027-fe7ab1652f3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1d9fa9a-b445-4c08-b632-bfb1242bb0ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be4a836c-b3f8-4433-a0cb-4dff5a8575c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd2bfea-2107-4677-9066-9a3bb5a2dc2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86cb396-292c-43ad-aefa-7d24da569f67");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45539e43-6d1a-4506-9b7f-2a30610c0008", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1032ce96-5386-4e95-b212-0b6446fb822b", 0, "d491272e-b01f-4f1d-a1ea-d169c309d8de", "Diana.Wiegand@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAELt6YT/ZHgV/ull/pt/kRMkLBvaLpMCEJ3LTiV5Js6zvYbxBal7sb1bjh+1Mp6mpTg==", null, false, "aaf48bc8-3dd7-41e7-8cea-b04746d59c61", false, "Diana.Wiegand@gmail.com" },
                    { "13ee4105-45c5-4c2c-8ebe-0da1d7604088", 0, "068d1862-b2c9-4385-bf11-fd7f05a3c859", "Reilly11@yahoo.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEP8VmjBjGuscopLXQNzpWG/wxFvJMupY07ZdSQ+8zw+nyFcu1J37+S0giJWD6c0RWw==", null, false, "531d35a9-af7f-48a7-a2a1-1439541ce173", false, "Reilly11@yahoo.com" },
                    { "141c219a-5f2d-4a3d-a3d0-d655eab6b36f", 0, "e551562c-388d-4f68-925b-bdf6ba861e05", "fi.kwiatkowski@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAECV4Ohh9Amozwstt9DvoRiOKy0uKnqgQEd7derOnuV4rRZKm+oxoEpdoIxrbufy2gg==", null, false, "47f43953-0ded-4b49-a894-593fac0b02a1", false, "fi.kwiatkowski@gmail.com" },
                    { "2405638c-5295-48e0-a232-75a22ac9c1fd", 0, "a32580b0-0ebc-495c-8de0-546969dcb545", "Evangeline_Spencer72@hotmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEKAiGeNPbdSo4f3JZFdMaxIhdWCBOOWk+R6WrFsbozsI5AqbIEERgAn3a7TYMkCUAQ==", null, false, "f657bf37-9c01-4b30-91f1-39e3f4a0219b", false, "Evangeline_Spencer72@hotmail.com" },
                    { "2bad0a52-f80d-4780-94a0-2909bc4a7a87", 0, "d95206ff-e272-4ea2-817c-887b933f41da", "Royal_Toy92@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ0VqT7lg2wYFE+mE/JKPliWqQjUJm0ZRfuYpokqO/wesEQmtwTj+J8/eX11TnLeNw==", null, false, "de95d2e1-a0f0-45be-980a-cc35bd90f10e", false, "Royal_Toy92@gmail.com" },
                    { "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd", 0, "0df663d3-d2e5-4876-952a-bfae003aaf13", "Brando.Balistreri@hotmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMLtgW7YBaO+ER3UmUljHhRg7+BuKgzhj7tA1gsaGEUVoiu1nGcVBh45mpA71HugSg==", null, false, "4c6aa368-f0a2-4fd4-85a7-32aa046093c0", false, "Brando.Balistreri@hotmail.com" },
                    { "9aef1613-965e-4579-9b03-95c05a90b0e2", 0, "274285e1-8d2d-4f35-9151-08f736fe23ab", "Florida.Predovic@hotmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEK2PDwcPBU7G5QD3tL9U8eaFa2k8mFq/uqvRmsoTvEesVkmkSZeMmvwwN9EvecgoSQ==", null, false, "c842999d-9ac2-4614-9847-8070e968cdae", false, "Florida.Predovic@hotmail.com" },
                    { "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", 0, "788a4a8f-d78c-4ea5-b7b1-ab6a0c044782", "Maiya29@yahoo.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEN3heGrfXiGgXKDPGaRVrYuVZpN5afaTBJgcydq/MVf+0Qj1CotDVz3n5PBhGRd9Tw==", null, false, "ea64fe63-3bdb-4e39-b60f-c540e6e32fb4", false, "Maiya29@yahoo.com" },
                    { "dd767247-16e5-41c9-a0d2-d5f9883146ef", 0, "f356f3bc-399f-4a78-a627-09f1541a0318", "Dante.Gusikowski@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEOa7CbzNURD5GRwCGlDMYSWg9q9+n7jdrt11StqvI0IWIYCJtJKsPiMrehp1cHoqxg==", null, false, "d08c1218-4c7b-43e9-9464-237cc835ff55", false, "Dante.Gusikowski@gmail.com" },
                    { "e79ba770-a43f-4069-b95f-ad60a62320c9", 0, "8d343668-71f7-4d03-a21e-7877d7539af2", "Zakary.Rath@yahoo.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEPsm62LeVjSykIixBHUV3U/LBdyqAp7+SiMguxoGLRbRuhJAntnkkeJw8DS7fldrgA==", null, false, "437c720a-27ab-4530-811c-670cf9a0493c", false, "Zakary.Rath@yahoo.com" },
                    { "f524888c-56f3-4d04-be92-fe6b4f895b12", 0, "ce991acd-7fec-44d8-93a4-d128387d62f7", "Hobart_Mills@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEH8fS9NTD1mv1a/kuZYoE/MzXqZsqGDrPemPlnxOwPfy3iNNnhsFY57Gsbo/grniVg==", null, false, "db5135a6-1562-42c2-a180-b7f4f8c53c5c", false, "Hobart_Mills@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "45539e43-6d1a-4506-9b7f-2a30610c0008", "141c219a-5f2d-4a3d-a3d0-d655eab6b36f" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "02490e24-e61f-40d0-b1ce-f604d5435c87", new DateTime(2022, 3, 22, 12, 30, 48, 152, DateTimeKind.Unspecified).AddTicks(9857), "13ee4105-45c5-4c2c-8ebe-0da1d7604088", null, "Quis deleniti sunt eaque assumenda aut autem assumenda rerum. Veniam consequatur eveniet ut vero voluptatem reiciendis non expedita. Recusandae eligendi nostrum tempora rerum architecto debitis ut nemo et. Saepe et qui id dignissimos eos.", false, "Itaque aut et fuga non. Necessitatibus neque harum ipsam ut facilis eaque quasi omnis. Laborum aut totam. Rem assumenda aliquam", new DateTime(2022, 3, 22, 12, 30, 48, 152, DateTimeKind.Unspecified).AddTicks(9857), "13ee4105-45c5-4c2c-8ebe-0da1d7604088" },
                    { "2a3eec74-b118-41fc-99aa-f7a8b0b6b62c", new DateTime(2022, 4, 1, 6, 5, 51, 225, DateTimeKind.Unspecified).AddTicks(2597), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Eos quae alias aliquam iste. Molestias esse atque blanditiis similique sequi eius. Fugiat explicabo vero eaque neque in accusamus maxime. Eveniet porro doloribus sit non nemo tempore culpa et at.", true, "Voluptatibus beatae et et deserunt ea. Magni illum eos temporibus est. Corporis quis et ut quia explicabo quos. Omnis temporibus", new DateTime(2022, 4, 1, 6, 5, 51, 225, DateTimeKind.Unspecified).AddTicks(2597), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "480b8043-b15d-4124-b5dc-e93e7717cf8f", new DateTime(2022, 5, 4, 6, 29, 30, 537, DateTimeKind.Unspecified).AddTicks(215), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Occaecati dolore voluptatum ut molestias eum. Eos culpa ab. Eum ut amet neque eos. Animi nesciunt ducimus ipsum reprehenderit ut. Recusandae eos a ad dolor.", false, "Quia dolores nesciunt. Quo ea occaecati autem nihil fugit sed. Dolor voluptatum praesentium excepturi ratione voluptatem. Optio", new DateTime(2022, 5, 4, 6, 29, 30, 537, DateTimeKind.Unspecified).AddTicks(215), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "771c3266-ab4d-411b-b2ed-35a6eeb01e83", new DateTime(2022, 6, 1, 5, 13, 35, 559, DateTimeKind.Unspecified).AddTicks(6180), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Sunt consequatur rerum qui quos et omnis quam. Et esse ducimus nihil rerum provident. Et odio voluptas dignissimos ad in quae. Et sint error neque. Dolorum et accusantium quos quas omnis eaque. Qui aliquid error.", true, "Sed est aspernatur. Porro soluta magni sapiente molestias nesciunt officiis. Atque voluptatem natus non. Et aperiam laborum earu", new DateTime(2022, 6, 1, 5, 13, 35, 559, DateTimeKind.Unspecified).AddTicks(6180), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "85d978b2-2dbb-4fe0-adf9-d0d5657d868a", new DateTime(2023, 3, 1, 3, 45, 17, 5, DateTimeKind.Unspecified).AddTicks(3979), "dd767247-16e5-41c9-a0d2-d5f9883146ef", null, "Dignissimos delectus sit ut. Labore nemo impedit aperiam culpa occaecati veniam possimus ullam. Aliquid quas totam nihil fugiat in itaque rerum asperiores. Esse cupiditate nostrum quis cumque dignissimos. Velit voluptatem voluptatum expedita. Fugit dolores", true, "Velit harum quas voluptatum deleniti provident. Autem aut atque ipsa nulla quia voluptatem voluptate. Eius aut sed. Velit et aut", new DateTime(2023, 3, 1, 3, 45, 17, 5, DateTimeKind.Unspecified).AddTicks(3979), "dd767247-16e5-41c9-a0d2-d5f9883146ef" },
                    { "9ee31024-e1e8-499e-89cb-1676e9872e32", new DateTime(2023, 1, 28, 9, 26, 42, 294, DateTimeKind.Unspecified).AddTicks(8370), "f524888c-56f3-4d04-be92-fe6b4f895b12", null, "Delectus est et adipisci nostrum beatae maxime sapiente. Velit est voluptatem quisquam laboriosam hic ducimus nesciunt sint. Aperiam est quis adipisci atque optio. Cupiditate culpa quas dolore asperiores non voluptatibus. Tempore harum est inventore.", false, "Dignissimos minima ipsa laboriosam itaque. Modi omnis rerum porro. Id et vitae beatae et harum dicta sed debitis. Nam velit fuga", new DateTime(2023, 1, 28, 9, 26, 42, 294, DateTimeKind.Unspecified).AddTicks(8370), "f524888c-56f3-4d04-be92-fe6b4f895b12" },
                    { "c3151aa7-60b9-4682-a800-98077c6cef31", new DateTime(2022, 2, 15, 23, 45, 6, 0, DateTimeKind.Unspecified).AddTicks(3881), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Doloribus culpa et ullam rerum eum qui voluptas possimus iure. Qui exercitationem magni nemo. Magni quasi dolores eum et ab et velit. Eum sit nesciunt eum enim ratione explicabo. Omnis provident ut qui suscipit quaerat.", true, "Sunt rerum aspernatur repellendus non animi voluptatibus fuga quo. Repellendus fuga aut aut atque illo mollitia. Quaerat recusan", new DateTime(2022, 2, 15, 23, 45, 6, 0, DateTimeKind.Unspecified).AddTicks(3881), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "d46499b9-1bdd-4c01-98be-9d9bbd560d68", new DateTime(2022, 4, 15, 2, 57, 12, 430, DateTimeKind.Unspecified).AddTicks(5610), "9aef1613-965e-4579-9b03-95c05a90b0e2", null, "Iusto omnis numquam eum. Eaque itaque iusto recusandae placeat necessitatibus unde repellendus. Voluptatem qui enim qui eaque.", false, "Consequuntur adipisci repudiandae voluptatibus commodi vero facilis deserunt itaque. Distinctio et laboriosam voluptas at eius i", new DateTime(2022, 4, 15, 2, 57, 12, 430, DateTimeKind.Unspecified).AddTicks(5610), "9aef1613-965e-4579-9b03-95c05a90b0e2" },
                    { "f5f16745-8600-4a22-b864-4d86f1262478", new DateTime(2022, 3, 13, 14, 40, 36, 37, DateTimeKind.Unspecified).AddTicks(3617), "e79ba770-a43f-4069-b95f-ad60a62320c9", null, "Aspernatur qui officiis. Aspernatur id ea est et qui quam natus. Esse cupiditate omnis magni molestiae possimus ea architecto dolores. Alias aut autem sunt rem commodi est itaque numquam est.", false, "Impedit magni quaerat. Nihil sunt nihil nulla quo. Exercitationem consequuntur doloremque.", new DateTime(2022, 3, 13, 14, 40, 36, 37, DateTimeKind.Unspecified).AddTicks(3617), "e79ba770-a43f-4069-b95f-ad60a62320c9" },
                    { "f75b9f22-1cf4-4c0d-a838-05525371fa44", new DateTime(2023, 3, 3, 2, 56, 17, 959, DateTimeKind.Unspecified).AddTicks(9018), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd", null, "Magni rerum nobis dolor quos deserunt et omnis cupiditate rem. Sed et nisi dolores. Non similique repudiandae. Officiis sunt temporibus suscipit ut qui. Velit qui consequuntur ullam voluptatem quae et provident.", true, "Nihil ab nam perferendis dolor et pariatur autem. Et aliquid necessitatibus velit suscipit et suscipit inventore sint non. Maxim", new DateTime(2023, 3, 3, 2, 56, 17, 959, DateTimeKind.Unspecified).AddTicks(9018), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "0068240d-7419-40ac-b3e5-8e68378d8aae", new DateTime(2022, 4, 20, 8, 30, 21, 959, DateTimeKind.Unspecified).AddTicks(1498), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd", null, "Natus vero fugiat quia incidunt. Fuga aut aut. Voluptatum enim exercitationem labore libero alias quia est magnam.", true, "[{\"role\":\"system\",\"content\":\"Rerum nisi qui porro. Qui vitae vel qui sapiente libero ut nihil\"},{\"role\":\"user\",\"content\":\"Animi voluptas eum et quis qui ipsam temporibus. Incidunt velit\"},{\"role\":\"assistant\",\"content\":\"Corporis molestiae perferendis enim optio qui quo. Rerum dolores\"},{\"role\":\"user\",\"content\":\"Facilis quae cupiditate quis et dolore sed libero corporis omnis\"},{\"role\":\"system\",\"content\":\"Harum nobis doloremque eum rerum molestias illo ut. Deserunt ali\"},{\"role\":\"user\",\"content\":\"Est quia quod libero aperiam quia sapiente dolores. Doloremque f\"},{\"role\":\"assistant\",\"content\":\"Aut voluptas dolore ad at recusandae quidem. Eos unde repellendu\"},{\"role\":\"user\",\"content\":\"Rerum voluptatem nam eum. Voluptas ad aliquid culpa ut dignissim\"}]", "gpt-3.5-trubo", "Sit sit quaerat quia ullam cumque soluta. Cupiditate praesentium perspiciatis eaque molestiae consequuntur ut neque. Quisquam pl", "f75b9f22-1cf4-4c0d-a838-05525371fa44", 13655, new DateTime(2022, 4, 20, 8, 30, 21, 959, DateTimeKind.Unspecified).AddTicks(1498), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd" },
                    { "043fe92e-b719-4f28-8074-d3a48c9deb70", new DateTime(2022, 5, 13, 14, 8, 5, 63, DateTimeKind.Unspecified).AddTicks(8696), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Dolores est assumenda eos impedit omnis animi. Et nihil enim non. Odio ullam facilis. Vero est et. Est omnis perferendis.", false, "[{\"role\":\"system\",\"content\":\"Distinctio id non sed sed amet. Est eum ipsa voluptas qui quod i\"},{\"role\":\"user\",\"content\":\"Quas dolorem est eum excepturi tempora qui. Voluptatem libero od\"},{\"role\":\"system\",\"content\":\"A fuga fugit aut. Quis enim sit ut ratione. Aspernatur impedit v\"},{\"role\":\"user\",\"content\":\"Nemo dolorum dignissimos rem. Maxime nobis aut voluptatem enim a\"},{\"role\":\"system\",\"content\":\"Explicabo est magnam eveniet. Unde quia totam velit minima. Quia\"},{\"role\":\"user\",\"content\":\"Aliquid ut voluptatem. Necessitatibus laboriosam corrupti. Animi\"}]", "gpt-3.5-trubo", "Ut voluptates est velit natus repudiandae. Et et sit. Dignissimos molestias magnam et id quibusdam et ex et. Id amet vitae.", "480b8043-b15d-4124-b5dc-e93e7717cf8f", 9480, new DateTime(2022, 5, 13, 14, 8, 5, 63, DateTimeKind.Unspecified).AddTicks(8696), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "0a061869-5614-4609-a7f9-1ebfa719aa45", new DateTime(2023, 9, 25, 15, 11, 6, 482, DateTimeKind.Unspecified).AddTicks(3739), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Veniam odio odio. Blanditiis eaque repellendus sit culpa repudiandae. Aut deserunt id natus eum magni. Quis et cumque et commodi saepe qui. Voluptas earum aspernatur error.", true, "[{\"role\":\"user\",\"content\":\"Inventore non possimus rem a amet enim sit. Et officiis et dolor\"},{\"role\":\"assistant\",\"content\":\"Quidem harum dolorem laborum odit iusto rem quia. Voluptatem tem\"},{\"role\":\"user\",\"content\":\"Tempora qui hic unde nostrum. Vero mollitia nulla omnis optio. F\"},{\"role\":\"system\",\"content\":\"Ad rerum pariatur in totam et. Id eum nulla recusandae voluptati\"},{\"role\":\"system\",\"content\":\"Quasi soluta dignissimos delectus molestias occaecati voluptatem\"},{\"role\":\"assistant\",\"content\":\"Dignissimos et itaque vitae ut veritatis eos illo blanditiis qui\"},{\"role\":\"system\",\"content\":\"Architecto accusantium consequuntur suscipit quisquam aut aliqui\"}]", "gpt-3.5-trubo", "Repellendus velit earum nam qui dolores a. Autem veritatis assumenda quod qui dicta possimus sint necessitatibus praesentium. Ex", "2a3eec74-b118-41fc-99aa-f7a8b0b6b62c", 11764, new DateTime(2023, 9, 25, 15, 11, 6, 482, DateTimeKind.Unspecified).AddTicks(3739), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "0e0ed653-4588-40ac-a4b2-2e06eb2d0ec4", new DateTime(2023, 12, 24, 13, 12, 10, 867, DateTimeKind.Unspecified).AddTicks(942), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Blanditiis ullam laborum in amet ut minima dolorum. Ut alias pariatur rerum molestiae voluptas ducimus veniam modi non. Expedita qui porro voluptatem nihil.", false, "[{\"role\":\"user\",\"content\":\"Ea animi non excepturi consequuntur iure quia provident. Sequi f\"},{\"role\":\"user\",\"content\":\"Vel enim accusamus. Cumque eius temporibus. Excepturi earum veli\"},{\"role\":\"user\",\"content\":\"Quidem consectetur repellat reprehenderit nisi quo cupiditate. F\"},{\"role\":\"user\",\"content\":\"Repellendus ex cum tenetur odio provident voluptatem. Tenetur es\"},{\"role\":\"assistant\",\"content\":\"Tempora totam magni aut fugit nesciunt consequatur alias eos. Es\"},{\"role\":\"user\",\"content\":\"Nam qui commodi est porro facilis deleniti blanditiis et. Porro\"},{\"role\":\"system\",\"content\":\"Corporis quibusdam eaque eius et aliquid dignissimos. Quia dolor\"},{\"role\":\"system\",\"content\":\"Architecto in qui non ratione sit nobis accusamus dicta quisquam\"},{\"role\":\"system\",\"content\":\"Explicabo cupiditate aut ut quos. Et et ut vel voluptatibus elig\"}]", "gpt-4", "Et ipsam voluptatem minima et omnis. Velit magni est sit non quia voluptatem. Voluptate et eveniet autem velit. Fugiat ducimus a", "c3151aa7-60b9-4682-a800-98077c6cef31", 6439, new DateTime(2023, 12, 24, 13, 12, 10, 867, DateTimeKind.Unspecified).AddTicks(942), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "1efb87fa-3f05-41fe-a2ca-0ff55352635b", new DateTime(2022, 10, 6, 1, 23, 14, 665, DateTimeKind.Unspecified).AddTicks(3941), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Animi reprehenderit sint modi est sed ad culpa similique. Harum fugiat cum optio quas provident dolore. Tempore occaecati qui modi nulla. Aut et quis ut.", false, "[{\"role\":\"user\",\"content\":\"Corporis illum id pariatur ea qui quia dolore. Facilis non labor\"},{\"role\":\"system\",\"content\":\"Occaecati omnis neque provident non aut amet id sint. Natus et e\"},{\"role\":\"system\",\"content\":\"Sit rerum aut ipsam adipisci quia incidunt dolore voluptatem et.\"},{\"role\":\"user\",\"content\":\"Qui et omnis ut. Quidem excepturi eos consequatur accusantium ei\"},{\"role\":\"assistant\",\"content\":\"Sequi nostrum tempora eaque quas dolor quidem enim eius. Accusam\"},{\"role\":\"system\",\"content\":\"Non ut et quaerat nihil voluptatem. Facilis iste ut qui quas et\"},{\"role\":\"assistant\",\"content\":\"Vitae tempore placeat et dolorem sed. Numquam fugit ex incidunt\"},{\"role\":\"system\",\"content\":\"Temporibus sit sit quos eos. Ea autem et qui minima omnis et mol\"},{\"role\":\"assistant\",\"content\":\"Iusto fugiat quae est sit ut hic fugit natus neque. Hic ea sit.\"},{\"role\":\"assistant\",\"content\":\"Inventore inventore autem repudiandae aut quisquam quia voluptas\"}]", "gpt-3.5-trubo", "Debitis cumque nobis distinctio dolores delectus quo quidem voluptatibus. Ipsa qui molestiae blanditiis ea voluptatem consequatu", "771c3266-ab4d-411b-b2ed-35a6eeb01e83", 12284, new DateTime(2022, 10, 6, 1, 23, 14, 665, DateTimeKind.Unspecified).AddTicks(3941), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "23aafa22-24bc-4634-9a84-e1595c5b3875", new DateTime(2023, 6, 1, 11, 2, 15, 944, DateTimeKind.Unspecified).AddTicks(566), "f524888c-56f3-4d04-be92-fe6b4f895b12", null, "Quod et modi iure libero veniam enim recusandae vero. Esse facilis reiciendis aperiam atque dolor qui nobis dolores. Ut rerum beatae repellat.", true, "[{\"role\":\"assistant\",\"content\":\"Perspiciatis blanditiis placeat. Ad vitae quis id. Quisquam aliq\"},{\"role\":\"user\",\"content\":\"Corporis vitae iure rerum molestiae consequatur voluptatem dolor\"},{\"role\":\"system\",\"content\":\"Dolor eum eius inventore molestiae. Voluptas dignissimos sunt vi\"},{\"role\":\"system\",\"content\":\"Dolor non aperiam sint voluptatum. Odit reiciendis temporibus. A\"}]", "gpt-3.5-trubo", "Officiis dolorem porro. Consequatur velit laborum ad cupiditate quisquam. Ut quo non ea fugit corrupti nam fugiat voluptate. Vel", "9ee31024-e1e8-499e-89cb-1676e9872e32", 8378, new DateTime(2023, 6, 1, 11, 2, 15, 944, DateTimeKind.Unspecified).AddTicks(566), "f524888c-56f3-4d04-be92-fe6b4f895b12" },
                    { "2a03b6db-b6d2-4575-b074-382694dc0724", new DateTime(2023, 2, 25, 3, 45, 23, 587, DateTimeKind.Unspecified).AddTicks(5121), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Deserunt commodi impedit quam aut aperiam ex. Accusantium facere aliquid distinctio consequatur cupiditate et natus quas. Dolorem ut facere recusandae quam impedit ea omnis.", true, "[{\"role\":\"user\",\"content\":\"At hic fugit doloribus numquam earum distinctio magnam dolor dol\"},{\"role\":\"system\",\"content\":\"Temporibus dolor quibusdam. Consequatur at tempore mollitia quo\"},{\"role\":\"system\",\"content\":\"Illum voluptates facere magni distinctio rerum quibusdam aliquid\"},{\"role\":\"assistant\",\"content\":\"Modi eos nostrum nisi quasi beatae dolorem saepe. Facere et inci\"},{\"role\":\"system\",\"content\":\"Recusandae suscipit sed et iste sed provident. Et et quos fugiat\"},{\"role\":\"user\",\"content\":\"Vel libero inventore esse atque. Sed unde voluptatem amet provid\"}]", "gpt-4", "Ea necessitatibus assumenda eaque hic est aut. Tempora incidunt atque ipsam nisi non. Et iure numquam.", "480b8043-b15d-4124-b5dc-e93e7717cf8f", 7086, new DateTime(2023, 2, 25, 3, 45, 23, 587, DateTimeKind.Unspecified).AddTicks(5121), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "31d673f1-53fd-4a59-a641-4ee1063306d1", new DateTime(2022, 12, 13, 4, 19, 55, 541, DateTimeKind.Unspecified).AddTicks(2034), "9aef1613-965e-4579-9b03-95c05a90b0e2", null, "Porro suscipit molestiae vel aut omnis aut itaque ut velit. Non molestiae nostrum in. Corporis ducimus eos necessitatibus laudantium aut maxime excepturi. Quia officiis provident quo est voluptatem. Quo impedit sit tenetur occaecati quas vitae.", true, "[{\"role\":\"assistant\",\"content\":\"Quia aut labore doloremque inventore. Nulla soluta commodi fugit\"}]", "gpt-3.5-trubo", "Aut fugiat autem est assumenda sed. Delectus sit itaque fugiat ad delectus est. Totam consequatur molestiae suscipit id qui exer", "d46499b9-1bdd-4c01-98be-9d9bbd560d68", 5983, new DateTime(2022, 12, 13, 4, 19, 55, 541, DateTimeKind.Unspecified).AddTicks(2034), "9aef1613-965e-4579-9b03-95c05a90b0e2" },
                    { "32bfe1fc-3438-42a3-9679-de6de2a510ae", new DateTime(2022, 11, 14, 19, 30, 56, 443, DateTimeKind.Unspecified).AddTicks(7765), "f524888c-56f3-4d04-be92-fe6b4f895b12", null, "Ut in harum expedita tempore maxime ipsam. Perferendis veniam numquam optio suscipit voluptatibus nesciunt iure ea. Ullam rerum omnis impedit corporis explicabo. Esse laboriosam repudiandae.", false, "[{\"role\":\"assistant\",\"content\":\"Ipsum labore iste eligendi eligendi nihil ullam dolore. Pariatur\"},{\"role\":\"system\",\"content\":\"Assumenda dolorem error ab voluptas dolor. Voluptatem velit adip\"},{\"role\":\"assistant\",\"content\":\"Quis quos dolores neque. Molestiae asperiores et quaerat. Iure i\"},{\"role\":\"user\",\"content\":\"Voluptatem minus accusantium sunt autem ex quaerat. Ipsam sed ip\"},{\"role\":\"assistant\",\"content\":\"Et ad voluptas incidunt saepe rerum officia perferendis et. Quas\"},{\"role\":\"user\",\"content\":\"Rerum unde quasi. Et id dicta dignissimos. Impedit praesentium i\"}]", "gpt-4", "Excepturi id modi. Aut dolore minima nisi dolore odio itaque debitis ea dignissimos. Vitae necessitatibus voluptatem cupiditate", "9ee31024-e1e8-499e-89cb-1676e9872e32", 8771, new DateTime(2022, 11, 14, 19, 30, 56, 443, DateTimeKind.Unspecified).AddTicks(7765), "f524888c-56f3-4d04-be92-fe6b4f895b12" },
                    { "3e58cd86-f2a8-4619-b4b7-f6ee7a437926", new DateTime(2023, 2, 15, 22, 40, 52, 432, DateTimeKind.Unspecified).AddTicks(3052), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "In itaque doloribus facere incidunt velit officia. Optio quis minus. Recusandae natus ut veritatis libero consequuntur veritatis. Id veritatis animi quae.", false, "[{\"role\":\"user\",\"content\":\"Quo sit voluptas voluptatum est consequatur rem. Velit voluptate\"},{\"role\":\"user\",\"content\":\"Nihil impedit corrupti blanditiis quis nesciunt corporis nobis l\"},{\"role\":\"system\",\"content\":\"Consequatur rerum modi rerum et recusandae accusamus consectetur\"},{\"role\":\"assistant\",\"content\":\"Sint nobis harum. Officia et ut quos nemo voluptates laborum. La\"},{\"role\":\"assistant\",\"content\":\"Voluptas deleniti commodi distinctio voluptatem porro minima lab\"}]", "gpt-4", "Ut ut totam iusto odio nihil consequatur. Labore sed officia sed optio accusamus est ut et vel. Quis esse unde.", "c3151aa7-60b9-4682-a800-98077c6cef31", 1960, new DateTime(2023, 2, 15, 22, 40, 52, 432, DateTimeKind.Unspecified).AddTicks(3052), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "41389ae7-21ff-490e-a7dc-234ca62ad1d5", new DateTime(2023, 11, 20, 23, 59, 18, 216, DateTimeKind.Unspecified).AddTicks(2413), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd", null, "Tenetur perferendis sit est dolorem exercitationem molestiae. Et temporibus molestias quaerat sit. Dolorum quis consectetur in nostrum. Perferendis et incidunt minima facere. Eum repellat rerum provident.", false, "[{\"role\":\"assistant\",\"content\":\"Ut eius rem aut laudantium. Commodi accusantium nobis nihil quam\"}]", "gpt-4", "Non molestiae voluptas voluptates vel. Fugiat aut nihil debitis deserunt dolor est esse. Tempore eos aliquid placeat autem.", "f75b9f22-1cf4-4c0d-a838-05525371fa44", 9527, new DateTime(2023, 11, 20, 23, 59, 18, 216, DateTimeKind.Unspecified).AddTicks(2413), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd" },
                    { "487b7cfb-6066-4e0f-9bf7-881040d10869", new DateTime(2023, 3, 25, 1, 22, 3, 356, DateTimeKind.Unspecified).AddTicks(1307), "13ee4105-45c5-4c2c-8ebe-0da1d7604088", null, "Blanditiis consequuntur quasi qui est. Qui error vel sed ut sunt officia et. Consequatur itaque voluptatibus est at nostrum culpa cumque expedita.", true, "[{\"role\":\"system\",\"content\":\"Rerum accusamus id commodi est sit recusandae corrupti. Corrupti\"},{\"role\":\"system\",\"content\":\"Laudantium sint est aperiam laboriosam vitae. Voluptatum nisi au\"},{\"role\":\"user\",\"content\":\"Ut omnis harum pariatur voluptas sit. Quam et inventore autem. Q\"},{\"role\":\"assistant\",\"content\":\"Nam et et. Explicabo et ut eos omnis rerum harum. Consequatur ve\"}]", "gpt-4", "Iste delectus quis explicabo voluptate cupiditate eum iste recusandae. Magnam accusamus temporibus commodi labore quia repudiand", "02490e24-e61f-40d0-b1ce-f604d5435c87", 5801, new DateTime(2023, 3, 25, 1, 22, 3, 356, DateTimeKind.Unspecified).AddTicks(1307), "13ee4105-45c5-4c2c-8ebe-0da1d7604088" },
                    { "560bb51e-2572-4747-9eea-9aecd189bdca", new DateTime(2022, 2, 2, 0, 34, 38, 550, DateTimeKind.Unspecified).AddTicks(9091), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Magni vel reprehenderit totam provident tempora quaerat non optio. Voluptas est accusamus minima. Sint velit ab ipsa recusandae. Omnis necessitatibus sequi vel harum distinctio quaerat nulla nam.", true, "[{\"role\":\"assistant\",\"content\":\"Nihil vero harum cumque in enim praesentium. Minus corrupti repe\"},{\"role\":\"user\",\"content\":\"Voluptatem molestiae officia. Optio ut rerum maxime molestias ve\"},{\"role\":\"system\",\"content\":\"Corporis fuga iure rerum voluptatibus rerum. Cum cum ad. Qui seq\"},{\"role\":\"system\",\"content\":\"Sit odio ea sunt recusandae enim accusantium veniam illum. Et se\"},{\"role\":\"assistant\",\"content\":\"Omnis explicabo dolores qui voluptatibus omnis voluptas voluptat\"},{\"role\":\"assistant\",\"content\":\"Atque dicta aut nobis illo nam id ipsa sit est. Quia placeat nul\"},{\"role\":\"user\",\"content\":\"Ut consequatur ut aliquam quasi itaque quis suscipit ipsum nemo.\"},{\"role\":\"system\",\"content\":\"Exercitationem porro quod omnis quae. Quaerat qui accusamus saep\"},{\"role\":\"user\",\"content\":\"Nihil autem quia qui expedita. Officiis a earum voluptates fuga\"}]", "gpt-4", "Dolor quaerat eaque exercitationem et voluptas rerum sed quae. Delectus praesentium ut nesciunt. Ut unde aliquam quo consequatur", "771c3266-ab4d-411b-b2ed-35a6eeb01e83", 5715, new DateTime(2022, 2, 2, 0, 34, 38, 550, DateTimeKind.Unspecified).AddTicks(9091), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "6e7a4f5f-c3de-442c-aa22-3685b91b2144", new DateTime(2022, 8, 15, 6, 18, 32, 980, DateTimeKind.Unspecified).AddTicks(2995), "f524888c-56f3-4d04-be92-fe6b4f895b12", null, "Aut hic ipsum distinctio hic. Aliquam quos eaque animi quae autem. Sequi aut dolorum. Omnis voluptatibus in eveniet enim.", true, "[{\"role\":\"assistant\",\"content\":\"Quam provident qui aut voluptate quae animi est. Eveniet aut qua\"},{\"role\":\"assistant\",\"content\":\"Corrupti minima nam quibusdam cupiditate alias neque fugit. Sed\"}]", "gpt-4", "Aliquam repellendus aut fugit asperiores blanditiis aliquam voluptatem. Qui ea est distinctio perferendis. Vitae et numquam exce", "9ee31024-e1e8-499e-89cb-1676e9872e32", 2092, new DateTime(2022, 8, 15, 6, 18, 32, 980, DateTimeKind.Unspecified).AddTicks(2995), "f524888c-56f3-4d04-be92-fe6b4f895b12" },
                    { "6f653840-a482-49c7-a670-ec0080e1da7b", new DateTime(2022, 3, 4, 4, 23, 37, 760, DateTimeKind.Unspecified).AddTicks(487), "13ee4105-45c5-4c2c-8ebe-0da1d7604088", null, "Tenetur vel sit omnis consequatur sed et rerum inventore minus. Qui sunt ab et animi. Ab quia voluptatem sit explicabo molestias quia. Odit qui dolore. Dicta sed fugit culpa. Officia aperiam sapiente fugit id porro et.", false, "[{\"role\":\"user\",\"content\":\"Velit doloribus nam quaerat dolorem nihil et. Quae aut in alias\"},{\"role\":\"system\",\"content\":\"Nulla aut velit non. Accusamus ea neque sunt culpa qui est labor\"},{\"role\":\"assistant\",\"content\":\"Atque et numquam ad qui nemo. Blanditiis est cupiditate rem quis\"},{\"role\":\"system\",\"content\":\"Veniam aliquid illo repellat ad occaecati qui. Error neque eos m\"},{\"role\":\"assistant\",\"content\":\"Nam quis velit nam iste dolorem recusandae facilis. Deserunt vel\"},{\"role\":\"user\",\"content\":\"Id similique consequatur autem ea quam. Sed officiis accusamus a\"},{\"role\":\"system\",\"content\":\"Nihil corporis dolorum perferendis. Dolorem odio ab tempore et q\"}]", "gpt-4", "Nostrum cupiditate sed totam qui. Quo minima quod repellendus sint nesciunt temporibus. Distinctio ad ut repudiandae.", "02490e24-e61f-40d0-b1ce-f604d5435c87", 13720, new DateTime(2022, 3, 4, 4, 23, 37, 760, DateTimeKind.Unspecified).AddTicks(487), "13ee4105-45c5-4c2c-8ebe-0da1d7604088" },
                    { "6f969943-954b-49e1-9e20-6d1e2c767953", new DateTime(2022, 4, 4, 3, 53, 47, 279, DateTimeKind.Unspecified).AddTicks(3228), "e79ba770-a43f-4069-b95f-ad60a62320c9", null, "Hic fugiat impedit ut omnis aut. Soluta iusto consequuntur officia repellat aspernatur ut officia magnam. Minus eligendi et esse velit a. Veniam quam sit qui dicta dolores doloribus voluptas. Dolore iste ad atque animi.", true, "[{\"role\":\"user\",\"content\":\"Eos eos quam consequatur sint et nihil. Officiis quam a architec\"},{\"role\":\"system\",\"content\":\"Architecto molestiae ipsam corrupti vel iure. Aut et ipsa nesciu\"},{\"role\":\"user\",\"content\":\"Fuga dignissimos delectus corrupti consequatur debitis et. Sit v\"},{\"role\":\"assistant\",\"content\":\"Quo numquam dolores dolor laudantium deserunt. Aperiam fuga dolo\"},{\"role\":\"user\",\"content\":\"Consequatur enim qui nisi consequuntur non amet qui quo. Dolorem\"},{\"role\":\"user\",\"content\":\"Sapiente quod est sint debitis voluptate dolorum provident. Dele\"},{\"role\":\"assistant\",\"content\":\"Sunt et aspernatur quas asperiores sed optio adipisci. Libero ra\"}]", "gpt-3.5-trubo", "Saepe nostrum omnis. Laborum labore libero est sit ut nisi blanditiis modi illum. Ut occaecati dolores in velit amet velit harum", "f5f16745-8600-4a22-b864-4d86f1262478", 9441, new DateTime(2022, 4, 4, 3, 53, 47, 279, DateTimeKind.Unspecified).AddTicks(3228), "e79ba770-a43f-4069-b95f-ad60a62320c9" },
                    { "70004fb2-e7f9-49a3-a4e1-19188d3b5c17", new DateTime(2023, 7, 25, 19, 47, 54, 970, DateTimeKind.Unspecified).AddTicks(3849), "dd767247-16e5-41c9-a0d2-d5f9883146ef", null, "Aliquid ipsum esse inventore quas. Tempora voluptate et dolore ullam quidem voluptatem dolorum. Iure amet aut aut nulla quia eius aut a.", true, "[{\"role\":\"assistant\",\"content\":\"Veniam et ullam ut aut. Voluptas magnam vero. Dolorem eligendi o\"},{\"role\":\"assistant\",\"content\":\"Est et et. Quia aut qui similique numquam cumque laborum cupidit\"}]", "gpt-3.5-trubo", "Nostrum consequatur adipisci impedit odio maiores qui et ut placeat. Odit fugit ipsum. Sint occaecati quo aut.", "85d978b2-2dbb-4fe0-adf9-d0d5657d868a", 10134, new DateTime(2023, 7, 25, 19, 47, 54, 970, DateTimeKind.Unspecified).AddTicks(3849), "dd767247-16e5-41c9-a0d2-d5f9883146ef" },
                    { "70732666-cb16-481b-a676-77caae32bbfb", new DateTime(2022, 3, 13, 21, 20, 39, 511, DateTimeKind.Unspecified).AddTicks(5118), "e79ba770-a43f-4069-b95f-ad60a62320c9", null, "Molestias quis laboriosam mollitia enim dignissimos autem sed. At dolorem rerum non laudantium molestias ab qui eveniet. Ad ut hic nostrum vero quia rerum eaque aliquam. Saepe dignissimos quia aspernatur molestias nihil. Voluptate quam atque et asperiores", false, "[{\"role\":\"assistant\",\"content\":\"Eos non nihil dolor aut. In dignissimos consequatur quia quia te\"},{\"role\":\"assistant\",\"content\":\"Quos hic dolorum sit est id placeat suscipit ea eligendi. Volupt\"},{\"role\":\"assistant\",\"content\":\"Totam amet repellendus dignissimos qui recusandae et sed non del\"},{\"role\":\"system\",\"content\":\"Incidunt dicta vero. Ducimus est autem possimus facere sit quo c\"},{\"role\":\"system\",\"content\":\"Iure quod error molestias. Ullam minus officiis eum voluptatum c\"},{\"role\":\"user\",\"content\":\"Ut veritatis placeat mollitia distinctio mollitia nihil neque. D\"},{\"role\":\"assistant\",\"content\":\"Quae aut blanditiis sapiente. Quia voluptatem quidem maxime eum\"},{\"role\":\"system\",\"content\":\"Qui rerum quasi quis vel unde sed. Esse doloribus qui est dolore\"},{\"role\":\"assistant\",\"content\":\"Asperiores numquam nobis alias. Officia perferendis dolor quis a\"}]", "gpt-3.5-trubo", "Aliquam laborum consequuntur voluptatem numquam et numquam corrupti necessitatibus. Doloribus quo qui corporis distinctio volupt", "f5f16745-8600-4a22-b864-4d86f1262478", 757, new DateTime(2022, 3, 13, 21, 20, 39, 511, DateTimeKind.Unspecified).AddTicks(5118), "e79ba770-a43f-4069-b95f-ad60a62320c9" },
                    { "73260645-2ba6-48f0-82ec-44e5577153c7", new DateTime(2022, 12, 16, 17, 25, 39, 679, DateTimeKind.Unspecified).AddTicks(6618), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Necessitatibus perferendis voluptatem ea corrupti placeat ut ipsa sint. Laboriosam voluptas odit fugit est rerum ad eveniet placeat sit. Ex veniam ea nemo eos et quidem. Beatae esse repudiandae quis cupiditate. Expedita eos molestiae non cum temporibus dol", true, "[{\"role\":\"system\",\"content\":\"Debitis quia non aspernatur ex. Sit accusamus unde maiores fuga\"},{\"role\":\"assistant\",\"content\":\"Aperiam voluptates libero. Voluptatum omnis quia maiores impedit\"},{\"role\":\"user\",\"content\":\"Possimus hic aut officia accusamus. Excepturi omnis fugiat sapie\"}]", "gpt-4", "Id voluptatibus quae voluptas. Sed sit dolorem ex reiciendis excepturi. Porro officiis nostrum facere quis nam est. Corporis pra", "480b8043-b15d-4124-b5dc-e93e7717cf8f", 7892, new DateTime(2022, 12, 16, 17, 25, 39, 679, DateTimeKind.Unspecified).AddTicks(6618), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "a9073efe-4f16-48d5-a22d-682f03cfa72b", new DateTime(2022, 5, 16, 11, 17, 17, 471, DateTimeKind.Unspecified).AddTicks(7637), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Adipisci quaerat asperiores asperiores. Dicta ut nihil. Vitae occaecati maxime dolorem eum ea. Possimus corrupti eos cumque exercitationem. Libero dolorem alias ipsum eius quis quasi eaque.", true, "[{\"role\":\"user\",\"content\":\"Consequatur voluptatem animi ullam dolores autem et aperiam non.\"},{\"role\":\"user\",\"content\":\"Eum corporis eveniet quaerat possimus sapiente. Voluptatem est a\"},{\"role\":\"system\",\"content\":\"Quis eaque blanditiis veritatis. Nihil inventore et sunt. Vero e\"},{\"role\":\"assistant\",\"content\":\"Dolorum veritatis voluptas quia aperiam quis mollitia eaque mole\"},{\"role\":\"system\",\"content\":\"Nesciunt quam et ut consequuntur ullam harum. Velit aliquid et n\"},{\"role\":\"system\",\"content\":\"Labore nisi possimus. Est laborum sunt quis sunt dicta assumenda\"},{\"role\":\"assistant\",\"content\":\"Et nesciunt ratione eum. Ipsa maiores iusto corrupti quod repell\"}]", "gpt-4", "Consectetur deserunt qui et tempora est sit. Quo quibusdam autem quis. Mollitia aliquam sed nobis ut quia. Dicta iste dicta vita", "c3151aa7-60b9-4682-a800-98077c6cef31", 6098, new DateTime(2022, 5, 16, 11, 17, 17, 471, DateTimeKind.Unspecified).AddTicks(7637), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "c18feec0-a694-4658-9d03-926c36f6d5da", new DateTime(2023, 10, 24, 8, 47, 9, 719, DateTimeKind.Unspecified).AddTicks(2312), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Qui consequatur odit et est voluptatem autem vitae. Aut voluptas fugiat illo beatae repudiandae autem error est. Nihil minima soluta impedit animi molestiae sunt corrupti. Quaerat nihil aut voluptatem praesentium rerum enim. Et ut eos qui corporis quisquam", true, "[{\"role\":\"assistant\",\"content\":\"Illum harum placeat quidem dolor aliquam explicabo error volupta\"},{\"role\":\"system\",\"content\":\"Dolor laudantium labore quis voluptas ut eum veniam. Praesentium\"},{\"role\":\"assistant\",\"content\":\"Nam officiis quas. Nemo dolor natus et iste repellendus molestia\"},{\"role\":\"user\",\"content\":\"Quam rerum voluptas error. Iure qui doloremque explicabo ducimus\"},{\"role\":\"user\",\"content\":\"Placeat fuga temporibus quis et alias harum voluptatem. Officiis\"},{\"role\":\"assistant\",\"content\":\"Ratione aperiam consequatur rerum voluptatibus veniam. Pariatur\"},{\"role\":\"system\",\"content\":\"Dolores deserunt tempore repudiandae fuga. Praesentium quos in q\"},{\"role\":\"user\",\"content\":\"Cupiditate sint adipisci earum. Numquam consequatur molestiae et\"}]", "gpt-3.5-trubo", "Et quasi reprehenderit dolor deserunt modi excepturi voluptas. Illum at tenetur aperiam est. Natus qui possimus. Tenetur neque e", "2a3eec74-b118-41fc-99aa-f7a8b0b6b62c", 10927, new DateTime(2023, 10, 24, 8, 47, 9, 719, DateTimeKind.Unspecified).AddTicks(2312), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "c5115b51-cbdf-4b18-b9b0-a2a2b618ab04", new DateTime(2022, 6, 1, 8, 49, 10, 482, DateTimeKind.Unspecified).AddTicks(4530), "dd767247-16e5-41c9-a0d2-d5f9883146ef", null, "Voluptatem voluptas molestias quia. Quo dolor voluptatem est excepturi suscipit necessitatibus incidunt quibusdam tenetur. Ea ea vero quaerat dolore aliquam consequatur. Dolorum ut quia suscipit.", false, "[{\"role\":\"system\",\"content\":\"Culpa earum rerum aliquid corporis et. Ea et magni et. Animi nat\"},{\"role\":\"user\",\"content\":\"Quo suscipit rem cum autem hic autem saepe quidem iure. Tenetur\"},{\"role\":\"assistant\",\"content\":\"Rerum veniam laudantium corporis. Consectetur ipsa aut voluptate\"},{\"role\":\"assistant\",\"content\":\"Occaecati quis temporibus aut voluptatibus non consequuntur porr\"},{\"role\":\"user\",\"content\":\"Officia excepturi nihil enim hic ducimus commodi nihil. Delectus\"},{\"role\":\"assistant\",\"content\":\"Minima ratione mollitia doloremque ducimus dolores consequuntur\"},{\"role\":\"assistant\",\"content\":\"Et voluptatibus sequi enim qui sequi debitis ut cum. Optio repre\"}]", "gpt-3.5-trubo", "Molestiae rerum ipsam. Esse quos explicabo. Iure assumenda repudiandae vel qui deleniti occaecati nemo eum blanditiis. Debitis i", "85d978b2-2dbb-4fe0-adf9-d0d5657d868a", 6724, new DateTime(2022, 6, 1, 8, 49, 10, 482, DateTimeKind.Unspecified).AddTicks(4530), "dd767247-16e5-41c9-a0d2-d5f9883146ef" },
                    { "cccdcef1-d086-41f6-b72d-fb348da06989", new DateTime(2023, 2, 17, 17, 6, 0, 607, DateTimeKind.Unspecified).AddTicks(7094), "dd767247-16e5-41c9-a0d2-d5f9883146ef", null, "Est eos voluptatem commodi explicabo rerum ut sapiente. Placeat et beatae molestiae sint sint quia fugiat. Saepe veniam fugit sunt nisi quod molestias.", false, "[{\"role\":\"user\",\"content\":\"Impedit hic eius facilis dolorem necessitatibus perferendis. Mol\"},{\"role\":\"assistant\",\"content\":\"Rerum aut mollitia placeat eaque dignissimos. Nulla enim numquam\"},{\"role\":\"system\",\"content\":\"Recusandae reiciendis distinctio suscipit ullam quia non. Nulla\"},{\"role\":\"user\",\"content\":\"Perferendis cum laudantium dolores dolor nobis quasi autem liber\"},{\"role\":\"user\",\"content\":\"Inventore aut perferendis. Explicabo quae est non aut. Deserunt\"},{\"role\":\"system\",\"content\":\"Eum odio id. Perferendis et ipsum unde molestiae asperiores. Off\"}]", "gpt-4", "Sit quia provident sint. Architecto et provident sapiente autem quia. Ullam ea accusamus quidem. Velit deserunt sed pariatur vel", "85d978b2-2dbb-4fe0-adf9-d0d5657d868a", 15071, new DateTime(2023, 2, 17, 17, 6, 0, 607, DateTimeKind.Unspecified).AddTicks(7094), "dd767247-16e5-41c9-a0d2-d5f9883146ef" },
                    { "cff1b582-e186-4807-a778-b3653f482e7a", new DateTime(2023, 11, 23, 20, 18, 47, 583, DateTimeKind.Unspecified).AddTicks(9042), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd", null, "Consequatur et illo id provident incidunt nam rem et. Expedita voluptates accusamus similique quos. Labore fuga rerum. Fuga sint autem quis sint incidunt aliquid fugiat iure illo.", false, "[{\"role\":\"user\",\"content\":\"Non hic ullam temporibus nostrum nisi. Vel ipsa magni saepe nost\"},{\"role\":\"assistant\",\"content\":\"Pariatur in rerum consequatur pariatur optio a quis. Ut vero ad.\"},{\"role\":\"user\",\"content\":\"Ut temporibus rerum ad ratione cum laboriosam voluptatem et. Opt\"},{\"role\":\"assistant\",\"content\":\"Et expedita quia. Esse placeat temporibus fuga repellat a qui. D\"},{\"role\":\"system\",\"content\":\"Voluptatem consequatur unde. Qui voluptas ad voluptatibus perspi\"},{\"role\":\"system\",\"content\":\"Cumque molestias aut id et suscipit doloremque repudiandae tempo\"},{\"role\":\"user\",\"content\":\"Tempore ad aut reiciendis id. Ut saepe eos laudantium quo animi\"},{\"role\":\"user\",\"content\":\"Voluptas omnis consequatur possimus fugiat ad. Nisi vel qui volu\"},{\"role\":\"system\",\"content\":\"Voluptatem repellat laudantium id illo quos sed ipsum ex. Mollit\"}]", "gpt-4", "Similique commodi dolor dignissimos debitis mollitia blanditiis accusamus dolor occaecati. Et adipisci et. Quo consequatur reici", "f75b9f22-1cf4-4c0d-a838-05525371fa44", 14728, new DateTime(2023, 11, 23, 20, 18, 47, 583, DateTimeKind.Unspecified).AddTicks(9042), "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd" },
                    { "d0f36e99-d06a-4aa1-a1b2-5b2d1645178a", new DateTime(2022, 8, 26, 11, 3, 19, 652, DateTimeKind.Unspecified).AddTicks(2007), "e79ba770-a43f-4069-b95f-ad60a62320c9", null, "Ea suscipit harum qui earum quae hic et ea. Excepturi sunt consequatur consectetur magni. Qui occaecati nihil ut molestias beatae.", false, "[{\"role\":\"assistant\",\"content\":\"A neque illum tenetur quisquam et id. Magnam facilis ut veritati\"},{\"role\":\"system\",\"content\":\"Sed aliquid et eius. Consectetur corporis quis maxime soluta. Pr\"},{\"role\":\"user\",\"content\":\"Placeat quisquam laudantium voluptatem et. Iure nemo harum dolor\"},{\"role\":\"system\",\"content\":\"Non voluptatem corrupti eos quasi qui rerum. Velit voluptatem to\"},{\"role\":\"system\",\"content\":\"Quibusdam ut cum qui occaecati. Est quae quod beatae. Autem saep\"},{\"role\":\"user\",\"content\":\"Molestias ut illum ut quia unde excepturi id. Ipsa eaque minus n\"}]", "gpt-3.5-trubo", "Sed aut ut repellat est dicta. Dolores in repellat autem culpa similique ullam. Architecto quod quae omnis libero molestiae alia", "f5f16745-8600-4a22-b864-4d86f1262478", 15082, new DateTime(2022, 8, 26, 11, 3, 19, 652, DateTimeKind.Unspecified).AddTicks(2007), "e79ba770-a43f-4069-b95f-ad60a62320c9" },
                    { "d57fb6e0-0cfa-4e5b-9503-7c2837632ca6", new DateTime(2022, 9, 24, 15, 37, 29, 853, DateTimeKind.Unspecified).AddTicks(1988), "9aef1613-965e-4579-9b03-95c05a90b0e2", null, "Tempora praesentium magnam repudiandae quis. Autem laborum voluptas et ut dolor sed alias qui ab. Sint ad consequatur. Nihil excepturi et illo. Omnis fugit dolor mollitia dolor ea et dolor sit maiores.", false, "[{\"role\":\"system\",\"content\":\"Et cum fuga distinctio. Fugiat cumque esse consequatur reprehend\"},{\"role\":\"assistant\",\"content\":\"Et ducimus eveniet provident. Neque voluptatibus excepturi iure\"}]", "gpt-3.5-trubo", "Voluptates similique adipisci sunt fugiat ad nihil sed nam. Aut et autem veniam alias adipisci enim fugit. Quo ea incidunt provi", "d46499b9-1bdd-4c01-98be-9d9bbd560d68", 1933, new DateTime(2022, 9, 24, 15, 37, 29, 853, DateTimeKind.Unspecified).AddTicks(1988), "9aef1613-965e-4579-9b03-95c05a90b0e2" },
                    { "d77bf5f2-4d0f-41b8-bb89-92e7a0d6a4ce", new DateTime(2023, 4, 14, 8, 44, 12, 385, DateTimeKind.Unspecified).AddTicks(448), "2bad0a52-f80d-4780-94a0-2909bc4a7a87", null, "Molestiae veniam explicabo quasi vel suscipit. Aut neque ut. Quia aut et dolore exercitationem quas repudiandae. Officiis quas quidem. Libero qui dolor et distinctio sed minus velit consequuntur occaecati.", false, "[{\"role\":\"user\",\"content\":\"Aut harum eum aut doloribus. Exercitationem accusantium minus re\"},{\"role\":\"assistant\",\"content\":\"Nam vitae voluptatem quidem tenetur illo eos omnis dolorem aut.\"},{\"role\":\"assistant\",\"content\":\"Autem veritatis quod. Ea architecto facere officiis accusantium.\"},{\"role\":\"system\",\"content\":\"Nesciunt omnis impedit magnam corrupti facilis est velit volupta\"},{\"role\":\"assistant\",\"content\":\"Aspernatur ad et reiciendis sit. Corrupti et officia dolor commo\"},{\"role\":\"user\",\"content\":\"Dolores quasi sed magnam omnis. Molestiae animi iure. Aut velit\"}]", "gpt-4", "A animi maiores. Consequatur dicta recusandae labore voluptatem et est. Magni aliquid alias unde recusandae sit sunt soluta omni", "771c3266-ab4d-411b-b2ed-35a6eeb01e83", 706, new DateTime(2023, 4, 14, 8, 44, 12, 385, DateTimeKind.Unspecified).AddTicks(448), "2bad0a52-f80d-4780-94a0-2909bc4a7a87" },
                    { "de5003e5-fbf9-4782-9c52-6fd7b56c8523", new DateTime(2022, 9, 7, 11, 0, 31, 538, DateTimeKind.Unspecified).AddTicks(9306), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555", null, "Consequuntur ut iure adipisci. Ipsam at qui accusantium amet assumenda. Fugiat quis dolore hic ab aut assumenda debitis. Inventore iste veritatis optio quis vel cumque doloremque modi.", false, "[{\"role\":\"assistant\",\"content\":\"Temporibus tenetur quae facilis perferendis. Unde nostrum accusa\"},{\"role\":\"user\",\"content\":\"Est dolorum eaque. Quis cupiditate dolorum aliquam dignissimos.\"},{\"role\":\"user\",\"content\":\"Voluptatem molestias consequatur. Modi impedit alias doloribus u\"},{\"role\":\"system\",\"content\":\"Delectus impedit quis repudiandae. Quam minima deserunt aut. Eve\"},{\"role\":\"user\",\"content\":\"Et dolorem minus quibusdam corrupti blanditiis et sit. Sit asper\"},{\"role\":\"assistant\",\"content\":\"Ullam vel in praesentium excepturi itaque reiciendis quo volupta\"},{\"role\":\"system\",\"content\":\"Tenetur quo ipsa praesentium ut iusto sit soluta. Et ut molestia\"},{\"role\":\"user\",\"content\":\"Eligendi rem quia eligendi possimus in quia ipsam. Laborum sunt\"}]", "gpt-3.5-trubo", "Minima id culpa cumque necessitatibus eum omnis omnis aut. Consequatur sequi ut molestiae debitis voluptatem. Ipsam cupiditate r", "2a3eec74-b118-41fc-99aa-f7a8b0b6b62c", 5853, new DateTime(2022, 9, 7, 11, 0, 31, 538, DateTimeKind.Unspecified).AddTicks(9306), "aa52b4b1-5d82-4f6d-ac2d-033c8202c555" },
                    { "e769e6b0-c2ed-487a-8fcc-234e9790705b", new DateTime(2023, 12, 17, 6, 23, 25, 92, DateTimeKind.Unspecified).AddTicks(2232), "9aef1613-965e-4579-9b03-95c05a90b0e2", null, "Aut sapiente id porro et molestiae. Et dolorem minima in voluptate eius fugit sit debitis. Praesentium ab cupiditate sed est sequi et provident atque.", true, "[{\"role\":\"assistant\",\"content\":\"Autem veniam nostrum explicabo sit rem similique ea. Quo vero nu\"},{\"role\":\"system\",\"content\":\"Itaque quasi unde earum natus libero. Soluta corporis ratione ip\"},{\"role\":\"assistant\",\"content\":\"Culpa nihil perferendis. Et id et. At animi aperiam sapiente. Re\"},{\"role\":\"user\",\"content\":\"Quasi molestiae nihil recusandae voluptatem nihil non dolorem no\"},{\"role\":\"user\",\"content\":\"Asperiores officiis tempore sequi velit quo non. Blanditiis qui\"},{\"role\":\"assistant\",\"content\":\"Consequatur quia eaque nemo et id nemo dicta. Ea nisi autem qui\"},{\"role\":\"system\",\"content\":\"Et dicta voluptate molestias cupiditate et voluptatem. Omnis dol\"}]", "gpt-4", "Aut dolor non sed voluptatem praesentium praesentium expedita. Sunt aspernatur veritatis. Sit saepe quidem et dolores excepturi", "d46499b9-1bdd-4c01-98be-9d9bbd560d68", 8325, new DateTime(2023, 12, 17, 6, 23, 25, 92, DateTimeKind.Unspecified).AddTicks(2232), "9aef1613-965e-4579-9b03-95c05a90b0e2" },
                    { "e88a2181-894c-4005-898b-268298607d8a", new DateTime(2022, 8, 19, 23, 33, 31, 107, DateTimeKind.Unspecified).AddTicks(3145), "13ee4105-45c5-4c2c-8ebe-0da1d7604088", null, "Est quas qui voluptas cum. Et delectus ut laboriosam est. Quis impedit qui qui. Et aut laboriosam libero provident accusamus qui. Quasi ut aut totam ut laboriosam quo. Ad dolorem quisquam aliquam non corrupti incidunt.", false, "[{\"role\":\"user\",\"content\":\"Explicabo sapiente vitae est qui atque soluta quis error non. Au\"},{\"role\":\"user\",\"content\":\"Beatae et est reprehenderit et ducimus quam consequatur. Volupta\"},{\"role\":\"assistant\",\"content\":\"Dolorem officiis ut officia eos dolor nihil voluptas facere dign\"},{\"role\":\"system\",\"content\":\"Ex modi odio velit dolor voluptatem temporibus itaque aut ea. De\"},{\"role\":\"system\",\"content\":\"Dolorem error rerum et. Atque rerum magnam quia iusto consequunt\"},{\"role\":\"user\",\"content\":\"Odio iusto cum saepe dignissimos. Officia occaecati nihil ipsa m\"}]", "gpt-4", "Aut qui ut. Similique voluptatum dolorem possimus quos suscipit omnis provident. Voluptatibus qui numquam sit et alias dolorem e", "02490e24-e61f-40d0-b1ce-f604d5435c87", 7536, new DateTime(2022, 8, 19, 23, 33, 31, 107, DateTimeKind.Unspecified).AddTicks(3145), "13ee4105-45c5-4c2c-8ebe-0da1d7604088" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45539e43-6d1a-4506-9b7f-2a30610c0008", "141c219a-5f2d-4a3d-a3d0-d655eab6b36f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1032ce96-5386-4e95-b212-0b6446fb822b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2405638c-5295-48e0-a232-75a22ac9c1fd");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "0068240d-7419-40ac-b3e5-8e68378d8aae");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "043fe92e-b719-4f28-8074-d3a48c9deb70");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "0a061869-5614-4609-a7f9-1ebfa719aa45");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "0e0ed653-4588-40ac-a4b2-2e06eb2d0ec4");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "1efb87fa-3f05-41fe-a2ca-0ff55352635b");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "23aafa22-24bc-4634-9a84-e1595c5b3875");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "2a03b6db-b6d2-4575-b074-382694dc0724");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "31d673f1-53fd-4a59-a641-4ee1063306d1");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "32bfe1fc-3438-42a3-9679-de6de2a510ae");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "3e58cd86-f2a8-4619-b4b7-f6ee7a437926");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "41389ae7-21ff-490e-a7dc-234ca62ad1d5");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "487b7cfb-6066-4e0f-9bf7-881040d10869");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "560bb51e-2572-4747-9eea-9aecd189bdca");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6e7a4f5f-c3de-442c-aa22-3685b91b2144");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6f653840-a482-49c7-a670-ec0080e1da7b");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6f969943-954b-49e1-9e20-6d1e2c767953");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "70004fb2-e7f9-49a3-a4e1-19188d3b5c17");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "70732666-cb16-481b-a676-77caae32bbfb");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "73260645-2ba6-48f0-82ec-44e5577153c7");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "a9073efe-4f16-48d5-a22d-682f03cfa72b");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "c18feec0-a694-4658-9d03-926c36f6d5da");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "c5115b51-cbdf-4b18-b9b0-a2a2b618ab04");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "cccdcef1-d086-41f6-b72d-fb348da06989");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "cff1b582-e186-4807-a778-b3653f482e7a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "d0f36e99-d06a-4aa1-a1b2-5b2d1645178a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "d57fb6e0-0cfa-4e5b-9503-7c2837632ca6");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "d77bf5f2-4d0f-41b8-bb89-92e7a0d6a4ce");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "de5003e5-fbf9-4782-9c52-6fd7b56c8523");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "e769e6b0-c2ed-487a-8fcc-234e9790705b");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "e88a2181-894c-4005-898b-268298607d8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45539e43-6d1a-4506-9b7f-2a30610c0008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "141c219a-5f2d-4a3d-a3d0-d655eab6b36f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "02490e24-e61f-40d0-b1ce-f604d5435c87");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2a3eec74-b118-41fc-99aa-f7a8b0b6b62c");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "480b8043-b15d-4124-b5dc-e93e7717cf8f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "771c3266-ab4d-411b-b2ed-35a6eeb01e83");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "85d978b2-2dbb-4fe0-adf9-d0d5657d868a");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "9ee31024-e1e8-499e-89cb-1676e9872e32");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "c3151aa7-60b9-4682-a800-98077c6cef31");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "d46499b9-1bdd-4c01-98be-9d9bbd560d68");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "f5f16745-8600-4a22-b864-4d86f1262478");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "f75b9f22-1cf4-4c0d-a838-05525371fa44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13ee4105-45c5-4c2c-8ebe-0da1d7604088");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bad0a52-f80d-4780-94a0-2909bc4a7a87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a74c5b1-24bb-4fac-bd3e-6b7947f3f1dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9aef1613-965e-4579-9b03-95c05a90b0e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa52b4b1-5d82-4f6d-ac2d-033c8202c555");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd767247-16e5-41c9-a0d2-d5f9883146ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e79ba770-a43f-4069-b95f-ad60a62320c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f524888c-56f3-4d04-be92-fe6b4f895b12");

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
        }
    }
}
