
         1# Projeye sa� t�klanarak NUGET Package Manager ile EntityFramework projeye eklenir.
         2# ORM Klas�r� alt�nda=> Context ve Entity klas�rleri olu�turulur.
         3# Entity klas�r� alt�nda tablo haline gelecek olan classlar a��l�r. (Product.cs, Category.cs)
         4# Context klas�r� alt�nda "ProjectContext" isminde bir context s�n�f� a��l�r.
         5# ProjectContext class'� DbContext (System.Data.Entity) miras almal�d�r.
         6# Tablo haline gelmesini istedi�imiz classlar� "public DbSet<Category> Categories { get; set; }" �eklinde tek tek tan�mlan�r.
         7# Form1.cs  Form_Load eventi i�erisinde ProjectContext'ten bir instance (�rnek) al�narak herhangi bir tablo Liste (ToList) olarak �a�r�ld���nda veritaban� ba�lant� i�lemini ger�ekle�tirerek �yle bir veritaban� yoksa olu�turur. varsa verileri liste halinde getirir.
