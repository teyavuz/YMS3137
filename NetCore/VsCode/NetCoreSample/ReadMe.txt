mkdir => yeni klasör oluşturur.
cd (klasör adı) => o klasöre girer
cd.. => bir üst klasöre geri döner
--------------------------
dotnet --version => bilgisarımızda yüklü olan dotnet versiyonunu gösterir.
dotnet --help => dotnet komutu ile beraber kullanılan komutları listeler.
dotnet new --help => yeni bir dotnet projesi oluştururken kullanıcılacak olan komutları listeler.
dotnet new web => yeni .net core projesi(boş) oluşturur
-------------------
dotnet run => debug çalıştırır
dotnet watch run => debug kapatılmadan otomatik değişiklikler algılanarak çalışmaya devam eder.
-----------------

.NET CORE MVC PROJESİ OLUŞTURMA
1-Projeyi oluşturduktan sonra proje ana dizininde Controllers isminde bir klasör oluşturuyoruz.
2-Controllers klasörü içerisine HomeController isminde bir class tanımlıyoruz. Bu Class Controller classından miras almalıdır.
3-içerisinde Index isminde ActionResult oluşturuyoruz.
4-Proje ana dizinine Views isminde bir klasör tanımlayarak Controller aynı ismine sahip bir klasör açıyoruz (Home)
5-View/Home klasörü içerisine HomeController içerisinde oluşturmuş olduğumuz Index isimli index.cshtml tanımlıyoruz.
    --Projeyi çalıştırdığımzıda oluşturduğumuz index'i test ediyoruz.
6-proje dizinine Models isminde bir klasör tanımlayarak içerisinde Person.cs isminde bir class oluşturyoruz. 
7-Person.cs classı içerisinde tanımlı olan propertyleri static bir List içerisinde bir kaç adet person dahil ederek ardından HomeController içerisinde bulunan Index isiminde ActionResult'a Tolist olarak gönderip ardından Views/Home/index.cshtml içerisinde yakalayarak bir döngü dahilinde listeliyoruz.
8- projede bootstrap yüklü olmadığı için yükleme işlemlerini otomatik olarak gerçekleştirmek adına www.nodejs.org adresine giriş yapıp nodejs kütüphanesini bilgisayara indirip kurmamız gerekmektedir.
    --NodeJs: javascript kodlarını server side çalıştırmak için kullanılan open source bir kütüphanedir. bu kütüphaneyi kullanarak bir takım paketleri kendi projemize ekleyebiliriz ve eklemiş olduğumuz bu paketlerde herhangi bir güncelleme olması durumunda otomatik olarak projemiz dahilinde güncellenir. Bu mantıkla beraber bootstrap kütüphanesini npm olarak adlandırılan node package manager vasıtasıyla projemize dahil ediyoruz.
9- Terminal ekranı açılarak ilk etapta nodejs bilgisayarımızda kurulu olup olmaıdğını npm -v komutunu yazarak kontrol ediyoruz. ardından
    9.1- npm install bootstrap komutunu yazıp bootstrap kütüphanesini projemize kurulumunu gerçekleştiriyoruz. bu işlemin ardından proje dizininde node_modules isminde bir klasör oluşturularak içerisinde bootstrap kütüphanesini görebiliriz.
10-node_modules klasörünü dorğudan dışarıya açıp herbir view içerisinden ulaşabilmek adına Startup.cs içerisinde Middleware eklememiz gerekmektedir. Bknz. Startup içerisindeki Configure metodu.


