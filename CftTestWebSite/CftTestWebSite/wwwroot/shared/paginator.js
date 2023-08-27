var claimsResult = null;

fetch("/Claims/ClaimsEdit/GetClaims")
    .then((response) => response.json())
    .then(claims => {
        claimsResult = claims;
        var count = 100; //всего записей
        var cnt = 10; //сколько отображаем сначала
        var cnt_page = Math.ceil(count / cnt); //кол-во страниц
        console.log(claims);
        //выводим список страниц
        var paginator = document.querySelector(".paginator");
        var page = "";
        for (var i = 0; i < cnt_page; i++) {
            page += "<span data-page=" + i * cnt + "  id=\"page" + (i + 1) + "\">" + (i + 1) + "</span>";
        }
        paginator.innerHTML = page;

        //выводим первые записи {cnt}
        var t = document.getElementById('tableClaims');
        console.log(t);
        var trs = t.getElementsByTagName("tr");
        console.log(trs);
        var tds = null;

        for (var i = 1; i < cnt + 1; i++) {
            tds = trs[i].getElementsByTagName("td");
            tds[0].innerHTML = claims[i - 1].name;
            tds[1].innerHTML = claims[i - 1].application;
            tds[2].innerHTML = claims[i - 1].dateEnd;
            tds[3].innerHTML = claims[i - 1].description;
            tds[4].innerHTML = claims[i - 1].email;
        }

    });


//листаем
function pagination(event) {
    console.log(event);
    var counter = event.srcElement.innerHTML * 10 - 10;
    console.log(counter);
    var cnt = 10; 
    var t = document.getElementById('tableClaims');
    var trs = t.getElementsByTagName("tr");
    console.log(claimsResult);

    var j = 1;
    for (var i = counter; i < counter + cnt; i++) {
        var tds = trs[j].getElementsByTagName("td");
        tds[0].innerHTML = claimsResult[i].id;
        tds[1].innerHTML = claimsResult[i].application;
        tds[2].innerHTML = claimsResult[i].dateEnd;
        tds[3].innerHTML = claimsResult[i].description;
        tds[4].innerHTML = claimsResult[i].email;
        j++;
    }
}