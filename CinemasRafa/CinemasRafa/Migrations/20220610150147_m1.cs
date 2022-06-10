using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemasRafa.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdminDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDto", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDto", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Controller = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pegi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EdadMin = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PegiEdad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegi", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkerDto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerDto", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Director = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "datetime", nullable: false),
                    UrlDescarga = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valoracion = table.Column<double>(type: "double", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Director = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Temporada = table.Column<int>(type: "int", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "datetime", nullable: false),
                    HaTerminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UrlDescarga = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valoracion = table.Column<double>(type: "double", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CuentaUsuario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleHasMenu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CuentaUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    { 13, "Index", "AdminControlSeries", "Control Series" },
                    { 12, "Index", "AdminControlPeliculas", "Control Peliculas" },
                    { 11, "Index", "Categorias", "Categorias" },
                    { 10, "Index", "Series", "Series" },
                    { 9, "Index", "Peliculas", "Peliculas" },
                    { 7, "Index", "Roles", "Roles" },
                    { 8, "Index", "Pegis", "Pegis" },
                    { 5, "Index", "Menus", "Menus" },
                    { 4, "Index", "Customer", "Customer" },
                    { 3, "Index", "Worker", "Workers" },
                    { 2, "Index", "Admins", "Administradores" },
                    { 1, "Index", "CuentaUsuarios", "Cuentas" },
                    { 6, "Index", "RoleHasMenus", "RoleMenus" }
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
                    { 2, false, "admin2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin2" },
                    { 5, true, "worker1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker1" },
                    { 6, false, "worker2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 2, "worker2" },
                    { 4, false, "customer2@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customert2" },
                    { 3, true, "customer1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 3, "customer1" },
                    { 1, true, "admin1@hotmail.com", "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==", 1, "admin1" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Director", "Duracion", "FechaEstreno", "ImageUrl", "Nombre", "PegiId", "UrlDescarga", "Valoracion" },
                values: new object[,]
                {
                    { 4, 1, "Han pasado dos años desde que el tranquilo Peter Parker dejó a Mary Jane Watson, su gran amor, y decidió seguir asumiendo sus responsabilidades como Spider-Man. Peter debe afrontar nuevos desafíos mientras lucha contra el don y la maldición de sus poderes equilibrando sus dos identidades: el escurridizo superhéroe Spider-Man y el estudiante universitario. Las relaciones con las personas que más aprecia están ahora en peligro de ser descubiertas con la aparición del poderoso villano de múltiples tentáculos Doctor Octopus, Doc Ock.", "Sam Raimi", 127, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/35/16/02/18380826.jpg", "Spider-Man 2", 4, "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/35/16/02/18380826.jpg", 5.0 },
                    { 5, 1, "Basada en el famoso cuento Aladino y la lámpara maravillosa, la trama se sitúa en el exótico paisaje del mítico reino árabe de Agrabah. Aladdin es un ingenioso joven que, a pesar de vivir en un estado de extrema pobreza, sueña con casarse con la bella hija del sultán, la princesa Yasmin. El destino interviene cuando el astuto visir del Sultán, Yafar, recluta a Aladdin para que le ayude a recuperar una lámpara mágica de las profundidades de la Cueva de las Maravillas. El joven encuentra la lámpara, en la que vive un genio que concede tres deseos a quien lo libere.", "John Musker, Ron Clements", 87, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img3.acsta.net/r_1920_1080/img/6c/02/6c022db26a46682b554a0e43a896de17.jpg", "Aladdin", 1, "https://es.web.img3.acsta.net/r_1920_1080/img/6c/02/6c022db26a46682b554a0e43a896de17.jpg", 5.0 },
                    { 1, 1, "Por primera vez en la historia cinematográfica de Spider-Man, nuestro héroe, vecino y amigo es desenmascarado, y por tanto, ya no es capaz de separar su vida normal de los enormes riesgos que conlleva ser un superhéroe. Cuando pide ayuda al Doctor Strange, los riesgos pasan a ser aún más peligrosos, obligándole a descubrir lo que realmente significa ser él. Secuela de 'Spider-Man: Far From Home'. ", "Jon Watts", 148, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img2.acsta.net/r_1920_1080/pictures/21/12/01/12/07/0243323.jpg", "Spider-Man: No Way Home", 2, "https://es.web.img3.acsta.net/c_200_200/pictures/15/11/24/16/53/595385.jpg", 5.0 },
                    { 3, 2, "Un joven hastiado de su gris y monótona vida lucha contra el insomnio. En un viaje en avión conoce a un carismático vendedor de jabón que sostiene una teoría muy particular: el perfeccionismo es cosa de gentes débiles; sólo la autodestrucción hace que la vida merezca la pena. Ambos deciden entonces fundar un club secreto de lucha, donde poder descargar sus frustaciones y su ira, que tendrá un éxito arrollador.", "David Fincher", 139, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img3.acsta.net/r_1920_1080/img/23/b7/23b757ce995171ae05ba7449c67a47dc.jpg", "Club de la lucha", 5, "https://es.web.img3.acsta.net/c_200_200/pictures/15/11/24/16/53/595385.jpg", 5.0 },
                    { 2, 1, "Tras la muerte de sus padres, Peter Parker, un tímido estudiante, vive con su tía May y su tío Ben. Precisamente debido a su retraimiento no es un chico muy popular en el instituto. Un día le muerde una araña que ha sido modificada genéticamente; a la mañana siguiente, descubre estupefacto que posee la fuerza y la agilidad de ese insecto. Las aventuras del hombre araña se basan en el famoso cómic de Stan Lee y Steve Ditko.", "Sam Raimi", 121, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://es.web.img2.acsta.net/r_1920_1080/medias/nmedia/00/00/00/33/spiderman.jpg", "Spider-Man", 3, "https://es.web.img2.acsta.net/r_1920_1080/medias/nmedia/00/00/00/33/spiderman.jpg", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "RoleHasMenu",
                columns: new[] { "ID", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 21, 13, 2 },
                    { 22, 13, 1 },
                    { 19, 12, 2 },
                    { 16, 11, 2 },
                    { 13, 8, 2 },
                    { 12, 4, 2 },
                    { 15, 10, 2 },
                    { 14, 9, 2 },
                    { 20, 12, 1 },
                    { 6, 6, 1 },
                    { 8, 8, 1 },
                    { 7, 7, 1 },
                    { 17, 9, 3 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 10, 10, 1 },
                    { 9, 9, 1 },
                    { 11, 11, 1 },
                    { 18, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "Serie",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Director", "FechaEstreno", "HaTerminado", "ImageUrl", "Nombre", "PegiId", "Temporada", "UrlDescarga", "Valoracion" },
                values: new object[,]
                {
                    { 3, 1, "Walter decide seguir con el negocio a pesar de todos los conflictos que conlleva. Además, se ve obligado a contratar los servicios de un abogado deshonesto, Saul Goodman, para ayudar al traficante Badger después que fuese arrestado por la policía. Combo, otro de los distribuidores, es asesinado por una banda rival. Mientras todo esto sucede, Jesse comienza una relación con Jane, una joven que se está recuperando de su adicción a las drogas, y Walt encuentra un nuevo socio llamado Gus. Al final de la temporada, la esposa de Walter comienza a sospechar sobre la segunda vida de su marido.", "Vince Gilligan", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), true, "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1597342.jpg", "Breaking Bad", 2, 2, "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1597342.jpg", 5.0 },
                    { 2, 1, "Walter White decide entrar en el mundo de las drogas ilegales después de que le diagnosticaran cáncer de pulmón. Al ser profesor de química, utiliza sus conocimientos y habilidades para elaborar una metanfetamina junto a un antiguo alumno, Jesse Pinkman (Aaron Paul). Durante sus primeros días, como productores de droga, tienen varios problemas con los distribuidores locales. Además, empiezan a ser famosos, gracias a la droga que producen, y amplian territorio. Walt se crea un apodo, Heisenberg, para darse a conocer en su segunda vida.", "Vince Gilligan", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), true, "https://es.web.img2.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1237965.jpg", "Breaking Bad", 2, 1, "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg", 5.0 },
                    { 1, 1, "La serie sigue las múltiples tramas de la saga Canción de hielo y fuego.2​ Comienza cuando el Rey Robert Baratheon (Mark Addy) le pide a su viejo amigo Ned Stark (Sean Bean) que realice la función de nuevo consejero real (cargo conocido como la Mano del Rey). La esposa de Ned, Catelyn (Michelle Fairley) recibe una carta de su hermana, Lysa (Kate Dickie) que le da razones para creer que la Casa Lannister, a la cual pertenece Cersei, la esposa del rey, está involucrada en la muerte de la anterior Mano del Rey. Ned debe viajar al sur con el Rey para descubrir el asesino de la Mano del Rey muerto, Jon Arryn (John Standing) y a la misma vez proteger a su familia de los Lannister. Mientras descubre las razones detrás de la muerte de Jon, desentierra el oscuro secreto concerniente a los Lannister que el propio Arryn murió tratando de revelar. ", "David Benioff", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), true, "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg", "Juego de tronos", 2, 1, "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg", 5.0 }
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
