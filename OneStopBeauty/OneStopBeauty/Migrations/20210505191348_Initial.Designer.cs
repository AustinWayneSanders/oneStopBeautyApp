// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneStopBeauty.Data;

namespace OneStopBeauty.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210505191348_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("OneStopBeauty.Models.BillingStatement", b =>
                {
                    b.Property<int>("BillingStatementID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .IsRequired();

                    b.Property<int?>("EmployeeID");

                    b.Property<DateTime>("Invoice_Date");

                    b.Property<decimal>("Taxes");

                    b.Property<decimal>("Total_Price");

                    b.HasKey("BillingStatementID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("BillingStatements");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product_Name");

                    b.Property<string>("Purpose")
                        .HasMaxLength(50);

                    b.Property<decimal>("Unit_Price");

                    b.HasKey("InventoryID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("OneStopBeauty.Models.ItemOrdered", b =>
                {
                    b.Property<int>("ItemOrderedID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Arrived_Date_Ordered_Item");

                    b.Property<int?>("InventoryID");

                    b.Property<string>("Product_Code")
                        .HasMaxLength(3);

                    b.Property<DateTime>("Shipped_Date_Ordered_Item");

                    b.Property<int?>("SupplierID");

                    b.HasKey("ItemOrderedID");

                    b.HasIndex("InventoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("ItemsOrdered");
                });

            modelBuilder.Entity("OneStopBeauty.Models.ItemSold", b =>
                {
                    b.Property<int>("ItemSoldID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Arrived_Date_Sold_Item");

                    b.Property<int?>("BillingStatementID")
                        .IsRequired();

                    b.Property<double>("Discount");

                    b.Property<decimal>("Ext_Price");

                    b.Property<int?>("InventoryID");

                    b.Property<int?>("LocationID");

                    b.Property<bool>("Online");

                    b.Property<int>("Quantity");

                    b.Property<int?>("ServiceID");

                    b.Property<DateTime>("Shipped_Date_Sold_Item");

                    b.HasKey("ItemSoldID");

                    b.HasIndex("BillingStatementID");

                    b.HasIndex("InventoryID");

                    b.HasIndex("LocationID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ItemsSold");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasMaxLength(15);

                    b.Property<string>("Street_Address")
                        .HasMaxLength(100);

                    b.Property<string>("Zip_Code");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Ethnicity")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("Gender")
                        .HasMaxLength(7);

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<string>("State")
                        .HasMaxLength(15);

                    b.Property<string>("Street_Address")
                        .HasMaxLength(100);

                    b.Property<string>("Zip_Code");

                    b.HasKey("ID");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Service_Price");

                    b.Property<string>("Service_Rendered")
                        .HasMaxLength(50);

                    b.Property<string>("Service_Type")
                        .HasMaxLength(50);

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasMaxLength(15);

                    b.Property<string>("Street_Address")
                        .HasMaxLength(100);

                    b.Property<string>("Zip_Code");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Customer", b =>
                {
                    b.HasBaseType("OneStopBeauty.Models.Person");

                    b.Property<string>("Eye_Color")
                        .HasMaxLength(15);

                    b.Property<string>("Hair_Color")
                        .HasMaxLength(15);

                    b.Property<string>("Skin_Color")
                        .HasMaxLength(15);

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("OneStopBeauty.Models.Employee", b =>
                {
                    b.HasBaseType("OneStopBeauty.Models.Person");

                    b.Property<int>("Months_Employeed");

                    b.Property<float>("Pay_Rate");

                    b.Property<string>("Position_Title")
                        .HasMaxLength(50);

                    b.HasDiscriminator().HasValue("Employee");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneStopBeauty.Models.BillingStatement", b =>
                {
                    b.HasOne("OneStopBeauty.Models.Customer", "Customer")
                        .WithMany("BillingStatements")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OneStopBeauty.Models.Employee", "Employee")
                        .WithMany("BillingStatements")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("OneStopBeauty.Models.ItemOrdered", b =>
                {
                    b.HasOne("OneStopBeauty.Models.Inventory", "Inventory")
                        .WithMany("ItemsOrdered")
                        .HasForeignKey("InventoryID");

                    b.HasOne("OneStopBeauty.Models.Supplier", "Supplier")
                        .WithMany("ItemsOrdered")
                        .HasForeignKey("SupplierID");
                });

            modelBuilder.Entity("OneStopBeauty.Models.ItemSold", b =>
                {
                    b.HasOne("OneStopBeauty.Models.BillingStatement", "BillingStatement")
                        .WithMany("ItemsSold")
                        .HasForeignKey("BillingStatementID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OneStopBeauty.Models.Inventory", "Inventory")
                        .WithMany("ItemsSold")
                        .HasForeignKey("InventoryID");

                    b.HasOne("OneStopBeauty.Models.Location", "Location")
                        .WithMany("ItemsSold")
                        .HasForeignKey("LocationID");

                    b.HasOne("OneStopBeauty.Models.Service", "Services")
                        .WithMany("ItemsSold")
                        .HasForeignKey("ServiceID");
                });
#pragma warning restore 612, 618
        }
    }
}
