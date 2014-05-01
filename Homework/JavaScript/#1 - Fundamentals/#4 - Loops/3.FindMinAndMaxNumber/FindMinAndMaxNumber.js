// Write a script that finds the max and min number from a sequence of numbers.

function FindMinAndMaxNumber() {
    var arr = parseInt(document.getElementById("number").value),
        i,
        maxNum = Number.MIN_VALUE,
        minNum = Number.MAX_VALUE,
        num;

    for (i = 1; i <= arr; i++) {       
        num = Math.round(Math.random() * 100);
        alert("The number: " + num);
		
        if (maxNum < num) {
            maxNum = num;
        }

        if (minNum > num) {
            minNum = num;
        }
    }

    document.getElementById("min-number").innerHTML = "Min number is: " + minNum;
    document.getElementById("max-number").innerHTML = "Max number is: " + maxNum;
}