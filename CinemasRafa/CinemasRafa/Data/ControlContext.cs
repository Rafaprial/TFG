using Microsoft.EntityFrameworkCore;
using CinemasRafa.Models;
using CinemasRafa.Util;
using CinemasRafa.DTOs;

namespace CinemasRafa.Data
{
    public class ControlContext : DbContext
    {
        public ControlContext(DbContextOptions<ControlContext> opt) : base(opt)
        {

        }
        public DbSet<CuentaUsuario> CuentaUsuario { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<RoleHasMenu> RoleHasMenu { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<CinemasRafa.Models.Categoria> Categoria { get; set; }
        public DbSet<CinemasRafa.Models.Series> Serie { get; set; }
        public DbSet<CinemasRafa.Models.Pegi> Pegi { get; set; }
        public DbSet<CinemasRafa.Models.Peliculas> Peliculas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuentaUsuario>().HasData(
                new CuentaUsuario
                {
                    ID = 1,
                    Username = "admin1",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "admin1@hotmail.com",
                    Active = true,
                    RoleID = 1
                },
                new CuentaUsuario
                {
                    ID = 2,
                    Username = "admin2",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "admin2@hotmail.com",
                    Active = false,
                    RoleID = 1
                },
                new CuentaUsuario
                {
                    ID = 3,
                    Username = "customer1",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "customer1@hotmail.com",
                    Active = true,
                    RoleID = 3
                },
                new CuentaUsuario
                 {
                    ID = 4,
                    Username = "customert2",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "customer2@hotmail.com",
                    Active = false,
                    RoleID = 3
                },
                new CuentaUsuario
                {
                    ID = 5,
                    Username = "worker1",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "worker1@hotmail.com",
                    Active = true,
                    RoleID = 2
                },
                new CuentaUsuario
                {
                    ID = 6,
                    Username = "worker2",
                    Password = Utils.Encript("Altair123$%"),
                    Email = "worker2@hotmail.com",
                    Active = false,
                    RoleID = 2
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 1,
                    RoleName = "Admin",
                    RoleDescription = "Admin rol",
                    Enabled = true
                },
                new Role
                {
                    ID = 2,
                    RoleName = "Worker",
                    RoleDescription = "Worker rol",
                    Enabled = true
                },
                new Role
                {
                    ID = 3,
                    RoleName = "Customer",
                    RoleDescription = "Customer rol",
                    Enabled = true
                }
            );

            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    ID = 1,
                    Controller = "CuentaUsuarios",
                    Action = "Index",
                    Label = "Cuentas"
                }, 
                new Menu
                {
                    ID = 2,
                    Controller = "Admins",
                    Action = "Index",
                    Label = "Administradores"
                }, 
                new Menu
                {
                    ID = 3,
                    Controller = "Worker",
                    Action = "Index",
                    Label = "Workers"
                }, 
                new Menu
                {
                    ID = 4,
                    Controller = "Customer",
                    Action = "Index",
                    Label = "Customer"
                }, 
                new Menu
                {
                    ID = 5,
                    Controller = "Menus",
                    Action = "Index",
                    Label = "Menus"
                }, 
                new Menu
                {
                    ID = 6,
                    Controller = "RoleHasMenus",
                    Action = "Index",
                    Label = "RoleMenus"
                }, 
                new Menu
                {
                    ID = 7,
                    Controller = "Roles",
                    Action = "Index",
                    Label = "Roles"
                }, 
                new Menu
                {
                    ID = 8,
                    Controller = "Pegis",
                    Action = "Index",
                    Label = "Pegis"
                },
                new Menu
                {
                    ID = 9,
                    Controller = "Peliculas",
                    Action = "Index",
                    Label = "Peliculas"
                },
                new Menu
                {
                    ID = 10,
                    Controller = "Series",
                    Action = "Index",
                    Label = "Series"
                }, 
                new Menu
                {
                    ID = 11,
                    Controller = "Categorias",
                    Action = "Index",
                    Label = "Categorias"
                },
                new Menu
                {
                    ID = 12,
                    Controller = "AdminControlPeliculas",
                    Action = "Index",
                    Label = "Control Peliculas"
                },
                new Menu
                {
                    ID = 13,
                    Controller = "AdminControlSeries",
                    Action = "Index",
                    Label = "Control Series"
                }

            );

