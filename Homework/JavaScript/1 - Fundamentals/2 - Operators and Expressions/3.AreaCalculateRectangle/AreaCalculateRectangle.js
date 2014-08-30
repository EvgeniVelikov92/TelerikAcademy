// Write an expression that calculates rectangle’s area by given width and height.

function calculateRectangleArea() {
	var height = parseInt(document.getElementById("height").value);
		width = parseInt(document.getElementById("width").value),
		area = height * width,
	
	document.getElementById("result").value = " " + area.toFixed(2);
}