// Write an expression that checks if given integer is odd or even.

function givenInteger() {
    var number = parseInt(document.getElementById("number").value);

    if (number % 2 == 0) {
        alert("The number: " + number + " is Odd");
    }
    else {
        alert("The number: " + number + " is Even");
    }
}