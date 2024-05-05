USE [master]
GO
/****** Object:  Database [ProyectoIS]    Script Date: 5/4/2024 9:31:35 PM ******/
CREATE DATABASE [ProyectoIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoIS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoIS] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoIS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProyectoIS] SET QUERY_STORE = OFF
GO
USE [ProyectoIS]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 5/4/2024 9:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Mensaje] [varchar](max) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BitacoraTipo]    Script Date: 5/4/2024 9:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BitacoraTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/4/2024 9:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Username]    Script Date: 5/4/2024 9:31:35 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Username] ON [dbo].[Usuario]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_BitacoraTipo] FOREIGN KEY([Tipo])
REFERENCES [dbo].[BitacoraTipo] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_BitacoraTipo]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[FiltrarBitacora]    Script Date: 5/4/2024 9:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FiltrarBitacora] 
	-- Add the parameters for the stored procedure here
	@Usuario int,
	@Tipo int,
	@Desde datetime,
	@Hasta datetime,
	@Page int,
	@Filas int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		b.id AS 'Id',
		u.username AS 'Usuario',
		bt.nombre AS 'Tipo',
		b.Mensaje,
		b.Fecha
	FROM Bitacora AS b
	INNER JOIN Usuario u ON u.id = b.usuario
	INNER JOIN BitacoraTipo bt ON bt.id = b.tipo
	WHERE (
			@Usuario IS NULL
			OR u.Username = @Usuario
			)
		AND (
			@Tipo IS NULL
			OR bt.Id = @Tipo
			)
		AND (
			b.Fecha BETWEEN @Desde
				AND @Hasta
			)
	ORDER BY b.Fecha DESC OFFSET @Page ROWS
	FETCH NEXT @Filas ROWS ONLY;

END
GO
USE [master]
GO
ALTER DATABASE [ProyectoIS] SET  READ_WRITE 
GO
