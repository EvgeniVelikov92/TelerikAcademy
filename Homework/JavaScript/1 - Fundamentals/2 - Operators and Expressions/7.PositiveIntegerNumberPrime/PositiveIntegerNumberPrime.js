// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

function givenIntegerNumberIsPrime() {
	var number = parseInt(document.getElementById("number").value),
		booleans,
		divider = 2,
		num = Math.sqrt(number),
		i;

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