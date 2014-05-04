// Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.

function countTumesGivenNumber() {
    var num = parseInt(document.getElementById("number").value);
    var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 5, 7, 3, 4, 5, 7, 4, 5, 4, 4, 4, 3, 2, 3, 4];
    var i;
    var len = 1;

    for (i = 0; i < arr.length; i++) {
        if (arr[i] == num) {
            len += 1;
        }
    }

    document.getElementById("result").innerHTML = "Repeat as many times is: " + len;
}

countTumesGivenNumber();