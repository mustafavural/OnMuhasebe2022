USE [SIRKET]
GO
/****** Object:  Table [dbo].[BankaHareketler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankaHareketler](
	[Id] [int] NOT NULL,
	[BankaHesapId] [int] NOT NULL,
	[CariId] [int] NOT NULL,
	[EvrakNo] [varchar](14) NOT NULL,
	[GirenCikanMiktar] [money] NOT NULL,
	[Tarih] [date] NOT NULL,
	[Aciklama] [nvarchar](250) NULL,
 CONSTRAINT [PK_BankaHareketler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_BankaHareketler_EvrakNo] UNIQUE NONCLUSTERED 
(
	[EvrakNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankaHesaplar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankaHesaplar](
	[Id] [int] NOT NULL,
	[BankaAd] [nvarchar](100) NOT NULL,
	[BankaSubeAd] [nvarchar](100) NOT NULL,
	[HesapNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Bankalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_BankaHesap_No] UNIQUE NONCLUSTERED 
(
	[HesapNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CariCategoryler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CariCategoryler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CariCategoryler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CariGruplar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CariGruplar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CariId] [int] NOT NULL,
	[CariCategoryId] [int] NOT NULL,
 CONSTRAINT [PK_CariGruplar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CariHareketler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CariHareketler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CariId] [int] NOT NULL,
	[Tutar] [money] NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[Aciklama] [nvarchar](500) NULL,
 CONSTRAINT [PK_CariHareketler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cariler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cariler](
	[Id] [int] NOT NULL,
	[Kod] [nvarchar](50) NOT NULL,
	[Unvan] [nvarchar](50) NOT NULL,
	[VergiDairesi] [nvarchar](50) NOT NULL,
	[VergiNo] [varchar](11) NOT NULL,
 CONSTRAINT [PK_Cariler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Cariler_Kod] UNIQUE NONCLUSTERED 
(
	[Kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Cariler_Unvan] UNIQUE NONCLUSTERED 
(
	[Unvan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DegerliEvraklar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DegerliEvraklar](
	[Id] [int] NOT NULL,
	[Kod] [varchar](50) NOT NULL,
	[VerilenCariId] [int] NULL,
	[Vade] [date] NOT NULL,
	[Tutar] [money] NOT NULL,
	[CikisTarihi] [date] NULL,
	[Aciklama] [nvarchar](250) NULL,
 CONSTRAINT [PK_DegerliEvraklar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_DegerliEvrak_Kod] UNIQUE NONCLUSTERED 
(
	[Kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Id] [int] NOT NULL,
	[No] [varchar](50) NOT NULL,
	[Tur] [nvarchar](50) NOT NULL,
	[CariId] [int] NOT NULL,
	[Tarih] [date] NOT NULL,
	[KayitTarihi] [date] NOT NULL,
	[Aciklama] [nvarchar](500) NULL,
 CONSTRAINT [PK_Faturalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Fatura_No] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adresler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Telefon] [nvarchar](20) NULL,
	[Telefon2] [nvarchar](20) NULL,
	[Fax] [nvarchar](20) NULL,
	[Web] [varchar](150) NULL,
	[Eposta] [varchar](150) NULL,
	[IlceId] [int] NOT NULL,
	[AcikAdres] [nvarchar](500) NULL,
 CONSTRAINT [PK_Adresler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SehirId] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ilceler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Ilce_Ad] UNIQUE NONCLUSTERED 
(
	[Ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sehirler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehirler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sehirler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Sehir_Ad] UNIQUE NONCLUSTERED 
(
	[Ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KasaHareketler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KasaHareketler](
	[Id] [int] NOT NULL,
	[KasaId] [int] NOT NULL,
	[CariId] [int] NOT NULL,
	[EvrakNo] [varchar](14) NOT NULL,
	[GirenCikanMiktar] [money] NOT NULL,
	[Tarih] [date] NOT NULL,
	[Aciklama] [nvarchar](255) NULL,
 CONSTRAINT [PK_KasaHareketler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [KasaHareket_EvrakNo] UNIQUE NONCLUSTERED 
(
	[EvrakNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasalar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kasa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Kasa_Ad] UNIQUE NONCLUSTERED 
(
	[Ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriEvraklar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriEvraklar](
	[Id] [int] NOT NULL,
	[AlinanCariId] [int] NOT NULL,
	[AsilBorclu] [nvarchar](250) NOT NULL,
	[AlisTarihi] [date] NOT NULL,
 CONSTRAINT [PK_MusteriEvraklar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_MusteriEvrak_Id] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokCategoryler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokCategoryler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StokCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokGruplar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokGruplar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StokId] [int] NOT NULL,
	[StokCategoryId] [int] NOT NULL,
 CONSTRAINT [PK_StokGrup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokHareketler]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokHareketler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StokId] [int] NOT NULL,
	[FaturaId] [int] NOT NULL,
	[Miktar] [decimal](18, 6) NOT NULL,
	[Birim] [nvarchar](50) NOT NULL,
	[Fiyat] [money] NOT NULL,
	[BrutTutar] [money] NOT NULL,
	[KDV] [int] NOT NULL,
	[NetTutar] [money] NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[Aciklama] [nvarchar](500) NULL,
 CONSTRAINT [PK_StokHareket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 29.11.2022 07:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stoklar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kod] [varchar](10) NOT NULL,
	[Barkod] [varchar](15) NOT NULL,
	[Ad] [nvarchar](255) NOT NULL,
	[KDV] [int] NOT NULL,
	[Birim] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Stok_Ad] UNIQUE NONCLUSTERED 
(
	[Ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Stok_Barkod] UNIQUE NONCLUSTERED 
(
	[Barkod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Stok_Kod] UNIQUE NONCLUSTERED 
(
	[Kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BankaHareketler]  WITH CHECK ADD  CONSTRAINT [BankaHesap_1_M_BankaHareketler] FOREIGN KEY([BankaHesapId])
REFERENCES [dbo].[BankaHesaplar] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BankaHareketler] CHECK CONSTRAINT [BankaHesap_1_M_BankaHareketler]
GO
ALTER TABLE [dbo].[BankaHareketler]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_BankaHareketler] FOREIGN KEY([CariId])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[BankaHareketler] CHECK CONSTRAINT [Cari_1_M_BankaHareketler]
GO
ALTER TABLE [dbo].[BankaHareketler]  WITH CHECK ADD  CONSTRAINT [CariHareket_1_1o0_BankaHareket] FOREIGN KEY([Id])
REFERENCES [dbo].[CariHareketler] ([Id])
GO
ALTER TABLE [dbo].[BankaHareketler] CHECK CONSTRAINT [CariHareket_1_1o0_BankaHareket]
GO
ALTER TABLE [dbo].[BankaHesaplar]  WITH CHECK ADD  CONSTRAINT [Adres_1_1o0_BankaHesap] FOREIGN KEY([Id])
REFERENCES [dbo].[Adresler] ([Id])
GO
ALTER TABLE [dbo].[BankaHesaplar] CHECK CONSTRAINT [Adres_1_1o0_BankaHesap]
GO
ALTER TABLE [dbo].[CariGruplar]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_CariGruplar] FOREIGN KEY([CariId])
REFERENCES [dbo].[Cariler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CariGruplar] CHECK CONSTRAINT [Cari_1_M_CariGruplar]
GO
ALTER TABLE [dbo].[CariGruplar]  WITH CHECK ADD  CONSTRAINT [CariCategory_1_M_CariGruplar] FOREIGN KEY([CariCategoryId])
REFERENCES [dbo].[CariCategoryler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CariGruplar] CHECK CONSTRAINT [CariCategory_1_M_CariGruplar]
GO
ALTER TABLE [dbo].[CariHareketler]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_CariHareketler] FOREIGN KEY([CariId])
REFERENCES [dbo].[Cariler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CariHareketler] CHECK CONSTRAINT [Cari_1_M_CariHareketler]
GO
ALTER TABLE [dbo].[Cariler]  WITH CHECK ADD  CONSTRAINT [Adres_1_1o0_Cari] FOREIGN KEY([Id])
REFERENCES [dbo].[Adresler] ([Id])
GO
ALTER TABLE [dbo].[Cariler] CHECK CONSTRAINT [Adres_1_1o0_Cari]
GO
ALTER TABLE [dbo].[DegerliEvraklar]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_DegerliEvraklar] FOREIGN KEY([VerilenCariId])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[DegerliEvraklar] CHECK CONSTRAINT [Cari_1_M_DegerliEvraklar]
GO
ALTER TABLE [dbo].[DegerliEvraklar]  WITH CHECK ADD  CONSTRAINT [CariHareket_1_1o0_DegerliEvrak] FOREIGN KEY([Id])
REFERENCES [dbo].[CariHareketler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DegerliEvraklar] CHECK CONSTRAINT [CariHareket_1_1o0_DegerliEvrak]
GO
ALTER TABLE [dbo].[Faturalar]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_Faturalar] FOREIGN KEY([CariId])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[Faturalar] CHECK CONSTRAINT [Cari_1_M_Faturalar]
GO
ALTER TABLE [dbo].[Faturalar]  WITH CHECK ADD  CONSTRAINT [CariHareket_1_1o0_Fatura] FOREIGN KEY([Id])
REFERENCES [dbo].[CariHareketler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Faturalar] CHECK CONSTRAINT [CariHareket_1_1o0_Fatura]
GO
ALTER TABLE [dbo].[Adresler]  WITH CHECK ADD  CONSTRAINT [Ilce_1_M_Adresler] FOREIGN KEY([IlceId])
REFERENCES [dbo].[Ilceler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Adresler] CHECK CONSTRAINT [Ilce_1_M_Adresler]
GO
ALTER TABLE [dbo].[Ilceler]  WITH CHECK ADD  CONSTRAINT [Sehir_1_M_Ilceler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([Id])
GO
ALTER TABLE [dbo].[Ilceler] CHECK CONSTRAINT [Sehir_1_M_Ilceler]
GO
ALTER TABLE [dbo].[KasaHareketler]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_KasaHareketler] FOREIGN KEY([CariId])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[KasaHareketler] CHECK CONSTRAINT [Cari_1_M_KasaHareketler]
GO
ALTER TABLE [dbo].[KasaHareketler]  WITH CHECK ADD  CONSTRAINT [CariHareket_1_1o0_KasaHareket] FOREIGN KEY([Id])
REFERENCES [dbo].[CariHareketler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KasaHareketler] CHECK CONSTRAINT [CariHareket_1_1o0_KasaHareket]
GO
ALTER TABLE [dbo].[KasaHareketler]  WITH CHECK ADD  CONSTRAINT [Kasa_1_M_KasaHareketler] FOREIGN KEY([KasaId])
REFERENCES [dbo].[Kasalar] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KasaHareketler] CHECK CONSTRAINT [Kasa_1_M_KasaHareketler]
GO
ALTER TABLE [dbo].[MusteriEvraklar]  WITH CHECK ADD  CONSTRAINT [Cari_1_M_MusteriEvraklar] FOREIGN KEY([AlinanCariId])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[MusteriEvraklar] CHECK CONSTRAINT [Cari_1_M_MusteriEvraklar]
GO
ALTER TABLE [dbo].[MusteriEvraklar]  WITH CHECK ADD  CONSTRAINT [CariHareket_1_1o0_MusteriEvrak] FOREIGN KEY([Id])
REFERENCES [dbo].[CariHareketler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MusteriEvraklar] CHECK CONSTRAINT [CariHareket_1_1o0_MusteriEvrak]
GO
ALTER TABLE [dbo].[MusteriEvraklar]  WITH CHECK ADD  CONSTRAINT [DegerliEvrak_1_1o0_MusteriEvrak] FOREIGN KEY([Id])
REFERENCES [dbo].[DegerliEvraklar] ([Id])
GO
ALTER TABLE [dbo].[MusteriEvraklar] CHECK CONSTRAINT [DegerliEvrak_1_1o0_MusteriEvrak]
GO
ALTER TABLE [dbo].[StokGruplar]  WITH CHECK ADD  CONSTRAINT [Stok_1_M_StokGruplar] FOREIGN KEY([StokId])
REFERENCES [dbo].[Stoklar] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StokGruplar] CHECK CONSTRAINT [Stok_1_M_StokGruplar]
GO
ALTER TABLE [dbo].[StokGruplar]  WITH CHECK ADD  CONSTRAINT [StokCategory_1_M_StokGruplar] FOREIGN KEY([StokCategoryId])
REFERENCES [dbo].[StokCategoryler] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StokGruplar] CHECK CONSTRAINT [StokCategory_1_M_StokGruplar]
GO
ALTER TABLE [dbo].[StokHareketler]  WITH CHECK ADD  CONSTRAINT [Fatura_1_M_StokHareketler] FOREIGN KEY([FaturaId])
REFERENCES [dbo].[Faturalar] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StokHareketler] CHECK CONSTRAINT [Fatura_1_M_StokHareketler]
GO
ALTER TABLE [dbo].[StokHareketler]  WITH CHECK ADD  CONSTRAINT [Stok_1_M_StokHareketler] FOREIGN KEY([StokId])
REFERENCES [dbo].[Stoklar] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StokHareketler] CHECK CONSTRAINT [Stok_1_M_StokHareketler]
GO
USE [master]
GO
ALTER DATABASE [SIRKET] SET  READ_WRITE 
GO
INSERT INTO Sehirler VALUES
('Adana'),
('Ad�yaman'),
('Afyonkarahisar'),
('A�r�'),
('Amasya'),
('Ankara'),
('Antalya'),
('Artvin'),
('Ayd�n'),
('Bal�kesir'),
('Bilecik'),
('Bing�l'),
('Bitlis'),
('Bolu'),
('Burdur'),
('Bursa'),
('�anakkale'),
('�ank�r�'),
('�orum'),
('Denizli'),
('Diyarbak�r'),
('Edirne'),
('Elaz��'),
('Erzincan'),
('Erzurum'),
('Eski�ehir'),
('Gaziantep'),
('Giresun'),
('G�m��hane'),
('Hakkari'),
('Hatay'),
('Isparta'),
('Mersin'),
('�stanbul'),
('�zmir'),
('Kars'),
('Kastamonu'),
('Kayseri'),
('K�rklareli'),
('K�r�ehir'),
('Kocaeli'),
('Konya'),
('K�tahya'),
('Malatya'),
('Manisa'),
('Kahramanmara�'),
('Mardin'),
('Mu�la'),
('Mu�'),
('Nev�ehir'),
('Ni�de'),
('Ordu'),
('Rize'),
('Sakarya'),
('Samsun'),
('Siirt'),
('Sinop'),
('Sivas'),
('Tekirda�'),
('Tokat'),
('Trabzon'),
('Tunceli'),
('�anl�urfa'),
('U�ak'),
('Van'),
('Yozgat'),
('Zonguldak'),
('Aksaray'),
('Bayburt'),
('Karaman'),
('K�r�kkale'),
('Batman'),
('��rnak'),
('Bart�n'),
('Ardahan'),
('I�d�r'),
('Yalova'),
('Karab�k'),
('Kilis'),
('Osmaniye'),
('D�zce');
INSERT INTO Ilceler (Ad,SehirId) VALUES
('Seyhan', 1),
('Ceyhan', 1),
('Feke', 1),
('Karaisal�', 1),
('Karata�', 1),
('Kozan', 1),
('Pozant�', 1),
('Saimbeyli', 1),
('Tufanbeyli', 1),
('Yumurtal�k', 1),
('Y�re�ir', 1),
('Alada�', 1),
('�mamo�lu', 1),
('Sar��am', 1),
('�ukurova', 1),
('Ad�yaman Merkez', 2),
('Besni', 2),
('�elikhan', 2),
('Gerger', 2),
('G�lba�� / Ad�yaman', 2),
('Kahta', 2),
('Samsat', 2),
('Sincik', 2),
('Tut', 2),
('Afyonkarahisar Merkez', 3),
('Bolvadin', 3),
('�ay', 3),
('Dazk�r�', 3),
('Dinar', 3),
('Emirda�', 3),
('�hsaniye', 3),
('Sand�kl�', 3),
('Sinanpa�a', 3),
('Sultanda��', 3),
('�uhut', 3),
('Ba�mak��', 3),
('Bayat / Afyonkarahisar', 3),
('�scehisar', 3),
('�obanlar', 3),
('Evciler', 3),
('Hocalar', 3),
('K�z�l�ren', 3),
('A�r� Merkez', 4),
('Diyadin', 4),
('Do�ubayaz�t', 4),
('Ele�kirt', 4),
('Hamur', 4),
('Patnos', 4),
('Ta�l��ay', 4),
('Tutak', 4),
('Amasya Merkez', 5),
('G�yn�cek', 5),
('G�m��hac�k�y', 5),
('Merzifon', 5),
('Suluova', 5),
('Ta�ova', 5),
('Hamam�z�', 5),
('Alt�nda�', 6),
('Aya�', 6),
('Bala', 6),
('Beypazar�', 6),
('�aml�dere', 6),
('�ankaya', 6),
('�ubuk', 6),
('Elmada�', 6),
('G�d�l', 6),
('Haymana', 6),
('Kalecik', 6),
('K�z�lcahamam', 6),
('Nall�han', 6),
('Polatl�', 6),
('�erefliko�hisar', 6),
('Yenimahalle', 6),
('G�lba�� / Ankara', 6),
('Ke�i�ren', 6),
('Mamak', 6),
('Sincan', 6),
('Kazan', 6),
('Akyurt', 6),
('Etimesgut', 6),
('Evren', 6),
('Pursaklar', 6),
('Akseki', 7),
('Alanya', 7),
('Elmal�', 7),
('Finike', 7),
('Gazipa�a', 7),
('G�ndo�mu�', 7),
('Ka�', 7),
('Korkuteli', 7),
('Kumluca', 7),
('Manavgat', 7),
('Serik', 7),
('Demre', 7),
('�brad�', 7),
('Kemer / Antalya', 7),
('Aksu / Antalya', 7),
('D��emealt�', 7),
('Kepez', 7),
('Konyaalt�', 7),
('Muratpa�a', 7),
('Ardanu�', 8),
('Arhavi', 8),
('Artvin Merkez', 8),
('Bor�ka', 8),
('Hopa', 8),
('�av�at', 8),
('Yusufeli', 8),
('Murgul', 8),
('Bozdo�an', 9),
('�ine', 9),
('Germencik', 9),
('Karacasu', 9),
('Ko�arl�', 9),
('Ku�adas�', 9),
('Kuyucak', 9),
('Nazilli', 9),
('S�ke', 9),
('Sultanhisar', 9),
('Yenipazar / Ayd�n', 9),
('Buharkent', 9),
('�ncirliova', 9),
('Karpuzlu', 9),
('K��k', 9),
('Didim', 9),
('Efeler', 9),
('Ayval�k', 10),
('Balya', 10),
('Band�rma', 10),
('Bigadi�', 10),
('Burhaniye', 10),
('Dursunbey', 10),
('Edremit / Bal�kesir', 10),
('Erdek', 10),
('G�nen / Bal�kesir', 10),
('Havran', 10),
('�vrindi', 10),
('Kepsut', 10),
('Manyas', 10),
('Sava�tepe', 10),
('S�nd�rg�', 10),
('Susurluk', 10),
('Marmara', 10),
('G�me�', 10),
('Alt�eyl�l', 10),
('Karesi', 10),
('Bilecik Merkez', 11),
('Boz�y�k', 11),
('G�lpazar�', 11),
('Osmaneli', 11),
('Pazaryeri', 11),
('S���t', 11),
('Yenipazar / Bilecik', 11),
('�nhisar', 11),
('Bing�l Merkez', 12),
('Gen�', 12),
('Karl�ova', 12),
('Ki��', 12),
('Solhan', 12),
('Adakl�', 12),
('Yayladere', 12),
('Yedisu', 12),
('Adilcevaz', 13),
('Ahlat', 13),
('Bitlis Merkez', 13),
('Hizan', 13),
('Mutki', 13),
('Tatvan', 13),
('G�roymak', 13),
('Bolu Merkez', 14),
('Gerede', 14),
('G�yn�k', 14),
('K�br�sc�k', 14),
('Mengen', 14),
('Mudurnu', 14),
('Seben', 14),
('D�rtdivan', 14),
('Yeni�a�a', 14),
('A�lasun', 15),
('Bucak', 15),
('Burdur Merkez', 15),
('G�lhisar', 15),
('Tefenni', 15),
('Ye�ilova', 15),
('Karamanl�', 15),
('Kemer / Burdur', 15),
('Alt�nyayla / Burdur', 15),
('�avd�r', 15),
('�eltik�i', 15),
('Gemlik', 16),
('�neg�l', 16),
('�znik', 16),
('Karacabey', 16),
('Keles', 16),
('Mudanya', 16),
('Mustafakemalpa�a', 16),
('Orhaneli', 16),
('Orhangazi', 16),
('Yeni�ehir / Bursa', 16),
('B�y�korhan', 16),
('Harmanc�k', 16),
('Nil�fer', 16),
('Osmangazi', 16),
('Y�ld�r�m', 16),
('G�rsu', 16),
('Kestel', 16),
('Ayvac�k / �anakkale', 17),
('Bayrami�', 17),
('Biga', 17),
('Bozcaada', 17),
('�an', 17),
('�anakkale Merkez', 17),
('Eceabat', 17),
('Ezine', 17),
('Gelibolu', 17),
('G�k�eada', 17),
('Lapseki', 17),
('Yenice / �anakkale', 17),
('�ank�r� Merkez', 18),
('�erke�', 18),
('Eldivan', 18),
('Ilgaz', 18),
('Kur�unlu', 18),
('Orta', 18),
('�aban�z�', 18),
('Yaprakl�', 18),
('Atkaracalar', 18),
('K�z�l�rmak', 18),
('Bayram�ren', 18),
('Korgun', 18),
('Alaca', 19),
('Bayat / �orum', 19),
('�orum Merkez', 19),
('�skilip', 19),
('Karg�', 19),
('Mecit�z�', 19),
('Ortak�y / �orum', 19),
('Osmanc�k', 19),
('Sungurlu', 19),
('Bo�azkale', 19),
('U�urluda�', 19),
('Dodurga', 19),
('La�in', 19),
('O�uzlar', 19),
('Ac�payam', 20),
('Buldan', 20),
('�al', 20),
('�ameli', 20),
('�ardak', 20),
('�ivril', 20),
('G�ney', 20),
('Kale / Denizli', 20),
('Sarayk�y', 20),
('Tavas', 20),
('Babada�', 20),
('Bekilli', 20),
('Honaz', 20),
('Serinhisar', 20),
('Pamukkale', 20),
('Baklan', 20),
('Beya�a�', 20),
('Bozkurt / Denizli', 20),
('Merkezefendi', 20),
('Bismil', 21),
('�ermik', 21),
('��nar', 21),
('��ng��', 21),
('Dicle', 21),
('Ergani', 21),
('Hani', 21),
('Hazro', 21),
('Kulp', 21),
('Lice', 21),
('Silvan', 21),
('E�il', 21),
('Kocak�y', 21),
('Ba�lar', 21),
('Kayap�nar', 21),
('Sur', 21),
('Yeni�ehir / Diyarbak�r', 21),
('Edirne Merkez', 22),
('Enez', 22),
('Havsa', 22),
('�psala', 22),
('Ke�an', 22),
('Lalapa�a', 22),
('Meri�', 22),
('Uzunk�pr�', 22),
('S�lo�lu', 22),
('A��n', 23),
('Baskil', 23),
('Elaz�� Merkez', 23),
('Karako�an', 23),
('Keban', 23),
('Maden', 23),
('Palu', 23),
('Sivrice', 23),
('Ar�cak', 23),
('Kovanc�lar', 23),
('Alacakaya', 23),
('�ay�rl�', 24),
('Erzincan Merkez', 24),
('�li�', 24),
('Kemah', 24),
('Kemaliye', 24),
('Refahiye', 24),
('Tercan', 24),
('�z�ml�', 24),
('Otlukbeli', 24),
('A�kale', 25),
('�at', 25),
('H�n�s', 25),
('Horasan', 25),
('�spir', 25),
('Karayaz�', 25),
('Narman', 25),
('Oltu', 25),
('Olur', 25),
('Pasinler', 25),
('�enkaya', 25),
('Tekman', 25),
('Tortum', 25),
('Kara�oban', 25),
('Uzundere', 25),
('Pazaryolu', 25),
('Aziziye', 25),
('K�pr�k�y', 25),
('Paland�ken', 25),
('Yakutiye', 25),
('�ifteler', 26),
('Mahmudiye', 26),
('Mihal����k', 26),
('Sar�cakaya', 26),
('Seyitgazi', 26),
('Sivrihisar', 26),
('Alpu', 26),
('Beylikova', 26),
('�n�n�', 26),
('G�ny�z�', 26),
('Han', 26),
('Mihalgazi', 26),
('Odunpazar�', 26),
('Tepeba��', 26),
('Araban', 27),
('�slahiye', 27),
('Nizip', 27),
('O�uzeli', 27),
('Yavuzeli', 27),
('�ahinbey', 27),
('�ehitkamil', 27),
('Karkam��', 27),
('Nurda��', 27),
('Alucra', 28),
('Bulancak', 28),
('Dereli', 28),
('Espiye', 28),
('Eynesil', 28),
('Giresun Merkez', 28),
('G�rele', 28),
('Ke�ap', 28),
('�ebinkarahisar', 28),
('Tirebolu', 28),
('Piraziz', 28),
('Ya�l�dere', 28),
('�amoluk', 28),
('�anak��', 28),
('Do�ankent', 28),
('G�ce', 28),
('G�m��hane Merkez', 29),
('Kelkit', 29),
('�iran', 29),
('Torul', 29),
('K�se', 29),
('K�rt�n', 29),
('�ukurca', 30),
('Hakkari Merkez', 30),
('�emdinli', 30),
('Y�ksekova', 30),
('Alt�n�z�', 31),
('D�rtyol', 31),
('Hassa', 31),
('�skenderun', 31),
('K�r�khan', 31),
('Reyhanl�', 31),
('Samanda�', 31),
('Yaylada��', 31),
('Erzin', 31),
('Belen', 31),
('Kumlu', 31),
('Antakya', 31),
('Arsuz', 31),
('Defne', 31),
('Payas', 31),
('Atabey', 32),
('E�irdir', 32),
('Gelendost', 32),
('Isparta Merkez', 32),
('Ke�iborlu', 32),
('Senirkent', 32),
('S�t��ler', 32),
('�arkikaraa�a�', 32),
('Uluborlu', 32),
('Yalva�', 32),
('Aksu / Isparta', 32),
('G�nen / Isparta', 32),
('Yeni�arbademli', 32),
('Anamur', 33),
('Erdemli', 33),
('G�lnar', 33),
('Mut', 33),
('Silifke', 33),
('Tarsus', 33),
('Ayd�nc�k / Mersin', 33),
('Bozyaz�', 33),
('�aml�yayla', 33),
('Akdeniz', 33),
('Mezitli', 33),
('Toroslar', 33),
('Yeni�ehir / Mersin', 33),
('Adalar', 34),
('Bak�rk�y', 34),
('Be�ikta�', 34),
('Beykoz', 34),
('Beyo�lu', 34),
('�atalca', 34),
('Ey�p', 34),
('Fatih', 34),
('Gaziosmanpa�a', 34),
('Kad�k�y', 34),
('Kartal', 34),
('Sar�yer', 34),
('Silivri', 34),
('�ile', 34),
('�i�li', 34),
('�sk�dar', 34),
('Zeytinburnu', 34),
('B�y�k�ekmece', 34),
('Ka��thane', 34),
('K���k�ekmece', 34),
('Pendik', 34),
('�mraniye', 34),
('Bayrampa�a', 34),
('Avc�lar', 34),
('Ba�c�lar', 34),
('Bah�elievler', 34),
('G�ng�ren', 34),
('Maltepe', 34),
('Sultanbeyli', 34),
('Tuzla', 34),
('Esenler', 34),
('Arnavutk�y', 34),
('Ata�ehir', 34),
('Ba�ak�ehir', 34),
('Beylikd�z�', 34),
('�ekmek�y', 34),
('Esenyurt', 34),
('Sancaktepe', 34),
('Sultangazi', 34),
('Alia�a', 35),
('Bay�nd�r', 35),
('Bergama', 35),
('Bornova', 35),
('�e�me', 35),
('Dikili', 35),
('Fo�a', 35),
('Karaburun', 35),
('Kar��yaka', 35),
('Kemalpa�a / �zmir', 35),
('K�n�k', 35),
('Kiraz', 35),
('Menemen', 35),
('�demi�', 35),
('Seferihisar', 35),
('Sel�uk', 35),
('Tire', 35),
('Torbal�', 35),
('Urla', 35),
('Beyda�', 35),
('Buca', 35),
('Konak', 35),
('Menderes', 35),
('Bal�ova', 35),
('�i�li', 35),
('Gaziemir', 35),
('Narl�dere', 35),
('G�zelbah�e', 35),
('Bayrakl�', 35),
('Karaba�lar', 35),
('Arpa�ay', 36),
('Digor', 36),
('Ka��zman', 36),
('Kars Merkez', 36),
('Sar�kam��', 36),
('Selim', 36),
('Susuz', 36),
('Akyaka', 36),
('Abana', 37),
('Ara�', 37),
('Azdavay', 37),
('Bozkurt / Kastamonu', 37),
('Cide', 37),
('�atalzeytin', 37),
('Daday', 37),
('Devrekani', 37),
('�nebolu', 37),
('Kastamonu Merkez', 37),
('K�re', 37),
('Ta�k�pr�', 37),
('Tosya', 37),
('�hsangazi', 37),
('P�narba�� / Kastamonu', 37),
('�enpazar', 37),
('A�l�', 37),
('Do�anyurt', 37),
('Han�n�', 37),
('Seydiler', 37),
('B�nyan', 38),
('Develi', 38),
('Felahiye', 38),
('�ncesu', 38),
('P�narba�� / Kayseri', 38),
('Sar�o�lan', 38),
('Sar�z', 38),
('Tomarza', 38),
('Yahyal�', 38),
('Ye�ilhisar', 38),
('Akk��la', 38),
('Talas', 38),
('Kocasinan', 38),
('Melikgazi', 38),
('Hac�lar', 38),
('�zvatan', 38),
('Babaeski', 39),
('Demirk�y', 39),
('K�rklareli Merkez', 39),
('Kof�az', 39),
('L�leburgaz', 39),
('Pehlivank�y', 39),
('P�narhisar', 39),
('Vize', 39),
('�i�ekda��', 40),
('Kaman', 40),
('K�r�ehir Merkez', 40),
('Mucur', 40),
('Akp�nar', 40),
('Ak�akent', 40),
('Boztepe', 40),
('Gebze', 41),
('G�lc�k', 41),
('Kand�ra', 41),
('Karam�rsel', 41),
('K�rfez', 41),
('Derince', 41),
('Ba�iskele', 41),
('�ay�rova', 41),
('Dar�ca', 41),
('Dilovas�', 41),
('�zmit', 41),
('Kartepe', 41),
('Ak�ehir', 42),
('Bey�ehir', 42),
('Bozk�r', 42),
('Cihanbeyli', 42),
('�umra', 42),
('Do�anhisar', 42),
('Ere�li / Konya', 42),
('Hadim', 42),
('Ilg�n', 42),
('Kad�nhan�', 42),
('Karap�nar', 42),
('Kulu', 42),
('Saray�n�', 42),
('Seydi�ehir', 42),
('Yunak', 42),
('Ak�ren', 42),
('Alt�nekin', 42),
('Derebucak', 42),
('H�y�k', 42),
('Karatay', 42),
('Meram', 42),
('Sel�uklu', 42),
('Ta�kent', 42),
('Ah�rl�', 42),
('�eltik', 42),
('Derbent', 42),
('Emirgazi', 42),
('G�neys�n�r', 42),
('Halkap�nar', 42),
('Tuzluk�u', 42),
('Yal�h�y�k', 42),
('Alt�nta�', 43),
('Domani�', 43),
('Emet', 43),
('Gediz', 43),
('K�tahya Merkez', 43),
('Simav', 43),
('Tav�anl�', 43),
('Aslanapa', 43),
('Dumlup�nar', 43),
('Hisarc�k', 43),
('�aphane', 43),
('�avdarhisar', 43),
('Pazarlar', 43),
('Ak�ada�', 44),
('Arapgir', 44),
('Arguvan', 44),
('Darende', 44),
('Do�an�ehir', 44),
('Hekimhan', 44),
('P�t�rge', 44),
('Ye�ilyurt / Malatya', 44),
('Battalgazi', 44),
('Do�anyol', 44),
('Kale / Malatya', 44),
('Kuluncak', 44),
('Yaz�han', 44),
('Akhisar', 45),
('Ala�ehir', 45),
('Demirci', 45),
('G�rdes', 45),
('K�rka�a�', 45),
('Kula', 45),
('Salihli', 45),
('Sar�g�l', 45),
('Saruhanl�', 45),
('Selendi', 45),
('Soma', 45),
('Turgutlu', 45),
('Ahmetli', 45),
('G�lmarmara', 45),
('K�pr�ba�� / Manisa', 45),
('�ehzadeler', 45),
('Yunusemre', 45),
('Af�in', 46),
('And�r�n', 46),
('Elbistan', 46),
('G�ksun', 46),
('Pazarc�k', 46),
('T�rko�lu', 46),
('�a�layancerit', 46),
('Ekin�z�', 46),
('Nurhak', 46),
('Dulkadiro�lu', 46),
('Oniki�ubat', 46),
('Derik', 47),
('K�z�ltepe', 47),
('Maz�da��', 47),
('Midyat', 47),
('Nusaybin', 47),
('�merli', 47),
('Savur', 47),
('Darge�it', 47),
('Ye�illi', 47),
('Artuklu', 47),
('Bodrum', 48),
('Dat�a', 48),
('Fethiye', 48),
('K�yce�iz', 48),
('Marmaris', 48),
('Milas', 48),
('Ula', 48),
('Yata�an', 48),
('Dalaman', 48),
('Ortaca', 48),
('Kavakl�dere', 48),
('Mente�e', 48),
('Seydikemer', 48),
('Bulan�k', 49),
('Malazgirt', 49),
('Mu� Merkez', 49),
('Varto', 49),
('Hask�y', 49),
('Korkut', 49),
('Avanos', 50),
('Derinkuyu', 50),
('G�l�ehir', 50),
('Hac�bekta�', 50),
('Kozakl�', 50),
('Nev�ehir Merkez', 50),
('�rg�p', 50),
('Ac�g�l', 50),
('Bor', 51),
('�amard�', 51),
('Ni�de Merkez', 51),
('Uluk��la', 51),
('Altunhisar', 51),
('�iftlik', 51),
('Akku�', 52),
('Aybast�', 52),
('Fatsa', 52),
('G�lk�y', 52),
('Korgan', 52),
('Kumru', 52),
('Mesudiye', 52),
('Per�embe', 52),
('Ulubey / Ordu', 52),
('�nye', 52),
('G�lyal�', 52),
('G�rgentepe', 52),
('�ama�', 52),
('�atalp�nar', 52),
('�ayba��', 52),
('�kizce', 52),
('Kabad�z', 52),
('Kabata�', 52),
('Alt�nordu', 52),
('Arde�en', 53),
('�aml�hem�in', 53),
('�ayeli', 53),
('F�nd�kl�', 53),
('�kizdere', 53),
('Kalkandere', 53),
('Pazar / Rize', 53),
('Rize Merkez', 53),
('G�neysu', 53),
('Derepazar�', 53),
('Hem�in', 53),
('�yidere', 53),
('Akyaz�', 54),
('Geyve', 54),
('Hendek', 54),
('Karasu', 54),
('Kaynarca', 54),
('Sapanca', 54),
('Kocaali', 54),
('Pamukova', 54),
('Tarakl�', 54),
('Ferizli', 54),
('Karap�r�ek', 54),
('S���tl�', 54),
('Adapazar�', 54),
('Arifiye', 54),
('Erenler', 54),
('Serdivan', 54),
('Ala�am', 55),
('Bafra', 55),
('�ar�amba', 55),
('Havza', 55),
('Kavak', 55),
('Ladik', 55),
('Terme', 55),
('Vezirk�pr�', 55),
('Asarc�k', 55),
('19 May�s', 55),
('Sal�pazar�', 55),
('Tekkek�y', 55),
('Ayvac�k / Samsun', 55),
('Yakakent', 55),
('Atakum', 55),
('Canik', 55),
('�lkad�m', 55),
('Baykan', 56),
('Eruh', 56),
('Kurtalan', 56),
('Pervari', 56),
('Siirt Merkez', 56),
('�irvan', 56),
('Tillo', 56),
('Ayanc�k', 57),
('Boyabat', 57),
('Dura�an', 57),
('Erfelek', 57),
('Gerze', 57),
('Sinop Merkez', 57),
('T�rkeli', 57),
('Dikmen', 57),
('Sarayd�z�', 57),
('Divri�i', 58),
('Gemerek', 58),
('G�r�n', 58),
('Hafik', 58),
('�mranl�', 58),
('Kangal', 58),
('Koyulhisar', 58),
('Sivas Merkez', 58),
('Su�ehri', 58),
('�ark��la', 58),
('Y�ld�zeli', 58),
('Zara', 58),
('Ak�nc�lar', 58),
('Alt�nyayla / Sivas', 58),
('Do�an�ar', 58),
('G�lova', 58),
('Ula�', 58),
('�erkezk�y', 59),
('�orlu', 59),
('Hayrabolu', 59),
('Malkara', 59),
('Muratl�', 59),
('Saray / Tekirda�', 59),
('�ark�y', 59),
('Marmaraere�lisi', 59),
('Ergene', 59),
('Kapakl�', 59),
('S�leymanpa�a', 59),
('Almus', 60),
('Artova', 60),
('Erbaa', 60),
('Niksar', 60),
('Re�adiye', 60),
('Tokat Merkez', 60),
('Turhal', 60),
('Zile', 60),
('Pazar / Tokat', 60),
('Ye�ilyurt / Tokat', 60),
('Ba��iftlik', 60),
('Sulusaray', 60),
('Ak�aabat', 61),
('Arakl�', 61),
('Arsin', 61),
('�aykara', 61),
('Ma�ka', 61),
('Of', 61),
('S�rmene', 61),
('Tonya', 61),
('Vakf�kebir', 61),
('Yomra', 61),
('Be�ikd�z�', 61),
('�alpazar�', 61),
('�ar��ba��', 61),
('Dernekpazar�', 61),
('D�zk�y', 61),
('Hayrat', 61),
('K�pr�ba�� / Trabzon', 61),
('Ortahisar', 61),
('�emi�gezek', 62),
('Hozat', 62),
('Mazgirt', 62),
('Naz�miye', 62),
('Ovac�k / Tunceli', 62),
('Pertek', 62),
('P�l�m�r', 62),
('Tunceli Merkez', 62),
('Ak�akale', 63),
('Birecik', 63),
('Bozova', 63),
('Ceylanp�nar', 63),
('Halfeti', 63),
('Hilvan', 63),
('Siverek', 63),
('Suru�', 63),
('Viran�ehir', 63),
('Harran', 63),
('Eyy�biye', 63),
('Haliliye', 63),
('Karak�pr�', 63),
('Banaz', 64),
('E�me', 64),
('Karahall�', 64),
('Sivasl�', 64),
('Ulubey / U�ak', 64),
('U�ak Merkez', 64),
('Ba�kale', 65),
('�atak', 65),
('Erci�', 65),
('Geva�', 65),
('G�rp�nar', 65),
('Muradiye', 65),
('�zalp', 65),
('Bah�esaray', 65),
('�ald�ran', 65),
('Edremit / Van', 65),
('Saray / Van', 65),
('�pekyolu', 65),
('Tu�ba', 65),
('Akda�madeni', 66),
('Bo�azl�yan', 66),
('�ay�ralan', 66),
('�ekerek', 66),
('Sar�kaya', 66),
('Sorgun', 66),
('�efaatli', 66),
('Yerk�y', 66),
('Yozgat Merkez', 66),
('Ayd�nc�k / Yozgat', 66),
('�and�r', 66),
('Kad��ehri', 66),
('Saraykent', 66),
('Yenifak�l�', 66),
('�aycuma', 67),
('Devrek', 67),
('Ere�li / Zonguldak', 67),
('Zonguldak Merkez', 67),
('Alapl�', 67),
('G�k�ebey', 67),
('Kilimli', 67),
('Kozlu', 67),
('Aksaray Merkez', 68),
('Ortak�y / Aksaray', 68),
('A�a��ren', 68),
('G�zelyurt', 68),
('Sar�yah�i', 68),
('Eskil', 68),
('G�la�a�', 68),
('Bayburt Merkez', 69),
('Ayd�ntepe', 69),
('Demir�z�', 69),
('Ermenek', 70),
('Karaman Merkez', 70),
('Ayranc�', 70),
('Kaz�mkarabekir', 70),
('Ba�yayla', 70),
('Sar�veliler', 70),
('Delice', 71),
('Keskin', 71),
('K�r�kkale Merkez', 71),
('Sulakyurt', 71),
('Bah�ili', 71),
('Bal��eyh', 71),
('�elebi', 71),
('Karake�ili', 71),
('Yah�ihan', 71),
('Batman Merkez', 72),
('Be�iri', 72),
('Gerc��', 72),
('Kozluk', 72),
('Sason', 72),
('Hasankeyf', 72),
('Beyt���ebap', 73),
('Cizre', 73),
('�dil', 73),
('Silopi', 73),
('��rnak Merkez', 73),
('Uludere', 73),
('G��l�konak', 73),
('Bart�n Merkez', 74),
('Kuruca�ile', 74),
('Ulus', 74),
('Amasra', 74),
('Ardahan Merkez', 75),
('��ld�r', 75),
('G�le', 75),
('Hanak', 75),
('Posof', 75),
('Damal', 75),
('Aral�k', 76),
('I�d�r Merkez', 76),
('Tuzluca', 76),
('Karakoyunlu', 76),
('Yalova Merkez', 77),
('Alt�nova', 77),
('Armutlu', 77),
('��narc�k', 77),
('�iftlikk�y', 77),
('Termal', 77),
('Eflani', 78),
('Eskipazar', 78),
('Karab�k Merkez', 78),
('Ovac�k / Karab�k', 78),
('Safranbolu', 78),
('Yenice / Karab�k', 78),
('Kilis Merkez', 79),
('Elbeyli', 79),
('Musabeyli', 79),
('Polateli', 79),
('Bah�e', 80),
('Kadirli', 80),
('Osmaniye Merkez', 80),
('D�zi�i', 80),
('Hasanbeyli', 80),
('Sumbas', 80),
('Toprakkale', 80),
('Ak�akoca', 81),
('D�zce Merkez', 81),
('Y���lca', 81),
('Cumayeri', 81),
('G�lyaka', 81),
('�ilimli', 81),
('G�m��ova', 81),
('Kayna�l�', 81);