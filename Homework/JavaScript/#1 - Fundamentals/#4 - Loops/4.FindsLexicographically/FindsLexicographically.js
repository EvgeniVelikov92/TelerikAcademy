// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

// Navigator Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];                                      

for (property in navigator) {
    arr.push(navigator[property]);
}

smallestProperty = arr[0]
largestProperty = arr[0];

for (i = 0; i < arr.length; i++) {
        
    if (arr[i] < smallestProperty) {
        smallestProperty = arr[i];
    }

    if (arr[i] > largestProperty) {
        largestProperty = arr[i];
    }
} 

// Window Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];

for (property in window) {
    arr.push(window[property]);
}

smallestProperty = arr[0]
largestProperty = arr[0];

for (i = 0; i < arr.length; i++) {

    if (arr[i] < smallestProperty) {
        smallestProperty = arr[i];
    }

    if (arr[i] > largestProperty) {
        largestProperty = arr[i];
    }
}

// Document Object --------------------------------------------------
var property,
    smallestProperty,
    largestProperty;
var arr = [];

for (property in document) {
    arr.push(document[property]);
}

smallestProperty = arr[0]
largestProperty = arr[0];

for (i = 0; i < arr.length; i++) {

    if (arr[i] < smallestProperty) {
        smallestProperty = arr[i];
    }

    if (arr[i] > largestProperty) {
        largestProperty = arr[i];
    }
}