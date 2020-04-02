--İndirmiş olduğunuz theme'nın bütün klasörlerini oluşturmuş olduğumuz projede Content isimli bir klasör açarak içerisine taşıdık.
--Proje ana dizininde bulunan view isimli klasör içerisine Shared isminde bir klasör açarak içerisinde her bir View'in ortak olarak kullanacağı _Layout.cshtml açtık. Bunu açmamızdaki temel sebep bütün sayfaların ortak olarak kullandığı Layout sayfası olma özelliğinden ötürüdür.
--Layout içerisine durmadan değişecek olan alanı tayin etmemiz gerekiyor. Bu sebeple RenderBody() tanımlaması yapıldı.
--RenderBody()'nin ait olduğu html kodlarının tamamı Home/Index.cshtml sayfasına taşındı.
--Projeyi çalıştırğımızda bi takım görsellerin görüntülenmesi için görsellerin ait olduğu yollar düzenlendir. (örn. img src="img/avatar.png" olan yol <img src="Content/img/avatar.png" şeklinde...)

-----------------------------------------------------

