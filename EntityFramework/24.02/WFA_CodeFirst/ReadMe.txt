
         1# Projeye sað týklanarak NUGET Package Manager ile EntityFramework projeye eklenir.
         2# ORM Klasörü altýnda=> Context ve Entity klasörleri oluþturulur.
         3# Entity klasörü altýnda tablo haline gelecek olan classlar açýlýr. (Product.cs, Category.cs)
         4# Context klasörü altýnda "ProjectContext" isminde bir context sýnýfý açýlýr.
         5# ProjectContext class'ý DbContext (System.Data.Entity) miras almalýdýr.
         6# Tablo haline gelmesini istediðimiz classlarý "public DbSet<Category> Categories { get; set; }" þeklinde tek tek tanýmlanýr.
         7# Form1.cs  Form_Load eventi içerisinde ProjectContext'ten bir instance (örnek) alýnarak herhangi bir tablo Liste (ToList) olarak çaðrýldýðýnda veritabaný baðlantý iþlemini gerçekleþtirerek öyle bir veritabaný yoksa oluþturur. varsa verileri liste halinde getirir.
