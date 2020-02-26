//Oluþturulan Proje Ntier Katmanlý projesi.
	--3 adet katman loluþturuldu.
		--DAL => Data Access Layer (Veriye Eriþim Katmaný)
		--BLL => Business Logic Layer (Ýþ Katmaný)
		--UI => User Interface / Prensation (Sunum Katmaný)

----------------------------------------------------------------

DAL => Data Access Layer (Veriye Eriþim Katmaný)

DAL içerisinde sadece veritabanýný barýndýran katman olarak açýldý. Görevi sadece baðlý bulunduðu veriler ve o verilere ait entityler olacaktýr.

	DAL katmaný içerisine MODEL isminde bir klasör oluþturuldu. Bu klasörün oluþturlma amacý ise içerisinde sadece veritabanýnýn yansýmasýný tutmak için. Bu yüzden Model1.edmx uzantýlý yansýmayý bu klasör içerisine DbFirst kullanarak çektik.
-----------------------------------------------------------------

BLL => Business Logic Layer (Ýþ Katmaný)

Bll katmaný Dal katmaný içerisinde bulunan veritabanýna doðrudan baðlanarak UI katmaný içerisinden talep edilen iþlemleri getirmekle yükümlü bir katman olarak oluþturuldu.

--References
BLL katmaný DAL katmanýndan referans almalý bu yüzden References'a sað týklayarak daha önce oluþturulan DAL katmanýný iþaretleyerek bu katman ile haberleþmesini saðlýyoruz.

Ayný zamanda bütün iþlemler UI katmanýnda da görüntüleneceði için DAL ve BLL katmanlarýný da UI katmanýna referans olarak vermemiz gerekiyor bu yüzden WFA katmanýnda bulunan Referances alanaýna sað týoklayarak BLL ve DAL katmanýný referans olarak verdik.
--

--UI => User Interface / Prensation (Sunum Katmaný)

DAL katmaný içerisidne oluþturulan Model klasörü içerisindeki NorthwindEntities nesnesini WFA Form1.cs içerisinde çaðýrýp bütün kategorileri listelemek istediðimizde ilk etapta projede entityframework kurulu olmadýðý için bir hata alacaðýz. çünkü entityframework bizim için veritabýndaki bilgileri bi takým metotlar dahilinde bize sunmakla yükümlü kütüphane olarak geliyordu. Ancak bu kütüphane baðlý bulunan katmanda tanýmlý deðilse ne þekilde getireceðini bilemez. Bu noktada solution'a sað týklayarak Nuget package manager dan büyün katmanlara EntityFramework'ü yüklememiz gerekmektedir. 

Daha sonra db.categories.TolSit() metodunu kullandýðýmýzda Categories DAL katmaný içerisindeki Model kalsörü içerisinde tanýmlý olan Model1.edmx içerisinde tanýmlý olduðundan dolayý WFA ieçrisindeki app.config içerisinde bu katmanada tanýmlý olan connectionstring düðümünü bulamayacak. Bu noktada DAL katmanýnda bulunan apconfig açýlarak içserisindeki <connectionstring></connectionstring> düðümü kopyalanarak WFA proje içerisindeki appconfig içerisine yapýþtýrýlýr. bknz. WFA=>appconfig.cs





