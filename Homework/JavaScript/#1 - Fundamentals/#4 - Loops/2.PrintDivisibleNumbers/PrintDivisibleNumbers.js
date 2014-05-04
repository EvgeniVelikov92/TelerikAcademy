// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

function printDivisibleNumbers() {
    var n = parseInt(document.getElementById("number").value),
		index;

    for (index = 1; index <= n; index++) {
        if ((index % 3 != 0) || (index % 7 != 0)) {
            alert("The number: " + index);
        }
    }
}