// Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.

function translateNumberToEnglish() {
    var num = parseInt(document.getElementById("number").value),
		result = "";

    if (isNaN(num)) {
        result = "Number is empty! Check your entered number! Please Try Again!";
    }
    else if (num > 999) {
        result = "Number is too Biggest! Please Try Again!";
    }
    else if (num < 0) {
        result = "Number is not Positive! Please Try Again!";
    }
    else {
        if (num >= 100) {
            result += GetSimpleDigits(Math.floor(num / 100));
            result += " Hundred ";
            num %= 100;
        }

        if (num > 19) {
            result += GetTwentyToNineTeen(Math.floor(num / 10));
            result += " ";
            num %= 10;
        }

        if (num > 9) {
            result += GetTeenNumbers(num);
            result += " ";
            num &= 10;
        }

        if (num > 0) {
            result += GetSimpleDigits(num);
            result += " ";
            num = 0;
        }

        if (num == 0) {
            if (result.length === 0) {
                result += "zero";
            }
        }
    }

    document.getElementById("result").innerHTML = result;
}

function GetSimpleDigits(digit) {
    switch (digit) {
        case 0: return "";
        case 1: return "One"; 
        case 2: return "Two"; 
        case 3: return "Three"; 
        case 4: return "Four"; 
        case 5: return "Five"; 
        case 6: return "Six";
        case 7: return "Seven";
        case 8: return "Eight";
        case 9: return "Nine"; 
        default: return "";
    }
}

function GetTeenNumbers(number) {
    switch (number) {
        case 10: return "Ten";
        case 11: return "Eleven";
        case 12: return "Twelve";
        case 13: return "Thirteen";
        case 14: return "Fourteen"; 
        case 15: return "Fifteen"; 
        case 16: return "Sixteen";
        case 17: return "Seventeen";
        case 18: return "Eighteen";
        case 19: return "Nineteen";
        default: return "";
    }
}

function GetTwentyToNineTeen(digit) {
    switch (digit) {
        case 2: return "Twenty";
        case 3: return "Thirty";
        case 4: return "Fourty";
        case 5: return "Fifty";
        case 6: return "Sixty";
        case 7: return "Seventy";
        case 8: return "Eighty";
        case 9: return "Ninety";
        default: return "";
    }
}