// Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

function GivenPointCircle() {
	var x = parseInt(document.getElementById("x").value);	
	var y = parseInt(document.getElementById("y").value);	
	var r = parseInt(document.getElementById("r").value);
	var point = (x * x) + (y * y) <= r;
	document.getElementById("result").value = point;
}