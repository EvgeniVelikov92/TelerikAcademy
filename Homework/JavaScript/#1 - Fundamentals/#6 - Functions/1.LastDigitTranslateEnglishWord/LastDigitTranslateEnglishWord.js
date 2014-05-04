// Write a function that returns the last digit of given integer as an English word. 

function returnsLastDigit() {
    var number = parseInt(document.getElementById("number").value),
        reside = number % 10;

    givenIntegerEnglishWord(reside);
}

function givenIntegerEnglishWord(digit) {
    switch (digit) {
        case 0: document.getElementById("result").innerHTML = "Zero"; break;
        case 1: document.getElementById("result").innerHTML = "One"; break;
        case 2: document.getElementById("result").innerHTML = "Two"; break;
        case 3: document.getElementById("result").innerHTML = "Three"; break;
        case 4: document.getElementById("result").innerHTML = "Four"; break;
        case 5: document.getElementById("result").innerHTML = "Five"; break;
        case 6: document.getElementById("result").innerHTML = "Six"; break;
        case 7: document.getElementById("result").innerHTML = "Seven"; break;
        case 8: document.getElementById("result").innerHTML = "Eight"; break;
        case 9: document.getElementById("result").innerHTML = "Nine"; break;
    }
}