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
        public DbSet<CinemasRafa.Models.Comida> Comida { get; set; }
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
                    Controller = "Workers",
                    Action = "Index",
                    Label = "Workers"
                }, 
                new Menu
                {
                    ID = 4,
                    Controller = "Customers",
                    Action = "Index",
                    Label = "Customers"
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
                    Controller = "Comidas",
                    Action = "Index",
                    Label = "Comidas"
                }, 
                new Menu
                {
                    ID = 11,
                    Controller = "Categorias",
                    Action = "Index",
                    Label = "Categorias"
                }
            );

            modelBuilder.Entity<RoleHasMenu>().HasData(
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
                    ID = 11,
                    MenuID = 11,
                    RoleID = 1
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
                    ID = 16,
                    MenuID = 11,
                    RoleID = 2
                },
                new RoleHasMenu
                {
                    ID = 17,
                    MenuID = 8,
                    RoleID = 3
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
/*
        public DbSet<CinemasRafa.DTOs.AdminDto> AdminDto { get; set; }

        public DbSet<CinemasRafa.DTOs.CustomerDto> CustomerDto { get; set; }

        public DbSet<CinemasRafa.DTOs.WorkerDto> WorkerDto { get; set; }*/
    }
}
