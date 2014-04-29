// Write a script that finds the biggest of three integers using nested if statements.

function FindBiggestOfThree() {
    var first = parseInt(document.getElementById("first").value);
    var second = parseInt(document.getElementById("second").value);
    var third = parseInt(document.getElementById("third").value);

    if (first > second) {
        if (second > third) {
            document.getElementById("result").value = "The biggest of three is: " + first;
        }
        else if (third > first) {
            document.getElementById("result").value = "The biggest of three is: " + third;
        }
    }
    else if (second > first) {
        if (first > third) {
            document.getElementById("result").value = "The biggest of three is: " + second;
        }
        else if (third > second) {
            document.getElementById("result").value = "The biggest of three is: " + third;
        }
    }
    else if (third > first) {
        if (first > second) {
            document.getElementById("result").value = "The biggest of three is: " + third;
        }
        else if (second > third) {
            document.getElementById("result").value = "The biggest of three is: " + second;
        }
    }
}