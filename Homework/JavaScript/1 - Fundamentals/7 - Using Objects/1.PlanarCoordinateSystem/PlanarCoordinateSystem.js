// Write functions for working with shapes in  standard Planar coordinate system. Points are represented by coordinates P(X, Y). Lines are represented by two points, marking their beginning and ending. L(P1(X1,Y1), P2(X2,Y2)). Calculate the distance between two points. Check if three segment lines can form a triangle.

var pOne = createPoint(3, 8),
    pTwo = createPoint(4, 5),
    pThree = createPoint(6, 7),
    lOne = getLine(pOne, pTwo),
    lTwo = getLine(pTwo, pThree),
    lThree = getLine(pThree, pOne);
    n = calculateDistance(pThree, pTwo);

function createPoint(x, y) {
	return {
        x: x,
        y: y
    };
}

function getLine (pointOne, pointTwo) {
    return {
        pointA: pointOne,
        pointB: pointTwo
    };
}

function calculateDistance(PointOne, PointTwo) {
    return Math.sqrt(parseFloat((PointOne.x - PointTwo.x) * (PointOne.x + PointTwo.x) + (PointOne.y - PointTwo.y) * (PointOne.y - PointTwo.y)));
}

function createTriangle(lineOne, lineTwo, lineThree) {
    var a = calculateDistance(lineOne.pointA, lineOne.pointB),
        b = calculateDistance(lineTwo.pointA, lineTwo.pointB),
        c = calculateDistance(lineThree.pointA, lineThree.pointB);

    if ((a + b) > c && (a + c) > b && (b + c) > a) {
        alert("Congratilation! You create a Triangle!");
    }
    else {
        alert("This is not a Triangle. Please try again.");
    }
}

createTriangle(lOne, lTwo, lThree);