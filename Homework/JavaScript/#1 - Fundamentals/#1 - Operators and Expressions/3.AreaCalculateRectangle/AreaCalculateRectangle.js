// Write an expression that calculates rectangle�s area by given width and height.

function CalculateRectangleArea() {
	var height = parseInt(document.getElementById("height").value);
	var width = parseInt(document.getElementById("width").value);
	var area = height * width;
	document.getElementById("result").value = " " + area.toFixed(2);
}