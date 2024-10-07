using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStore_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class TryingBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "brand_id", "brand_description", "brand_name" },
                values: new object[,]
                {
                    { 1, "Dignissimos aut quod rem dolore consequatur est non harum consequatur.", "Cummings, Gaylord and Sipes" },
                    { 2, "Autem voluptatem vitae vel sunt laudantium nostrum harum minus asperiores.", "Adams - Howe" },
                    { 3, "Aut eum voluptas cumque sunt hic est et ad itaque.", "Rodriguez Group" },
                    { 4, "Dolor sapiente non perspiciatis pariatur neque blanditiis adipisci et dolorum.", "Wintheiser Group" },
                    { 5, "Molestias asperiores eum rerum enim quo adipisci earum omnis ea.", "Thompson, Schoen and Witting" },
                    { 6, "Eligendi repudiandae ratione qui provident dolorem est a sed sunt.", "Dare Inc" },
                    { 7, "Alias autem saepe debitis a sequi et qui rerum dignissimos.", "Oberbrunner, Donnelly and Schneider" },
                    { 8, "Sed autem laboriosam incidunt rem corporis et quia est aut.", "Hickle, Bartell and Ward" },
                    { 9, "Quos incidunt nobis dolor ipsam dignissimos sed optio totam dicta.", "Heathcote - Gerhold" },
                    { 10, "Nisi aut sed sint sed voluptate sequi quaerat ut non.", "Ebert, Walsh and Kessler" },
                    { 11, "Vel asperiores iste nobis nihil dolores et est eos quo.", "Gerlach - Schaden" },
                    { 12, "Est vel voluptas voluptatibus assumenda nesciunt suscipit alias doloremque iure.", "Beahan - Walter" },
                    { 13, "Sed velit blanditiis nesciunt consequatur ut ut voluptas rem et.", "Lemke - Fahey" },
                    { 14, "Impedit praesentium autem deleniti amet sint doloremque dolorem et corporis.", "Runolfsson, Kemmer and Nader" },
                    { 15, "Ipsam ab sed deleniti eveniet omnis voluptas quam in delectus.", "Tremblay - Wuckert" },
                    { 16, "Delectus consequatur numquam sunt quia quibusdam sit qui voluptatum fugit.", "Ullrich - Spencer" },
                    { 17, "Vitae quia suscipit voluptates consequuntur error voluptatem necessitatibus consequatur tempore.", "Carroll - Hahn" },
                    { 18, "Cumque sed qui laboriosam sit nulla illum non accusamus illum.", "Deckow, Yundt and Kuhn" },
                    { 19, "Est sint et qui aut expedita aut consequatur et est.", "Leannon LLC" },
                    { 20, "Quia iusto illo quis aut et earum necessitatibus et doloribus.", "Schowalter Inc" },
                    { 21, "Excepturi harum ea nemo nihil est quia enim saepe vel.", "Nader - Bechtelar" },
                    { 22, "Sequi sit doloribus est cumque est quos eius iusto rem.", "Boyer LLC" },
                    { 23, "Nam voluptatem mollitia fugit et saepe voluptates consequuntur occaecati distinctio.", "Senger and Sons" },
                    { 24, "Repellat eveniet aut deleniti eos est maiores sed odio dolorem.", "Barton, Bode and Erdman" },
                    { 25, "In commodi a quidem ea soluta magnam ipsum velit repellendus.", "Upton - Robel" },
                    { 26, "Quae natus ea a consectetur aut reiciendis quis nemo fugit.", "Morissette, Sanford and Abernathy" },
                    { 27, "Eum error dolor est aut voluptates quae aliquid laborum magni.", "Satterfield, Hoppe and Ernser" },
                    { 28, "Placeat ex voluptas aut ea blanditiis quo iste consequatur aliquam.", "Barrows - Johnson" },
                    { 29, "Mollitia illum officiis magnam debitis et non ea et similique.", "Bins - Wuckert" },
                    { 30, "Qui et expedita enim aut repellat eligendi doloremque asperiores adipisci.", "Lehner - Johns" },
                    { 31, "Placeat itaque doloribus dicta repellendus vero modi rerum sunt beatae.", "Pfannerstill Group" },
                    { 32, "Maxime architecto sed rerum eveniet ut facere in quaerat vel.", "McCullough Group" },
                    { 33, "Quo vel accusantium qui fugiat veniam distinctio minus est omnis.", "Shanahan - Morissette" },
                    { 34, "Velit velit soluta voluptatem nostrum ea ut ipsam consequatur dolorem.", "Nader - Rodriguez" },
                    { 35, "Aut aut occaecati error voluptatum est libero qui asperiores molestiae.", "Stark Inc" },
                    { 36, "Ipsam eligendi sunt distinctio asperiores repellat totam nostrum repellendus aut.", "Jones Inc" },
                    { 37, "Itaque et voluptas natus consectetur esse dolores similique nostrum soluta.", "Frami, Cronin and Kutch" },
                    { 38, "Voluptatem inventore corporis eaque quis saepe quis ipsam voluptas porro.", "Gislason Group" },
                    { 39, "Earum ut voluptatem esse illum suscipit est molestiae modi autem.", "Osinski, Stark and Okuneva" },
                    { 40, "Unde eveniet velit ut voluptatum eligendi harum cupiditate voluptas commodi.", "Mraz, Swift and Hilpert" },
                    { 41, "Corrupti rem eos corrupti commodi vel ut at ipsa assumenda.", "Cassin and Sons" },
                    { 42, "Eos molestias autem qui molestiae eius corporis id libero excepturi.", "Emard Group" },
                    { 43, "Consequatur dolorum et rem repudiandae autem ipsa maiores quia nobis.", "Hermiston - Raynor" },
                    { 44, "Vero dolorum qui qui ullam dolor deleniti veritatis ut est.", "Langosh, Ernser and Bartoletti" },
                    { 45, "Ut quo occaecati quasi provident corporis quo corrupti laboriosam impedit.", "Berge, Funk and Metz" },
                    { 46, "Accusamus deserunt dolorum dolores quis qui soluta tempora iusto blanditiis.", "Sawayn, Padberg and Monahan" },
                    { 47, "Impedit voluptatem similique vitae nam maiores consequuntur necessitatibus molestiae tenetur.", "Balistreri and Sons" },
                    { 48, "Ipsam eum ratione eaque sequi dicta debitis illo dicta neque.", "Tillman, Goldner and Thompson" },
                    { 49, "Blanditiis accusamus hic dolor et rem enim sint quia accusantium.", "Becker - Krajcik" },
                    { 50, "Voluptatum eos tempora adipisci possimus omnis unde est et odit.", "Bruen - Marks" },
                    { 51, "Ad et quisquam nam repellat sit quia quaerat veniam porro.", "Murazik - Streich" },
                    { 52, "Sed eum rerum deleniti asperiores non voluptatem accusamus assumenda aut.", "Hauck, Gaylord and Rippin" },
                    { 53, "Dolor dicta omnis sint magni pariatur inventore mollitia facere sint.", "Keeling LLC" },
                    { 54, "Natus sit id facere aut aspernatur iure eligendi deleniti nesciunt.", "Pacocha, Luettgen and Bergnaum" },
                    { 55, "Et dicta excepturi quisquam magnam qui omnis consequatur quo quia.", "Bayer - Sipes" },
                    { 56, "Natus dolorem sunt consequuntur explicabo itaque magni molestias amet totam.", "Little - Flatley" },
                    { 57, "Et nisi eveniet illum aut libero nulla qui ut quo.", "Wunsch - O'Conner" },
                    { 58, "Et error eos aut tempore rerum libero facilis sit nemo.", "Deckow - Bailey" },
                    { 59, "Atque iste rerum officia ut eveniet perspiciatis id recusandae harum.", "Wilderman and Sons" },
                    { 60, "Ex aut quam atque porro ut ut dolorum totam sed.", "Abshire - Sauer" },
                    { 61, "Et dolor quae eligendi suscipit et consectetur sed aut omnis.", "Sauer, Hagenes and DuBuque" },
                    { 62, "Consectetur beatae ipsa impedit architecto cum consectetur facilis magni beatae.", "Blick, Dicki and Christiansen" },
                    { 63, "Provident sed iste et voluptate iure cupiditate rerum in et.", "Feest Group" },
                    { 64, "Neque cupiditate tenetur quas eveniet eos numquam quis explicabo facilis.", "Fritsch Group" },
                    { 65, "Non ex sed dolores sint sint vero nostrum ipsa inventore.", "Lang LLC" },
                    { 66, "Ducimus sunt quia cum et quam magnam fuga qui sed.", "Abernathy - Blick" },
                    { 67, "Enim rerum officiis vitae nisi quia repellendus consequatur labore voluptatem.", "Nikolaus, Weimann and Mayert" },
                    { 68, "Sed voluptatibus adipisci non dolorum id consequuntur dolore at id.", "Donnelly and Sons" },
                    { 69, "Neque numquam voluptatem rerum aut nihil iste atque natus velit.", "Bruen LLC" },
                    { 70, "Soluta debitis aut voluptate autem id voluptatum tempora tempora nihil.", "Hettinger LLC" },
                    { 71, "Numquam quasi deserunt non eum enim accusantium velit et perspiciatis.", "Harvey Inc" },
                    { 72, "Illum nulla rerum dignissimos eius dolorem voluptatibus eligendi iusto officia.", "Gusikowski - Feil" },
                    { 73, "Saepe est rerum et dolorum aliquam aspernatur perferendis nobis maxime.", "Sporer - Kuhn" },
                    { 74, "Cum qui ut unde facilis illum deleniti sit ea necessitatibus.", "Cremin - Doyle" },
                    { 75, "Minus occaecati molestiae officiis quia nihil maiores qui delectus illo.", "Bruen - Gulgowski" },
                    { 76, "Quia quis aut est illum et consequatur rerum ad placeat.", "Stokes - Leannon" },
                    { 77, "Ipsum quisquam aut ut eius possimus non est nesciunt dolorum.", "Terry, Hickle and Kub" },
                    { 78, "Perspiciatis mollitia ducimus eveniet iste sed deleniti qui aut facere.", "Boyer, Goodwin and O'Connell" },
                    { 79, "Omnis quasi consequuntur dolorum animi impedit eligendi incidunt ut ut.", "Wunsch - Quigley" },
                    { 80, "Necessitatibus quia doloribus dolorem enim aut natus omnis quam nam.", "Rolfson, Johns and Ullrich" },
                    { 81, "Est temporibus voluptatibus nisi et ut culpa et et nesciunt.", "Cruickshank LLC" },
                    { 82, "Et qui omnis pariatur labore ipsa architecto non est est.", "Bechtelar, Bosco and Stroman" },
                    { 83, "A et consequatur quidem quibusdam molestiae sapiente debitis iure et.", "Marquardt - Roob" },
                    { 84, "Voluptatem harum sed excepturi in blanditiis voluptatem deserunt eaque perferendis.", "Greenholt Inc" },
                    { 85, "Repellendus non voluptatem culpa possimus exercitationem temporibus cumque modi ducimus.", "Hauck Group" },
                    { 86, "Non eum optio reprehenderit placeat ad est omnis est illum.", "Larkin, Kautzer and Rath" },
                    { 87, "Possimus est id ratione sed blanditiis eos quis ratione assumenda.", "Renner LLC" },
                    { 88, "Recusandae exercitationem quod facere fuga cupiditate debitis iste et facere.", "Lang - Christiansen" },
                    { 89, "Aut asperiores officiis voluptas deleniti et voluptatem qui assumenda tempore.", "Nienow - Ruecker" },
                    { 90, "Et odio et quae ut quod consequatur minus atque tempore.", "Zemlak - Reinger" },
                    { 91, "Corrupti vitae eos dolores nam sunt quo veritatis illo harum.", "Blanda, Kessler and Pagac" },
                    { 92, "Velit velit qui officiis eligendi rerum beatae reprehenderit incidunt esse.", "Kunze - Hegmann" },
                    { 93, "Laboriosam molestiae quidem incidunt est earum non repellat voluptas occaecati.", "Brown, Connelly and Spencer" },
                    { 94, "Dolorem ut amet non nostrum sint vel id dolores quod.", "Sauer - Schamberger" },
                    { 95, "Magnam perspiciatis ab sint quasi et et aut facilis corrupti.", "Hayes - Walter" },
                    { 96, "Perspiciatis voluptates voluptas amet in nisi esse dolor sunt dolores.", "Gulgowski Group" },
                    { 97, "Eum magnam molestiae voluptas voluptas ea ex est distinctio velit.", "Welch LLC" },
                    { 98, "Maiores itaque velit est ducimus quisquam laborum minima assumenda ut.", "Lakin, Kihn and Ziemann" },
                    { 99, "Similique voluptatem et et iste impedit numquam laboriosam debitis neque.", "Harris and Sons" },
                    { 100, "Voluptas similique nihil tempore placeat animi labore est et modi.", "Dicki - Lubowitz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "brand_id",
                keyValue: 100);
        }
    }
}
