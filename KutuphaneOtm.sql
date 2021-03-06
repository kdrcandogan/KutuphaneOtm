USE [KutuphaneOtm]
GO
/****** Object:  Table [dbo].[Emanetler]    Script Date: 28.01.2019 23:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emanetler](
	[EmanetID] [int] IDENTITY(1,1) NOT NULL,
	[UyeID] [int] NULL,
	[KitapID] [int] NULL,
	[EmanetVerilmeTarih] [date] NULL,
	[EmanetGeriAlmaTarihi] [date] NULL,
	[EmanetNot] [text] NULL,
 CONSTRAINT [PK_Emanetler] PRIMARY KEY CLUSTERED 
(
	[EmanetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 28.01.2019 23:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[KitapID] [int] IDENTITY(1,1) NOT NULL,
	[KitapAd] [nvarchar](100) NULL,
	[KitapTur] [nvarchar](100) NULL,
	[KitapYayinEvi] [nvarchar](150) NULL,
	[KitapSayfaSayısı] [int] NULL,
	[KitapYazar] [nvarchar](150) NULL,
	[KitapDil] [nvarchar](50) NULL,
	[KitapAciklama] [text] NULL,
	[KitapAdet] [int] NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[KitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 28.01.2019 23:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[UyeID] [int] IDENTITY(1,1) NOT NULL,
	[UyeAd] [nvarchar](150) NULL,
	[UyeSoyad] [nvarchar](150) NULL,
	[UyeTelefon] [int] NULL,
	[UyeEposta] [nvarchar](150) NULL,
	[UyeAdres] [nvarchar](150) NULL,
 CONSTRAINT [PK_Uye] PRIMARY KEY CLUSTERED 
(
	[UyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emanetler] ON 

INSERT [dbo].[Emanetler] ([EmanetID], [UyeID], [KitapID], [EmanetVerilmeTarih], [EmanetGeriAlmaTarihi], [EmanetNot]) VALUES (2, 1, 3, CAST(N'2005-01-22' AS Date), CAST(N'2018-10-10' AS Date), N'sadasdasd')
INSERT [dbo].[Emanetler] ([EmanetID], [UyeID], [KitapID], [EmanetVerilmeTarih], [EmanetGeriAlmaTarihi], [EmanetNot]) VALUES (4, 1, 6, CAST(N'2011-11-11' AS Date), CAST(N'2017-10-10' AS Date), N'asdasd')
INSERT [dbo].[Emanetler] ([EmanetID], [UyeID], [KitapID], [EmanetVerilmeTarih], [EmanetGeriAlmaTarihi], [EmanetNot]) VALUES (5, 1, 3, CAST(N'2010-10-10' AS Date), CAST(N'2020-10-10' AS Date), N'dsadad')
INSERT [dbo].[Emanetler] ([EmanetID], [UyeID], [KitapID], [EmanetVerilmeTarih], [EmanetGeriAlmaTarihi], [EmanetNot]) VALUES (6, 1, 1, CAST(N'2011-11-10' AS Date), CAST(N'2022-12-10' AS Date), N'asdasdasdaasd')
INSERT [dbo].[Emanetler] ([EmanetID], [UyeID], [KitapID], [EmanetVerilmeTarih], [EmanetGeriAlmaTarihi], [EmanetNot]) VALUES (7, 3, 6, CAST(N'2011-11-11' AS Date), CAST(N'2020-10-10' AS Date), N'kitap sayfası yırtık')
SET IDENTITY_INSERT [dbo].[Emanetler] OFF
SET IDENTITY_INSERT [dbo].[Kitaplar] ON 

INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (1, N'İçimizdeki Şeytan ', N'Edebiyat', N'Yapı Kredi Yayınları', 254, N'Sabahattin Ali ', N'Türkçe', N'"İsteyip istemedeğimi doğru dürüst bilmediğim, fakat neticede aleyhime çıkarsa istemediğimi iddia ettiğim bu nevi söz ve fiillerimin daimi bir mesulünü bulmuştum: Buna içimdeki şeytan diyordum, müdafaasını üzerime almaktan korktuğum bütün hareketlerimi ona yüklüyor ve kendi suratıma tüküreceğim yerde, haksızlığa, tesadüfün cilvesine uğramış bir mazlum gibi nefsimi şefkat ve ihtimama layık görüyordum. ', 2)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (2, N'Satranç ', N'Edebiyat', N'İş Bankası Kültür Yayınları', 77, N'Stefan Zweig', N'Türkçe', N'Stefan Zweig, çok geniş bir psikoloji birikimini eserlerinde bütünüyle kullanmış ender yazarlardandır. Onun dünya edebiyatında bir biyografi yazarı olarak kazandığı haklı ünün temelinde de bu özelliği, yani yazarlığının yanı sıra çok usta bir psikolog olması yatar.', 3)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (3, N'Kürk Mantolu Madonna ', N'Edebiyat', N'Yapı Kredi Yayınları', 136, N'Sabahattin Ali', N'Türkçe', N'”Dünya’nın en basit, en zavallı, hatta en ahmak adamı bile, insanı hayretten hayrete düşürecek ne müthiş ve karışık bir ruha maliktir!... Niçin bunu anlamaktan bu kadar kaçıyor ve insan dedikleri mahluku anlaşılması ve hakkında hüküm verilmesi en kolay şeylerden biri zannediyoruz?”', 5)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (4, N'Sevda Sözleri', N'Şiir', N'Yapı Kredi Yayınları', 336, N'Cemal Süreya', N'Türkçe', N'Cemal Süreya, Cumhuriyet Dönemi şiirinin en özel "vitamin"iydi. Lirik, erotik, politik gür bir ırmak. Sevda Sözleri bu büyük ustanın bütün şiirlerini bir araya getiriyor. Öyle bir bütünlük ki bu, sıcak, tılsımlı ve ölümsüz...', 11)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (5, N'Ben Sana Mecburum ', N'Şiir', N'İş Bankası Kültür Yayınları', 156, N'Attilâ İlhan ', N'Türkçe', N'Bizi en ince yerimizden yakalıyor hep; birimizi, bazılarımızı değil, hepimizi... Kendini anlatıyor ama, dizelerinde hepimiz kendimizi buluyoruz, üstelik onlarda sadece biz varız sanarak. Öznel sevdalarımızı, "bize ait olanı" duyuyoruz onun sesinde. Hepimiz onun şiirinin kahramanlarıyız; bir türlü layıkıyla söylemeyi beceremediğimizi üç kelimeye sığdırıveriyor o:
"Ben sana mecburum!"', 7)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (6, N'Tesla-Aforizmalar ', N'Biyografi', N'Zeplin Kitap', 160, N'Nikola Tesla ', N'Türkçe', N'Aforizmalar, Nikola Tesla’nın eserlerinden özenle derlenmiş bir seçki olmasının yanında, Nikola Tesla’ya ait fotoğraflardan oluşan bir “fotoğraf albümü”nü, hayatı boyunca aldığı patentlerin çizimlerini de içermektedir. Bu yanıyla, Türkçede çıkmış en kapsamlı Nikola Tesla kitaplarından bir tanesidir.', 1)
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAd], [KitapTur], [KitapYayinEvi], [KitapSayfaSayısı], [KitapYazar], [KitapDil], [KitapAciklama], [KitapAdet]) VALUES (7, N'Büyük İskender', N'Biyografi', N'Kronik Kitap', 456, N'Jona Lendering', N'Türkçe', N'Büyük İskender, antik dünyanın, belki de tüm tarihin en büyük askerî lideriydi. Yalnızca dört sene içinde, kararlı liderliği, zekâ kokan taktikleri ve sarsılmaz azmi sayesinde Pers İmparatorluğu’nu dize getirmişti.', 3)
SET IDENTITY_INSERT [dbo].[Kitaplar] OFF
SET IDENTITY_INSERT [dbo].[Uye] ON 

INSERT [dbo].[Uye] ([UyeID], [UyeAd], [UyeSoyad], [UyeTelefon], [UyeEposta], [UyeAdres]) VALUES (1, N'Kamil', N'Sarı', 65656, N'a@a', N'sadsadasdasd')
INSERT [dbo].[Uye] ([UyeID], [UyeAd], [UyeSoyad], [UyeTelefon], [UyeEposta], [UyeAdres]) VALUES (3, N'Mehmet', N'Mor', 1231231, N'm@m', N'asdasdadsaasd')
INSERT [dbo].[Uye] ([UyeID], [UyeAd], [UyeSoyad], [UyeTelefon], [UyeEposta], [UyeAdres]) VALUES (4, N'Zeki', N'Topçu', 2131244, N'z@z', N'asadrqwrqwrq')
INSERT [dbo].[Uye] ([UyeID], [UyeAd], [UyeSoyad], [UyeTelefon], [UyeEposta], [UyeAdres]) VALUES (5, N'Ali', N'Koç', 21314212, N'y@y', N'adasdasdasdas')
INSERT [dbo].[Uye] ([UyeID], [UyeAd], [UyeSoyad], [UyeTelefon], [UyeEposta], [UyeAdres]) VALUES (6, N'mert', N'yıldırım', 645356, N't@t', N'asdasdadad')
SET IDENTITY_INSERT [dbo].[Uye] OFF
ALTER TABLE [dbo].[Emanetler]  WITH CHECK ADD  CONSTRAINT [FK_Emanetler_Kitaplar] FOREIGN KEY([KitapID])
REFERENCES [dbo].[Kitaplar] ([KitapID])
GO
ALTER TABLE [dbo].[Emanetler] CHECK CONSTRAINT [FK_Emanetler_Kitaplar]
GO
ALTER TABLE [dbo].[Emanetler]  WITH CHECK ADD  CONSTRAINT [FK_Emanetler_Uye] FOREIGN KEY([UyeID])
REFERENCES [dbo].[Uye] ([UyeID])
GO
ALTER TABLE [dbo].[Emanetler] CHECK CONSTRAINT [FK_Emanetler_Uye]
GO
/****** Object:  StoredProcedure [dbo].[Sp_EmanetSayisi]    Script Date: 28.01.2019 23:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_EmanetSayisi]
as
begin
	declare @adet int
	select @adet=COUNT([EmanetID]) from [dbo].[Emanetler]
end

GO
/****** Object:  StoredProcedure [dbo].[Sp_KitapSayisi]    Script Date: 28.01.2019 23:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_KitapSayisi]
as
begin
	declare @adet int
	select @adet=COUNT([KitapID]) from [dbo].[Kitaplar]
end

GO
