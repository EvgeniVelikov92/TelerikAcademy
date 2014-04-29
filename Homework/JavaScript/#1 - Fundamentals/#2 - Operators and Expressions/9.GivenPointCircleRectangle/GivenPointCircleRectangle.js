// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

function GivenPointCircleRectangle() {
	var x = parseInt(document.getElementById("x").value);	
	var y = parseInt(document.getElementById("y").value);	
	var r = parseInt(document.getElementById("r").value);
	var withinCircle = false;
	var outsideRectangle = false;
	var point = false;

	if (isNaN(x) && isNaN(y)) {
	    alert("The input is not valid");
	}
	else {
	    if ((x * x) + (y * y) < r * r) {
	        withinCircle = true;
	    }

	    if ((x < -1 || x > 5 || y < -1 || y > 1)) {
	        outsideRectangle = true;
	    }

	    if (outsideRectangle == true && withinCircle == true) {
	        point = true;
	        document.getElementById("result").innerHTML = "The Point is Outside Rectangle and Without Circle";
	    }
	}
}