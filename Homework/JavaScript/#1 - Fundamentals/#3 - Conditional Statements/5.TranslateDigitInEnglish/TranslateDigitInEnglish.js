// Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

function TranslateDigit() {
    var digit = parseInt(document.getElementById("number").value);

    switch (digit) {
        case 0: document.getElementById("result").value = digit + " = Zero"; break;
        case 1: document.getElementById("result").value = digit + " = One"; break;
        case 2: document.getElementById("result").value = digit + " = Two"; break;
        case 3: document.getElementById("result").value = digit + " = Three"; break;
        case 4: document.getElementById("result").value = digit + " = Four"; break;
        case 5: document.getElementById("result").value = digit + " = Five"; break;
        case 6: document.getElementById("result").value = digit + " = Six"; break;
        case 7: document.getElementById("result").value = digit + " = Seven"; break;
        case 8: document.getElementById("result").value = digit + " = Eight"; break;
        case 9: document.getElementById("result").value = digit + " = Nine"; break;
        default: document.getElementById("result").value = digit + " is NOT Digit"; break;
    }
}