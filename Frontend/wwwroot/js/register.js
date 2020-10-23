$("#kayitOlButon").click(function () {
    $("#theDiv").show();
    $.support.cors = true;
    var ItemJSON = {
        "kullaniciadi": $('#_kullaniciadi').val(),
        "email": $('#_email').val(),
        "password": $('#_password').val(),
        "ad": $('#_ad').val(),
        "soyad": $('#_soyad').val()
    };
    var username = $('#_kullaniciadi').val();
    var ad = $('#_ad').val();
    var soyad = $('#_soyad').val();
    var sifre = $('#_password').val();

    if (username == "" || username.length < 3) {
        console.log("hata");
        $('#hataKullaniciAdi').show();

    } else if (ad == "" || username.length < 3) {
        $('#hataAd').show();

    } else if (soyad == "" || username.length < 3) {
        $('#hataSoyad').show();
    } else if (sifre == "" || sifre.length < 3) {
        $('#hataSifre').show();
    }
    else {
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                alert(this.responseText);
            }
        };
        xhttp.open("POST", "https://localhost:44388/api/auth/register", true);
        xhttp.setRequestHeader("Content-type", "application/json");
        xhttp.send(JSON.stringify(ItemJSON));
    }

});
