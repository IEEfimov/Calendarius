function init() {
    var calendar = document.getElementById("calendar");
    var header = document.getElementById("header");

    var pageHeight = document.documentElement.clientHeight;
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
    calendar.style.minHeight = (pageHeight-60)+"px";
}