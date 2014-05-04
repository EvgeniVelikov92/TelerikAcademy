// Write a script that finds the greatest of given 5 variables.

function findTheGreatest() {
    var number = new Array(5);
    number[0] = parseFloat(document.getElementById("first").value);
    number[1] = parseFloat(document.getElementById("second").value);
    number[2] = parseFloat(document.getElementById("third").value);
    number[3] = parseFloat(document.getElementById("fourth").value);
    number[4] = parseFloat(document.getElementById("fifth").value);
    var index,
        greater = 0;

    for (index = 0; index < number.length; index++) {        
        if (number[index] > greater) {
            greater = number[index];
        }
    }

    document.getElementById("result").value = "Thre Greatest Variables is: " + greater;
}