// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function getText() {
    var text = document.getElementById("txt").value;
    var subString = document.getElementById("substr").value;
    var result = findSubstring(text, subString);

    document.getElementById("result").innerHTML = "The result is: " + result;
}

function findSubstring(txt, substr) {
    text = txt.toLowerCase();
    sub = substr.toLowerCase();
    var i;
    var count = 0;
    var index = text.indexOf(sub);

    while (index > -1) {
        count += 1;
        index = text.indexOf(sub, index + 1);
    }

    return count;
}