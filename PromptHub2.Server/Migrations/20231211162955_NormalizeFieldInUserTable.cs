using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromptHub2.Server.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeFieldInUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e99b398e-4e7e-46ba-9752-52b6bb8d1d42", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "074ba6f7-9633-410f-bb53-6fd71c8eb890", 0, "6b9f4923-72e6-4ce9-abfe-62009e33bf0d", "Raphaelle22@hotmail.com", true, false, null, "RAPHAELLE22@HOTMAIL.COM", "RAPHAELLE22@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHfpja4ahu1Tqqn3243xdCxfQilA9+O+ZdmiagtP+JNhtrdhbk475yRPic8DOBmW1A==", null, false, "c6c73aae-6b9a-4b38-b83a-9bbf2b304252", false, "Raphaelle22@hotmail.com" },
                    { "209ab5fe-d8b0-4903-bd40-2eb84825a9c2", 0, "c1d52bbf-5066-4c65-936a-b9fdb04c490c", "William_Shields64@yahoo.com", false, false, null, "WILLIAM_SHIELDS64@YAHOO.COM", "WILLIAM_SHIELDS64@YAHOO.COM", "AQAAAAIAAYagAAAAELpaH7IiJju0+6ktRvJlT/eJ+Z6b5AdqzNtzXXevlwFfDMjhL8EebVkTMYt9Y0tGcw==", null, false, "2a99f4c6-3a94-4b7c-965e-af76edda5579", false, "William_Shields64@yahoo.com" },
                    { "569ddf3b-ecd4-456b-aa9a-8f834b2ea573", 0, "2d53ba27-4fdb-425c-a95c-450b789163ce", "Terrence_Green53@hotmail.com", false, false, null, "TERRENCE_GREEN53@HOTMAIL.COM", "TERRENCE_GREEN53@HOTMAIL.COM", "AQAAAAIAAYagAAAAELYW/NXSQ9gQ+0kZEwPpezufzdBrYli3fF0XrqdXL1KLF1d4tBwjsYW2UlNha9jUxA==", null, false, "b6eeba6b-b9fa-4319-ae15-625c9e96ebea", false, "Terrence_Green53@hotmail.com" },
                    { "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3", 0, "b1e0b44d-fdef-4994-af9b-bcd2c2bed6b4", "fi.kwiatkowski@gmail.com", true, false, null, "FI.KWIATKOWSKI@GMAIL.COM", "FI.KWIATKOWSKI@GMAIL.COM", "AQAAAAIAAYagAAAAEJLLu6zAcsy0z0/8PBvp322mrMAuUjoKq4l2Q8FDh/tfCy51KzLyrxhy5kMWGCfyPQ==", null, false, "e80ef34a-e24a-4673-b80a-aad77dacafc3", false, "fi.kwiatkowski@gmail.com" },
                    { "b4237756-952a-4df5-b069-3d5efa3db87b", 0, "01b9549a-56d0-44c9-8cd2-8137dc5c4cfa", "Summer64@hotmail.com", true, false, null, "SUMMER64@HOTMAIL.COM", "SUMMER64@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP4a/jfosGCOD3mAd8WmlHe5uahiXYzlwvzopKc6qzPvK/l6eaKBNykgB3VUp9wjtQ==", null, false, "d70ec354-5977-49e6-88c9-127c2c63c798", false, "Summer64@hotmail.com" },
                    { "c93cb7cf-704c-4369-8323-b0d8680586cf", 0, "f627c3bc-36b1-4048-bcc1-a4a435034cfa", "Heather42@gmail.com", false, false, null, "HEATHER42@GMAIL.COM", "HEATHER42@GMAIL.COM", "AQAAAAIAAYagAAAAEIB8osyrxQg+h6G6M0TqKOHc9oT6WulXKNLOS8zq6/1Et5yjtHw2YNuG/12wH9CJvQ==", null, false, "5a719b31-3c7a-4e4c-b4c1-f967fa821d33", false, "Heather42@gmail.com" },
                    { "cb0daf3a-f3e4-42a3-b264-8e49bcebdcc4", 0, "44adb0d9-db68-482b-804d-c0cb31ae39dd", "Marta.Feeney3@yahoo.com", true, false, null, "MARTA.FEENEY3@YAHOO.COM", "MARTA.FEENEY3@YAHOO.COM", "AQAAAAIAAYagAAAAEG3JpkiSZ6zs5DAPYGx9MrpIzeecXceYJ5borwVMvnkp3kp31QvAoOAh22wIrEm8Iw==", null, false, "9e585e90-0bb8-4d9d-8a77-4e51f8641375", false, "Marta.Feeney3@yahoo.com" },
                    { "d059dd1e-45f7-4522-85c1-a7bf2147574c", 0, "a09728ea-82c2-438a-80f5-6a5acb222229", "Humberto89@hotmail.com", true, false, null, "HUMBERTO89@HOTMAIL.COM", "HUMBERTO89@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPSwKBppPND3of6V7nI4s4+CSG+xvab69Kq+s1y83eH5Ux1nRBWBGEHaZimGabelOw==", null, false, "5cba6896-f42b-4fd8-86f3-200f9e6bf278", false, "Humberto89@hotmail.com" },
                    { "e261f625-3e8a-422f-84c9-94bc09b14c04", 0, "cb412dec-18f6-4526-a32a-c0bd2141feaa", "Ross_Reichel62@yahoo.com", true, false, null, "ROSS_REICHEL62@YAHOO.COM", "ROSS_REICHEL62@YAHOO.COM", "AQAAAAIAAYagAAAAEPBPk5eeysfjbLKiaCZ+R1ct0hYkTAPSP0XjJm9bgJe7/PIY2joUHKq4N9wGXa9uuQ==", null, false, "5655dd57-ec5d-4d2c-bdd0-1e4cd4598530", false, "Ross_Reichel62@yahoo.com" },
                    { "edbcaed2-0e26-46a6-be4a-7c81e2ee850e", 0, "92ee2406-afc5-43d2-82c6-12e83980b234", "Charlene_OReilly@hotmail.com", true, false, null, "CHARLENE_OREILLY@HOTMAIL.COM", "CHARLENE_OREILLY@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP0b2SoG7xvpFVEoZlVn+OjKuVU7kRXj0/GVDRdgZIvpEjFoatQjy8zpaPCveS+MDA==", null, false, "8ced14ff-edaa-4571-afc5-818a6de1738d", false, "Charlene_OReilly@hotmail.com" },
                    { "fed14519-0455-49ff-935e-14389498585d", 0, "32f2eedb-ae79-4188-8441-37b66d085a3d", "Howard_Emmerich8@yahoo.com", true, false, null, "HOWARD_EMMERICH8@YAHOO.COM", "HOWARD_EMMERICH8@YAHOO.COM", "AQAAAAIAAYagAAAAEHKo79FDhcpp/fv6JaLmo+Gv7dMzbO9b8vJ64yOvD8WH4XPnTJPWQcWYwimwawOOkg==", null, false, "79b6b20d-4361-4820-bad6-33bf0650e0e0", false, "Howard_Emmerich8@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e99b398e-4e7e-46ba-9752-52b6bb8d1d42", "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "1ba33397-e4cc-48c2-9955-64c2aa4ee805", new DateTime(2023, 2, 9, 8, 27, 20, 959, DateTimeKind.Unspecified).AddTicks(3851), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Assumenda voluptate quis eos aspernatur dolor quisquam nihil enim. Ducimus enim a sunt harum ut. Aut cumque libero dolorem.", true, "Voluptate nulla quo dignissimos iste. Doloremque voluptatem incidunt aut asperiores. Enim et nesciunt similique deleniti et illo", new DateTime(2023, 2, 9, 8, 27, 20, 959, DateTimeKind.Unspecified).AddTicks(3851), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "1cb87bd7-86c6-4d95-a152-9a54e91ed684", new DateTime(2022, 8, 10, 21, 52, 31, 648, DateTimeKind.Unspecified).AddTicks(5825), "e261f625-3e8a-422f-84c9-94bc09b14c04", null, "Aut consequatur aut quia perspiciatis ut consectetur odio. Vel reiciendis assumenda consectetur. Quia hic quia dolorem est et quo vel. Quisquam non est sint.", true, "Aut numquam aut. Et est voluptatum. Quibusdam consequatur adipisci qui deserunt quos natus nobis ullam. Facere explicabo vel per", new DateTime(2022, 8, 10, 21, 52, 31, 648, DateTimeKind.Unspecified).AddTicks(5825), "e261f625-3e8a-422f-84c9-94bc09b14c04" },
                    { "326fb39d-3047-4357-8cd2-669ce64db9b8", new DateTime(2022, 6, 27, 15, 24, 19, 961, DateTimeKind.Unspecified).AddTicks(7317), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "In eos qui omnis repellat. Ad aut eveniet est voluptatem quae. Repellendus doloribus et.", false, "Sunt voluptates voluptatibus officia. Ut natus optio ut dignissimos iusto doloremque ducimus quae. Ea nostrum id nihil odit ut t", new DateTime(2022, 6, 27, 15, 24, 19, 961, DateTimeKind.Unspecified).AddTicks(7317), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "54b709d2-1b9c-4952-96a5-e2fad6d58c52", new DateTime(2022, 9, 9, 4, 53, 0, 559, DateTimeKind.Unspecified).AddTicks(5682), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Culpa autem et vero adipisci nisi autem facilis. Sit est incidunt consequuntur eum reiciendis qui est delectus delectus. Nesciunt cupiditate numquam ipsam sed praesentium rerum occaecati.", false, "Voluptates non aut aut est fugiat. Aspernatur quis ipsa rerum nesciunt veritatis nesciunt ullam temporibus. Enim est ipsum minim", new DateTime(2022, 9, 9, 4, 53, 0, 559, DateTimeKind.Unspecified).AddTicks(5682), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "79b3faa3-2a38-4bc7-9e87-10b4ed32c651", new DateTime(2022, 2, 9, 6, 15, 46, 580, DateTimeKind.Unspecified).AddTicks(3667), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3", null, "Voluptatem magnam corporis doloribus voluptatum. Aut id expedita. Corrupti dolor laboriosam aut ipsum explicabo qui deserunt est provident. Quidem est consectetur dolor incidunt fuga. Ea laborum laudantium beatae nam et nobis. Laudantium numquam fugiat.", false, "Blanditiis cumque asperiores eos. Error autem fuga rem. Consequatur quod accusamus consequatur quas nisi fugiat molestiae minima", new DateTime(2022, 2, 9, 6, 15, 46, 580, DateTimeKind.Unspecified).AddTicks(3667), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" },
                    { "84048d83-2704-4194-9f57-24c716a8508f", new DateTime(2022, 8, 4, 9, 13, 37, 636, DateTimeKind.Unspecified).AddTicks(831), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Harum repellendus voluptate. Sunt aliquam nihil et aut nemo. Dolores numquam sunt magnam velit. Consequatur quia enim vel facere.", false, "Veniam earum quisquam soluta placeat perspiciatis voluptatem sint. Ipsam praesentium quo enim doloribus provident unde deleniti", new DateTime(2022, 8, 4, 9, 13, 37, 636, DateTimeKind.Unspecified).AddTicks(831), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "8d98fc40-1b5d-4e56-b1db-6a3381a284d9", new DateTime(2022, 9, 28, 4, 9, 49, 19, DateTimeKind.Unspecified).AddTicks(7216), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Expedita ipsam sed sed voluptas. Similique dolores tempore. Voluptas porro facilis nesciunt aut reiciendis quis laborum. Velit iusto eos quas. Aut sapiente debitis dolores hic consectetur rem iure ipsam.", false, "Numquam placeat laborum vel vel incidunt. Quaerat omnis laborum minus. Minus voluptatem optio. Libero corporis ducimus exercitat", new DateTime(2022, 9, 28, 4, 9, 49, 19, DateTimeKind.Unspecified).AddTicks(7216), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "a223464d-0d09-46d8-92a8-39b5d41dbf9b", new DateTime(2022, 7, 28, 1, 5, 5, 615, DateTimeKind.Unspecified).AddTicks(2144), "074ba6f7-9633-410f-bb53-6fd71c8eb890", null, "Aut excepturi et autem. Eos occaecati commodi et labore maxime explicabo. Dolor ducimus ab labore consequatur.", false, "Distinctio neque qui libero. Quas delectus labore ducimus omnis reiciendis ea officiis. Quo hic autem aspernatur ut ea. Dolor mo", new DateTime(2022, 7, 28, 1, 5, 5, 615, DateTimeKind.Unspecified).AddTicks(2144), "074ba6f7-9633-410f-bb53-6fd71c8eb890" },
                    { "ade5346c-3732-45a0-b29c-76f32be74b81", new DateTime(2023, 5, 25, 3, 51, 42, 143, DateTimeKind.Unspecified).AddTicks(4526), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Ab reprehenderit doloribus. Nisi consectetur et sint veniam alias. Odio suscipit nisi tenetur.", false, "Aut rem autem cumque vitae ipsum est ea qui voluptatem. Voluptatem sit sequi amet repellat totam. Aut cupiditate earum vitae. Om", new DateTime(2023, 5, 25, 3, 51, 42, 143, DateTimeKind.Unspecified).AddTicks(4526), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "d7895405-ea42-4547-823c-386844994f8a", new DateTime(2023, 3, 13, 22, 49, 46, 613, DateTimeKind.Unspecified).AddTicks(402), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Exercitationem aut voluptate reprehenderit qui similique saepe non. Explicabo commodi qui sint voluptas eaque cum et voluptate. Rerum voluptas consequatur qui perferendis voluptatum. Iusto id corporis quidem. Sed ad qui consequatur eaque similique iusto co", false, "Voluptatem maiores quo inventore optio libero. Voluptas dolorem totam totam doloribus harum. Aut deleniti quaerat dolores vel co", new DateTime(2023, 3, 13, 22, 49, 46, 613, DateTimeKind.Unspecified).AddTicks(402), "b4237756-952a-4df5-b069-3d5efa3db87b" }
                });

            migrationBuilder.InsertData(
                table: "Prompts",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Messages", "Model", "Name", "ProjectId", "Tokens", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { "03c36806-0790-4540-a96f-547d4c82aed4", new DateTime(2022, 9, 9, 16, 6, 47, 971, DateTimeKind.Unspecified).AddTicks(3316), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Quisquam ut tempora omnis modi perspiciatis. Id qui quaerat minus dolores at dignissimos voluptatem repudiandae. Quia qui consequatur tenetur voluptas necessitatibus nemo totam ea.", false, "[{\"role\":\"assistant\",\"content\":\"Recusandae illum amet sit cupiditate qui doloremque rerum rerum\"},{\"role\":\"system\",\"content\":\"Earum neque ut iure distinctio labore sunt. Omnis perferendis la\"},{\"role\":\"assistant\",\"content\":\"Qui eveniet at ut consequatur eos qui. Exercitationem eos ut per\"},{\"role\":\"assistant\",\"content\":\"Odit in est neque aut excepturi. Possimus ratione aut consequunt\"},{\"role\":\"user\",\"content\":\"Sed eligendi velit reiciendis maxime dolores distinctio. Volupta\"}]", "gpt-3.5-trubo", "Qui minus minima rerum earum. Harum et commodi ratione adipisci. Voluptas velit recusandae omnis porro sequi. Ipsam aut tenetur", "d7895405-ea42-4547-823c-386844994f8a", 2671, new DateTime(2022, 9, 9, 16, 6, 47, 971, DateTimeKind.Unspecified).AddTicks(3316), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "042a28d0-7e72-4cda-8fb9-88ea57909098", new DateTime(2022, 9, 14, 0, 37, 38, 137, DateTimeKind.Unspecified).AddTicks(8382), "e261f625-3e8a-422f-84c9-94bc09b14c04", null, "Sint qui optio laboriosam dolores reiciendis dolorem. Tempore et aliquam totam expedita sunt cum qui voluptatum sed. Est odio doloribus reprehenderit aut.", true, "[{\"role\":\"assistant\",\"content\":\"Saepe vel est veritatis. Eum aut dolor veniam. Sequi quia error\"},{\"role\":\"user\",\"content\":\"Vel sit voluptatem vero voluptatibus doloribus nulla omnis. Volu\"},{\"role\":\"system\",\"content\":\"Officia veritatis ut atque et omnis dolor magni. Expedita qui si\"},{\"role\":\"system\",\"content\":\"Dolor corporis rerum repellat. Non repudiandae quas. Velit recus\"}]", "gpt-3.5-trubo", "Sed sint non magni ut unde. Quo molestiae adipisci nostrum accusantium quo deleniti officia. Voluptatibus numquam nostrum fuga c", "1cb87bd7-86c6-4d95-a152-9a54e91ed684", 13396, new DateTime(2022, 9, 14, 0, 37, 38, 137, DateTimeKind.Unspecified).AddTicks(8382), "e261f625-3e8a-422f-84c9-94bc09b14c04" },
                    { "08cdd86b-e1f4-45ff-9ba0-560d134b4cea", new DateTime(2022, 9, 13, 23, 54, 22, 971, DateTimeKind.Unspecified).AddTicks(7680), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Possimus temporibus vel fugit ut ad unde. Sint illum eaque quod modi esse enim blanditiis est. Nam sint qui hic quas ut rerum et nobis. Ex temporibus et.", true, "[{\"role\":\"user\",\"content\":\"Nulla qui pariatur neque facilis reiciendis commodi porro id imp\"},{\"role\":\"assistant\",\"content\":\"Nisi voluptatibus non. Velit similique ipsum harum qui eum tempo\"},{\"role\":\"assistant\",\"content\":\"Iusto magnam sint. Suscipit occaecati sit ad aperiam. Repellat d\"},{\"role\":\"system\",\"content\":\"Aut quod quidem cumque perspiciatis aliquam. Qui rerum error et\"},{\"role\":\"user\",\"content\":\"Qui aut dolorem ex expedita modi nam repudiandae voluptatem. Dol\"},{\"role\":\"assistant\",\"content\":\"Deleniti odio occaecati impedit sunt iste et blanditiis quia cum\"}]", "gpt-4", "In minima quasi facilis omnis pariatur earum odio voluptatem magni. Molestiae adipisci magni esse. Asperiores perspiciatis corru", "8d98fc40-1b5d-4e56-b1db-6a3381a284d9", 3209, new DateTime(2022, 9, 13, 23, 54, 22, 971, DateTimeKind.Unspecified).AddTicks(7680), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "0d6cab6f-f368-4420-9ced-9b3fde60d128", new DateTime(2023, 4, 12, 7, 57, 59, 283, DateTimeKind.Unspecified).AddTicks(8427), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Eum doloremque aut asperiores magnam. Ipsum error quis tenetur fugit exercitationem quod velit sed. Aut doloremque eveniet molestiae repellendus natus corporis at. Fuga est consequatur qui aperiam odit. Cupiditate modi ea ipsam fuga minus. Ut repellat volu", false, "[{\"role\":\"user\",\"content\":\"Tenetur inventore beatae veritatis. Recusandae omnis necessitati\"},{\"role\":\"assistant\",\"content\":\"Et et aliquam ea ut autem recusandae perspiciatis. Voluptatem ne\"},{\"role\":\"user\",\"content\":\"Eum a omnis et sit omnis sit. Accusamus sequi et ut veritatis ad\"},{\"role\":\"assistant\",\"content\":\"Aliquam molestiae neque fuga ipsa quo ipsa quis. Minus commodi s\"},{\"role\":\"assistant\",\"content\":\"Laboriosam ratione maxime. Quis quae nam facilis inventore. Et m\"},{\"role\":\"system\",\"content\":\"Hic consequatur tempora id ducimus ut. Sit sed minus sapiente et\"},{\"role\":\"user\",\"content\":\"Aliquam fuga et. Dolore magnam at ipsam rem consequatur nostrum\"}]", "gpt-3.5-trubo", "Eum ut possimus et. Voluptate non quia et consequatur ut maiores sequi minus. Eos libero vitae laboriosam qui illum voluptas ali", "d7895405-ea42-4547-823c-386844994f8a", 367, new DateTime(2023, 4, 12, 7, 57, 59, 283, DateTimeKind.Unspecified).AddTicks(8427), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "140e53ae-b417-4c8b-91f5-b758a5bd4cac", new DateTime(2022, 10, 19, 14, 5, 45, 847, DateTimeKind.Unspecified).AddTicks(476), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Iure incidunt qui sed ipsum minus eum esse assumenda esse. Repellendus ut quas. Nisi omnis aliquam vitae ipsum molestiae.", false, "[{\"role\":\"user\",\"content\":\"Laborum ut qui aperiam quidem veniam nemo fugiat. Minima qui id\"},{\"role\":\"user\",\"content\":\"Ut excepturi animi sequi vitae voluptas. Est dolor enim distinct\"},{\"role\":\"assistant\",\"content\":\"Quis officiis ex accusamus dolorem ea eveniet. Nobis et reiciend\"}]", "gpt-3.5-trubo", "Praesentium repellat rerum. Et exercitationem incidunt sed quos. Ullam doloremque sunt quos quis maxime animi. Et ut voluptas se", "326fb39d-3047-4357-8cd2-669ce64db9b8", 8024, new DateTime(2022, 10, 19, 14, 5, 45, 847, DateTimeKind.Unspecified).AddTicks(476), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "29336f12-9f4d-4465-8e78-b2fd48e504b6", new DateTime(2022, 6, 17, 12, 26, 46, 622, DateTimeKind.Unspecified).AddTicks(9206), "074ba6f7-9633-410f-bb53-6fd71c8eb890", null, "Consequuntur velit aut quasi non aspernatur corporis eligendi. Eos deleniti assumenda molestias aliquid commodi ut et ullam. Et officia molestiae rerum repellat at cumque eum.", true, "[{\"role\":\"system\",\"content\":\"Excepturi debitis reprehenderit veniam ab voluptas inventore dol\"},{\"role\":\"system\",\"content\":\"Et eveniet eaque illum repellat nam corrupti assumenda et labore\"},{\"role\":\"system\",\"content\":\"Occaecati occaecati fuga. Architecto itaque sint deserunt et nec\"},{\"role\":\"assistant\",\"content\":\"Perspiciatis molestiae voluptates dolore. Sed officia aut aut au\"},{\"role\":\"system\",\"content\":\"Cum doloremque ut quidem tempora aut sequi maiores. Voluptas eiu\"},{\"role\":\"system\",\"content\":\"Odit officia omnis doloremque aut. Autem totam quas. Officia sed\"},{\"role\":\"assistant\",\"content\":\"Doloribus vero et dolores cum non laborum beatae dolores rerum.\"},{\"role\":\"system\",\"content\":\"Porro sed sapiente sint quo qui iusto. Explicabo accusamus molli\"},{\"role\":\"assistant\",\"content\":\"Rerum quae omnis dolorum. Qui praesentium omnis optio dolores co\"},{\"role\":\"assistant\",\"content\":\"Maiores reprehenderit consequatur error qui illum. Sint dolores\"}]", "gpt-4", "Laboriosam asperiores sint ipsum delectus. Accusamus omnis commodi eum minima cum aliquid. Deleniti iste quia labore impedit. Ma", "a223464d-0d09-46d8-92a8-39b5d41dbf9b", 7963, new DateTime(2022, 6, 17, 12, 26, 46, 622, DateTimeKind.Unspecified).AddTicks(9206), "074ba6f7-9633-410f-bb53-6fd71c8eb890" },
                    { "423eb7f8-2827-43b3-90d4-d49d18bd6328", new DateTime(2023, 11, 28, 1, 10, 51, 664, DateTimeKind.Unspecified).AddTicks(4400), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Ipsa ut a at voluptates nisi quae unde. Vel explicabo in eum ut vel dolorum rerum soluta. Accusamus enim explicabo ipsum possimus nam voluptatum possimus et atque. Quibusdam omnis dolorum quia omnis in aut.", false, "[{\"role\":\"assistant\",\"content\":\"Qui voluptate veniam qui qui quaerat. Dignissimos harum commodi\"},{\"role\":\"user\",\"content\":\"Enim quam id labore aliquid temporibus nesciunt dolorem veniam.\"},{\"role\":\"user\",\"content\":\"Quo officia ipsa voluptas et ut. Ut est tempora ipsa quia dolore\"},{\"role\":\"system\",\"content\":\"Ipsum nesciunt quo iure velit et blanditiis. Aliquid ut numquam\"},{\"role\":\"system\",\"content\":\"Laborum hic dolor voluptatem. Cupiditate nihil maiores natus ape\"},{\"role\":\"system\",\"content\":\"Dolore odit laborum iste. At corrupti et eaque qui. Dolores ut q\"},{\"role\":\"assistant\",\"content\":\"Ducimus sed quasi et eveniet explicabo qui aliquam modi. Dolores\"},{\"role\":\"assistant\",\"content\":\"Aperiam consequuntur nostrum veritatis. Et eaque tempore est inv\"}]", "gpt-4", "Vitae molestiae quos alias modi quis eaque. Ut explicabo tempora ipsam sed quasi accusamus dolores adipisci quaerat. Blanditiis", "ade5346c-3732-45a0-b29c-76f32be74b81", 15536, new DateTime(2023, 11, 28, 1, 10, 51, 664, DateTimeKind.Unspecified).AddTicks(4400), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "4cf093c2-4909-4d9c-908d-8bbd5a14413b", new DateTime(2022, 6, 24, 14, 7, 21, 850, DateTimeKind.Unspecified).AddTicks(419), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Voluptatibus qui consequatur molestiae omnis ipsum aut eum. Est quasi eaque et. Eum blanditiis adipisci quia natus qui. Nam sit alias sed accusamus aut modi quas earum optio. Voluptas accusamus vel ex cumque.", true, "[{\"role\":\"system\",\"content\":\"Temporibus ab ea aliquam. Laboriosam eum eaque qui voluptas quia\"},{\"role\":\"system\",\"content\":\"Animi molestiae quia odio. Pariatur veritatis consequatur. Imped\"},{\"role\":\"assistant\",\"content\":\"Non officiis et ut aut animi rerum. Dolor aut odit. Veritatis ev\"},{\"role\":\"system\",\"content\":\"Sequi fugit quod consectetur qui eveniet rerum debitis voluptate\"},{\"role\":\"user\",\"content\":\"In assumenda similique et hic quisquam vel quaerat illum deserun\"},{\"role\":\"assistant\",\"content\":\"Tempora et ut provident placeat doloribus fuga consequatur. Iste\"},{\"role\":\"user\",\"content\":\"Dicta voluptatem facere. Quia et possimus aut suscipit exercitat\"},{\"role\":\"system\",\"content\":\"Quia sit qui commodi officia. Vel ut molestiae tenetur dicta bea\"}]", "gpt-3.5-trubo", "Et ipsa perferendis id velit nesciunt omnis commodi. Inventore qui et et nesciunt in. Reiciendis qui quisquam et. Ad deleniti se", "1ba33397-e4cc-48c2-9955-64c2aa4ee805", 11852, new DateTime(2022, 6, 24, 14, 7, 21, 850, DateTimeKind.Unspecified).AddTicks(419), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "558059fc-ae73-4cc3-8704-6444682b47a2", new DateTime(2022, 1, 5, 5, 22, 17, 155, DateTimeKind.Unspecified).AddTicks(8423), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Nihil culpa voluptatum et adipisci necessitatibus ut doloremque. Architecto rerum suscipit ipsam autem. Neque reprehenderit veritatis provident voluptas. Dolores quasi eos non nemo omnis. Modi ab eligendi culpa et provident suscipit aspernatur nihil occaec", true, "[{\"role\":\"system\",\"content\":\"Velit ut minima. Iste ipsa aut voluptatem suscipit praesentium.\"},{\"role\":\"assistant\",\"content\":\"Magnam odio rerum doloribus omnis aut rem magnam ut itaque. Eaqu\"}]", "gpt-4", "In eos nam exercitationem voluptatem aut eos quisquam ut. Repellat et nemo cupiditate molestiae rerum impedit sunt vel dolorem.", "8d98fc40-1b5d-4e56-b1db-6a3381a284d9", 14533, new DateTime(2022, 1, 5, 5, 22, 17, 155, DateTimeKind.Unspecified).AddTicks(8423), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "56db8950-8982-4014-9431-174ea13b1e91", new DateTime(2022, 10, 24, 0, 51, 33, 288, DateTimeKind.Unspecified).AddTicks(9628), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Non quia natus odit unde et est provident. Ut accusamus quasi aut impedit dolore. Culpa iusto et quia quo. Enim quaerat suscipit est dicta minima doloribus qui iure aut.", true, "[{\"role\":\"assistant\",\"content\":\"Aut quia at. Quidem sit laborum doloremque eligendi libero est d\"},{\"role\":\"assistant\",\"content\":\"Illum repellendus dolores voluptate dolor et enim. Et quia eos q\"},{\"role\":\"assistant\",\"content\":\"Dolore est perspiciatis voluptates consequatur. Sint et perspici\"},{\"role\":\"assistant\",\"content\":\"Ipsum voluptatibus vitae animi aut consequatur. Aspernatur sint\"},{\"role\":\"assistant\",\"content\":\"Eos culpa qui voluptatem est quia aut. Non aut voluptates repell\"}]", "gpt-3.5-trubo", "Qui consequatur voluptatem non eius officiis consequatur dolor. Qui fugiat est voluptatem ut fuga similique molestiae veniam. Te", "ade5346c-3732-45a0-b29c-76f32be74b81", 15640, new DateTime(2022, 10, 24, 0, 51, 33, 288, DateTimeKind.Unspecified).AddTicks(9628), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "64a8b5eb-23c4-4c31-a1bf-65deb5c8d8d5", new DateTime(2022, 9, 1, 23, 5, 27, 610, DateTimeKind.Unspecified).AddTicks(5563), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3", null, "Tempora culpa nihil nulla id aut non est nobis. Omnis a dolor et ab reiciendis sint. Et totam voluptate assumenda possimus ipsam.", false, "[{\"role\":\"user\",\"content\":\"Ratione et amet rerum. Minus saepe quia magnam. Numquam ducimus\"},{\"role\":\"system\",\"content\":\"Aspernatur atque non sit repudiandae est facere id est. Dolores\"},{\"role\":\"assistant\",\"content\":\"At enim magnam tempore quibusdam inventore ullam autem. Fugiat o\"},{\"role\":\"assistant\",\"content\":\"Ab quis sunt earum vitae enim nihil voluptas. Provident ullam ex\"},{\"role\":\"assistant\",\"content\":\"Consequatur ut quia numquam a voluptatem at aut. Quod nemo verit\"},{\"role\":\"user\",\"content\":\"Suscipit accusantium cumque voluptas quisquam consequatur eos ip\"},{\"role\":\"assistant\",\"content\":\"Maxime eius culpa voluptates. Est a distinctio. Minus corrupti e\"}]", "gpt-3.5-trubo", "Ut velit amet velit officiis delectus ullam. Ad itaque recusandae nisi ut perferendis accusamus. Quaerat maiores aliquam dolorem", "79b3faa3-2a38-4bc7-9e87-10b4ed32c651", 11742, new DateTime(2022, 9, 1, 23, 5, 27, 610, DateTimeKind.Unspecified).AddTicks(5563), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" },
                    { "6e1cff81-a27b-44bb-96cd-3114bf6e7924", new DateTime(2022, 11, 17, 5, 58, 0, 589, DateTimeKind.Unspecified).AddTicks(2596), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Aliquid veritatis consequuntur eum. A eum fugiat possimus. Facilis dolores inventore qui ab. Ut et dicta in quia consequatur eligendi aperiam tenetur. Esse vel rerum quae velit eos. Aut maiores debitis dolorem non qui velit aperiam sint laudantium.", false, "[{\"role\":\"assistant\",\"content\":\"Culpa nobis sunt. Corrupti perspiciatis totam consequuntur recus\"},{\"role\":\"assistant\",\"content\":\"Alias distinctio eligendi quidem labore dolores. Quo unde esse e\"},{\"role\":\"assistant\",\"content\":\"Rerum quo quam nobis corrupti in quas sed. Odit eum non et et ma\"},{\"role\":\"system\",\"content\":\"Consequuntur accusantium natus vero quasi nisi facilis voluptate\"},{\"role\":\"user\",\"content\":\"Id velit dicta ut doloribus rerum dignissimos quis. Ab recusanda\"},{\"role\":\"assistant\",\"content\":\"Rerum necessitatibus labore. Repellat modi soluta quod fugit. Vo\"},{\"role\":\"user\",\"content\":\"Voluptatem nesciunt dolores perspiciatis vel mollitia reiciendis\"}]", "gpt-4", "Officiis hic sed vitae veritatis facere qui dolorem sit. Atque facilis aperiam id. Dolorem ratione iste aliquam voluptatum. Et v", "54b709d2-1b9c-4952-96a5-e2fad6d58c52", 267, new DateTime(2022, 11, 17, 5, 58, 0, 589, DateTimeKind.Unspecified).AddTicks(2596), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "83a74e66-0dc9-4f9b-a3e9-be5c62e19ca2", new DateTime(2022, 5, 3, 7, 41, 40, 473, DateTimeKind.Unspecified).AddTicks(318), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Sit voluptas voluptates enim velit sapiente eaque excepturi sed. Nulla occaecati vero sunt et minima. Quas et odit est vitae est eaque et quia sit. Molestiae sed fugit voluptas consequatur quis reiciendis illo.", false, "[{\"role\":\"user\",\"content\":\"Quis impedit voluptatem qui. Nobis sequi et recusandae possimus\"},{\"role\":\"assistant\",\"content\":\"Quisquam placeat sint libero recusandae. Illum sint eos numquam.\"},{\"role\":\"user\",\"content\":\"Explicabo deleniti ratione maxime repellat aut. Illum corporis d\"},{\"role\":\"assistant\",\"content\":\"Corporis tempore velit ipsa voluptatem dolorem voluptas fugiat i\"},{\"role\":\"assistant\",\"content\":\"Tempora eos ut. Quae vel repellat nihil assumenda repellendus of\"},{\"role\":\"system\",\"content\":\"Molestias corporis suscipit. Et incidunt eum. Consectetur dolore\"},{\"role\":\"assistant\",\"content\":\"Expedita qui omnis sint enim id. Praesentium assumenda excepturi\"},{\"role\":\"user\",\"content\":\"Et sint incidunt iste nihil aliquid veniam repellat. Minima sit\"},{\"role\":\"assistant\",\"content\":\"Totam dolorem voluptatem deleniti sunt facere. Odit esse eligend\"},{\"role\":\"system\",\"content\":\"Deleniti sed quis provident sequi aut similique et incidunt qui.\"}]", "gpt-4", "Fugiat maiores numquam exercitationem sunt eum blanditiis neque id deserunt. Ullam eos officiis non sapiente voluptas ut. Rem sa", "84048d83-2704-4194-9f57-24c716a8508f", 3198, new DateTime(2022, 5, 3, 7, 41, 40, 473, DateTimeKind.Unspecified).AddTicks(318), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "8ceda7ea-f577-483a-8779-24df63f98992", new DateTime(2022, 3, 14, 8, 46, 44, 243, DateTimeKind.Unspecified).AddTicks(6715), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Omnis alias soluta perferendis eveniet et voluptatum est quos non. Ut occaecati corporis velit molestias voluptatem. Recusandae nobis itaque optio. Voluptatem aut ut incidunt architecto. Eos voluptas sequi voluptatibus facere quibusdam sit numquam rerum qu", false, "[{\"role\":\"assistant\",\"content\":\"Quod dolores optio qui velit provident dignissimos. Commodi cumq\"},{\"role\":\"system\",\"content\":\"Occaecati esse rem fugiat nulla ea. A quia reprehenderit eos et\"}]", "gpt-3.5-trubo", "Molestias quos autem explicabo maxime voluptatum explicabo. Optio dolorem maxime laborum at nobis sunt aut quaerat. Ut debitis a", "1ba33397-e4cc-48c2-9955-64c2aa4ee805", 1462, new DateTime(2022, 3, 14, 8, 46, 44, 243, DateTimeKind.Unspecified).AddTicks(6715), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "915ef70f-f48d-4a52-8716-586f7092690e", new DateTime(2023, 3, 30, 1, 40, 46, 212, DateTimeKind.Unspecified).AddTicks(5212), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3", null, "Quo voluptatem aperiam explicabo ea incidunt. Numquam quas est molestiae sit. Quos vel est doloremque a laboriosam rerum. Nihil ducimus quod qui.", false, "[{\"role\":\"assistant\",\"content\":\"Nisi totam dolorem placeat numquam aliquid. Minima dolorem eos f\"},{\"role\":\"assistant\",\"content\":\"Veniam autem ea sit omnis et rem sit repellendus saepe. Magni be\"},{\"role\":\"system\",\"content\":\"Est nostrum necessitatibus quia quia. Quod minus nihil laudantiu\"},{\"role\":\"user\",\"content\":\"Est totam aliquid saepe alias. Odit placeat voluptate quasi quam\"},{\"role\":\"user\",\"content\":\"Sint nihil delectus perspiciatis est alias optio tempora. Quis c\"},{\"role\":\"user\",\"content\":\"Esse eius enim occaecati quis voluptas laudantium eum nihil. Eve\"},{\"role\":\"assistant\",\"content\":\"At quidem inventore sunt suscipit quidem sunt est. Velit illum q\"},{\"role\":\"user\",\"content\":\"Autem adipisci architecto et veritatis velit dolorum. Dolorem et\"},{\"role\":\"system\",\"content\":\"Qui repellendus est tempora qui quia a ratione. Provident aut ac\"},{\"role\":\"assistant\",\"content\":\"Voluptate modi eligendi ducimus. Deleniti laboriosam debitis ita\"}]", "gpt-3.5-trubo", "Fugiat eum sint reprehenderit est at. Magni debitis laboriosam at. Recusandae porro iste sint.", "79b3faa3-2a38-4bc7-9e87-10b4ed32c651", 1938, new DateTime(2023, 3, 30, 1, 40, 46, 212, DateTimeKind.Unspecified).AddTicks(5212), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" },
                    { "948d7250-9059-48b5-9d25-96cb26376a37", new DateTime(2022, 3, 11, 7, 3, 24, 953, DateTimeKind.Unspecified).AddTicks(4741), "e261f625-3e8a-422f-84c9-94bc09b14c04", null, "Repellendus est asperiores. Consequatur ea sit in deserunt vel est. Sed rerum aut amet voluptates laudantium. Distinctio doloribus repellendus dolore. Est qui dolorum eaque maiores. Iusto quaerat at odio ut est blanditiis.", false, "[{\"role\":\"system\",\"content\":\"Minima eius at. Autem voluptate architecto occaecati ut ea rem v\"},{\"role\":\"system\",\"content\":\"Quidem soluta quidem voluptatem reprehenderit rem. Minus sequi e\"},{\"role\":\"user\",\"content\":\"Dicta mollitia alias soluta id voluptates. Natus aut quasi minim\"},{\"role\":\"assistant\",\"content\":\"Illum quaerat unde voluptatem nulla vitae. Quis earum debitis ip\"},{\"role\":\"system\",\"content\":\"Expedita qui sint dignissimos at. Doloremque culpa cumque tempor\"},{\"role\":\"user\",\"content\":\"Vel cumque rerum beatae velit fuga culpa dolores impedit blandit\"},{\"role\":\"system\",\"content\":\"Molestiae delectus architecto. Quo eos cum sint consectetur. Mol\"}]", "gpt-3.5-trubo", "Harum voluptatum illum. Sint aperiam et voluptatem labore culpa quam tenetur. Vel consequatur culpa ut laudantium omnis rem reru", "1cb87bd7-86c6-4d95-a152-9a54e91ed684", 13659, new DateTime(2022, 3, 11, 7, 3, 24, 953, DateTimeKind.Unspecified).AddTicks(4741), "e261f625-3e8a-422f-84c9-94bc09b14c04" },
                    { "97bce606-fe67-409e-86ae-3e0aa3a8be43", new DateTime(2023, 3, 9, 2, 36, 28, 823, DateTimeKind.Unspecified).AddTicks(5150), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Fugit expedita sed perspiciatis similique. Explicabo deserunt accusantium. Repudiandae commodi a ut et. Quo consequatur est maxime assumenda in.", false, "[{\"role\":\"user\",\"content\":\"Vel facilis officia rerum quo perspiciatis. Autem omnis autem no\"},{\"role\":\"assistant\",\"content\":\"Aut deleniti provident temporibus quos ex quibusdam vel fugit. U\"},{\"role\":\"assistant\",\"content\":\"Sit velit aut delectus illum quas. Ut magni possimus illum rerum\"},{\"role\":\"user\",\"content\":\"Itaque omnis ut doloribus aut voluptate molestias ut. Praesentiu\"},{\"role\":\"assistant\",\"content\":\"Facilis ipsa nihil blanditiis consequatur praesentium voluptatum\"},{\"role\":\"system\",\"content\":\"Ut iure magnam. Ab qui accusamus. Voluptas dolor odio placeat nu\"},{\"role\":\"assistant\",\"content\":\"Repellendus quia dolore sint rerum id quibusdam. Sit saepe quis\"}]", "gpt-3.5-trubo", "Voluptates sapiente velit repudiandae accusantium sit sit maxime repellendus. Quae atque laboriosam molestias ipsum reprehenderi", "d7895405-ea42-4547-823c-386844994f8a", 6254, new DateTime(2023, 3, 9, 2, 36, 28, 823, DateTimeKind.Unspecified).AddTicks(5150), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "9dfd1d21-f47b-4bb4-9de6-536edcfbff29", new DateTime(2023, 6, 22, 10, 47, 7, 227, DateTimeKind.Unspecified).AddTicks(9843), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Nobis quisquam in sequi fugit accusamus voluptatem non sed. Ut et officiis nobis mollitia qui iure quia. Esse et id. Laborum quod est. Sequi asperiores dolor aut error consequatur alias rerum consequatur reiciendis. Earum qui et enim id cupiditate non dolo", true, "[{\"role\":\"user\",\"content\":\"Sapiente neque dolorem qui illum quia. Repudiandae odio placeat\"},{\"role\":\"system\",\"content\":\"Autem eaque doloremque. Recusandae harum laborum aut non. Est cu\"},{\"role\":\"user\",\"content\":\"Sed sunt provident eum. Non fuga recusandae qui cupiditate et. V\"},{\"role\":\"user\",\"content\":\"Sed veritatis a illum. Ratione harum quos id. Odio magnam cum qu\"},{\"role\":\"system\",\"content\":\"Omnis reiciendis a hic molestiae. Fugiat ipsa excepturi fugiat n\"},{\"role\":\"assistant\",\"content\":\"Est vel sequi neque. Rerum corporis quas qui ut et mollitia. Arc\"},{\"role\":\"user\",\"content\":\"Quo reiciendis et voluptatibus consequatur praesentium est totam\"}]", "gpt-3.5-trubo", "Quibusdam reprehenderit reprehenderit ut quia maiores ea repudiandae. Nam cupiditate ea omnis vero qui vel sed sed. Eius veniam", "ade5346c-3732-45a0-b29c-76f32be74b81", 1768, new DateTime(2023, 6, 22, 10, 47, 7, 227, DateTimeKind.Unspecified).AddTicks(9843), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "b1e68666-1a74-4e79-94fa-838fdfe45b43", new DateTime(2023, 2, 25, 16, 55, 30, 230, DateTimeKind.Unspecified).AddTicks(1612), "074ba6f7-9633-410f-bb53-6fd71c8eb890", null, "Neque non ut officia. Maiores fuga nisi sed ut minima quia et. Et aliquam modi molestiae inventore dolores nemo sed non. Cum totam voluptas quas ab qui nobis molestias nihil soluta.", true, "[{\"role\":\"system\",\"content\":\"Ut atque ipsum. Aut id fugiat. Ex eveniet voluptatem quia veniam\"},{\"role\":\"user\",\"content\":\"Delectus commodi eum. Consequatur dolores eius numquam accusanti\"},{\"role\":\"user\",\"content\":\"Consequatur perferendis qui quis ipsam laborum ut minus sint. Fa\"},{\"role\":\"system\",\"content\":\"Accusantium aut quis iure reiciendis sunt quasi. Quidem deserunt\"},{\"role\":\"user\",\"content\":\"Ut autem est a. Quia et fugiat. Numquam quia aut illum quis et q\"}]", "gpt-4", "Non blanditiis non consequatur reiciendis quo fugit sit nesciunt. Et repudiandae ut quis recusandae perferendis esse saepe commo", "a223464d-0d09-46d8-92a8-39b5d41dbf9b", 6081, new DateTime(2023, 2, 25, 16, 55, 30, 230, DateTimeKind.Unspecified).AddTicks(1612), "074ba6f7-9633-410f-bb53-6fd71c8eb890" },
                    { "b4133ea9-5867-460b-a7d4-0c339d0c7046", new DateTime(2022, 3, 14, 19, 5, 35, 579, DateTimeKind.Unspecified).AddTicks(4595), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Eveniet tempora voluptatem est quod. Et aperiam sint illum velit. Quidem expedita fugit quibusdam tenetur omnis facere non ex qui.", false, "[{\"role\":\"user\",\"content\":\"Unde ex facere adipisci doloremque quidem omnis cum. Sed id impe\"},{\"role\":\"system\",\"content\":\"Quis ut necessitatibus rerum rem qui quis magni quia repellendus\"}]", "gpt-3.5-trubo", "Et quia incidunt suscipit fugiat sunt suscipit sunt autem perferendis. Ipsa quisquam quibusdam quia earum doloribus molestias du", "84048d83-2704-4194-9f57-24c716a8508f", 15798, new DateTime(2022, 3, 14, 19, 5, 35, 579, DateTimeKind.Unspecified).AddTicks(4595), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "c56fedd0-808d-4490-a0fe-1e004acf4d2a", new DateTime(2023, 5, 27, 10, 44, 38, 535, DateTimeKind.Unspecified).AddTicks(4738), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Voluptatem velit quis quis qui. Ratione quas consequatur a dicta ducimus. Ut est sit pariatur incidunt provident alias temporibus. Molestiae et corporis repellendus rerum totam deserunt. Voluptas soluta quisquam omnis.", true, "[{\"role\":\"user\",\"content\":\"Nulla qui soluta deleniti odio voluptatibus rerum autem eius qua\"},{\"role\":\"user\",\"content\":\"Quae a minima perferendis non quod debitis facere qui necessitat\"},{\"role\":\"system\",\"content\":\"Suscipit eius dignissimos et error rerum vel cupiditate voluptas\"},{\"role\":\"assistant\",\"content\":\"Sequi itaque sed perferendis enim non nisi accusamus quisquam. V\"},{\"role\":\"user\",\"content\":\"Voluptas in eum. Odit aperiam quisquam placeat numquam quis et e\"}]", "gpt-3.5-trubo", "Inventore labore dolor dolor. Magni omnis libero. Ut eaque quae eum illo distinctio assumenda earum et. Quas molestiae repudiand", "8d98fc40-1b5d-4e56-b1db-6a3381a284d9", 12622, new DateTime(2023, 5, 27, 10, 44, 38, 535, DateTimeKind.Unspecified).AddTicks(4738), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "c6f06591-2fbd-4aab-ba50-ccd0a74d12b6", new DateTime(2022, 7, 2, 2, 51, 30, 883, DateTimeKind.Unspecified).AddTicks(4811), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Facilis quo nobis molestiae aperiam dicta in veritatis impedit perferendis. Molestiae accusamus voluptatem. Sapiente eveniet omnis veniam. Suscipit at quam vel exercitationem impedit occaecati aspernatur. Non quia beatae praesentium excepturi magnam conseq", false, "[{\"role\":\"user\",\"content\":\"Voluptatibus dolore possimus earum similique. Architecto quia co\"},{\"role\":\"system\",\"content\":\"Quod esse dolores. Praesentium sint delectus nulla quibusdam omn\"},{\"role\":\"assistant\",\"content\":\"Fugiat repudiandae aut commodi consequuntur eveniet. Molestias q\"}]", "gpt-4", "Eum necessitatibus voluptatem natus aliquam ea maiores. Et praesentium qui eligendi. Omnis non sapiente blanditiis voluptatem eu", "84048d83-2704-4194-9f57-24c716a8508f", 15416, new DateTime(2022, 7, 2, 2, 51, 30, 883, DateTimeKind.Unspecified).AddTicks(4811), "c93cb7cf-704c-4369-8323-b0d8680586cf" },
                    { "ce772031-9295-4571-b4d8-dfc36e279a2d", new DateTime(2023, 6, 25, 11, 25, 15, 387, DateTimeKind.Unspecified).AddTicks(1830), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Fugiat possimus molestiae ex quis. Voluptas voluptate soluta quod minima qui. Soluta tempora dolorem autem et. Molestias eaque voluptatem culpa explicabo quia id consequatur voluptatum vero.", true, "[{\"role\":\"assistant\",\"content\":\"Qui pariatur laudantium odit est est aspernatur suscipit odio qu\"},{\"role\":\"system\",\"content\":\"Doloremque et eligendi necessitatibus qui ad id vel. Nesciunt ut\"},{\"role\":\"assistant\",\"content\":\"Ducimus quis itaque voluptas perferendis explicabo culpa alias d\"},{\"role\":\"user\",\"content\":\"Impedit rerum dolor commodi reprehenderit impedit autem consecte\"}]", "gpt-4", "Ut aliquid a. Eum ratione sit ipsum unde dignissimos facere. Culpa reiciendis voluptates velit nesciunt est est.", "326fb39d-3047-4357-8cd2-669ce64db9b8", 5932, new DateTime(2023, 6, 25, 11, 25, 15, 387, DateTimeKind.Unspecified).AddTicks(1830), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "dbcad1dd-e4e7-478a-b442-95538ece7b54", new DateTime(2022, 10, 29, 19, 53, 51, 941, DateTimeKind.Unspecified).AddTicks(6587), "e261f625-3e8a-422f-84c9-94bc09b14c04", null, "Iure deleniti dolorum velit nulla expedita vel nihil ex corporis. Maiores fugit sunt aut ut qui quo eum. Porro sunt veniam voluptate dolorem fugiat neque eligendi.", false, "[{\"role\":\"assistant\",\"content\":\"Consequatur sapiente aliquid molestiae quasi eveniet minus liber\"},{\"role\":\"user\",\"content\":\"Dolorum quis quaerat ipsum. Vitae et rerum. Ex et aspernatur qui\"},{\"role\":\"system\",\"content\":\"Cum occaecati quis quod minima maxime nostrum illum. Inventore s\"},{\"role\":\"assistant\",\"content\":\"Aut architecto rerum et eos cupiditate et at cum et. Beatae vel\"},{\"role\":\"user\",\"content\":\"Vitae ut fugiat. Quia nisi facilis optio maxime aut voluptas nob\"},{\"role\":\"system\",\"content\":\"Itaque blanditiis non consequatur quis minima in atque necessita\"},{\"role\":\"user\",\"content\":\"Excepturi quisquam qui animi possimus sed. Quis beatae tempore i\"},{\"role\":\"assistant\",\"content\":\"Vel autem adipisci. Consequatur ut natus. Ab impedit dolores mol\"}]", "gpt-3.5-trubo", "Ea et et rerum nihil. Quam sint voluptatem et. Voluptatem ut veniam aspernatur rerum pariatur deleniti. Quos sed non molestiae m", "1cb87bd7-86c6-4d95-a152-9a54e91ed684", 14284, new DateTime(2022, 10, 29, 19, 53, 51, 941, DateTimeKind.Unspecified).AddTicks(6587), "e261f625-3e8a-422f-84c9-94bc09b14c04" },
                    { "e2c6c8e6-8132-4053-8e37-d11dc473fc02", new DateTime(2022, 8, 27, 13, 58, 38, 867, DateTimeKind.Unspecified).AddTicks(2421), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Voluptatem ut ullam consequatur sunt natus quis. Eos at possimus in excepturi animi hic sed. Sequi qui aut aut necessitatibus.", false, "[{\"role\":\"user\",\"content\":\"Fugiat impedit aut aut minima rerum minus accusamus. Delectus es\"},{\"role\":\"user\",\"content\":\"Eum eligendi distinctio accusantium sint ad quod minus dolores.\"},{\"role\":\"assistant\",\"content\":\"Sed consectetur aut. Earum dolores quae. Dolores provident volup\"},{\"role\":\"system\",\"content\":\"Perferendis cumque et commodi id dolor. Eum provident maxime. Se\"}]", "gpt-4", "Delectus laboriosam quaerat sint sapiente voluptatem accusantium rerum fugit. Reprehenderit facere quia voluptatem dolor. Fugit", "54b709d2-1b9c-4952-96a5-e2fad6d58c52", 15557, new DateTime(2022, 8, 27, 13, 58, 38, 867, DateTimeKind.Unspecified).AddTicks(2421), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "e47fd54f-ef65-49f9-b1f6-38a198b43fe5", new DateTime(2022, 4, 10, 17, 46, 52, 973, DateTimeKind.Unspecified).AddTicks(1122), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3", null, "Id qui quia cumque rem fugit magnam ipsa. Voluptatem reiciendis excepturi voluptatem. Illum minima vel. Reiciendis illum laborum. Quia et labore totam quia ut et et minus. Aut incidunt ullam expedita natus perferendis debitis asperiores.", true, "[{\"role\":\"system\",\"content\":\"Et ducimus amet ut quibusdam. Occaecati magnam aliquid impedit o\"},{\"role\":\"system\",\"content\":\"Aut alias mollitia aspernatur veritatis dignissimos minima et mi\"},{\"role\":\"system\",\"content\":\"Non cum harum iure aut ea architecto non harum corporis. Dolore\"}]", "gpt-4", "Et corrupti reiciendis qui placeat. Voluptatem eveniet sunt dolor excepturi quas expedita at vel aut. Quia corrupti beatae est a", "79b3faa3-2a38-4bc7-9e87-10b4ed32c651", 4069, new DateTime(2022, 4, 10, 17, 46, 52, 973, DateTimeKind.Unspecified).AddTicks(1122), "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" },
                    { "ec862e61-a7f4-4246-97a6-311981881587", new DateTime(2022, 3, 4, 1, 12, 2, 429, DateTimeKind.Unspecified).AddTicks(6498), "d059dd1e-45f7-4522-85c1-a7bf2147574c", null, "Ad ut totam quos. Consectetur aut ex optio quas facilis. Cupiditate quia aut ut atque adipisci saepe quis. Ea qui maiores quis vel. Id quia optio odio vel modi ducimus.", true, "[{\"role\":\"assistant\",\"content\":\"Eligendi dolore quos. Facere vero dolor quasi dolores. Ullam duc\"},{\"role\":\"assistant\",\"content\":\"Nihil et aperiam expedita aliquid sint consequatur occaecati. Cu\"},{\"role\":\"assistant\",\"content\":\"Aperiam enim sapiente fugit. Quia quidem aliquid non iusto quae\"},{\"role\":\"assistant\",\"content\":\"Voluptas velit et velit architecto est cupiditate. Quo ipsa susc\"}]", "gpt-4", "Suscipit natus non neque quia adipisci vel. Et commodi incidunt quo qui voluptas delectus perspiciatis nesciunt ipsam. Ut earum", "54b709d2-1b9c-4952-96a5-e2fad6d58c52", 4690, new DateTime(2022, 3, 4, 1, 12, 2, 429, DateTimeKind.Unspecified).AddTicks(6498), "d059dd1e-45f7-4522-85c1-a7bf2147574c" },
                    { "ef620537-3c1f-41b7-a4f7-2dd5a864e893", new DateTime(2022, 9, 21, 6, 2, 39, 192, DateTimeKind.Unspecified).AddTicks(2146), "b4237756-952a-4df5-b069-3d5efa3db87b", null, "Fugit exercitationem veniam maiores enim. Laborum molestias velit sed. Amet inventore quibusdam dolorem nam numquam. Ut nam numquam. Doloribus placeat est tempora. Eius et voluptate et aspernatur.", false, "[{\"role\":\"system\",\"content\":\"Sed ea doloremque doloribus cumque doloremque non nesciunt est u\"},{\"role\":\"system\",\"content\":\"Sapiente doloribus quia omnis. Modi sed qui quo unde corporis mo\"}]", "gpt-3.5-trubo", "Delectus qui temporibus eveniet qui dignissimos. Delectus rerum incidunt numquam iure est. Ut quo id amet eos aut dolor et ipsa.", "326fb39d-3047-4357-8cd2-669ce64db9b8", 3463, new DateTime(2022, 9, 21, 6, 2, 39, 192, DateTimeKind.Unspecified).AddTicks(2146), "b4237756-952a-4df5-b069-3d5efa3db87b" },
                    { "f0817911-a123-4b3e-8945-050c562fde37", new DateTime(2023, 11, 1, 6, 9, 57, 171, DateTimeKind.Unspecified).AddTicks(9268), "074ba6f7-9633-410f-bb53-6fd71c8eb890", null, "Eveniet eum quidem eaque. Qui aliquam sed dignissimos quasi. Fuga tenetur sapiente deleniti non expedita ullam quia. Quis aut ipsam sint enim. Omnis suscipit vel nisi officia.", false, "[{\"role\":\"assistant\",\"content\":\"Nihil rerum consectetur recusandae iusto eveniet. Qui voluptatem\"},{\"role\":\"assistant\",\"content\":\"Velit ea velit est libero quasi eveniet. Aut tenetur eaque quod\"},{\"role\":\"assistant\",\"content\":\"Officia tempore provident eius sint sed aspernatur natus. Quam a\"},{\"role\":\"system\",\"content\":\"Officiis voluptate quod similique dolore incidunt. Aliquid quisq\"},{\"role\":\"user\",\"content\":\"Deserunt explicabo doloribus dolore nihil voluptas tempore. Qui\"},{\"role\":\"user\",\"content\":\"Voluptas adipisci voluptas unde quia laudantium dolorem ea ut. D\"},{\"role\":\"system\",\"content\":\"Quos vel modi. Fugit nesciunt voluptatem amet rerum. Ut ipsum ea\"},{\"role\":\"assistant\",\"content\":\"Quas enim ipsum. Saepe in quaerat sequi voluptatem dolores ut cu\"}]", "gpt-4", "Non rerum dolorem est nam dolores quaerat nulla fugit. Dolorum veniam molestias omnis tenetur nemo qui delectus. Rerum voluptate", "a223464d-0d09-46d8-92a8-39b5d41dbf9b", 6198, new DateTime(2023, 11, 1, 6, 9, 57, 171, DateTimeKind.Unspecified).AddTicks(9268), "074ba6f7-9633-410f-bb53-6fd71c8eb890" },
                    { "f6dfacad-566f-41a2-ba26-19c931816c8d", new DateTime(2022, 6, 22, 10, 57, 20, 476, DateTimeKind.Unspecified).AddTicks(7131), "c93cb7cf-704c-4369-8323-b0d8680586cf", null, "Repellendus architecto eum repellendus repellendus ab. Omnis dolore laboriosam sint soluta praesentium rerum sed natus. Nostrum ipsam aliquam nam aut est.", false, "[{\"role\":\"assistant\",\"content\":\"Error quas sed dolor. Quidem quia eligendi aut nam omnis omnis n\"},{\"role\":\"user\",\"content\":\"Debitis qui fugit facere voluptatem est qui vel. Quia doloribus\"}]", "gpt-3.5-trubo", "Vel temporibus excepturi. Laborum ut non. Corrupti omnis eos id eos quod. Non aliquam et quia. Corporis recusandae velit eius ve", "1ba33397-e4cc-48c2-9955-64c2aa4ee805", 8560, new DateTime(2022, 6, 22, 10, 57, 20, 476, DateTimeKind.Unspecified).AddTicks(7131), "c93cb7cf-704c-4369-8323-b0d8680586cf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e99b398e-4e7e-46ba-9752-52b6bb8d1d42", "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "209ab5fe-d8b0-4903-bd40-2eb84825a9c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569ddf3b-ecd4-456b-aa9a-8f834b2ea573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb0daf3a-f3e4-42a3-b264-8e49bcebdcc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edbcaed2-0e26-46a6-be4a-7c81e2ee850e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fed14519-0455-49ff-935e-14389498585d");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "03c36806-0790-4540-a96f-547d4c82aed4");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "042a28d0-7e72-4cda-8fb9-88ea57909098");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "08cdd86b-e1f4-45ff-9ba0-560d134b4cea");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "0d6cab6f-f368-4420-9ced-9b3fde60d128");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "140e53ae-b417-4c8b-91f5-b758a5bd4cac");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "29336f12-9f4d-4465-8e78-b2fd48e504b6");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "423eb7f8-2827-43b3-90d4-d49d18bd6328");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "4cf093c2-4909-4d9c-908d-8bbd5a14413b");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "558059fc-ae73-4cc3-8704-6444682b47a2");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "56db8950-8982-4014-9431-174ea13b1e91");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "64a8b5eb-23c4-4c31-a1bf-65deb5c8d8d5");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "6e1cff81-a27b-44bb-96cd-3114bf6e7924");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "83a74e66-0dc9-4f9b-a3e9-be5c62e19ca2");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "8ceda7ea-f577-483a-8779-24df63f98992");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "915ef70f-f48d-4a52-8716-586f7092690e");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "948d7250-9059-48b5-9d25-96cb26376a37");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "97bce606-fe67-409e-86ae-3e0aa3a8be43");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "9dfd1d21-f47b-4bb4-9de6-536edcfbff29");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "b1e68666-1a74-4e79-94fa-838fdfe45b43");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "b4133ea9-5867-460b-a7d4-0c339d0c7046");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "c56fedd0-808d-4490-a0fe-1e004acf4d2a");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "c6f06591-2fbd-4aab-ba50-ccd0a74d12b6");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ce772031-9295-4571-b4d8-dfc36e279a2d");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "dbcad1dd-e4e7-478a-b442-95538ece7b54");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "e2c6c8e6-8132-4053-8e37-d11dc473fc02");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "e47fd54f-ef65-49f9-b1f6-38a198b43fe5");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ec862e61-a7f4-4246-97a6-311981881587");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "ef620537-3c1f-41b7-a4f7-2dd5a864e893");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "f0817911-a123-4b3e-8945-050c562fde37");

            migrationBuilder.DeleteData(
                table: "Prompts",
                keyColumn: "Id",
                keyValue: "f6dfacad-566f-41a2-ba26-19c931816c8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e99b398e-4e7e-46ba-9752-52b6bb8d1d42");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1ba33397-e4cc-48c2-9955-64c2aa4ee805");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1cb87bd7-86c6-4d95-a152-9a54e91ed684");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "326fb39d-3047-4357-8cd2-669ce64db9b8");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "54b709d2-1b9c-4952-96a5-e2fad6d58c52");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "79b3faa3-2a38-4bc7-9e87-10b4ed32c651");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "84048d83-2704-4194-9f57-24c716a8508f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8d98fc40-1b5d-4e56-b1db-6a3381a284d9");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a223464d-0d09-46d8-92a8-39b5d41dbf9b");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "ade5346c-3732-45a0-b29c-76f32be74b81");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "d7895405-ea42-4547-823c-386844994f8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "074ba6f7-9633-410f-bb53-6fd71c8eb890");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c37ec7e-4044-42bd-bfaa-ac6d2ae768c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4237756-952a-4df5-b069-3d5efa3db87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c93cb7cf-704c-4369-8323-b0d8680586cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d059dd1e-45f7-4522-85c1-a7bf2147574c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e261f625-3e8a-422f-84c9-94bc09b14c04");

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
    }
}