            modelBuilder.Entity<Peliculas>().HasData(
            new Peliculas
            {
                Id = 1,
                Nombre = "Spider-Man: No Way Home",
                Descripcion = "Por primera vez en la historia cinematográfica de Spider-Man, nuestro héroe, vecino y amigo es desenmascarado, y por tanto, ya no es capaz de separar su vida normal de los enormes riesgos que conlleva ser un superhéroe. Cuando pide ayuda al Doctor Strange, los riesgos pasan a ser aún más peligrosos, obligándole a descubrir lo que realmente significa ser él. Secuela de 'Spider-Man: Far From Home'. ",
                Director = "Jon Watts",
                Duracion = 148,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img3.acsta.net/c_200_200/pictures/15/11/24/16/53/595385.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img2.acsta.net/r_1920_1080/pictures/21/12/01/12/07/0243323.jpg",
                CategoriaId = 1,
                PegiId = 2
            },
            new Peliculas
            {
                Id = 2,
                Nombre = "Spider-Man",
                Descripcion = "Tras la muerte de sus padres, Peter Parker, un tímido estudiante, vive con su tía May y su tío Ben. Precisamente debido a su retraimiento no es un chico muy popular en el instituto. Un día le muerde una araña que ha sido modificada genéticamente; a la mañana siguiente, descubre estupefacto que posee la fuerza y la agilidad de ese insecto. Las aventuras del hombre araña se basan en el famoso cómic de Stan Lee y Steve Ditko.",
                Director = "Sam Raimi",
                Duracion = 121,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img2.acsta.net/r_1920_1080/medias/nmedia/00/00/00/33/spiderman.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img2.acsta.net/r_1920_1080/medias/nmedia/00/00/00/33/spiderman.jpg",
                CategoriaId = 1,
                PegiId = 3
            },
            new Peliculas
            {
                Id = 3,
                Nombre = "Club de la lucha",
                Descripcion = "Un joven hastiado de su gris y monótona vida lucha contra el insomnio. En un viaje en avión conoce a un carismático vendedor de jabón que sostiene una teoría muy particular: el perfeccionismo es cosa de gentes débiles; sólo la autodestrucción hace que la vida merezca la pena. Ambos deciden entonces fundar un club secreto de lucha, donde poder descargar sus frustaciones y su ira, que tendrá un éxito arrollador.",
                Director = "David Fincher",
                Duracion = 139,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img3.acsta.net/c_200_200/pictures/15/11/24/16/53/595385.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img3.acsta.net/r_1920_1080/img/23/b7/23b757ce995171ae05ba7449c67a47dc.jpg",
                CategoriaId = 2,
                PegiId = 5
            },
            new Peliculas
            {
                Id = 4,
                Nombre = "Spider-Man 2",
                Descripcion = "Han pasado dos años desde que el tranquilo Peter Parker dejó a Mary Jane Watson, su gran amor, y decidió seguir asumiendo sus responsabilidades como Spider-Man. Peter debe afrontar nuevos desafíos mientras lucha contra el don y la maldición de sus poderes equilibrando sus dos identidades: el escurridizo superhéroe Spider-Man y el estudiante universitario. Las relaciones con las personas que más aprecia están ahora en peligro de ser descubiertas con la aparición del poderoso villano de múltiples tentáculos Doctor Octopus, Doc Ock.",
                Director = "Sam Raimi",
                Duracion = 127,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/35/16/02/18380826.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/35/16/02/18380826.jpg",
                CategoriaId = 1,
                PegiId = 4
            },
            new Peliculas
            {
                Id = 5,
                Nombre = "Aladdin",
                Descripcion = "Basada en el famoso cuento Aladino y la lámpara maravillosa, la trama se sitúa en el exótico paisaje del mítico reino árabe de Agrabah. Aladdin es un ingenioso joven que, a pesar de vivir en un estado de extrema pobreza, sueña con casarse con la bella hija del sultán, la princesa Yasmin. El destino interviene cuando el astuto visir del Sultán, Yafar, recluta a Aladdin para que le ayude a recuperar una lámpara mágica de las profundidades de la Cueva de las Maravillas. El joven encuentra la lámpara, en la que vive un genio que concede tres deseos a quien lo libere.",
                Director = "John Musker, Ron Clements",
                Duracion = 87,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img3.acsta.net/r_1920_1080/img/6c/02/6c022db26a46682b554a0e43a896de17.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img3.acsta.net/r_1920_1080/img/6c/02/6c022db26a46682b554a0e43a896de17.jpg",
                CategoriaId = 1,
                PegiId = 1
            }
            );
            modelBuilder.Entity<Series>().HasData(
            new Series
            {
                Id = 1,
                Nombre = "Juego de tronos",
                Descripcion = "La serie sigue las múltiples tramas de la saga Canción de hielo y fuego.2​ Comienza cuando el Rey Robert Baratheon (Mark Addy) le pide a su viejo amigo Ned Stark (Sean Bean) que realice la función de nuevo consejero real (cargo conocido como la Mano del Rey). La esposa de Ned, Catelyn (Michelle Fairley) recibe una carta de su hermana, Lysa (Kate Dickie) que le da razones para creer que la Casa Lannister, a la cual pertenece Cersei, la esposa del rey, está involucrada en la muerte de la anterior Mano del Rey. Ned debe viajar al sur con el Rey para descubrir el asesino de la Mano del Rey muerto, Jon Arryn (John Standing) y a la misma vez proteger a su familia de los Lannister. Mientras descubre las razones detrás de la muerte de Jon, desentierra el oscuro secreto concerniente a los Lannister que el propio Arryn murió tratando de revelar. ",
                Director = "David Benioff",
                Temporada = 1,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg",
                Valoracion = 5,
                ImageUrl = "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg",
                CategoriaId = 1,
                PegiId = 2,
                HaTerminado = true,
            },
            new Series
            {
                Id = 2,
                Nombre = "Breaking Bad",
                Descripcion = "Walter White decide entrar en el mundo de las drogas ilegales después de que le diagnosticaran cáncer de pulmón. Al ser profesor de química, utiliza sus conocimientos y habilidades para elaborar una metanfetamina junto a un antiguo alumno, Jesse Pinkman (Aaron Paul). Durante sus primeros días, como productores de droga, tienen varios problemas con los distribuidores locales. Además, empiezan a ser famosos, gracias a la droga que producen, y amplian territorio. Walt se crea un apodo, Heisenberg, para darse a conocer en su segunda vida.",
                Director = "Vince Gilligan",
                Temporada = 1,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://m.media-amazon.com/images/I/91kI5AXwz9L._SY445_.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img2.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1237965.jpg",
                CategoriaId = 1,
                PegiId = 2,
                HaTerminado = true,
            },
            new Series
            {
                Id = 3,
                Nombre = "Breaking Bad",
                Descripcion = "Walter decide seguir con el negocio a pesar de todos los conflictos que conlleva. Además, se ve obligado a contratar los servicios de un abogado deshonesto, Saul Goodman, para ayudar al traficante Badger después que fuese arrestado por la policía. Combo, otro de los distribuidores, es asesinado por una banda rival. Mientras todo esto sucede, Jesse comienza una relación con Jane, una joven que se está recuperando de su adicción a las drogas, y Walt encuentra un nuevo socio llamado Gus. Al final de la temporada, la esposa de Walter comienza a sospechar sobre la segunda vida de su marido.",
                Director = "Vince Gilligan",
                Temporada = 2,
                FechaEstreno = System.DateTime.Today,
                UrlDescarga = "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1597342.jpg",
                Valoracion = 5,
                ImageUrl = "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/07/23/11/26/1597342.jpg",
                CategoriaId = 1,
                PegiId = 2,
                HaTerminado = true,
            }

            );
            
