// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function findsLexicographically(obj) {
    var property;
    var arr = [];

    for (property in obj) {
        arr.push(property);
    }

    arr.sort();

    return "Smallest Properti in: " + arr[0] + "\nLargest Properti in: " + arr[arr.length - 1];
}

console.log("----------------Document----------------------");
console.log(findsLexicographically(document));

console.log("----------------Navigator----------------------");
console.log(findsLexicographically(navigator));

console.log("----------------Window----------------------");
console.log(findsLexicographically(window));