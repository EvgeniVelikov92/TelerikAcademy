// Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

function showSign() {
    var first = parseFloat(document.getElementById("first").value),
		second = parseFloat(document.getElementById("second").value),
		third = parseFloat(document.getElementById("third").value);

    if (first < 0 && second < 0 && third < 0) {
        document.getElementById("result").value = "The sign is: -";
    }
    else if (first < 0 && second < 0 || first < 0 && third < 0 || second < 0 && third < 0) {
        document.getElementById("result").value = "The sign is: +";
    }
    else if (first < 0 || second < 0 || third < 0) {
        document.getElementById("result").value = "The sign is: -";
    }
    else if (first > 0 && second > 0 && third > 0) {
        document.getElementById("result").value = "The sign is: +";
    }
}