// Write a script that compares two char arrays lexicographically (letter by letter).

function CommparesArrays() {
    var strOne = document.getElementById("firstWord").value,
        strTwo = document.getElementById("secondWord").value,
        i,
        len = Math.min(strOne.length, strTwo.length);

    for (i = 0; i < len; i++) {       
        if (strOne[i] > strTwo[i]) {
            document.getElementById("result").innerHTML = "The Second Word is forward on Lexicography";
            break;
        }
        else if (strTwo[i] > strOne[i]) {
            document.getElementById("result").innerHTML = "The First Word is forward on Lexicography";
            break;
        }
        else {
            if (strOne.length > strTwo.length) {
                document.getElementById("result").innerHTML = "The Second Word is forward on Lexicography";
            }
            else if (strOne.length < strTwo.length) {
                document.getElementById("result").innerHTML = "The First Word is forward on Lexicography";
            }
            else if (strOne.length === strTwo.length) {
                document.getElementById("result").innerHTML = "First Word = Second Word";
            }
        }
    }   
}
