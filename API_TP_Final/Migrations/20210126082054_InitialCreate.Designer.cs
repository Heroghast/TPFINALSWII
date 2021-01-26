﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using API_TP_Final;

namespace API_TP_Final.Migrations
{
    [DbContext(typeof(TPContext))]
    [Migration("20210126082054_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SWII_TP_Final.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdUsuarioCadastro")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioUpdate")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuarioCadastro");

                    b.HasIndex("IdUsuarioUpdate");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SWII_TP_Final.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SWII_TP_Final.Models.Produto", b =>
                {
                    b.HasOne("SWII_TP_Final.Models.Usuario", "UsuarioCadastro")
                        .WithMany()
                        .HasForeignKey("IdUsuarioCadastro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWII_TP_Final.Models.Usuario", "UsuarioUpdate")
                        .WithMany()
                        .HasForeignKey("IdUsuarioUpdate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioCadastro");

                    b.Navigation("UsuarioUpdate");
                });
#pragma warning restore 612, 618
        }
    }
}
