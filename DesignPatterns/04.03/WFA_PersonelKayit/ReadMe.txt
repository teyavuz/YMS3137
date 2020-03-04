Personel Kayýt
-------------------------

Personelin kayýtlarýný tutan bir otomasyon yazýn. Personel bilgileri aþaðýdaki gibidir;
	--Her personelin benzersiz bir Id'si olacak,
	-Personel adý
	-Personel soyadý
	-Doðum Tarihi
	-Departman
	-Adres
	-Telefon
	-TCKN
Þirket bünyesinde 4 departman bulunmaktadýr;
	-Muhasebe
	-IK,
	-IT,
	-Yönetim
oluþturulacak personeller bu departmanlardan birine ait olmalý.
Yukarýdaki bilgilerde beraber personeller istenirse personelin fotoðrafý ile birlikte kaydedilsin. Bunun için ayrýca bir fotoðraf alaný bulunmalýdýr.

kaydedilen her personel veritabanýnda saklansýn. istenirse personel bilgileri sorgulanabilsin. 
singleton pattern uygulanarak veritabaný nesnesinden sadece bir kez instance alýnabilsin.

Ýlerde yapýlacak web tabanlý projede departmana göre rol verileceði için departmanlar DesignPattern (Builder) kullanýlarak yetki verilsin. Örneðin bir personel eklendiðinde o personele yetki verebilmek için CreationalBuilder tasarým deseni kullanýlarak yetki verilsin.

Baþarýlar...
-----------------------------------------------------------------


--