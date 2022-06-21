﻿// <auto-generated />
using System;
using DataAccess.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Implementation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220330142643_AssignedTest")]
    partial class AssignedTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.AnswerOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<long?>("QuestionWithAnswerOptionsId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionWithAnswerOptionsId");

                    b.ToTable("AnswerOptions");
                });

            modelBuilder.Entity("Entities.AssignedTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TestId");

                    b.ToTable("AssignedTests");
                });

            modelBuilder.Entity("Entities.Participants.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParticipantType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Participants");

                    b.HasDiscriminator<string>("ParticipantType").HasValue("Participant");
                });

            modelBuilder.Entity("Entities.Participants.ParticipantRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Entities.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Questiontype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasDiscriminator<string>("Questiontype").HasValue("Question");
                });

            modelBuilder.Entity("Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Entities.Participants.Admin", b =>
                {
                    b.HasBaseType("Entities.Participants.Participant");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Entities.Participants.Student", b =>
                {
                    b.HasBaseType("Entities.Participants.Participant");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Entities.Participants.Teacher", b =>
                {
                    b.HasBaseType("Entities.Participants.Participant");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Entities.QuestionWithAnswerOptions", b =>
                {
                    b.HasBaseType("Entities.Question");

                    b.HasDiscriminator().HasValue("AnswerOptions");
                });

            modelBuilder.Entity("Entities.QuestionWithFileAnswer", b =>
                {
                    b.HasBaseType("Entities.Question");

                    b.HasDiscriminator().HasValue("FileAnswer");
                });

            modelBuilder.Entity("Entities.QuestionWithTextAnswer", b =>
                {
                    b.HasBaseType("Entities.Question");

                    b.HasDiscriminator().HasValue("TextAnswer");
                });

            modelBuilder.Entity("Entities.AnswerOption", b =>
                {
                    b.HasOne("Entities.QuestionWithAnswerOptions", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionWithAnswerOptionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.AssignedTest", b =>
                {
                    b.HasOne("Entities.Participants.Student", null)
                        .WithMany("AssignedTests")
                        .HasForeignKey("StudentId");

                    b.HasOne("Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Entities.Participants.Participant", b =>
                {
                    b.HasOne("Entities.Participants.ParticipantRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Question", b =>
                {
                    b.HasOne("Entities.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Test", b =>
                {
                    b.HasOne("Entities.Participants.Teacher", null)
                        .WithMany("CreatedTests")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Entities.Participants.Student", b =>
                {
                    b.Navigation("AssignedTests");
                });

            modelBuilder.Entity("Entities.Participants.Teacher", b =>
                {
                    b.Navigation("CreatedTests");
                });

            modelBuilder.Entity("Entities.QuestionWithAnswerOptions", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
