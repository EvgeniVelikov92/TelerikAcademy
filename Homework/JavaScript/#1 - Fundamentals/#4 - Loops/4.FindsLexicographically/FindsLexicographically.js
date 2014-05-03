// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

// Navigator Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];                                      

for (property in navigator) {
    arr.push(navigator[property]);
}

arr.sort();

smallestProperty = arr[0];
largestProperty = arr[arr.length - 1];

// Window Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];

for (property in window) {
    arr.push(window[property]);
}

arr.sort();

smallestProperty = arr[0];
largestProperty = arr[arr.length - 1];

// Document Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];

for (property in document) {
    arr.push(document[property]);
}

arr.sort();

smallestProperty = arr[0];
largestProperty = arr[arr.length - 1];