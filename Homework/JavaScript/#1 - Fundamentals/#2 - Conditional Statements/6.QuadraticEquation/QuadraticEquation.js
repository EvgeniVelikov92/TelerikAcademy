// Write a script that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

function EnterNumber() {
    var a = parseFloat(document.getElementById("a").value);
    var b = parseFloat(document.getElementById("b").value);
    var c = parseFloat(document.getElementById("c").value);

    CalculateQuadraticEquation(a, b, c);
}

function CalculateQuadraticEquation(a, b, c) {
    d = b * b + 4 * a * c;
    document.getElementById("d").value = "Discriminant = " + d.toFixed(2);
    if (d > 0) {
        var xOne = (-b + Math.sqrt(d)) / 2 * a;
        var xTwo = (-b - Math.sqrt(d)) / 2 * a;
        document.getElementById("x-one").value = "X1 = " + xOne.toFixed(2);
        document.getElementById("x-two").value = "X2 = " + xTwo.toFixed(2);
    }
    else if (d = 0) {
        var x = -b / 2 * a;
        document.getElementById("x-one").value = "X1 = X2 = " + x.toFixed(2);
    }
    else {
        document.getElementById("x-one").value = "Equation has no real roots!";
    }
}