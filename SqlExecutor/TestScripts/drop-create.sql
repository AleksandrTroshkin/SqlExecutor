USE [master]
GO

alter database SqlExecutor set single_user with rollback immediate

/****** Object:  Database [SqlExecutor]    Script Date: 11.09.2021 14:21:24 ******/
DROP DATABASE [SqlExecutor]
GO

/****** Object:  Database [SqlExecutor]    Script Date: 11.09.2021 14:21:24 ******/
CREATE DATABASE [SqlExecutor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SqlExecutor', FILENAME = N'D:\DB\Data\SqlExecutor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SqlExecutor_log', FILENAME = N'D:\DB\Data\SqlExecutor_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SqlExecutor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SqlExecutor] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SqlExecutor] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SqlExecutor] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SqlExecutor] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SqlExecutor] SET ARITHABORT OFF 
GO

ALTER DATABASE [SqlExecutor] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SqlExecutor] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SqlExecutor] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SqlExecutor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SqlExecutor] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SqlExecutor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SqlExecutor] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SqlExecutor] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SqlExecutor] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SqlExecutor] SET  DISABLE_BROKER 
GO

ALTER DATABASE [SqlExecutor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SqlExecutor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SqlExecutor] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SqlExecutor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SqlExecutor] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SqlExecutor] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SqlExecutor] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SqlExecutor] SET RECOVERY FULL 
GO

ALTER DATABASE [SqlExecutor] SET  MULTI_USER 
GO

ALTER DATABASE [SqlExecutor] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SqlExecutor] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SqlExecutor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SqlExecutor] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SqlExecutor] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SqlExecutor] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [SqlExecutor] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SqlExecutor] SET  READ_WRITE 
GO

