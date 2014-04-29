// Write an expression that calculates trapezoid's area by given sides a and b and height h.

function AreaCalculate() {
	var a = parseInt(document.getElementById("a").value);
	var b = parseInt(document.getElementById("b").value);
	var h = parseInt(document.getElementById("h").value);
	var area = ((a + b) / 2) * h;
	document.getElementById("result").value = " " + area;
}