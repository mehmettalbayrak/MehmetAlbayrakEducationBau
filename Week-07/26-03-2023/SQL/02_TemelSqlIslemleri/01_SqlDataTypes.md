METİNSEL TİPLER

1) char: 
Metinsel değerler tutar. 
Unicode karakterler tutulamaz. 
8000 karakterlik veri saklayabilir.
char(n) şeklinde tanımlanır ve n karakterlik yer kaplar.
Name char(20) -> Erdinc (bellekte 20 karakterlik yer kaplayacak.)

2) varchar:
Metinsel değerler tutar.
Unicode karakterler tutulmaz.
8000 karakterlik veri saklayabilir.
varchar(n) şeklinde tanımlanır ve içindeki verinin uzunluğu kadar yer kaplar.
Name varchar(20) => Erdinc (bellekte 6 karakterlik yer kaplayacak.)

3) nchar:
char'dan farklı olarak;
Unicode karakterleri tutabilir! (özel karakterler ya da Türkçe.)
4000 karakterlik veri saklayabilir. 
Dğer özellikleri char ile aynıdır.

4)nvarchar:
varchardan farklı olarak;
Unicode karakterleri tutabilir.
4000 karakterlik veri saklayabilir.
Diğer özellikleri varchar ile aynıdır.

SAYISAL TİPLER
1) bit: 0 ya da 1 değerini içinde tutar. Yani C#'daki bool tipinin karşılığı denebilir.
2) tinyint, smallint, int, bigint, tam sayı tiplerdir. (Sırasıyla 1, 2, 4 ve 8 byte yer kaplarlar.)
3) decimal, numeric, money ondalık tiplerdir. Bunlar 8 byte yer kaplarlar.

TATİHSEL TİPLER
1) date: yyyy-aa-gg formatında tarih verisi tutar. 3 byte.
2) datetime: yyyy-aa-gg ss-dd-ss-sl formatında tarih saat verisi tutar. 8 byte.
(1.1.1753 - 31.12.9999)
3) datetime2: datetime ile aynı formatta veri tutmasının yanı sıra, saliseyi çok daha detaylı tutar. 10 byte.
(1.1.0001 - 1.12.9999)
4) time: ss-dd-ss-sl formatında saat verisi tutar. 3 byte.