// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

function FindingBitThird() {
	var num = parseInt(document.getElementById("number").value),
		p = 3,
		byt = num >> p,
		nanbyt = num & 1;
	
	document.getElementById("result").value = "The Third bit is: " + nanbyt;
}