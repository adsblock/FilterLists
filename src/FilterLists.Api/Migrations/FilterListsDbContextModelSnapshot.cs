﻿// <auto-generated />
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FilterLists.Api.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    partial class FilterListsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriptionSourceUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DiscontinuedDate");

                    b.Property<string>("DonateUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("NVARCHAR(126)");

                    b.Property<string>("ForumUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssuesUrl")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LicenseId");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126) NOT NULL");

                    b.Property<string>("SubmissionUrl")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SyntaxId");

                    b.Property<string>("ViewUrl")
                        .HasColumnType("TEXT NOT NULL");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("filterlists");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListLanguage", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("LanguageId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("FilterListId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("filterlists_languages");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListMaintainer", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("MaintainerId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("FilterListId", "MaintainerId");

                    b.HasIndex("MaintainerId");

                    b.ToTable("filterlists_maintainers");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListRule", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("RuleId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("FilterListId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("filterlists_rules");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Fork", b =>
                {
                    b.Property<int>("ForkFilterListId");

                    b.Property<int>("UpstreamFilterListId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("ForkFilterListId", "UpstreamFilterListId");

                    b.HasIndex("UpstreamFilterListId");

                    b.ToTable("forks");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Merge", b =>
                {
                    b.Property<int>("MergeFilterListId");

                    b.Property<int>("UpstreamFilterListId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("MergeFilterListId", "UpstreamFilterListId");

                    b.HasIndex("UpstreamFilterListId");

                    b.ToTable("merges");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SoftwareSyntax", b =>
                {
                    b.Property<int>("SoftwareId");

                    b.Property<int>("SyntaxId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.HasKey("SoftwareId", "SyntaxId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("software_syntaxes");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("Iso6391")
                        .HasColumnType("NVARCHAR(2)");

                    b.Property<string>("Iso6392")
                        .HasColumnType("NVARCHAR(3)");

                    b.Property<string>("Iso6392B")
                        .HasColumnType("NVARCHAR(3)");

                    b.Property<string>("Iso6392T")
                        .HasColumnType("NVARCHAR(3)");

                    b.Property<string>("Iso6393")
                        .HasColumnType("NVARCHAR(3)");

                    b.Property<string>("LocalName")
                        .HasColumnType("NVARCHAR(126)");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126)");

                    b.HasKey("Id");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("DescriptionUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126) NOT NULL");

                    b.Property<bool>("PermissiveAdaptation");

                    b.Property<bool>("PermissiveCommercial");

                    b.HasKey("Id");

                    b.ToTable("licenses");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Maintainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("NVARCHAR(126)");

                    b.Property<string>("HomeUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126) NOT NULL");

                    b.Property<string>("TwitterHandle")
                        .HasColumnType("NVARCHAR(126)");

                    b.HasKey("Id");

                    b.ToTable("maintainers");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("Raw")
                        .HasColumnType("NVARCHAR(2083) NOT NULL");

                    b.HasKey("Id");

                    b.ToTable("rules");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("DownloadUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126) NOT NULL");

                    b.HasKey("Id");

                    b.ToTable("software");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Syntax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT UNSIGNED");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");

                    b.Property<string>("DefinitionUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(126) NOT NULL");

                    b.HasKey("Id");

                    b.ToTable("syntaxes");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.License")
                        .WithMany("FilterLists")
                        .HasForeignKey("LicenseId");

                    b.HasOne("FilterLists.Data.Entities.Syntax")
                        .WithMany("FilterLists")
                        .HasForeignKey("SyntaxId");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListLanguage", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Language", "Language")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListMaintainer", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Maintainer", "Maintainer")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("MaintainerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListRule", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListRules")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Rule", "Rule")
                        .WithMany("FilterListRules")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Fork", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "ForkFilterList")
                        .WithMany()
                        .HasForeignKey("ForkFilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.FilterList", "UpstreamFilterList")
                        .WithMany()
                        .HasForeignKey("UpstreamFilterListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Merge", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "MergeFilterList")
                        .WithMany()
                        .HasForeignKey("MergeFilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.FilterList", "UpstreamFilterList")
                        .WithMany()
                        .HasForeignKey("UpstreamFilterListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SoftwareSyntax", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.Software", "Software")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Syntax", "Syntax")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SyntaxId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
