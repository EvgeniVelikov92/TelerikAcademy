﻿// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

function GivenIntegerThirdDigit() {
	var number = parseInt(document.getElementById("number").value);
	var unit = number / 100;
	var tens = unit % 10 | 0;
	var booleans = true;

	if (tens === 7) {
		booleans = true;
		document.getElementById("result").value = tens + " = " + booleans;
	}
	else {
		booleans = false;
		document.getElementById("result").value = tens + " = " + booleans;
	}
}