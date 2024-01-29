﻿// <auto-generated />
using KarmaLympics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KarmaLympics.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240129103339_ReseedingDatabase")]
    partial class ReseedingDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KarmaLympics.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChallengeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GivenPoints")
                        .HasColumnType("int");

                    b.Property<int>("MaxPoints")
                        .HasColumnType("int");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<string>("Solution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("KarmaLympics.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("KarmaLympics.Models.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<bool>("HostQuest")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("KarmaLympics.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("KarmaLympics.Models.TeamQuest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamQuests");
                });

            modelBuilder.Entity("KarmaLympics.Models.Challenge", b =>
                {
                    b.HasOne("KarmaLympics.Models.Quest", "Quest")
                        .WithMany("Challenges")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("KarmaLympics.Models.Quest", b =>
                {
                    b.HasOne("KarmaLympics.Models.Event", "Event")
                        .WithOne("Quest")
                        .HasForeignKey("KarmaLympics.Models.Quest", "EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("KarmaLympics.Models.Team", b =>
                {
                    b.HasOne("KarmaLympics.Models.Event", "Event")
                        .WithMany("Teams")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("KarmaLympics.Models.TeamQuest", b =>
                {
                    b.HasOne("KarmaLympics.Models.Quest", "Quest")
                        .WithMany("TeamQuests")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KarmaLympics.Models.Team", "Team")
                        .WithMany("TeamQuests")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Quest");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("KarmaLympics.Models.Event", b =>
                {
                    b.Navigation("Quest");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("KarmaLympics.Models.Quest", b =>
                {
                    b.Navigation("Challenges");

                    b.Navigation("TeamQuests");
                });

            modelBuilder.Entity("KarmaLympics.Models.Team", b =>
                {
                    b.Navigation("TeamQuests");
                });
#pragma warning restore 612, 618
        }
    }
}
