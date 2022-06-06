﻿// <auto-generated />
using System;
using CinemasRafa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemasRafa.Migrations
{
    [DbContext(typeof(ControlContext))]
    partial class ControlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemasRafa.DTOs.AdminDto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("AdminDto");
                });

            modelBuilder.Entity("CinemasRafa.DTOs.CustomerDto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("CustomerDto");
                });

            modelBuilder.Entity("CinemasRafa.DTOs.WorkerDto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("WorkerDto");
                });

            modelBuilder.Entity("CinemasRafa.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaUsuarioID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ID");

                    b.HasIndex("CuentaUsuarioID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CuentaUsuarioID = 1,
                            Name = "admin",
                            Phone = "642443212",
                            Surname = "min"
                        },
                        new
                        {
                            ID = 2,
                            CuentaUsuarioID = 2,
                            Name = "administrador",
                            Phone = "642443213",
                            Surname = "pp"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("CinemasRafa.Models.CuentaUsuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("CuentaUsuario");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            Email = "admin1@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 1,
                            Username = "admin1"
                        },
                        new
                        {
                            ID = 2,
                            Active = false,
                            Email = "admin2@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 1,
                            Username = "admin2"
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            Email = "customer1@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 3,
                            Username = "customer1"
                        },
                        new
                        {
                            ID = 4,
                            Active = false,
                            Email = "customer2@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 3,
                            Username = "customert2"
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            Email = "worker1@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 2,
                            Username = "worker1"
                        },
                        new
                        {
                            ID = 6,
                            Active = false,
                            Email = "worker2@hotmail.com",
                            Password = "QQBsAHQAYQBpAHIAMQAyADMAJAAlAA==",
                            RoleID = 2,
                            Username = "worker2"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("CuentaUsuarioID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ID");

                    b.HasIndex("CuentaUsuarioID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Avenida M",
                            CuentaUsuarioID = 3,
                            Name = "customer",
                            Phone = "642443234",
                            Surname = "custo"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Avenida M",
                            CuentaUsuarioID = 4,
                            Name = "customer",
                            Phone = "642443265",
                            Surname = "custo"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Action = "Index",
                            Controller = "CuentaUsuarios",
                            Label = "Cuentas"
                        },
                        new
                        {
                            ID = 2,
                            Action = "Index",
                            Controller = "Admins",
                            Label = "Administradores"
                        },
                        new
                        {
                            ID = 3,
                            Action = "Index",
                            Controller = "Workers",
                            Label = "Workers"
                        },
                        new
                        {
                            ID = 4,
                            Action = "Index",
                            Controller = "Customers",
                            Label = "Customers"
                        },
                        new
                        {
                            ID = 5,
                            Action = "Index",
                            Controller = "Menus",
                            Label = "Menus"
                        },
                        new
                        {
                            ID = 6,
                            Action = "Index",
                            Controller = "RoleHasMenus",
                            Label = "RoleMenus"
                        },
                        new
                        {
                            ID = 7,
                            Action = "Index",
                            Controller = "Roles",
                            Label = "Roles"
                        },
                        new
                        {
                            ID = 8,
                            Action = "Index",
                            Controller = "Pegis",
                            Label = "Pegis"
                        },
                        new
                        {
                            ID = 9,
                            Action = "Index",
                            Controller = "Peliculas",
                            Label = "Peliculas"
                        },
                        new
                        {
                            ID = 10,
                            Action = "Index",
                            Controller = "Series",
                            Label = "Series"
                        },
                        new
                        {
                            ID = 11,
                            Action = "Index",
                            Controller = "Categorias",
                            Label = "Categorias"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Pegi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EdadMin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PegiEdad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pegi");
                });

            modelBuilder.Entity("CinemasRafa.Models.Peliculas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PegiId")
                        .HasColumnType("int");

                    b.Property<string>("UrlDescarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valoracion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PegiId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("CinemasRafa.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Enabled = true,
                            RoleDescription = "Admin rol",
                            RoleName = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Enabled = true,
                            RoleDescription = "Worker rol",
                            RoleName = "Worker"
                        },
                        new
                        {
                            ID = 3,
                            Enabled = true,
                            RoleDescription = "Customer rol",
                            RoleName = "Customer"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.RoleHasMenu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("RoleID");

                    b.ToTable("RoleHasMenu");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            MenuID = 1,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 2,
                            MenuID = 2,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 3,
                            MenuID = 3,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 4,
                            MenuID = 4,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 5,
                            MenuID = 5,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 6,
                            MenuID = 6,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 7,
                            MenuID = 7,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 8,
                            MenuID = 8,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 9,
                            MenuID = 9,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 10,
                            MenuID = 10,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 11,
                            MenuID = 11,
                            RoleID = 1
                        },
                        new
                        {
                            ID = 12,
                            MenuID = 4,
                            RoleID = 2
                        },
                        new
                        {
                            ID = 13,
                            MenuID = 8,
                            RoleID = 2
                        },
                        new
                        {
                            ID = 14,
                            MenuID = 9,
                            RoleID = 2
                        },
                        new
                        {
                            ID = 15,
                            MenuID = 10,
                            RoleID = 2
                        },
                        new
                        {
                            ID = 16,
                            MenuID = 11,
                            RoleID = 2
                        },
                        new
                        {
                            ID = 17,
                            MenuID = 9,
                            RoleID = 3
                        },
                        new
                        {
                            ID = 18,
                            MenuID = 10,
                            RoleID = 3
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HaTerminado")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PegiId")
                        .HasColumnType("int");

                    b.Property<string>("Temporada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlDescarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valoracion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PegiId");

                    b.ToTable("Serie");
                });

            modelBuilder.Entity("CinemasRafa.Models.Worker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaUsuarioID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ID");

                    b.HasIndex("CuentaUsuarioID");

                    b.ToTable("Worker");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CuentaUsuarioID = 5,
                            Name = "worker",
                            Phone = "642443214",
                            Surname = "wer"
                        },
                        new
                        {
                            ID = 2,
                            CuentaUsuarioID = 6,
                            Name = "worker",
                            Phone = "642443217",
                            Surname = "worke"
                        });
                });

            modelBuilder.Entity("CinemasRafa.Models.Admin", b =>
                {
                    b.HasOne("CinemasRafa.Models.CuentaUsuario", "CuentaUsuario")
                        .WithMany()
                        .HasForeignKey("CuentaUsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CuentaUsuario");
                });

            modelBuilder.Entity("CinemasRafa.Models.CuentaUsuario", b =>
                {
                    b.HasOne("CinemasRafa.Models.Role", "Role")
                        .WithMany("CuentaUsuarios")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CinemasRafa.Models.Customer", b =>
                {
                    b.HasOne("CinemasRafa.Models.CuentaUsuario", "CuentaUsuario")
                        .WithMany()
                        .HasForeignKey("CuentaUsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CuentaUsuario");
                });

            modelBuilder.Entity("CinemasRafa.Models.Peliculas", b =>
                {
                    b.HasOne("CinemasRafa.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemasRafa.Models.Pegi", "Pegi")
                        .WithMany()
                        .HasForeignKey("PegiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Pegi");
                });

            modelBuilder.Entity("CinemasRafa.Models.RoleHasMenu", b =>
                {
                    b.HasOne("CinemasRafa.Models.Menu", "Menu")
                        .WithMany("RoleHasMenus")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemasRafa.Models.Role", "Role")
                        .WithMany("RoleHasMenus")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CinemasRafa.Models.Series", b =>
                {
                    b.HasOne("CinemasRafa.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemasRafa.Models.Pegi", "Pegi")
                        .WithMany()
                        .HasForeignKey("PegiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Pegi");
                });

            modelBuilder.Entity("CinemasRafa.Models.Worker", b =>
                {
                    b.HasOne("CinemasRafa.Models.CuentaUsuario", "CuentaUsuario")
                        .WithMany()
                        .HasForeignKey("CuentaUsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CuentaUsuario");
                });

            modelBuilder.Entity("CinemasRafa.Models.Menu", b =>
                {
                    b.Navigation("RoleHasMenus");
                });

            modelBuilder.Entity("CinemasRafa.Models.Role", b =>
                {
                    b.Navigation("CuentaUsuarios");

                    b.Navigation("RoleHasMenus");
                });
#pragma warning restore 612, 618
        }
    }
}
