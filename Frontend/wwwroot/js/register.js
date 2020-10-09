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

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            alert(this.responseText);
        }
    };
    xhttp.open("POST", "https://localhost:44388/api/auth/register", true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send(JSON.stringify(ItemJSON));
});
