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
                name: "Comida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Valoraciones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comida", x => x.Id);
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
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
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
                table: "Menu",
                columns: new[] { "ID", "Action", "Controller", "Label" },
                values: new object[,]
                {
                    { 1, "Index", "CuentaUsuarios", "Cuentas" },
                    { 2, "Index", "Admins", "Administradores" },
                    { 3, "Index", "Workers", "Workers" },
                    { 4, "Index", "Customers", "Customers" },
                    { 5, "Index", "Menus", "Menus" },
                    { 6, "Index", "RoleHasMenus", "RoleMenus" },
                    { 7, "Index", "Roles", "Roles" },
                    { 8, "Index", "Pegis", "Pegis" },
                    { 9, "Index", "Peliculas", "Peliculas" },
                    { 10, "Index", "Comidas", "Comidas" },
                    { 11, "Index", "Categorias", "Categorias" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Enabled", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { 1, true, "Admin rol", "Admin" },
                    { 2, true, "Worker rol", "Worker" },
                    { 3, true, "Customer rol", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "CuentaUsuario",
                columns: new[] { "ID", "Active", "Email", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, true, "admin1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin1" },
                    { 2, false, "admin2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin2" },
                    { 3, true, "customer1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customer1" },
                    { 6, false, "worker2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker2" },
                    { 5, true, "worker1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker1" },
                    { 4, false, "customer2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customert2" }
                });

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
                    { 8, 8, 1 },
                    { 7, 7, 1 },
                    { 6, 6, 1 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 9, 9, 1 },
                    { 17, 8, 3 }
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
                name: "Comida");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerDto");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "RoleHasMenu");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "WorkerDto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pegi");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "CuentaUsuario");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
