USE [Muhtarlikİslemleri]
GO
/****** Object:  Table [dbo].[askerlikKayitlari]    Script Date: 22.02.2021 05:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[askerlikKayitlari](
	[tcKimlik] [nvarchar](11) NULL,
	[Adi] [nvarchar](40) NULL,
	[Soyadi] [nvarchar](40) NULL,
	[askerlikDurumu] [nvarchar](40) NULL,
	[askerlikBölgesi] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ikametgahKayitlari]    Script Date: 22.02.2021 05:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ikametgahKayitlari](
	[tcKimlik] [nvarchar](11) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[İl] [nvarchar](50) NULL,
	[İlce] [nvarchar](50) NULL,
	[Mahalle] [nvarchar](100) NULL,
	[CaddeSokak] [nvarchar](100) NULL,
	[DaireNo] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medeniKayitlari]    Script Date: 22.02.2021 05:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medeniKayitlari](
	[tcKimlik] [nvarchar](11) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[medeniDurum] [nvarchar](50) NULL,
	[cocukSayisi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[password]    Script Date: 22.02.2021 05:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[password](
	[tcKimlik] [nvarchar](11) NULL,
	[anneKizlik] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[askerlikKayitlari] ([tcKimlik], [Adi], [Soyadi], [askerlikDurumu], [askerlikBölgesi]) VALUES (N'11122233344', N'Fırat', N'Bayram', N'Tamamlandı', N'Hakkari')
GO
INSERT [dbo].[askerlikKayitlari] ([tcKimlik], [Adi], [Soyadi], [askerlikDurumu], [askerlikBölgesi]) VALUES (N'45845721564', N'Ersin', N'Keleş', N'Tamamlandı', N'Antalya')
GO
INSERT [dbo].[askerlikKayitlari] ([tcKimlik], [Adi], [Soyadi], [askerlikDurumu], [askerlikBölgesi]) VALUES (N'43355645856', N'Sezgin', N'Maden', N'Tamamlandı', N'Erzurum')
GO
INSERT [dbo].[ikametgahKayitlari] ([tcKimlik], [Adi], [Soyadi], [İl], [İlce], [Mahalle], [CaddeSokak], [DaireNo]) VALUES (N'43355645856', N'Sezgin', N'Maden', N'İstanbul', N'Başakşehir', N'Güvercintepe', N'Orhangazi Caddesi', N'152')
GO
INSERT [dbo].[ikametgahKayitlari] ([tcKimlik], [Adi], [Soyadi], [İl], [İlce], [Mahalle], [CaddeSokak], [DaireNo]) VALUES (N'45845721564', N'Ersin', N'Keleş', N'Antalya', N'Konyaaltı', N'Safran', N'Ali Şener Caddesi', N'154')
GO
INSERT [dbo].[ikametgahKayitlari] ([tcKimlik], [Adi], [Soyadi], [İl], [İlce], [Mahalle], [CaddeSokak], [DaireNo]) VALUES (N'11111111111', N'Fırat', N'Bayram', N'Yalova', N'Merkez', N'Adnan Menderes', N'Ömer Halisdemir Caddesi', N'14')
GO
INSERT [dbo].[medeniKayitlari] ([tcKimlik], [Adi], [Soyadi], [medeniDurum], [cocukSayisi]) VALUES (N'42548569878', N'Ersin', N'Keleş', N'Evli', N'3')
GO
INSERT [dbo].[medeniKayitlari] ([tcKimlik], [Adi], [Soyadi], [medeniDurum], [cocukSayisi]) VALUES (N'43355645856', N'Sezgin', N'Maden', N'Evli', N'2')
GO
INSERT [dbo].[medeniKayitlari] ([tcKimlik], [Adi], [Soyadi], [medeniDurum], [cocukSayisi]) VALUES (N'11111111111', N'Fırat', N'Bayram', N'Evli', N'3')
GO
INSERT [dbo].[password] ([tcKimlik], [anneKizlik], [sifre]) VALUES (N'11111111111', N'BAYRAK', N'1524')
GO
