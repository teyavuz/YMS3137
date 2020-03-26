//Sayfa yüklendiği anda tüm fonksiyonların çalışmaya hazır olması için $(document).ready(function(){}) kullanmamız gerekli.
$(document).ready(function () {
   //$ => selector (seçici) olarak kullanılır.
    $('#bir').click(function () {
        //alert('bir tıklandı');
        $('p').html('');
        $('p').html('Merhaba Jquery');
        $('#metin').html('Sayfa içerisindeki p elementlerine Merhaba Jquery yazıldı.');

    });

    //Id'si metin1 olan p'nin Html içeriğini değiştirme...
    $('#iki').click(function () {
        $('p').html('');
        $('p#metin1').html('Merhaba Jquery');
    });

    //Id'si metin1 ve metin2 olan p'lerin html içeriğini değiştirme.
    $('#uc').click(function () {
        $('#metin').html("Id'si 'metin1' ve 'metin2' olan p'lerin HTml içeriğini değiştirme");
        $('p#metin1,p#metin2').html('Merhaba Jquery');
    });

    //Lang attribute u tr olan elemetin Html içeriğini değiştirme.
    $('#dort').click(function () {
        $('p').html('');
        $('p[lang=tr]').html('Merhaba Jquery');
    });

    //Lang attribute'u tr ve en olan elementin Html'ni değiştirme.
    $('#bes').click(function () {
        $('p').html('');
        $('p[lang=tr],[lang=en]').html('Merhaba Jquery');
    });

    //Lang attribute'u en ve id attribute'u metin2 olan elementin Html içeriğini değiştirme.
    $('#alti').click(function () {
        $('p').html('');
        //$('p[lang=en],[id=metin2]').html('Merhaba Jquery');
        $('p[lang=en],#metin2').html('Merhaba Jquery');
    });

    //id'si metin3 olmayan elementlerin Html değiştirme.
    $('#yedi').click(function () {
        $('p').html('');
        //$('p[lang=en],[id=metin2]').html('Merhaba Jquery');
        $('p[id!=metin3]').html('Merhaba Jquery');
    });

    //id attribute2u 'me' ile başlayan elemenlerin html içeriğini değiştirime.
    $('#sekiz').click(function () {
        $('p').html('');
      
        $('p[id^=me]').html('Merhaba Jquery');
    });


    //Id attribute'u 4 ile biten elementlerin html değiştirme.
    $('#dokuz').click(function () {
        $('p').html('');
        $('p[id$=4]').html('Merhaba Jquery');
    });

    $('#on').click(function () {
        $('p').html('');

        $('p[id!^=me]').html('Merhaba Jquery');
    });
});