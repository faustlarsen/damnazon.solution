﻿// <auto-generated />
using System;
using Damnazon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Damnazon.Migrations
{
    [DbContext(typeof(DamnazonContext))]
    partial class DamnazonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Damnazon.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Damnazon.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName");

                    b.Property<string>("ThumbnailImage");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Shop Jeff Bezos financial assets!",
                            CategoryName = "Assets",
                            ThumbnailImage = "\\img\\assett2.jpg"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Shop Jeff Bezos properties!",
                            CategoryName = "Properties",
                            ThumbnailImage = "\\img\\properties.jpg"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Shop Jeff Bezos vehicles!",
                            CategoryName = "Vehicles",
                            ThumbnailImage = "\\img\\vehicles.jpg"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Shop Jeff Bezos personal items!",
                            CategoryName = "Items",
                            ThumbnailImage = "\\img\\items.jpg"
                        });
                });

            modelBuilder.Entity("Damnazon.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Damnazon.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDamnazonSlime");

                    b.Property<bool>("IsDamnazonsChoice");

                    b.Property<bool>("IsInStock");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("ProductPrice");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Image = "\\img\\blueOrigin.jpg",
                            IsDamnazonSlime = true,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Blue Origin, LLC is an American privately funded aerospace manufacturer and sub-orbital spaceflight services company headquartered in Kent, Washington.",
                            ProductName = "Blue Origin",
                            ProductPrice = 20000000m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Image = "\\img\\washingtonPost.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "The Washington Post is an ancient newspaper dating back to 1877, adapting and transforming to fit the modern era. Nowadays, the Post is primarily a popular online news source featuring reliant information and a touch of tradition.",
                            ProductName = "Washington Post",
                            ProductPrice = 250000000m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Image = "\\img\\wholeFoods.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Whole Foods Market, Inc. is an American multinational supermarket chain headquartered in Austin, Texas, which sells products free from hydrogenated fats and artificial colors, flavors, and preservatives.",
                            ProductName = "Whole Foods",
                            ProductPrice = 14000000000m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Image = "\\img\\seattleLakehouse.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "One of his most popular homes is this Seattle mansion, located less than a mile from one of Bill Gates's favorite houses.",
                            ProductName = "Seattle Lake House",
                            ProductPrice = 10000000m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Image = "\\img\\largestHouseInDc.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "The gigantic mansion used to be a textile museum and features a bold, extravagant exterior perfect for a man of Bezos’ stature.",
                            ProductName = "Largest house in Washington D.C.",
                            ProductPrice = 23000000m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Image = "\\img\\gulfstreamPrivateJet.jpg",
                            IsDamnazonSlime = true,
                            IsDamnazonsChoice = false,
                            IsInStock = false,
                            ProductDescription = "Gulfstream G-650ER one of the fastest in the world, but it’s also all decked out to resemble a Michelin-starred restaurant more than a plane.",
                            ProductName = "Gulfstream Private Jet",
                            ProductPrice = 65000000m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Image = "\\img\\hondaAccord.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "This was the first car purchase by Amazon boss, This 1997 Honda Accord  four-cylinder engine, air conditioning, AM/FM/cassette radio, automatic transmission, power locks and windows",
                            ProductName = "1997 Honda Accord",
                            ProductPrice = 4000m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            Image = "\\img\\clock.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "this clock is unique because it is designed to keep time for 10,000 years. Jeff Bezos invested in this in order to have the means to embody the abstract longevity of time itself",
                            ProductName = "10,000-Year Clock",
                            ProductPrice = 42000000m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            Image = "\\img\\watch.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Overly priced Rolex that once belonged to Jeff Bezos.",
                            ProductName = "Rolex",
                            ProductPrice = 200000m
                        });
                });

            modelBuilder.Entity("Damnazon.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Damnazon.Models.Product", b =>
                {
                    b.HasOne("Damnazon.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Damnazon.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Damnazon.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Damnazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Damnazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Damnazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Damnazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
