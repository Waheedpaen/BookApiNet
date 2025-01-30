﻿// <auto-generated />
using System;
using EntitiesClasses.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntitiesClasses.Migrations
{
    [DbContext(typeof(DataContexts))]
    partial class DataContextsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntitiesClasses.Entitie.ChatGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("ChatGroups");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.AudioDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AudioScholarsId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRelase")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Dislikes")
                        .HasColumnType("bigint");

                    b.Property<string>("FileNameAudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePathAudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("Likes")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AudioScholarsId");

                    b.ToTable("AudioDetail");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.AudioScholars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AudioScholares");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePathImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ScholarId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ScholarId");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookDetailId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileNamePDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePathPDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookDetailId");

                    b.ToTable("BookImages");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.EmailVerificationCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailVerificationCodes");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.FarqaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookCategoryId");

                    b.ToTable("FarqaCategories");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.GroupMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attachment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("MessageFromUserId")
                        .HasColumnType("int");

                    b.Property<int?>("MessageReplyId")
                        .HasColumnType("int");

                    b.Property<string>("MessageToUserIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MessageFromUserId");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MadrassaClassId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MadrassaClassId");

                    b.ToTable("MadrassaBooks");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaBookCatgory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileNamePDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePathPDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("MadrassaBookId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MadrassaBookId");

                    b.ToTable("MadrassaBookCatgories");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MadrassaClasses");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileNameAudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePathAudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MessageReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attachment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<string>("Reply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReplyFromUserId")
                        .HasColumnType("int");

                    b.Property<int?>("ReplyToUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("ReplyFromUserId");

                    b.HasIndex("ReplyToUserId");

                    b.ToTable("MessageReplies");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MonthlyMagzine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileNamePDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePathPDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MonthlyMagzines");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.Scholar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("FarqaCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MadrassaName")
                        .IsRequired()
                        .HasColumnType("varchar(900)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FarqaCategoryId");

                    b.ToTable("Scholars");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsOnlined")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastActive")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastLogout")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Offline")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserTypesId")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<int>("updatebyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserTypesId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.UserTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.Visitors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("VisitorsTimes")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("EntitiesClasses.Entitie.ChatGroup", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.AudioDetail", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.AudioScholars", "AudioScholars")
                        .WithMany()
                        .HasForeignKey("AudioScholarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AudioScholars");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookDetail", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.Scholar", "Scholar")
                        .WithMany()
                        .HasForeignKey("ScholarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scholar");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookImage", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.BookDetail", "BookDetail")
                        .WithMany("BookImages")
                        .HasForeignKey("BookDetailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.FarqaCategory", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.BookCategory", "BookCategory")
                        .WithMany()
                        .HasForeignKey("BookCategoryId");

                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.GroupMessage", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.User", "MessageFromUser")
                        .WithMany()
                        .HasForeignKey("MessageFromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MessageFromUser");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaBook", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.MadrassaClass", "MadrassaClass")
                        .WithMany()
                        .HasForeignKey("MadrassaClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MadrassaClass");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaBookCatgory", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.MadrassaBook", "MadrassaBook")
                        .WithMany("MadrassaBookCatgories")
                        .HasForeignKey("MadrassaBookId");

                    b.Navigation("MadrassaBook");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.Message", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EntitiesClasses.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MessageReply", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitiesClasses.Entities.User", "ReplyFromUser")
                        .WithMany()
                        .HasForeignKey("ReplyFromUserId");

                    b.HasOne("EntitiesClasses.Entities.User", "ReplyToUser")
                        .WithMany()
                        .HasForeignKey("ReplyToUserId");

                    b.Navigation("Message");

                    b.Navigation("ReplyFromUser");

                    b.Navigation("ReplyToUser");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.Scholar", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.FarqaCategory", "FarqaCategory")
                        .WithMany()
                        .HasForeignKey("FarqaCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FarqaCategory");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.User", b =>
                {
                    b.HasOne("EntitiesClasses.Entities.UserTypes", "UserTypes")
                        .WithMany()
                        .HasForeignKey("UserTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserTypes");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.BookDetail", b =>
                {
                    b.Navigation("BookImages");
                });

            modelBuilder.Entity("EntitiesClasses.Entities.MadrassaBook", b =>
                {
                    b.Navigation("MadrassaBookCatgories");
                });
#pragma warning restore 612, 618
        }
    }
}
