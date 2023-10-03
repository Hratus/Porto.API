﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppBdContext))]
    partial class AppBdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlunoEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("AlunoFaculdade")
                        .HasColumnType("longtext");

                    b.Property<string>("AlunoMentor")
                        .HasColumnType("longtext");

                    b.Property<string>("AlunoNome")
                        .HasColumnType("longtext");

                    b.Property<byte>("AlunoSquad")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("AlunoTurma")
                        .HasColumnType("longtext");

                    b.Property<string>("AlunoTurno")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int?>("FaculdadeId")
                        .HasColumnType("int");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<byte?>("SquadId")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("AlunoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("FaculdadeId");

                    b.HasIndex("MentorId");

                    b.HasIndex("SquadId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("API.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmpresaIdNome")
                        .HasColumnType("longtext");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("API.Models.Faculdade", b =>
                {
                    b.Property<int>("FaculdadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FaculdadeEndereco")
                        .HasColumnType("longtext");

                    b.Property<string>("FaculdadeNome")
                        .HasColumnType("longtext");

                    b.HasKey("FaculdadeId");

                    b.ToTable("Faculdades");
                });

            modelBuilder.Entity("API.Models.Mentor", b =>
                {
                    b.Property<int>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("MentorEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("MentorLinkedInUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("MentorNome")
                        .HasColumnType("longtext");

                    b.HasKey("MentorId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("API.Models.Squad", b =>
                {
                    b.Property<byte>("SquadId")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<string>("SquadEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("SquadMenrtor")
                        .HasColumnType("longtext");

                    b.HasKey("SquadId");

                    b.HasIndex("MentorId");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("API.Models.Aluno", b =>
                {
                    b.HasOne("API.Models.Empresa", "Empresa")
                        .WithMany("Alunos")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("API.Models.Faculdade", "Faculdade")
                        .WithMany("Alunos")
                        .HasForeignKey("FaculdadeId");

                    b.HasOne("API.Models.Mentor", "Mentor")
                        .WithMany("Alunos")
                        .HasForeignKey("MentorId");

                    b.HasOne("API.Models.Squad", "Squad")
                        .WithMany("Alunos")
                        .HasForeignKey("SquadId");

                    b.Navigation("Empresa");

                    b.Navigation("Faculdade");

                    b.Navigation("Mentor");

                    b.Navigation("Squad");
                });

            modelBuilder.Entity("API.Models.Mentor", b =>
                {
                    b.HasOne("API.Models.Empresa", "Empresa")
                        .WithMany("Mentors")
                        .HasForeignKey("EmpresaId");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("API.Models.Squad", b =>
                {
                    b.HasOne("API.Models.Mentor", "Mentor")
                        .WithMany("Squads")
                        .HasForeignKey("MentorId");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("API.Models.Empresa", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Mentors");
                });

            modelBuilder.Entity("API.Models.Faculdade", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("API.Models.Mentor", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Squads");
                });

            modelBuilder.Entity("API.Models.Squad", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
