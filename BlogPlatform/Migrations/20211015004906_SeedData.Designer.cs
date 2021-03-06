// <auto-generated />
using System;
using BlogPlatform;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20211015004906_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatName = "Dance Steps"
                        },
                        new
                        {
                            Id = 2,
                            CatName = "Music"
                        },
                        new
                        {
                            Id = 3,
                            CatName = "Social Dancing"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Now")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Deserae Florentine",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 3,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "How To Get a Man To Ask You To Dance"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Brandon Bell",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 1,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Best Dancing Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Julio Santiago",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 2,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "90's Bachata"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Neil Potbelly",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 2,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Who Is The Best Salsa Singer Of All Time: Marc Anthony Or Hector Lavoe?"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Brittany Rabbit",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 2,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Do You Need To Know Spanish To Appreciate Bachata Music?"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Donna Doleur",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 1,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "What Is The Hardest Latin Dance To Learn?"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Randy Super",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 3,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dancing Couple's Guide To Navigating Jealousy"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Kay Dee",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 2,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Five Salsa Moves You Should Know"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Maria Reuben",
                            Body = "Body body body body body body body body body body body body body body body body body",
                            CategoryId = 3,
                            Now = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Important Milonga Etiquette"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.HasOne("BlogPlatform.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Navigation("Contents");
                });
#pragma warning restore 612, 618
        }
    }
}
