USE [master]
GO
/****** Object:  Database [Pubs]    Script Date: 8/15/2014 11:37:59 AM ******/
CREATE DATABASE [Pubs]
 CONTAINMENT = NONE
 ON  PRIMARY 

GO
ALTER DATABASE [Pubs] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pubs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pubs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pubs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pubs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pubs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pubs] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pubs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pubs] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Pubs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pubs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pubs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pubs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pubs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pubs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pubs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pubs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pubs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pubs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pubs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pubs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pubs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pubs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pubs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pubs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pubs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pubs] SET  MULTI_USER 
GO
ALTER DATABASE [Pubs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pubs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pubs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pubs] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Pubs] SET  READ_WRITE 
GO
