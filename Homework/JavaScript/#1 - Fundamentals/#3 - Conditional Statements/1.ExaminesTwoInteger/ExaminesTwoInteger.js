// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

function ExaminesIntegerVariables() {
    var first = parseFloat(document.getElementById("FirstNum").value);
    var second = parseFloat(document.getElementById("SecondNum").value);
    var bigger = second;
    if (bigger < first) {
        bigger = first;
    }
    document.getElementById("result").value = "The greater number is: " + bigger;
}