// Write an expression that checks if given integer is odd or even.

function givenInteger() {
    var number = parseInt(document.getElementById("number").value);

    if (number % 2 == 0) {
		document.getElementById("result").value = "The number: " + number + " is Even";
    }
    else {
		document.getElementById("result").value = "The number: " + number + " is Odd";
    }
}