var cevaplar = document.getElementById('PassingToJavaScript1').value;
console.log(cevaplar);
var cevap = cevaplar.split('');
for (var i = 0; i < 3; i++) {
    $("#tik-1" + i).hide();
    $("#tik-2" + i).hide();
    $("#tik-3" + i).hide();
    $("#tik-4" + i).hide();
}


for (var i = 0; i < cevap.length; i++) {
    if (cevap[i] == 1) {
        //  $("#tik-1" + i).show();
        $("#secenekDiv1" + i).css("background-color", "#71f4cb");
    } else if (cevap[i] == 2) {
        //   $("#tik-2" + i).show();
        $("#secenekDiv2" + i).css("background-color", "#71f4cb");
    } else if (cevap[i] == 3) {
        //  $("#tik-3" + i).show();
        $("#secenekDiv3" + i).css("background-color", "#71f4cb");
    } else if (cevap[i] == 4) {
        //   $("#tik-4" + i).show();
        $("#secenekDiv4" + i).css("background-color", "#71f4cb");
    }
}





