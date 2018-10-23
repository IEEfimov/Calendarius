function init() {
    var header = document.getElementById("header");
    var calendar = document.getElementById("calendar");
    var sideBar = document.getElementById("sideBar");

    var pageHeight = document.documentElement.clientHeight;
    var pageWidth = document.documentElement.clientWidth;


    var newsideBarWidth = pageWidth / 5;
    if (newsideBarWidth > 250) newsideBarWidth = 250;
    sideBar.style.width = newsideBarWidth + "px";

    calendar.width = header.offsetWidth - newsideBarWidth;
    calendar.style.width = (header.offsetWidth - newsideBarWidth)+"px";
    var calendarWidth = calendar.offsetWidth;
    

    var items = document.getElementsByClassName("item");
    console.log(items.length);
    for (i = 0; i<items.length; i++){
        items[i].style.width = (Math.floor(calendarWidth/7) - 4)+"px";
        console.log("sss "+items[i].offsetWidth);
        items[i].style.height = ((pageHeight-60)/5)+"px";
    }
    console.log(calendarWidth/7-2);
    calendar.style.calendarWidth=calendarWidth+"px";
    calendar.style.minHeight = (pageHeight - 60) + "px";

    calendar.style.visibility = "visible";
    sideBar.style.visibility = "visible";
}

function cellMouseOn(i) {
    //var calendar = document.getElementById("calendar");
    //calendar.style
}