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
('Adýyaman'),
('Afyonkarahisar'),
('Aðrý'),
('Amasya'),
('Ankara'),
('Antalya'),
('Artvin'),
('Aydýn'),
('Balýkesir'),
('Bilecik'),
('Bingöl'),
('Bitlis'),
('Bolu'),
('Burdur'),
('Bursa'),
('Çanakkale'),
('Çankýrý'),
('Çorum'),
('Denizli'),
('Diyarbakýr'),
('Edirne'),
('Elazýð'),
('Erzincan'),
('Erzurum'),
('Eskiþehir'),
('Gaziantep'),
('Giresun'),
('Gümüþhane'),
('Hakkari'),
('Hatay'),
('Isparta'),
('Mersin'),
('Ýstanbul'),
('Ýzmir'),
('Kars'),
('Kastamonu'),
('Kayseri'),
('Kýrklareli'),
('Kýrþehir'),
('Kocaeli'),
('Konya'),
('Kütahya'),
('Malatya'),
('Manisa'),
('Kahramanmaraþ'),
('Mardin'),
('Muðla'),
('Muþ'),
('Nevþehir'),
('Niðde'),
('Ordu'),
('Rize'),
('Sakarya'),
('Samsun'),
('Siirt'),
('Sinop'),
('Sivas'),
('Tekirdað'),
('Tokat'),
('Trabzon'),
('Tunceli'),
('Þanlýurfa'),
('Uþak'),
('Van'),
('Yozgat'),
('Zonguldak'),
('Aksaray'),
('Bayburt'),
('Karaman'),
('Kýrýkkale'),
('Batman'),
('Þýrnak'),
('Bartýn'),
('Ardahan'),
('Iðdýr'),
('Yalova'),
('Karabük'),
('Kilis'),
('Osmaniye'),
('Düzce');
INSERT INTO Ilceler (Ad,SehirId) VALUES
('Seyhan', 1),
('Ceyhan', 1),
('Feke', 1),
('Karaisalý', 1),
('Karataþ', 1),
('Kozan', 1),
('Pozantý', 1),
('Saimbeyli', 1),
('Tufanbeyli', 1),
('Yumurtalýk', 1),
('Yüreðir', 1),
('Aladað', 1),
('Ýmamoðlu', 1),
('Sarýçam', 1),
('Çukurova', 1),
('Adýyaman Merkez', 2),
('Besni', 2),
('Çelikhan', 2),
('Gerger', 2),
('Gölbaþý / Adýyaman', 2),
('Kahta', 2),
('Samsat', 2),
('Sincik', 2),
('Tut', 2),
('Afyonkarahisar Merkez', 3),
('Bolvadin', 3),
('Çay', 3),
('Dazkýrý', 3),
('Dinar', 3),
('Emirdað', 3),
('Ýhsaniye', 3),
('Sandýklý', 3),
('Sinanpaþa', 3),
('Sultandaðý', 3),
('Þuhut', 3),
('Baþmakçý', 3),
('Bayat / Afyonkarahisar', 3),
('Ýscehisar', 3),
('Çobanlar', 3),
('Evciler', 3),
('Hocalar', 3),
('Kýzýlören', 3),
('Aðrý Merkez', 4),
('Diyadin', 4),
('Doðubayazýt', 4),
('Eleþkirt', 4),
('Hamur', 4),
('Patnos', 4),
('Taþlýçay', 4),
('Tutak', 4),
('Amasya Merkez', 5),
('Göynücek', 5),
('Gümüþhacýköy', 5),
('Merzifon', 5),
('Suluova', 5),
('Taþova', 5),
('Hamamözü', 5),
('Altýndað', 6),
('Ayaþ', 6),
('Bala', 6),
('Beypazarý', 6),
('Çamlýdere', 6),
('Çankaya', 6),
('Çubuk', 6),
('Elmadað', 6),
('Güdül', 6),
('Haymana', 6),
('Kalecik', 6),
('Kýzýlcahamam', 6),
('Nallýhan', 6),
('Polatlý', 6),
('Þereflikoçhisar', 6),
('Yenimahalle', 6),
('Gölbaþý / Ankara', 6),
('Keçiören', 6),
('Mamak', 6),
('Sincan', 6),
('Kazan', 6),
('Akyurt', 6),
('Etimesgut', 6),
('Evren', 6),
('Pursaklar', 6),
('Akseki', 7),
('Alanya', 7),
('Elmalý', 7),
('Finike', 7),
('Gazipaþa', 7),
('Gündoðmuþ', 7),
('Kaþ', 7),
('Korkuteli', 7),
('Kumluca', 7),
('Manavgat', 7),
('Serik', 7),
('Demre', 7),
('Ýbradý', 7),
('Kemer / Antalya', 7),
('Aksu / Antalya', 7),
('Döþemealtý', 7),
('Kepez', 7),
('Konyaaltý', 7),
('Muratpaþa', 7),
('Ardanuç', 8),
('Arhavi', 8),
('Artvin Merkez', 8),
('Borçka', 8),
('Hopa', 8),
('Þavþat', 8),
('Yusufeli', 8),
('Murgul', 8),
('Bozdoðan', 9),
('Çine', 9),
('Germencik', 9),
('Karacasu', 9),
('Koçarlý', 9),
('Kuþadasý', 9),
('Kuyucak', 9),
('Nazilli', 9),
('Söke', 9),
('Sultanhisar', 9),
('Yenipazar / Aydýn', 9),
('Buharkent', 9),
('Ýncirliova', 9),
('Karpuzlu', 9),
('Köþk', 9),
('Didim', 9),
('Efeler', 9),
('Ayvalýk', 10),
('Balya', 10),
('Bandýrma', 10),
('Bigadiç', 10),
('Burhaniye', 10),
('Dursunbey', 10),
('Edremit / Balýkesir', 10),
('Erdek', 10),
('Gönen / Balýkesir', 10),
('Havran', 10),
('Ývrindi', 10),
('Kepsut', 10),
('Manyas', 10),
('Savaþtepe', 10),
('Sýndýrgý', 10),
('Susurluk', 10),
('Marmara', 10),
('Gömeç', 10),
('Altýeylül', 10),
('Karesi', 10),
('Bilecik Merkez', 11),
('Bozüyük', 11),
('Gölpazarý', 11),
('Osmaneli', 11),
('Pazaryeri', 11),
('Söðüt', 11),
('Yenipazar / Bilecik', 11),
('Ýnhisar', 11),
('Bingöl Merkez', 12),
('Genç', 12),
('Karlýova', 12),
('Kiðý', 12),
('Solhan', 12),
('Adaklý', 12),
('Yayladere', 12),
('Yedisu', 12),
('Adilcevaz', 13),
('Ahlat', 13),
('Bitlis Merkez', 13),
('Hizan', 13),
('Mutki', 13),
('Tatvan', 13),
('Güroymak', 13),
('Bolu Merkez', 14),
('Gerede', 14),
('Göynük', 14),
('Kýbrýscýk', 14),
('Mengen', 14),
('Mudurnu', 14),
('Seben', 14),
('Dörtdivan', 14),
('Yeniçaða', 14),
('Aðlasun', 15),
('Bucak', 15),
('Burdur Merkez', 15),
('Gölhisar', 15),
('Tefenni', 15),
('Yeþilova', 15),
('Karamanlý', 15),
('Kemer / Burdur', 15),
('Altýnyayla / Burdur', 15),
('Çavdýr', 15),
('Çeltikçi', 15),
('Gemlik', 16),
('Ýnegöl', 16),
('Ýznik', 16),
('Karacabey', 16),
('Keles', 16),
('Mudanya', 16),
('Mustafakemalpaþa', 16),
('Orhaneli', 16),
('Orhangazi', 16),
('Yeniþehir / Bursa', 16),
('Büyükorhan', 16),
('Harmancýk', 16),
('Nilüfer', 16),
('Osmangazi', 16),
('Yýldýrým', 16),
('Gürsu', 16),
('Kestel', 16),
('Ayvacýk / Çanakkale', 17),
('Bayramiç', 17),
('Biga', 17),
('Bozcaada', 17),
('Çan', 17),
('Çanakkale Merkez', 17),
('Eceabat', 17),
('Ezine', 17),
('Gelibolu', 17),
('Gökçeada', 17),
('Lapseki', 17),
('Yenice / Çanakkale', 17),
('Çankýrý Merkez', 18),
('Çerkeþ', 18),
('Eldivan', 18),
('Ilgaz', 18),
('Kurþunlu', 18),
('Orta', 18),
('Þabanözü', 18),
('Yapraklý', 18),
('Atkaracalar', 18),
('Kýzýlýrmak', 18),
('Bayramören', 18),
('Korgun', 18),
('Alaca', 19),
('Bayat / Çorum', 19),
('Çorum Merkez', 19),
('Ýskilip', 19),
('Kargý', 19),
('Mecitözü', 19),
('Ortaköy / Çorum', 19),
('Osmancýk', 19),
('Sungurlu', 19),
('Boðazkale', 19),
('Uðurludað', 19),
('Dodurga', 19),
('Laçin', 19),
('Oðuzlar', 19),
('Acýpayam', 20),
('Buldan', 20),
('Çal', 20),
('Çameli', 20),
('Çardak', 20),
('Çivril', 20),
('Güney', 20),
('Kale / Denizli', 20),
('Sarayköy', 20),
('Tavas', 20),
('Babadað', 20),
('Bekilli', 20),
('Honaz', 20),
('Serinhisar', 20),
('Pamukkale', 20),
('Baklan', 20),
('Beyaðaç', 20),
('Bozkurt / Denizli', 20),
('Merkezefendi', 20),
('Bismil', 21),
('Çermik', 21),
('Çýnar', 21),
('Çüngüþ', 21),
('Dicle', 21),
('Ergani', 21),
('Hani', 21),
('Hazro', 21),
('Kulp', 21),
('Lice', 21),
('Silvan', 21),
('Eðil', 21),
('Kocaköy', 21),
('Baðlar', 21),
('Kayapýnar', 21),
('Sur', 21),
('Yeniþehir / Diyarbakýr', 21),
('Edirne Merkez', 22),
('Enez', 22),
('Havsa', 22),
('Ýpsala', 22),
('Keþan', 22),
('Lalapaþa', 22),
('Meriç', 22),
('Uzunköprü', 22),
('Süloðlu', 22),
('Aðýn', 23),
('Baskil', 23),
('Elazýð Merkez', 23),
('Karakoçan', 23),
('Keban', 23),
('Maden', 23),
('Palu', 23),
('Sivrice', 23),
('Arýcak', 23),
('Kovancýlar', 23),
('Alacakaya', 23),
('Çayýrlý', 24),
('Erzincan Merkez', 24),
('Ýliç', 24),
('Kemah', 24),
('Kemaliye', 24),
('Refahiye', 24),
('Tercan', 24),
('Üzümlü', 24),
('Otlukbeli', 24),
('Aþkale', 25),
('Çat', 25),
('Hýnýs', 25),
('Horasan', 25),
('Ýspir', 25),
('Karayazý', 25),
('Narman', 25),
('Oltu', 25),
('Olur', 25),
('Pasinler', 25),
('Þenkaya', 25),
('Tekman', 25),
('Tortum', 25),
('Karaçoban', 25),
('Uzundere', 25),
('Pazaryolu', 25),
('Aziziye', 25),
('Köprüköy', 25),
('Palandöken', 25),
('Yakutiye', 25),
('Çifteler', 26),
('Mahmudiye', 26),
('Mihalýççýk', 26),
('Sarýcakaya', 26),
('Seyitgazi', 26),
('Sivrihisar', 26),
('Alpu', 26),
('Beylikova', 26),
('Ýnönü', 26),
('Günyüzü', 26),
('Han', 26),
('Mihalgazi', 26),
('Odunpazarý', 26),
('Tepebaþý', 26),
('Araban', 27),
('Ýslahiye', 27),
('Nizip', 27),
('Oðuzeli', 27),
('Yavuzeli', 27),
('Þahinbey', 27),
('Þehitkamil', 27),
('Karkamýþ', 27),
('Nurdaðý', 27),
('Alucra', 28),
('Bulancak', 28),
('Dereli', 28),
('Espiye', 28),
('Eynesil', 28),
('Giresun Merkez', 28),
('Görele', 28),
('Keþap', 28),
('Þebinkarahisar', 28),
('Tirebolu', 28),
('Piraziz', 28),
('Yaðlýdere', 28),
('Çamoluk', 28),
('Çanakçý', 28),
('Doðankent', 28),
('Güce', 28),
('Gümüþhane Merkez', 29),
('Kelkit', 29),
('Þiran', 29),
('Torul', 29),
('Köse', 29),
('Kürtün', 29),
('Çukurca', 30),
('Hakkari Merkez', 30),
('Þemdinli', 30),
('Yüksekova', 30),
('Altýnözü', 31),
('Dörtyol', 31),
('Hassa', 31),
('Ýskenderun', 31),
('Kýrýkhan', 31),
('Reyhanlý', 31),
('Samandað', 31),
('Yayladaðý', 31),
('Erzin', 31),
('Belen', 31),
('Kumlu', 31),
('Antakya', 31),
('Arsuz', 31),
('Defne', 31),
('Payas', 31),
('Atabey', 32),
('Eðirdir', 32),
('Gelendost', 32),
('Isparta Merkez', 32),
('Keçiborlu', 32),
('Senirkent', 32),
('Sütçüler', 32),
('Þarkikaraaðaç', 32),
('Uluborlu', 32),
('Yalvaç', 32),
('Aksu / Isparta', 32),
('Gönen / Isparta', 32),
('Yeniþarbademli', 32),
('Anamur', 33),
('Erdemli', 33),
('Gülnar', 33),
('Mut', 33),
('Silifke', 33),
('Tarsus', 33),
('Aydýncýk / Mersin', 33),
('Bozyazý', 33),
('Çamlýyayla', 33),
('Akdeniz', 33),
('Mezitli', 33),
('Toroslar', 33),
('Yeniþehir / Mersin', 33),
('Adalar', 34),
('Bakýrköy', 34),
('Beþiktaþ', 34),
('Beykoz', 34),
('Beyoðlu', 34),
('Çatalca', 34),
('Eyüp', 34),
('Fatih', 34),
('Gaziosmanpaþa', 34),
('Kadýköy', 34),
('Kartal', 34),
('Sarýyer', 34),
('Silivri', 34),
('Þile', 34),
('Þiþli', 34),
('Üsküdar', 34),
('Zeytinburnu', 34),
('Büyükçekmece', 34),
('Kaðýthane', 34),
('Küçükçekmece', 34),
('Pendik', 34),
('Ümraniye', 34),
('Bayrampaþa', 34),
('Avcýlar', 34),
('Baðcýlar', 34),
('Bahçelievler', 34),
('Güngören', 34),
('Maltepe', 34),
('Sultanbeyli', 34),
('Tuzla', 34),
('Esenler', 34),
('Arnavutköy', 34),
('Ataþehir', 34),
('Baþakþehir', 34),
('Beylikdüzü', 34),
('Çekmeköy', 34),
('Esenyurt', 34),
('Sancaktepe', 34),
('Sultangazi', 34),
('Aliaða', 35),
('Bayýndýr', 35),
('Bergama', 35),
('Bornova', 35),
('Çeþme', 35),
('Dikili', 35),
('Foça', 35),
('Karaburun', 35),
('Karþýyaka', 35),
('Kemalpaþa / Ýzmir', 35),
('Kýnýk', 35),
('Kiraz', 35),
('Menemen', 35),
('Ödemiþ', 35),
('Seferihisar', 35),
('Selçuk', 35),
('Tire', 35),
('Torbalý', 35),
('Urla', 35),
('Beydað', 35),
('Buca', 35),
('Konak', 35),
('Menderes', 35),
('Balçova', 35),
('Çiðli', 35),
('Gaziemir', 35),
('Narlýdere', 35),
('Güzelbahçe', 35),
('Bayraklý', 35),
('Karabaðlar', 35),
('Arpaçay', 36),
('Digor', 36),
('Kaðýzman', 36),
('Kars Merkez', 36),
('Sarýkamýþ', 36),
('Selim', 36),
('Susuz', 36),
('Akyaka', 36),
('Abana', 37),
('Araç', 37),
('Azdavay', 37),
('Bozkurt / Kastamonu', 37),
('Cide', 37),
('Çatalzeytin', 37),
('Daday', 37),
('Devrekani', 37),
('Ýnebolu', 37),
('Kastamonu Merkez', 37),
('Küre', 37),
('Taþköprü', 37),
('Tosya', 37),
('Ýhsangazi', 37),
('Pýnarbaþý / Kastamonu', 37),
('Þenpazar', 37),
('Aðlý', 37),
('Doðanyurt', 37),
('Hanönü', 37),
('Seydiler', 37),
('Bünyan', 38),
('Develi', 38),
('Felahiye', 38),
('Ýncesu', 38),
('Pýnarbaþý / Kayseri', 38),
('Sarýoðlan', 38),
('Sarýz', 38),
('Tomarza', 38),
('Yahyalý', 38),
('Yeþilhisar', 38),
('Akkýþla', 38),
('Talas', 38),
('Kocasinan', 38),
('Melikgazi', 38),
('Hacýlar', 38),
('Özvatan', 38),
('Babaeski', 39),
('Demirköy', 39),
('Kýrklareli Merkez', 39),
('Kofçaz', 39),
('Lüleburgaz', 39),
('Pehlivanköy', 39),
('Pýnarhisar', 39),
('Vize', 39),
('Çiçekdaðý', 40),
('Kaman', 40),
('Kýrþehir Merkez', 40),
('Mucur', 40),
('Akpýnar', 40),
('Akçakent', 40),
('Boztepe', 40),
('Gebze', 41),
('Gölcük', 41),
('Kandýra', 41),
('Karamürsel', 41),
('Körfez', 41),
('Derince', 41),
('Baþiskele', 41),
('Çayýrova', 41),
('Darýca', 41),
('Dilovasý', 41),
('Ýzmit', 41),
('Kartepe', 41),
('Akþehir', 42),
('Beyþehir', 42),
('Bozkýr', 42),
('Cihanbeyli', 42),
('Çumra', 42),
('Doðanhisar', 42),
('Ereðli / Konya', 42),
('Hadim', 42),
('Ilgýn', 42),
('Kadýnhaný', 42),
('Karapýnar', 42),
('Kulu', 42),
('Sarayönü', 42),
('Seydiþehir', 42),
('Yunak', 42),
('Akören', 42),
('Altýnekin', 42),
('Derebucak', 42),
('Hüyük', 42),
('Karatay', 42),
('Meram', 42),
('Selçuklu', 42),
('Taþkent', 42),
('Ahýrlý', 42),
('Çeltik', 42),
('Derbent', 42),
('Emirgazi', 42),
('Güneysýnýr', 42),
('Halkapýnar', 42),
('Tuzlukçu', 42),
('Yalýhüyük', 42),
('Altýntaþ', 43),
('Domaniç', 43),
('Emet', 43),
('Gediz', 43),
('Kütahya Merkez', 43),
('Simav', 43),
('Tavþanlý', 43),
('Aslanapa', 43),
('Dumlupýnar', 43),
('Hisarcýk', 43),
('Þaphane', 43),
('Çavdarhisar', 43),
('Pazarlar', 43),
('Akçadað', 44),
('Arapgir', 44),
('Arguvan', 44),
('Darende', 44),
('Doðanþehir', 44),
('Hekimhan', 44),
('Pütürge', 44),
('Yeþilyurt / Malatya', 44),
('Battalgazi', 44),
('Doðanyol', 44),
('Kale / Malatya', 44),
('Kuluncak', 44),
('Yazýhan', 44),
('Akhisar', 45),
('Alaþehir', 45),
('Demirci', 45),
('Gördes', 45),
('Kýrkaðaç', 45),
('Kula', 45),
('Salihli', 45),
('Sarýgöl', 45),
('Saruhanlý', 45),
('Selendi', 45),
('Soma', 45),
('Turgutlu', 45),
('Ahmetli', 45),
('Gölmarmara', 45),
('Köprübaþý / Manisa', 45),
('Þehzadeler', 45),
('Yunusemre', 45),
('Afþin', 46),
('Andýrýn', 46),
('Elbistan', 46),
('Göksun', 46),
('Pazarcýk', 46),
('Türkoðlu', 46),
('Çaðlayancerit', 46),
('Ekinözü', 46),
('Nurhak', 46),
('Dulkadiroðlu', 46),
('Onikiþubat', 46),
('Derik', 47),
('Kýzýltepe', 47),
('Mazýdaðý', 47),
('Midyat', 47),
('Nusaybin', 47),
('Ömerli', 47),
('Savur', 47),
('Dargeçit', 47),
('Yeþilli', 47),
('Artuklu', 47),
('Bodrum', 48),
('Datça', 48),
('Fethiye', 48),
('Köyceðiz', 48),
('Marmaris', 48),
('Milas', 48),
('Ula', 48),
('Yataðan', 48),
('Dalaman', 48),
('Ortaca', 48),
('Kavaklýdere', 48),
('Menteþe', 48),
('Seydikemer', 48),
('Bulanýk', 49),
('Malazgirt', 49),
('Muþ Merkez', 49),
('Varto', 49),
('Hasköy', 49),
('Korkut', 49),
('Avanos', 50),
('Derinkuyu', 50),
('Gülþehir', 50),
('Hacýbektaþ', 50),
('Kozaklý', 50),
('Nevþehir Merkez', 50),
('Ürgüp', 50),
('Acýgöl', 50),
('Bor', 51),
('Çamardý', 51),
('Niðde Merkez', 51),
('Ulukýþla', 51),
('Altunhisar', 51),
('Çiftlik', 51),
('Akkuþ', 52),
('Aybastý', 52),
('Fatsa', 52),
('Gölköy', 52),
('Korgan', 52),
('Kumru', 52),
('Mesudiye', 52),
('Perþembe', 52),
('Ulubey / Ordu', 52),
('Ünye', 52),
('Gülyalý', 52),
('Gürgentepe', 52),
('Çamaþ', 52),
('Çatalpýnar', 52),
('Çaybaþý', 52),
('Ýkizce', 52),
('Kabadüz', 52),
('Kabataþ', 52),
('Altýnordu', 52),
('Ardeþen', 53),
('Çamlýhemþin', 53),
('Çayeli', 53),
('Fýndýklý', 53),
('Ýkizdere', 53),
('Kalkandere', 53),
('Pazar / Rize', 53),
('Rize Merkez', 53),
('Güneysu', 53),
('Derepazarý', 53),
('Hemþin', 53),
('Ýyidere', 53),
('Akyazý', 54),
('Geyve', 54),
('Hendek', 54),
('Karasu', 54),
('Kaynarca', 54),
('Sapanca', 54),
('Kocaali', 54),
('Pamukova', 54),
('Taraklý', 54),
('Ferizli', 54),
('Karapürçek', 54),
('Söðütlü', 54),
('Adapazarý', 54),
('Arifiye', 54),
('Erenler', 54),
('Serdivan', 54),
('Alaçam', 55),
('Bafra', 55),
('Çarþamba', 55),
('Havza', 55),
('Kavak', 55),
('Ladik', 55),
('Terme', 55),
('Vezirköprü', 55),
('Asarcýk', 55),
('19 Mayýs', 55),
('Salýpazarý', 55),
('Tekkeköy', 55),
('Ayvacýk / Samsun', 55),
('Yakakent', 55),
('Atakum', 55),
('Canik', 55),
('Ýlkadým', 55),
('Baykan', 56),
('Eruh', 56),
('Kurtalan', 56),
('Pervari', 56),
('Siirt Merkez', 56),
('Þirvan', 56),
('Tillo', 56),
('Ayancýk', 57),
('Boyabat', 57),
('Duraðan', 57),
('Erfelek', 57),
('Gerze', 57),
('Sinop Merkez', 57),
('Türkeli', 57),
('Dikmen', 57),
('Saraydüzü', 57),
('Divriði', 58),
('Gemerek', 58),
('Gürün', 58),
('Hafik', 58),
('Ýmranlý', 58),
('Kangal', 58),
('Koyulhisar', 58),
('Sivas Merkez', 58),
('Suþehri', 58),
('Þarkýþla', 58),
('Yýldýzeli', 58),
('Zara', 58),
('Akýncýlar', 58),
('Altýnyayla / Sivas', 58),
('Doðanþar', 58),
('Gölova', 58),
('Ulaþ', 58),
('Çerkezköy', 59),
('Çorlu', 59),
('Hayrabolu', 59),
('Malkara', 59),
('Muratlý', 59),
('Saray / Tekirdað', 59),
('Þarköy', 59),
('Marmaraereðlisi', 59),
('Ergene', 59),
('Kapaklý', 59),
('Süleymanpaþa', 59),
('Almus', 60),
('Artova', 60),
('Erbaa', 60),
('Niksar', 60),
('Reþadiye', 60),
('Tokat Merkez', 60),
('Turhal', 60),
('Zile', 60),
('Pazar / Tokat', 60),
('Yeþilyurt / Tokat', 60),
('Baþçiftlik', 60),
('Sulusaray', 60),
('Akçaabat', 61),
('Araklý', 61),
('Arsin', 61),
('Çaykara', 61),
('Maçka', 61),
('Of', 61),
('Sürmene', 61),
('Tonya', 61),
('Vakfýkebir', 61),
('Yomra', 61),
('Beþikdüzü', 61),
('Þalpazarý', 61),
('Çarþýbaþý', 61),
('Dernekpazarý', 61),
('Düzköy', 61),
('Hayrat', 61),
('Köprübaþý / Trabzon', 61),
('Ortahisar', 61),
('Çemiþgezek', 62),
('Hozat', 62),
('Mazgirt', 62),
('Nazýmiye', 62),
('Ovacýk / Tunceli', 62),
('Pertek', 62),
('Pülümür', 62),
('Tunceli Merkez', 62),
('Akçakale', 63),
('Birecik', 63),
('Bozova', 63),
('Ceylanpýnar', 63),
('Halfeti', 63),
('Hilvan', 63),
('Siverek', 63),
('Suruç', 63),
('Viranþehir', 63),
('Harran', 63),
('Eyyübiye', 63),
('Haliliye', 63),
('Karaköprü', 63),
('Banaz', 64),
('Eþme', 64),
('Karahallý', 64),
('Sivaslý', 64),
('Ulubey / Uþak', 64),
('Uþak Merkez', 64),
('Baþkale', 65),
('Çatak', 65),
('Erciþ', 65),
('Gevaþ', 65),
('Gürpýnar', 65),
('Muradiye', 65),
('Özalp', 65),
('Bahçesaray', 65),
('Çaldýran', 65),
('Edremit / Van', 65),
('Saray / Van', 65),
('Ýpekyolu', 65),
('Tuþba', 65),
('Akdaðmadeni', 66),
('Boðazlýyan', 66),
('Çayýralan', 66),
('Çekerek', 66),
('Sarýkaya', 66),
('Sorgun', 66),
('Þefaatli', 66),
('Yerköy', 66),
('Yozgat Merkez', 66),
('Aydýncýk / Yozgat', 66),
('Çandýr', 66),
('Kadýþehri', 66),
('Saraykent', 66),
('Yenifakýlý', 66),
('Çaycuma', 67),
('Devrek', 67),
('Ereðli / Zonguldak', 67),
('Zonguldak Merkez', 67),
('Alaplý', 67),
('Gökçebey', 67),
('Kilimli', 67),
('Kozlu', 67),
('Aksaray Merkez', 68),
('Ortaköy / Aksaray', 68),
('Aðaçören', 68),
('Güzelyurt', 68),
('Sarýyahþi', 68),
('Eskil', 68),
('Gülaðaç', 68),
('Bayburt Merkez', 69),
('Aydýntepe', 69),
('Demirözü', 69),
('Ermenek', 70),
('Karaman Merkez', 70),
('Ayrancý', 70),
('Kazýmkarabekir', 70),
('Baþyayla', 70),
('Sarýveliler', 70),
('Delice', 71),
('Keskin', 71),
('Kýrýkkale Merkez', 71),
('Sulakyurt', 71),
('Bahþili', 71),
('Balýþeyh', 71),
('Çelebi', 71),
('Karakeçili', 71),
('Yahþihan', 71),
('Batman Merkez', 72),
('Beþiri', 72),
('Gercüþ', 72),
('Kozluk', 72),
('Sason', 72),
('Hasankeyf', 72),
('Beytüþþebap', 73),
('Cizre', 73),
('Ýdil', 73),
('Silopi', 73),
('Þýrnak Merkez', 73),
('Uludere', 73),
('Güçlükonak', 73),
('Bartýn Merkez', 74),
('Kurucaþile', 74),
('Ulus', 74),
('Amasra', 74),
('Ardahan Merkez', 75),
('Çýldýr', 75),
('Göle', 75),
('Hanak', 75),
('Posof', 75),
('Damal', 75),
('Aralýk', 76),
('Iðdýr Merkez', 76),
('Tuzluca', 76),
('Karakoyunlu', 76),
('Yalova Merkez', 77),
('Altýnova', 77),
('Armutlu', 77),
('Çýnarcýk', 77),
('Çiftlikköy', 77),
('Termal', 77),
('Eflani', 78),
('Eskipazar', 78),
('Karabük Merkez', 78),
('Ovacýk / Karabük', 78),
('Safranbolu', 78),
('Yenice / Karabük', 78),
('Kilis Merkez', 79),
('Elbeyli', 79),
('Musabeyli', 79),
('Polateli', 79),
('Bahçe', 80),
('Kadirli', 80),
('Osmaniye Merkez', 80),
('Düziçi', 80),
('Hasanbeyli', 80),
('Sumbas', 80),
('Toprakkale', 80),
('Akçakoca', 81),
('Düzce Merkez', 81),
('Yýðýlca', 81),
('Cumayeri', 81),
('Gölyaka', 81),
('Çilimli', 81),
('Gümüþova', 81),
('Kaynaþlý', 81);