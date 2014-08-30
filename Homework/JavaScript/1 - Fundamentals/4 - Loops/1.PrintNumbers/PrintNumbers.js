// Write a script that prints all the numbers from 1 to N

function printNumbers() {
    var n = parseInt(document.getElementById("number").value),
		index;

    for (index = 1; index <= n; index++) {
        alert("The number is: " + index);
    }
}