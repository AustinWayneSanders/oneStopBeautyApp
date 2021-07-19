using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OneStopBeauty.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Name = table.Column<string>(nullable: true),
                    Unit_Price = table.Column<decimal>(nullable: false),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street_Address = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 15, nullable: true),
                    Zip_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(maxLength: 7, nullable: true),
                    Ethnicity = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street_Address = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 15, nullable: true),
                    Zip_Code = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Hair_Color = table.Column<string>(maxLength: 15, nullable: true),
                    Skin_Color = table.Column<string>(maxLength: 15, nullable: true),
                    Eye_Color = table.Column<string>(maxLength: 15, nullable: true),
                    Position_Title = table.Column<string>(maxLength: 50, nullable: true),
                    Months_Employeed = table.Column<int>(nullable: true),
                    Pay_Rate = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Service_Rendered = table.Column<string>(maxLength: 50, nullable: true),
                    Service_Type = table.Column<string>(maxLength: 50, nullable: true),
                    Service_Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Street_Address = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 15, nullable: true),
                    Zip_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingStatements",
                columns: table => new
                {
                    BillingStatementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true),
                    Invoice_Date = table.Column<DateTime>(nullable: false),
                    Total_Price = table.Column<decimal>(nullable: false),
                    Taxes = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingStatements", x => x.BillingStatementID);
                    table.ForeignKey(
                        name: "FK_BillingStatements_People_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingStatements_People_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsOrdered",
                columns: table => new
                {
                    ItemOrderedID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierID = table.Column<int>(nullable: true),
                    InventoryID = table.Column<int>(nullable: true),
                    Product_Code = table.Column<string>(maxLength: 3, nullable: true),
                    Shipped_Date_Ordered_Item = table.Column<DateTime>(nullable: false),
                    Arrived_Date_Ordered_Item = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsOrdered", x => x.ItemOrderedID);
                    table.ForeignKey(
                        name: "FK_ItemsOrdered_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsOrdered_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsSold",
                columns: table => new
                {
                    ItemSoldID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillingStatementID = table.Column<int>(nullable: false),
                    InventoryID = table.Column<int>(nullable: true),
                    ServiceID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    Online = table.Column<bool>(nullable: false),
                    Shipped_Date_Sold_Item = table.Column<DateTime>(nullable: false),
                    Arrived_Date_Sold_Item = table.Column<DateTime>(nullable: false),
                    Ext_Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsSold", x => x.ItemSoldID);
                    table.ForeignKey(
                        name: "FK_ItemsSold_BillingStatements_BillingStatementID",
                        column: x => x.BillingStatementID,
                        principalTable: "BillingStatements",
                        principalColumn: "BillingStatementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsSold_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsSold_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsSold_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillingStatements_CustomerID",
                table: "BillingStatements",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BillingStatements_EmployeeID",
                table: "BillingStatements",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsOrdered_InventoryID",
                table: "ItemsOrdered",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsOrdered_SupplierID",
                table: "ItemsOrdered",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSold_BillingStatementID",
                table: "ItemsSold",
                column: "BillingStatementID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSold_InventoryID",
                table: "ItemsSold",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSold_LocationID",
                table: "ItemsSold",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSold_ServiceID",
                table: "ItemsSold",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ItemsOrdered");

            migrationBuilder.DropTable(
                name: "ItemsSold");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "BillingStatements");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
