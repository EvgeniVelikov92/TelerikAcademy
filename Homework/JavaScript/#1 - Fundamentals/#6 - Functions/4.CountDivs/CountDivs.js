// Write a function to count the number of divs on the web page.

function countDivs() {
    var tag = document.getElementById("tag").value,
        tags = document.getElementsByTagName(tag).length,
        res = document.getElementById("result").innerHTML = "The number of " + tag + " on you Web Page is: " + tags;
}

countDivs();