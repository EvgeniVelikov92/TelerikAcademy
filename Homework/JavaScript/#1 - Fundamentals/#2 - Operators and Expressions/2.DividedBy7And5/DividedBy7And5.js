// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function GivenIntegerDivided() {
	var number = parseInt(document.getElementById("number").value);
	var bool = true;
	
	if (number % 5 == 0 && number % 7 == 0) {
		bool = true;
		document.getElementById("result").value = "The number " + number + " can be divided by 7 and 5"
	}
	else {
		bool = false;
		document.getElementById("result").value = "The number " + number + " can not be divided by 7 and 5"
	}
}