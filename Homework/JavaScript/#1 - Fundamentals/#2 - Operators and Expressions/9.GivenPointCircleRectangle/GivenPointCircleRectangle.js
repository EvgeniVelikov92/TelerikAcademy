// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

function GivenPointCircleRectangle() {
	var x = parseInt(document.getElementById("x").value);	
	var y = parseInt(document.getElementById("y").value);	
	var r = parseInt(document.getElementById("r").value);
	var withinCircle = false;
	var outsideRectangle = true;
	var point = false;

	if (isNaN(x) && isNaN(y)) {
	    alert("The input is not valid");
	    document.getElementById("result").innerHTML = "The input is not valid coordinates";
	}
	else {
	    if ((x * x) + (y * y) < r * r) {
	        withinCircle = true;
	    }
	    else {
	        withinCircle = false;
	    }

	    if ((x < -1 || x > 6 || y < 1 || y > 2)) {
	        outsideRectangle = true;
	    }
	    else {
	        outsideRectangle = false;
	    }

	    if (outsideRectangle == false) {
	        if (withinCircle == false) {
	            point = false;
	            document.getElementById("result").innerHTML = "The Point is Outside Rectangle and Without Circle";
	        }
	        else {
	            point = false;
	            document.getElementById("result").innerHTML = "The Point is Outside Rectangle and Within Circle";
	        }
	    }
	    else {
	        if (withinCircle == false) {
	            point = false;
	            document.getElementById("result").innerHTML = "The Point is Outside Rectangle and Without Circle";
	        }
	        else {
	            point = true;
	            document.getElementById("result").innerHTML = "The Point is Inside Rectangle and Within Circle";
	        }
	    }
	}
}