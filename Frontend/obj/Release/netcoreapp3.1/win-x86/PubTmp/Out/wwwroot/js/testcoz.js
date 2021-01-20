var s = [];
function reply_click(clicked_id) {
    s.push(clicked_id);
    var c = clicked_id.split("");
    var c1 = c[0];//secenek sayisi
    var c2 = c[1];//soru sayisi
    $("#" + clicked_id).find('input[type=radio]').prop('checked', true);
        if (c1==1) {
        $("#" + clicked_id).css("background-color", "#71f4cb");
            $("#2" + c2).css("background-color", "#e8dbdb");
            $("#3" + c2).css("background-color", "#e8dbdb");
            $("#4" + c2).css("background-color", "#e8dbdb");

        }else if (c1 == 2) {
            $("#" + clicked_id).css("background-color", "#71f4cb");
            $("#1" + c2).css("background-color", "#e8dbdb");
            $("#3" + c2).css("background-color", "#e8dbdb");
            $("#4" + c2).css("background-color", "#e8dbdb");

        } else if (c1 == 3) {
            $("#" + clicked_id).css("background-color", "#71f4cb");
            $("#2" + c2).css("background-color", "#e8dbdb");
            $("#1" + c2).css("background-color", "#e8dbdb");
            $("#4" + c2).css("background-color", "#e8dbdb");

        } else if (c1 == 4) {
            $("#" + clicked_id).css("background-color", "#71f4cb");
            $("#2" + c2).css("background-color", "#e8dbdb");
            $("#3" + c2).css("background-color", "#e8dbdb");
            $("#1" + c2).css("background-color", "#e8dbdb");

        }
         //if (s.length > 1) { $("#" + s[s.length - 2]).css("background-color", "#e8dbdb"); }
      
    }
 /*   var _id = "radio" + clicked_id;
    $('input[type=radio][name="[1].dogruCevap"]').change(function () {
        if (this.value == '1') {
            alert("1");
        } else if (this.value == '2') {
            alert("Transfer Thai 2");
        } else if (this.value == '3') {
            alert("Transfer Thai 3");
        } else if (this.value == '4') {
            alert("Transfer Thai 4");
        }
    });

*/



