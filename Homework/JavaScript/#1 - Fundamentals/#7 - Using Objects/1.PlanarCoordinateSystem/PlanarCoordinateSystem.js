// Write functions for working with shapes in  standard Planar coordinate system. Points are represented by coordinates P(X, Y). Lines are represented by two points, marking their beginning and ending. L(P1(X1,Y1), P2(X2,Y2)). Calculate the distance between two points. Check if three segment lines can form a triangle.

function getPoint(x, y) {
    var point = {
        x: x,
        y: y,
    }

    return point;
}

function calculateDistance(xOne, xTwo, yOne, yTwo) {
    return Math.sqrt((xOne.x - xTwo.x) * (xOne.x + xTwo.x) + (yOne.y - yTwo.y) * (yOne.y - yTwo.y));
}

function createLines(x1, x2, x3, x4) {
    var a = calculateDistance(4, 2, 4, 8),
        b = calculateDistance(2, 5, 7, 3),
        c = calculateDistance(5, 6, 1, 4);
}

function createTriangle() {
    if (true) {
        alert("Congratilation! You create a Triangle!");
    }
    else {
        alert("This is not a Triangle. Please try again.");
    }
}