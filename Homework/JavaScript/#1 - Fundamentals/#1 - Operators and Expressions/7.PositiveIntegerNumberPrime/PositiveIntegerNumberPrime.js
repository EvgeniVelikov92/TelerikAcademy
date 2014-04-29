// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

function GivenIntegerNumberIsPrime() {
	var number = parseInt(document.getElementById("number").value);
	var booleans;
	var divider = 2;
	var num = Math.sqrt(number);

	for (var i = divider; i <= num; i++) {
		if (number % i == 0) {
			booleans = false;
			document.getElementById("result").value = "The Integer Number is not Prime";
			break;
		}
		else {
			booleans = true;		
			document.getElementById("result").value = "The Integer Number is Prime";
		}
	}
}