            modelBuilder.Entity<Pegi>().HasData(
            new Pegi
            {
                Id = 1,
                EdadMin = "Pegi 3",
                PegiEdad = 3
            }, new Pegi
            {
                Id = 5,
                EdadMin = "Pegi 7",
                PegiEdad = 7
            },
            new Pegi
            {
                Id = 2,
                EdadMin = "Pegi 12",
                PegiEdad = 12
            }, new Pegi
            {
                Id = 3,
                EdadMin = "Pegi 16",
                PegiEdad = 16
            }, new Pegi
            {
                Id = 4,
                EdadMin = "Pegi 18",
                PegiEdad = 18
            }
            );
            modelBuilder.Entity<Categoria>().HasData(
            new Categoria
            {
                Id = 1,
                Name = "Ficcion"
            },
            new Categoria
            {
                Id = 2,
                Name = "Accion"
            }, new Categoria
            {
                Id = 3,
                Name = "Romance"
            }, new Categoria
            {
                Id = 4,
                Name = "Thriller"
            }, new Categoria
            {
                Id = 5,
                Name = "Terror"
            }
            );

            modelBuilder.Entity<RoleHasMenu>().HasData(
                new RoleHasMenu
                {
                ID = 9,
                MenuID = 9,
                RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 10,
                    MenuID = 10,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 1,
                    MenuID = 1,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 2,
                    MenuID = 2,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 3,
                    MenuID = 3,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 4,
                    MenuID = 4,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 5,
                    MenuID = 5,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 6,
                    MenuID = 6,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 7,
                    MenuID = 7,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 8,
                    MenuID = 8,
                    RoleID = 1
                },

                new RoleHasMenu
                {
                    ID = 11,
                    MenuID = 11,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 14,
                    MenuID = 9,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 15,
                    MenuID = 10,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 12,
                    MenuID = 4,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 13,
                    MenuID = 8,
                    RoleID = 2
                },

                new RoleHasMenu
                {
                    ID = 16,
                    MenuID = 11,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 17,
                    MenuID = 9,
                    RoleID = 3
                },
                new RoleHasMenu
                {
                    ID = 18,
                    MenuID = 10,
                    RoleID = 3
                },
                new RoleHasMenu
                {
                    ID = 19,
                    MenuID = 12,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 20,
                    MenuID = 12,
                    RoleID = 1
                },
                new RoleHasMenu
                {
                    ID = 21,
                    MenuID = 13,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 22,
                    MenuID = 13,
                    RoleID = 1
                }
            );

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    ID = 1,
                    Name = "admin",
                    Surname = "min",
                    Phone = "642443212",
                    CuentaUsuarioID = 1
                },
                new Admin
                {
                    ID = 2,
                    Name = "administrador",
                    Surname = "pp",
                    Phone = "642443213",
                    CuentaUsuarioID = 2
                }
            );

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    ID = 1,
                    Name = "worker",
                    Surname = "wer",
                    Phone = "642443214",
                    CuentaUsuarioID = 5
                },
                new Worker
                {
                    ID = 2,
                    Name = "worker",
                    Surname = "worke",
                    Phone = "642443217",
                    CuentaUsuarioID = 6
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    ID = 1,
                    Name = "customer",
                    Surname = "custo",
                    Phone = "642443234",
                    Address = "Avenida M",
                    CuentaUsuarioID = 3
                },
                new Customer
                {
                    ID = 2,
                    Name = "customer",
                    Surname = "custo",
                    Phone = "642443265",
                    Address = "Avenida M",
                    CuentaUsuarioID = 4
                }
            );
        }

        public DbSet<CinemasRafa.DTOs.AdminDto> AdminDto { get; set; }

        public DbSet<CinemasRafa.DTOs.CustomerDto> CustomerDto { get; set; }

        public DbSet<CinemasRafa.DTOs.WorkerDto> WorkerDto { get; set; }
    }
}
