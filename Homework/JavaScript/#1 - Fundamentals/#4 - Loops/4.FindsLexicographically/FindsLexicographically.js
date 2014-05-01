// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function FindsLexicographically() {
    var property,
        smallestProperty,
        largestProperty;
    var arr = [];                                      

    for (property in navigator) {
        arr.push(navigator[property]);
    }

    for (i = 0; i < arr.length; i++) {

        if (arr[i] < smallestProperty) {
            smallestProperty = arr[i];
        }

        if (arr[i] > largestProperty) {
            largestProperty = arr[i];
        }
    } 
}

function FindDocumentProperty() {

}

function FindWindowProperty() {

}

function FindNavigatorProperty() {

}