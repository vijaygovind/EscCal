

//var isPortrait=true;

var currentView = "A"; // allporjects view

var currentSortOn = "pn"; // on prject name

var currentSort = "a"; // ascending or descending

//window.onresize = function () { location.reload(); }


function openSideMenu(evt) {
    document.getElementById("fullMask").style.height = "100%";
    document.getElementById("fullMask").style.opacity = 1;
    document.getElementById("sideMenu").style.width = "300px";
}

function closeSideMenu(evt) {

    document.getElementById("fullMask").style.opacity = 0;

    document.getElementById("sideMenu").style.width = "0px";

    window.setTimeout(removeMask, 400);
}
function removeMask() {
    document.getElementById("fullMask").style.height = "0%";

}
