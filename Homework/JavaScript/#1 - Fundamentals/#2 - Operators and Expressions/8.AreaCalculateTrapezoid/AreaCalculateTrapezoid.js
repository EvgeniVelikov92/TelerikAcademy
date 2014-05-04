// Write an expression that calculates trapezoid's area by given sides a and b and height h.

function areaCalculate() {
	var a = parseInt(document.getElementById("a").value),
		b = parseInt(document.getElementById("b").value),
		h = parseInt(document.getElementById("h").value),
		area = ((a + b) / 2) * h;
	
	document.getElementById("result").value = " " + area;
}