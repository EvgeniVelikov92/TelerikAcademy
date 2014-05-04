// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

function examinesIntegerVariables() {
    var first = parseFloat(document.getElementById("FirstNum").value),
		second = parseFloat(document.getElementById("SecondNum").value),
		bigger = second;
		
    if (bigger < first) {
        bigger = first;
    }
	
    document.getElementById("result").value = "The greater number is: " + bigger;
}