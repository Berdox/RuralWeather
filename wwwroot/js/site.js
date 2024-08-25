
function toggleHours() {
    var hiddenHours = document.querySelectorAll(".hidden-hours");
    var hourButton = document.getElementById("hoursButton");
    hiddenHours.forEach(hour => {
        var currentDisplay = window.getComputedStyle(hour).display;
        hour.style.display = currentDisplay === "none" ? "flex" : "none";
    });

    hourButton.textContent = hourButton.textContent === "Full 24 Hours" ? "Show less" : "Full 24 Hours";
}


function toggleAirData(uniqueID) {
    var airData = document.getElementById(uniqueID);

    if (airData.style.display === "none" || airData.style.display === "") {
        airData.style.display = "flex";
    } else {
        airData.style.display = "none";
    }
}