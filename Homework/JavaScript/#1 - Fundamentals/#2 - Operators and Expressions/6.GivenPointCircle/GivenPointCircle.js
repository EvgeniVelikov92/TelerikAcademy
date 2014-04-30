// Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

function GivenPointCircle() {
	var x = parseInt(document.getElementById("x").value),	
		y = parseInt(document.getElementById("y").value),	
		r = parseInt(document.getElementById("r").value),
		point = (x * x) + (y * y) <= r * r;
	
	document.getElementById("result").value = point;
}