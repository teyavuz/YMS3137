//Olu�turulan Proje Ntier Katmanl� projesi.
	--3 adet katman lolu�turuldu.
		--DAL => Data Access Layer (Veriye Eri�im Katman�)
		--BLL => Business Logic Layer (�� Katman�)
		--UI => User Interface / Prensation (Sunum Katman�)

----------------------------------------------------------------

DAL => Data Access Layer (Veriye Eri�im Katman�)

DAL i�erisinde sadece veritaban�n� bar�nd�ran katman olarak a��ld�. G�revi sadece ba�l� bulundu�u veriler ve o verilere ait entityler olacakt�r.

	DAL katman� i�erisine MODEL isminde bir klas�r olu�turuldu. Bu klas�r�n olu�turlma amac� ise i�erisinde sadece veritaban�n�n yans�mas�n� tutmak i�in. Bu y�zden Model1.edmx uzant�l� yans�may� bu klas�r i�erisine DbFirst kullanarak �ektik.
-----------------------------------------------------------------

BLL => Business Logic Layer (�� Katman�)

Bll katman� Dal katman� i�erisinde bulunan veritaban�na do�rudan ba�lanarak UI katman� i�erisinden talep edilen i�lemleri getirmekle y�k�ml� bir katman olarak olu�turuldu.

--References
BLL katman� DAL katman�ndan referans almal� bu y�zden References'a sa� t�klayarak daha �nce olu�turulan DAL katman�n� i�aretleyerek bu katman ile haberle�mesini sa�l�yoruz.

Ayn� zamanda b�t�n i�lemler UI katman�nda da g�r�nt�lenece�i i�in DAL ve BLL katmanlar�n� da UI katman�na referans olarak vermemiz gerekiyor bu y�zden WFA katman�nda bulunan Referances alana�na sa� t�oklayarak BLL ve DAL katman�n� referans olarak verdik.
--

--UI => User Interface / Prensation (Sunum Katman�)

DAL katman� i�erisidne olu�turulan Model klas�r� i�erisindeki NorthwindEntities nesnesini WFA Form1.cs i�erisinde �a��r�p b�t�n kategorileri listelemek istedi�imizde ilk etapta projede entityframework kurulu olmad��� i�in bir hata alaca��z. ��nk� entityframework bizim i�in veritab�ndaki bilgileri bi tak�m metotlar dahilinde bize sunmakla y�k�ml� k�t�phane olarak geliyordu. Ancak bu k�t�phane ba�l� bulunan katmanda tan�ml� de�ilse ne �ekilde getirece�ini bilemez. Bu noktada solution'a sa� t�klayarak Nuget package manager dan b�y�n katmanlara EntityFramework'� y�klememiz gerekmektedir. 

Daha sonra db.categories.TolSit() metodunu kulland���m�zda Categories DAL katman� i�erisindeki Model kals�r� i�erisinde tan�ml� olan Model1.edmx i�erisinde tan�ml� oldu�undan dolay� WFA ie�risindeki app.config i�erisinde bu katmanada tan�ml� olan connectionstring d���m�n� bulamayacak. Bu noktada DAL katman�nda bulunan apconfig a��larak i�serisindeki <connectionstring></connectionstring> d���m� kopyalanarak WFA proje i�erisindeki appconfig i�erisine yap��t�r�l�r. bknz. WFA=>appconfig.cs





