// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

function biggerThanNeighbours() {
    var arr = [1, 2, 3, 4, 5, 45, 6, 7, 8, 4, 6, 7, 8, 59, 3, 2, 4, 5, 3, 5, 3, 5, 7, 4, 3, 21, 3, 5, 6, 8];
    var pos = parseInt(document.getElementById("position").value);

    if (arr[pos - 2] < arr[pos - 1] && arr[pos] < arr[pos - 1]) {
        document.getElementById("result").innerHTML = "The element in position " + pos + " is bigger than two neighbors.";
    }
    else {
        document.getElementById("result").innerHTML = "The element in position " + pos + " is not bigger than two neighbors.";
    }
}