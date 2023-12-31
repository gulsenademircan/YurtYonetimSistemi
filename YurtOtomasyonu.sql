USE [master]
GO
/****** Object:  Database [YurtOtomasyonu]    Script Date: 17.06.2023 18:32:44 ******/
CREATE DATABASE [YurtOtomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonu.mdf' , SIZE = 9216KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YurtOtomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonu_log.ldf' , SIZE = 4224KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YurtOtomasyonu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyonu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YurtOtomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [YurtOtomasyonu]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[Yoneticiid] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](20) NULL,
	[YoneticiSifre] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bolumler](
	[Bolumid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](50) NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[Bolumid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Borclar](
	[BorcId] [tinyint] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](30) NULL,
	[OgrSoyad] [varchar](30) NULL,
	[OgrKalanBorc] [smallint] NULL,
	[OdemeTarih] [varchar](30) NULL,
	[OdemeTutar] [varchar](30) NULL,
 CONSTRAINT [PK_Borclar] PRIMARY KEY CLUSTERED 
(
	[BorcId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Esya]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Esya](
	[Esya] [varchar](50) NULL,
	[EsyaYer] [varchar](50) NULL,
	[EsyaTarih] [varchar](15) NULL,
	[Detay] [varchar](50) NULL,
	[EsyaSahip] [varchar](50) NULL,
	[EsyaNumara] [varchar](20) NULL,
	[Durum] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Harcamalar]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Harcamalar](
	[HarcamaId] [tinyint] IDENTITY(1,1) NOT NULL,
	[HarcamaTarih] [varchar](15) NULL,
	[HarcamaKisi] [varchar](50) NULL,
	[HarcamaTutar] [varchar](50) NULL,
	[HarcamaDetay] [varchar](50) NULL,
 CONSTRAINT [PK_Harcamalar] PRIMARY KEY CLUSTERED 
(
	[HarcamaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Izin]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Izin](
	[OgrenciAdi] [varchar](50) NULL,
	[OdaNo] [char](3) NULL,
	[OgrenciTelefon] [varchar](20) NULL,
	[IzinBaslangic] [varchar](15) NULL,
	[IzınBitis] [varchar](15) NULL,
	[IzinSebebi] [varchar](40) NULL,
	[KisiAdi] [varchar](35) NULL,
	[YakinlikDerecesi] [varchar](20) NULL,
	[KisiTelefon] [varchar](20) NULL,
	[KisiAdres] [varchar](300) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Odalar](
	[Odaid] [tinyint] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](3) NULL,
	[OdaKapasite] [char](1) NULL,
	[OdaAktifKalan] [char](1) NULL CONSTRAINT [DF_Odalar_OdaAktifKalan]  DEFAULT ((0))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Odeme]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Odeme](
	[BorcId] [tinyint] NULL,
	[OgrAd] [varchar](50) NULL,
	[OgrSoyad] [varchar](50) NULL,
	[OdemeTarihi] [varchar](20) NULL,
	[OdenenTutar] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Ogrid] [tinyint] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](30) NULL,
	[OgrSoyad] [varchar](30) NULL,
	[OgrTC] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](15) NULL,
	[OgrBolum] [varchar](50) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrOdaNo] [char](3) NULL,
	[OgrYillik] [int] NULL,
	[OgrVeliAdSoyad] [varchar](50) NULL,
	[OgrVeliTelefon] [varchar](30) NULL,
	[OgrVeliAdres] [varchar](300) NULL,
	[OgrResim] [image] NULL,
	[OgrSaglik] [varchar](50) NULL,
	[OgrKanGrubu] [varchar](50) NULL,
	[OgrOdemeTarih] [varchar](50) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Ogrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 17.06.2023 18:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personel](
	[Personelid] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelDepartman] [varchar](30) NULL,
	[PersonelTarih] [varchar](15) NULL,
	[PersonelTelefon] [varchar](20) NULL,
	[PersonelAdres] [varchar](300) NULL,
	[PersonelResim] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyonu] SET  READ_WRITE 
GO
