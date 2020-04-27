using Microsoft.EntityFrameworkCore.Migrations;

namespace KidsTime.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        CategoryId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CategoryName = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.CategoryId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Activities",
            //    columns: table => new
            //    {
            //        ActivityId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        ShortDescription = table.Column<string>(nullable: true),
            //        LongDescription = table.Column<string>(nullable: true),
            //        Teacher = table.Column<string>(nullable: true),
            //        Price = table.Column<decimal>(nullable: false),
            //        ImageURl = table.Column<string>(nullable: true),
            //        ImageThumbnailURl = table.Column<string>(nullable: true),
            //        IsActivityStar = table.Column<bool>(nullable: false),
            //        IsAvailable = table.Column<bool>(nullable: false),
            //        CategoryId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Activities", x => x.ActivityId);
            //        table.ForeignKey(
            //            name: "FK_Activities_Categories_CategoryId",
            //            column: x => x.CategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "CategoryId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Sport", "" },
                    { 2, "Tehnica", "" },
                    { 3, "Arta", "" },
                    { 4, "Cultura", "" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CategoryId", "ImageThumbnailURl", "ImageURl", "IsActivityStar", "IsAvailable", "LongDescription", "Name", "Price", "ShortDescription", "Teacher" },
                values: new object[,]
                {
                    { 8, 1, "https://cdn.pixabay.com/photo/2020/04/07/09/07/go-kart-5012595_1280.jpg", "https://cdn.pixabay.com/photo/2020/04/07/09/07/go-kart-5012595_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Karting", 20m, "Simte viteza", null },
                    { 9, 1, "https://cdn.pixabay.com/photo/2013/05/20/05/19/rollerderby-112223_1280.jpg", "https://cdn.pixabay.com/photo/2013/05/20/05/19/rollerderby-112223_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Patinaj viteza", 20m, "Sa invartim rotile", null },
                    { 11, 1, "https://scontent.fotp3-3.fna.fbcdn.net/v/t1.0-9/10676376_749670175148758_8086599348838060691_n.jpg?_nc_cat=108&_nc_sid=85a577&_nc_ohc=DxyQnDW55NcAX_D8i_S&_nc_ht=scontent.fotp3-3.fna&oh=3cb0b394586a2aa7cf77dc591efa775e&oe=5EB58729", "https://scontent.fotp3-3.fna.fbcdn.net/v/t1.0-9/10676376_749670175148758_8086599348838060691_n.jpg?_nc_cat=108&_nc_sid=85a577&_nc_ohc=DxyQnDW55NcAX_D8i_S&_nc_ht=scontent.fotp3-3.fna&oh=3cb0b394586a2aa7cf77dc591efa775e&oe=5EB58729", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Aeromodele", 20m, "Sa coboram rotile", null },
                    { 10, 2, "https://cdn.pixabay.com/photo/2016/06/13/08/00/pi-1453839_1280.jpg", "https://cdn.pixabay.com/photo/2016/06/13/08/00/pi-1453839_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Matematica aplicata", 20m, "Sa invartim rotile", null },
                    { 1, 3, "https://cdn.pixabay.com/photo/2019/05/24/16/49/brushes-4226688_1280.jpg", "https://cdn.pixabay.com/photo/2019/05/24/16/49/brushes-4226688_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Pictura", 20m, "Viata in culori", null },
                    { 2, 3, "https://cdn.pixabay.com/photo/2016/08/24/20/39/violin-1617972_1280.jpg", "https://cdn.pixabay.com/photo/2016/08/24/20/39/violin-1617972_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Vioara", 20m, "Viata intre vibratii", null },
                    { 3, 3, "https://cdn.pixabay.com/photo/2018/05/12/15/13/amateur-3393588_1280.jpg", "https://cdn.pixabay.com/photo/2018/05/12/15/13/amateur-3393588_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Dansuri populare", 20m, "Ne conectam cu bunnii si strabunii", null },
                    { 4, 3, "https://cdn.pixabay.com/photo/2017/09/03/16/16/musical-2710927_1280.jpg", "https://cdn.pixabay.com/photo/2017/09/03/16/16/musical-2710927_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Teatru", 20m, "Teatru de revista", null },
                    { 5, 3, "https://cdn.pixabay.com/photo/2015/02/03/16/14/potter-622708_1280.jpg", "https://cdn.pixabay.com/photo/2015/02/03/16/14/potter-622708_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Ceramica", 20m, "Dam viata lutului", null },
                    { 6, 4, "https://cdn.pixabay.com/photo/2015/09/21/15/10/geisha-949978_1280.jpg", "https://cdn.pixabay.com/photo/2015/09/21/15/10/geisha-949978_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Japonia", 20m, "Cultura si civilizatia Japoniei", null },
                    { 7, 4, "https://cdn.pixabay.com/photo/2016/08/15/08/22/greece-1594689_1280.jpg", "https://cdn.pixabay.com/photo/2016/08/15/08/22/greece-1594689_1280.jpg", true, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", "Grecia", 20m, "Cultura si civilizatia Greciei", null }
                });


            //migrationBuilder.CreateIndex(
            //    name: "IX_Activities_CategoryId",
            //    table: "Activities",
            //    column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
