// Write functions for working with shapes in  standard Planar coordinate system. Points are represented by coordinates P(X, Y). Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2)). Calculate the distance between two points. Check if three segment lines can form a triangle.

function getPoint(x, y) {
    var poin = {
        x: x,
        y: y
    }

    return poin;
}

function calculateDistance(x1, x2, y1, y2) {
    var distance = Math.sqrt(x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);

    return distance;
}


function createLines(pointX, pointY) {
    var line = {
        lineA: pointX,
        lineB: pointY
    }

    return line;
} 

function createTriangle(first, second, third) {
    var a = calculateDistance(first.lineA, first.lineB);
    var b = calculateDistance(second.lineA, second.lineB);
    var c = calculateDistance(third.lineA, third.lineB);
    if ((a + b) > c && (b + c) > a && (a + c) > b) {
        console.log("Triangle is Possible");
    }
    else {
        console.log("This points is did not make a Triangle. Please try again!");
    }
}

var firstPoint = getPoint(2, 5),
    secondPoint = getPoint(6, 8),
    thirdPoint = getPoint(2, 6),
    fourthPoint = getPoint(-7, 8),
    fifthPoint = getPoint(2, 7),
    sixthPoint = getPoint(0, 4);

var firstLine = createLines(firstPoint, secondPoint),
    secondLine = createLines(thirdPoint, fourthPoint),
    thirdLine = createLines(fifthPoint, sixthPoint);

console.log(createTriangle(firstLine, secondLine, thirdLine));