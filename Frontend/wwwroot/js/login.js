$(document).ready(function() {
    $("#form1123213123213213213213213123213123123123213").submit(function(e) {

        $.support.cors = true;
        var ItemJSON = {
            "id": $('#kullaniciadi').val(),
            "password": $('#password').val()
        };

        var gelenKullaniciAdi = $('#kullaniciadi').val();
        $.ajax({
            url: "https://localhost:44388/api/auth/getbyusername?username=" + gelenKullaniciAdi,
            type: "GET",
            dataType: "json",
            success: function(users) {
                JSON.parse(JSON.stringify(users));
            },
            error: function(request, message, error) {
                handleException(request, message, error);
            }
        });

        function getTest(a) {
            console.log("sero", a);
            // var url1 = `Test/GetTest/?kullaniciadi=`;
            // window.location.href = url1, a;

            $.ajax({
                url: "https://localhost:44388/api/auth/getbyusername?username=" + gelenKullaniciAdi,
                type: "GET",
                dataType: "json",
                success: function(x) {
                    console.log(a);
                },
                error: function(request, message, error) {
                    handleException(request, message, error);
                }
            });
        }

        $.ajax(
            {
                url: "https://localhost:44388/api/auth/login",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(ItemJSON),
                success: function(result) {
                    alert(result);
                    console.log("DENEMEMEMEMEMEMEM : " + result);
                    if (result === "Giriş Başarılı") {
                        console.log("TAMAM");
                    } else {
                        window.location.href = "Login/Index";
                    }
                }
            });

    });

})
