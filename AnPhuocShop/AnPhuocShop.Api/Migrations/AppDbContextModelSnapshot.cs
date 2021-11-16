﻿// <auto-generated />
using AnPhuocShop.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnPhuocShop.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnPhuocShop.Models.AnPhuoc", b =>
                {
                    b.Property<int>("AnPhuocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hinhanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoatiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaispId")
                        .HasColumnType("int");

                    b.Property<string>("Tensp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thongtin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnPhuocId");

                    b.ToTable("AnPhuocs");

                    b.HasData(
                        new
                        {
                            AnPhuocId = 1,
                            Gia = "905.000 đ",
                            Hinhanh = "image/ASN002182.jpg",
                            Hoatiet = "Trơn",
                            LoaispId = 1,
                            Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002182",
                            Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày."
                        },
                        new
                        {
                            AnPhuocId = 2,
                            Gia = "1.418.000 đ",
                            Hinhanh = "image/PTH000268.jpg",
                            Hoatiet = "Trơn",
                            LoaispId = 2,
                            Tensp = "Áo Thun Nam tay ngắn Pierre Cardin - PTH000268",
                            Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày."
                        },
                        new
                        {
                            AnPhuocId = 3,
                            Gia = "668.000 đ",
                            Hinhanh = "image/ASN002225.jpg",
                            Hoatiet = "Bông",
                            LoaispId = 3,
                            Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002225",
                            Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày."
                        },
                        new
                        {
                            AnPhuocId = 4,
                            Gia = "928.000 đ",
                            Hinhanh = "image/AJKN00103.jpg",
                            Hoatiet = "Bông",
                            LoaispId = 4,
                            Tensp = "Áo Jacket Nữ An Phước - AJKN00103",
                            Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày."
                        });
                });

            modelBuilder.Entity("AnPhuocShop.Models.Loaisp", b =>
                {
                    b.Property<int>("LoaispId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoaispName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaispId");

                    b.ToTable("Loaisps");

                    b.HasData(
                        new
                        {
                            LoaispId = 1,
                            LoaispName = "Áo Sơ mi Nam"
                        },
                        new
                        {
                            LoaispId = 2,
                            LoaispName = "Áo Thun Nam"
                        },
                        new
                        {
                            LoaispId = 3,
                            LoaispName = "Áo Sơ mi Nam"
                        },
                        new
                        {
                            LoaispId = 4,
                            LoaispName = "Áo Jacket Nữ"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}