﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221111070251_quaflux")]
    partial class quaflux
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescriptionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MissionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VissionEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entity.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAdressEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponayMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Massage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity.Corporate", b =>
                {
                    b.Property<int>("CorporateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CorporateId");

                    b.ToTable("Corporates");
                });

            modelBuilder.Entity("Entity.Galery", b =>
                {
                    b.Property<int>("GaleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GaleryId");

                    b.ToTable("Galeries");
                });

            modelBuilder.Entity("Entity.HomeAbout", b =>
                {
                    b.Property<int>("HomeAboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature2Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc2Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomeAboutId");

                    b.ToTable("HomeAbouts");
                });

            modelBuilder.Entity("Entity.OurService", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlatIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("OurServices");
                });

            modelBuilder.Entity("Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoxSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSize1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSize2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSize3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSize4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSizeEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Dimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionsEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metarial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetarialEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescriptionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatAngle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatAngleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDesc9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWeightEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entity.Referance", b =>
                {
                    b.Property<int>("ReferanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferanceId");

                    b.ToTable("Referances");
                });

            modelBuilder.Entity("Entity.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnSliderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnSliderText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnSliderText3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnSliderText4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnSliderText5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}
