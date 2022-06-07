using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemasRafa.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pegi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EdadMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PegiEdad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkerDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerDto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrlDescarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valoracion = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    PegiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peliculas_Pegi_PegiId",
                        column: x => x.PegiId,
                        principalTable: "Pegi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temporada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaTerminado = table.Column<bool>(type: "bit", nullable: false),
                    UrlDescarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valoracion = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    PegiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serie_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Serie_Pegi_PegiId",
                        column: x => x.PegiId,
                        principalTable: "Pegi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentaUsuario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaUsuario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CuentaUsuario_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleHasMenu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleHasMenu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoleHasMenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleHasMenu_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Admin_CuentaUsuario_CuentaUsuarioID",
                        column: x => x.CuentaUsuarioID,
                        principalTable: "CuentaUsuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_CuentaUsuario_CuentaUsuarioID",
                        column: x => x.CuentaUsuarioID,
                        principalTable: "CuentaUsuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Worker_CuentaUsuario_CuentaUsuarioID",
                        column: x => x.CuentaUsuarioID,
                        principalTable: "CuentaUsuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ficcion" },
                    { 2, "Accion" },
                    { 3, "Romance" },
                    { 4, "Thriller" },
                    { 5, "Terror" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "ID", "Action", "Controller", "Label" },
                values: new object[,]
                {
                    { 11, "Index", "Categorias", "Categorias" },
                    { 10, "Index", "Series", "Series" },
                    { 9, "Index", "Peliculas", "Peliculas" },
                    { 8, "Index", "Pegis", "Pegis" },
                    { 6, "Index", "RoleHasMenus", "RoleMenus" },
                    { 7, "Index", "Roles", "Roles" },
                    { 4, "Index", "Customer", "Customer" },
                    { 3, "Index", "Worker", "Workers" },
                    { 2, "Index", "Admins", "Administradores" },
                    { 1, "Index", "CuentaUsuarios", "Cuentas" },
                    { 5, "Index", "Menus", "Menus" }
                });

            migrationBuilder.InsertData(
                table: "Pegi",
                columns: new[] { "Id", "EdadMin", "PegiEdad" },
                values: new object[,]
                {
                    { 1, "Pegi 3", 3 },
                    { 5, "Pegi 7", 7 },
                    { 2, "Pegi 12", 12 },
                    { 3, "Pegi 16", 16 },
                    { 4, "Pegi 18", 18 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Enabled", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { 2, true, "Worker rol", "Worker" },
                    { 1, true, "Admin rol", "Admin" },
                    { 3, true, "Customer rol", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "CuentaUsuario",
                columns: new[] { "ID", "Active", "Email", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, true, "admin1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin1" },
                    { 2, false, "admin2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin2" },
                    { 4, false, "customer2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customert2" },
                    { 3, true, "customer1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customer1" },
                    { 6, false, "worker2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker2" },
                    { 5, true, "worker1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker1" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Director", "Duracion", "FechaEstreno", "ImageUrl", "Nombre", "PegiId", "UrlDescarga", "Valoracion" },
                values: new object[] { 1, 1, "Por primera vez en la historia cinematográfica de Spider-Man, nuestro héroe, vecino y amigo es desenmascarado, y por tanto, ya no es capaz de separar su vida normal de los enormes riesgos que conlleva ser un superhéroe. Cuando pide ayuda al Doctor Strange, los riesgos pasan a ser aún más peligrosos, obligándole a descubrir lo que realmente significa ser él. Secuela de 'Spider-Man: Far From Home'. ", "Jon Watts", 148, new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img2.acsta.net/r_1920_1080/pictures/21/12/01/12/07/0243323.jpg", "Spider-Man: No Way Home", 2, "https://es.web.img3.acsta.net/c_200_200/pictures/15/11/24/16/53/595385.jpg", 5.0 });

            migrationBuilder.InsertData(
                table: "RoleHasMenu",
                columns: new[] { "ID", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 16, 11, 2 },
                    { 15, 10, 2 },
                    { 14, 9, 2 },
                    { 13, 8, 2 },
                    { 12, 4, 2 },
                    { 11, 11, 1 },
                    { 10, 10, 1 },
                    { 9, 9, 1 },
                    { 8, 8, 1 },
                    { 7, 7, 1 },
                    { 6, 6, 1 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 17, 9, 3 },
                    { 18, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "CuentaUsuarioID", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "admin", "642443212", "min" },
                    { 2, 2, "administrador", "642443213", "pp" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "Address", "CuentaUsuarioID", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, "Avenida M", 3, "customer", "642443234", "custo" },
                    { 2, "Avenida M", 4, "customer", "642443265", "custo" }
                });

            migrationBuilder.InsertData(
                table: "Worker",
                columns: new[] { "ID", "CuentaUsuarioID", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, 5, "worker", "642443214", "wer" },
                    { 2, 6, "worker", "642443217", "worke" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_CuentaUsuarioID",
                table: "Admin",
                column: "CuentaUsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaUsuario_RoleID",
                table: "CuentaUsuario",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CuentaUsuarioID",
                table: "Customer",
                column: "CuentaUsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_CategoriaId",
                table: "Peliculas",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_PegiId",
                table: "Peliculas",
                column: "PegiId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleHasMenu_MenuID",
                table: "RoleHasMenu",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleHasMenu_RoleID",
                table: "RoleHasMenu",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_CategoriaId",
                table: "Serie",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_PegiId",
                table: "Serie",
                column: "PegiId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_CuentaUsuarioID",
                table: "Worker",
                column: "CuentaUsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AdminDto");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerDto");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "RoleHasMenu");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "WorkerDto");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pegi");

            migrationBuilder.DropTable(
                name: "CuentaUsuario");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
