USE [master]
GO
/****** Object:  Database [Multas]    Script Date: 10/31/2022 1:53:02 PM ******/
CREATE DATABASE [Multas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Multas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Multas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Multas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Multas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Multas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Multas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Multas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Multas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Multas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Multas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Multas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Multas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Multas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Multas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Multas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Multas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Multas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Multas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Multas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Multas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Multas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Multas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Multas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Multas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Multas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Multas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Multas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Multas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Multas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Multas] SET  MULTI_USER 
GO
ALTER DATABASE [Multas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Multas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Multas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Multas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Multas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Multas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Multas] SET QUERY_STORE = OFF
GO
USE [Multas]
GO
/****** Object:  Table [dbo].[Multas]    Script Date: 10/31/2022 1:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [nchar](10) NOT NULL,
	[Importe] [float] NOT NULL,
	[Observaciones] [varchar](200) NULL,
	[NAgente] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[FechaLimite] [date] NOT NULL,
 CONSTRAINT [PK_Multas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Multas] SET  READ_WRITE 
GO
