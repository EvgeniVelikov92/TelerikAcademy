// Write a function that reverses the digits of given decimal number.

function getNumber() {
    var num = parseInt(document.getElementById("number").value);

    (reverseDigits(num));

    document.getElementById("result").innerHTML = reverseDigits(num);
}

function reverseDigits(number) {
    var reversed = "",
        i;

    number = number.toString();

    for (i = number.length - 1; i >= 0; i--) {
        reversed += number[i];
    }

    return reversed;
}