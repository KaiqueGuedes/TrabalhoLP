USE [master]
GO
/****** Object:  Database [trabalho2semestre]    Script Date: 28/06/2017 19:41:23 ******/
CREATE DATABASE [trabalho2semestre]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'trabalho2semestre', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\trabalho2semestre.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'trabalho2semestre_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\trabalho2semestre_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [trabalho2semestre] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [trabalho2semestre].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [trabalho2semestre] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [trabalho2semestre] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [trabalho2semestre] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [trabalho2semestre] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [trabalho2semestre] SET ARITHABORT OFF 
GO
ALTER DATABASE [trabalho2semestre] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [trabalho2semestre] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [trabalho2semestre] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [trabalho2semestre] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [trabalho2semestre] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [trabalho2semestre] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [trabalho2semestre] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [trabalho2semestre] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [trabalho2semestre] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [trabalho2semestre] SET  DISABLE_BROKER 
GO
ALTER DATABASE [trabalho2semestre] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [trabalho2semestre] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [trabalho2semestre] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [trabalho2semestre] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [trabalho2semestre] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [trabalho2semestre] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [trabalho2semestre] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [trabalho2semestre] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [trabalho2semestre] SET  MULTI_USER 
GO
ALTER DATABASE [trabalho2semestre] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [trabalho2semestre] SET DB_CHAINING OFF 
GO
ALTER DATABASE [trabalho2semestre] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [trabalho2semestre] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [trabalho2semestre] SET DELAYED_DURABILITY = DISABLED 
GO
USE [trabalho2semestre]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[cpf_cnpj] [varchar](20) NULL,
	[cidade] [varchar](50) NULL,
	[cep] [varchar](12) NULL,
	[endereco] [varchar](70) NULL,
	[uf] [varchar](2) NULL,
	[email] [varchar](50) NULL,
	[fone] [varchar](15) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](70) NULL,
	[cpf_cnpj] [varchar](13) NULL,
	[cidade] [varchar](30) NULL,
	[cep] [varchar](10) NULL,
	[endereco] [varchar](70) NULL,
	[uf] [varchar](2) NULL,
	[email] [varchar](50) NULL,
	[fone] [varchar](14) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Os]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Os](
	[idOs] [int] IDENTITY(1,1) NOT NULL,
	[idcli] [int] NULL,
	[cliente] [varchar](20) NULL,
	[descricao] [varchar](50) NULL,
	[valor] [float] NULL,
	[data_ini] [datetime] NULL,
	[data_final] [datetime] NULL,
	[status] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idOs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OsP]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OsP](
	[idOs] [int] NULL,
	[id_prod] [int] NOT NULL,
	[nome_p] [varchar](20) NULL,
	[qtd] [int] NULL,
	[valor_unit] [real] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](70) NULL,
	[descricao] [varchar](50) NULL,
	[valor] [float] NULL,
	[status] [char](1) NULL,
	[id_fornecedor] [int] NOT NULL,
	[qtd] [float] NULL,
 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vendedor]    Script Date: 28/06/2017 19:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vendedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](70) NULL,
	[cpf] [varchar](13) NULL,
	[cidade] [varchar](30) NULL,
	[cep] [varchar](10) NULL,
	[endereco] [varchar](70) NULL,
	[uf] [varchar](2) NULL,
	[email] [varchar](50) NULL,
	[fone] [varchar](14) NULL,
 CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [trabalho2semestre] SET  READ_WRITE 
GO
