USE [master]
GO
/****** Object:  Database [dboSalonBelleza]    Script Date: 16/11/2023 22:58:08 ******/
CREATE DATABASE [dboSalonBelleza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dboSalonBelleza', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dboSalonBelleza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dboSalonBelleza_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dboSalonBelleza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dboSalonBelleza] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dboSalonBelleza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dboSalonBelleza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET ARITHABORT OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dboSalonBelleza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dboSalonBelleza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dboSalonBelleza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dboSalonBelleza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET RECOVERY FULL 
GO
ALTER DATABASE [dboSalonBelleza] SET  MULTI_USER 
GO
ALTER DATABASE [dboSalonBelleza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dboSalonBelleza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dboSalonBelleza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dboSalonBelleza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dboSalonBelleza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dboSalonBelleza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dboSalonBelleza', N'ON'
GO
ALTER DATABASE [dboSalonBelleza] SET QUERY_STORE = ON
GO
ALTER DATABASE [dboSalonBelleza] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dboSalonBelleza]
GO
/****** Object:  Table [dbo].[tblAdministrador]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAdministrador](
	[strUsuario] [varchar](50) NOT NULL,
	[strContraseña] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[strUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientes](
	[bigintIdIdentificacion] [bigint] NOT NULL,
	[strNombreCliente] [varchar](50) NOT NULL,
	[strApellidoCliente] [varchar](50) NOT NULL,
	[strCiudadCliente] [varchar](50) NOT NULL,
	[strDireccionCliente] [varchar](50) NOT NULL,
	[bigintTelefonoCliente] [bigint] NOT NULL,
	[stEmailCliente] [varchar](50) NOT NULL,
	[DateFechaNacimientoCliente] [datetime] NOT NULL,
	[intEdadCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bigintIdIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOpinion]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOpinion](
	[intIdOpinion] [int] NOT NULL,
	[strOpinionGeneral] [varchar](100) NOT NULL,
	[intIdReservasO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdOpinion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductos]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductos](
	[intIdProductos] [int] NOT NULL,
	[strNombreProducto] [varchar](50) NOT NULL,
	[strSugerenciaProducto] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdProductos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductosReservas]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductosReservas](
	[intIdProductosReservas] [int] NOT NULL,
	[intIdReservasPTR] [int] NULL,
	[intIdProductosPTR] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdProductosReservas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProfesional]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProfesional](
	[bigintIdProfesional] [bigint] NOT NULL,
	[strNombreProfesional] [varchar](50) NOT NULL,
	[strApellidoProfesional] [varchar](50) NOT NULL,
	[bigintTelefonoProfesional] [bigint] NOT NULL,
	[intIdSedeP] [int] NULL,
	[timeHoraInicioP] [time](7) NOT NULL,
	[timeHoraFinP] [time](7) NOT NULL,
	[strTiempoHoraInicioP] [varchar](50) NULL,
	[strTiempoHoraFINP] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[bigintIdProfesional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReservas]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReservas](
	[intIdReservas] [int] NOT NULL,
	[dateFechaReserva] [date] NOT NULL,
	[strTipocliente] [varchar](50) NOT NULL,
	[strPreferencia] [varchar](100) NULL,
	[strSeleccionProducto] [varchar](100) NULL,
	[bigintIdIdentificacionR] [bigint] NULL,
	[intIdSedeR] [int] NULL,
	[bigintIdProfesional] [bigint] NULL,
	[intIdServicios] [int] NULL,
	[timeHoraInicioR] [time](7) NOT NULL,
	[timeHoraFinR] [time](7) NOT NULL,
	[strTiempoHoraInicioCita] [varchar](50) NULL,
	[strTiempoTimeHoraFinCita] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdReservas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSedes]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSedes](
	[intIdSede] [int] NOT NULL,
	[strCiudadSede] [varchar](50) NOT NULL,
	[strDireccionSede] [varchar](50) NOT NULL,
	[timeHorarioapertura] [time](7) NOT NULL,
	[timeHorariocierre] [time](7) NOT NULL,
	[strTiempoApertura] [varchar](50) NULL,
	[strTiempoCierre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblServicios]    Script Date: 16/11/2023 22:58:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblServicios](
	[intIdServicios] [int] NOT NULL,
	[strServicios] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdServicios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblOpinion]  WITH CHECK ADD FOREIGN KEY([intIdReservasO])
REFERENCES [dbo].[tblReservas] ([intIdReservas])
GO
ALTER TABLE [dbo].[tblProductosReservas]  WITH CHECK ADD FOREIGN KEY([intIdReservasPTR])
REFERENCES [dbo].[tblReservas] ([intIdReservas])
GO
ALTER TABLE [dbo].[tblProductosReservas]  WITH CHECK ADD FOREIGN KEY([intIdProductosPTR])
REFERENCES [dbo].[tblProductos] ([intIdProductos])
GO
ALTER TABLE [dbo].[tblProfesional]  WITH CHECK ADD FOREIGN KEY([intIdSedeP])
REFERENCES [dbo].[tblSedes] ([intIdSede])
GO
ALTER TABLE [dbo].[tblReservas]  WITH CHECK ADD  CONSTRAINT [bigintIdProfesional] FOREIGN KEY([bigintIdProfesional])
REFERENCES [dbo].[tblProfesional] ([bigintIdProfesional])
GO
ALTER TABLE [dbo].[tblReservas] CHECK CONSTRAINT [bigintIdProfesional]
GO
ALTER TABLE [dbo].[tblReservas]  WITH CHECK ADD FOREIGN KEY([bigintIdIdentificacionR])
REFERENCES [dbo].[tblClientes] ([bigintIdIdentificacion])
GO
ALTER TABLE [dbo].[tblReservas]  WITH CHECK ADD FOREIGN KEY([intIdSedeR])
REFERENCES [dbo].[tblSedes] ([intIdSede])
GO
ALTER TABLE [dbo].[tblReservas]  WITH CHECK ADD  CONSTRAINT [intIdServicios] FOREIGN KEY([intIdServicios])
REFERENCES [dbo].[tblServicios] ([intIdServicios])
GO
ALTER TABLE [dbo].[tblReservas] CHECK CONSTRAINT [intIdServicios]
GO
USE [master]
GO
ALTER DATABASE [dboSalonBelleza] SET  READ_WRITE 
GO
