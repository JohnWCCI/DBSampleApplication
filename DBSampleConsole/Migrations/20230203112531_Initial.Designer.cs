// <auto-generated />
using System;
using DBSampleConsole.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBSampleConsole.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230203112531_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DBSampleConsole.Models.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1050,
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            Id = 4022,
                            Credits = 3,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            Id = 4041,
                            Credits = 3,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            Id = 1045,
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            Id = 3141,
                            Credits = 4,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            Id = 2021,
                            Credits = 3,
                            Title = "Composition"
                        },
                        new
                        {
                            Id = 2042,
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("DBSampleConsole.Models.EnrollmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseID = 1050,
                            Grade = 0,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseID = 4022,
                            Grade = 2,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseID = 4041,
                            Grade = 1,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseID = 1045,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 5,
                            CourseID = 3141,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseID = 2021,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseID = 1050,
                            Grade = 1,
                            StudentID = 3
                        },
                        new
                        {
                            Id = 8,
                            CourseID = 1050,
                            Grade = 1,
                            StudentID = 4
                        },
                        new
                        {
                            Id = 9,
                            CourseID = 4022,
                            Grade = 4,
                            StudentID = 4
                        },
                        new
                        {
                            Id = 10,
                            CourseID = 4041,
                            Grade = 2,
                            StudentID = 5
                        },
                        new
                        {
                            Id = 11,
                            CourseID = 1045,
                            Grade = 1,
                            StudentID = 6
                        },
                        new
                        {
                            Id = 12,
                            CourseID = 3141,
                            Grade = 0,
                            StudentID = 7
                        });
                });

            modelBuilder.Entity("DBSampleConsole.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            Id = 3,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            Id = 4,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            Id = 5,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            Id = 6,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            Id = 7,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            Id = 8,
                            EnrollmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("DBSampleConsole.Models.EnrollmentModel", b =>
                {
                    b.HasOne("DBSampleConsole.Models.CourseModel", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBSampleConsole.Models.StudentModel", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DBSampleConsole.Models.CourseModel", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("DBSampleConsole.Models.StudentModel", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
