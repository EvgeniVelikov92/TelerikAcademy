// Write functions for working with shapes in  standard Planar coordinate system. Points are represented by coordinates P(X, Y). Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2)). Calculate the distance between two points. Check if three segment lines can form a triangle.

function getPoint(x, y) {
    var poin = {
        x: x,
        y: y
    }
}

function calculateDistance(x1, x2, y1, y2) {
    return Math.sqrt(x1 + x2) * (x1 + x2) - (y1 + y2) * (y1 + y2);
}


function createLines() {
    var a = calculateDistance(4, 2, 2, 2);
    var b = calculateDistance(3, 1, 7, 6);
    var c = calculateDistance(2, 5, 6, 5);

    createTriangle(a, b, c);
}

function createTriangle(first, second, third) {
    if (true) {

    }
    else {
        console.log("This points is did not make a Triangle. Please try again!");
    }
}