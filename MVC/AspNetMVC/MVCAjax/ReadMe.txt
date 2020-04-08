//MVC projesi oluşturuldu.
//Models klasörü içerisine Northwind veritabanının DbFirst olarak yansıması alındı.
//ProductController isminde bir controller oluşturuldu.
//ProductController içerisinde Index isminde bir ActionView oluşturuldu. View'e model olarak product list gönderildi.
//index.cshtml içerisinde veriler tablo içerisinde listelendi.
//veriler listelenirken detay isminde bir buton oluşturuldu ve butona tıklandığında o ürüne ait detay sayfası oluşturuldu. bu detay sayfası normalde senkron bir yapı olduğu için için yapılan her istek bir sıralama ile serverdan gelen cevap doğrultusunda istemciye gönderilir. bu da sistemi bazı durumlarda yoracağı için bu bölümde AJAX (Asenkron javascript and xml) yapısı kullanıldı.
//AJAX yapısı, yapılan istekleri belli bir sıralama yerine belirtilen bölümde isteği gerçekleştirmesi için kullanılındığından ötürü index.cshtml içerisinde bize teslim edilen verinin nerede görüntülenmesini istiyorsak o alana ait bir @Ajax.ActionLink() metodunu kullandık. Bu metot içerisinde tanımlı olan ajaxoption sayesinde bize teslim edilen verinin nerede ve ne şekilde göstereceğini asenkron olarak belirledik.
//Nuget Package Manager üzerinden "Microsoft.jQuery.Unobtrusive.Ajax" kütüphanesi proje eklendi. Bu kütüphane istekleri ajax olarak getirmemizi sağlıyor. (BundleConfig içerisinde yolu tanımlandı.)
//ProductController içerisine _ProductDetailPartial isminde geriye partialview() dönen bir metot tanımladık ve view olarak ta View klasörü içerisine _ProductDetailPartial isminde partial oluşturuldu.

