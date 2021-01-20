var cevaplar = document.getElementById('PassingToJavaScript1').value;
var dogruCevaplar = document.getElementById('PassingToJavaScript2').value;

console.log(cevaplar);
var cevap = cevaplar.split('');
var dogruCevap = dogruCevaplar.split('');

for (var i = 0; i < cevaplar.length; i++) {
    $("#tik-1" + i).hide();
    $("#tik-2" + i).hide();
    $("#tik-3" + i).hide();
    $("#tik-4" + i).hide();
}


for (var i = 0; i < cevap.length; i++) {
    if (cevap[i] == 1) {
        if (cevap[i] == dogruCevap[i]) {
            $("#secenekDiv1" + i).css("background-color", "#71f4cb");
        } else {
            $("#secenekDiv1" + i).css("background-color", "#FE3360");
            $("#secenekDiv" + dogruCevap[i] + i).css("background-color", "#B0C7D6");
        }
    } else if (cevap[i] == 2) {
         //  $("#tik-2" + i).show();
        if (cevap[i] == dogruCevap[i]) {
            $("#secenekDiv2" + i).css("background-color", "#71f4cb");
        } else {
            $("#secenekDiv2" + i).css("background-color", "#FE3360");
            $("#secenekDiv" + dogruCevap[i] + i).css("background-color", "#B0C7D6");

        }
    } else if (cevap[i] == 3) {
        //  $("#tik-3" + i).show();
        if (cevap[i] == dogruCevap[i]) {
            $("#secenekDiv3" + i).css("background-color", "#71f4cb");
        } else {
            $("#secenekDiv3" + i).css("background-color", "#FE3360");
            $("#secenekDiv" + dogruCevap[i] + i).css("background-color", "#B0C7D6");

        }
    } else if (cevap[i] == 4) {
         //  $("#tik-4" + i).show();
        if (cevap[i] == dogruCevap[i]) {
            $("#secenekDiv4" + i).css("background-color", "#71f4cb");
        } else {
            $("#secenekDiv4" + i).css("background-color", "#FE3360");
            $("#secenekDiv" + dogruCevap[i] + i).css("background-color", "#B0C7D6");

        }
    }
}





