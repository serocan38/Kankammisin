﻿$('#form').submit( function() {

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
                console.log(users.id);
                console.log("sero ", users.kullaniciAdi);
                var a = String(users.kullaniciadi);


                //  $.post("Test/GetTest/", { kullaniciAdi: users.kullaniciadi }, function (data) {});
                //   var url = '/Test/gettest?kullaniciadi=' + users.kullaniciadi;
                   window.location.href = "test/test";
                //

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


                    }
                }
            });

    });


