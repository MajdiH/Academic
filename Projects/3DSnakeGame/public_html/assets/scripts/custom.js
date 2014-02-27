function loading() {
    document.getElementById("loading").style.visibility = "visible";
    setTimeout('loadingVisible()', 3000);
}

function loadingVisible() {
    document.getElementById("loading").style.visibility = "hidden";

}

