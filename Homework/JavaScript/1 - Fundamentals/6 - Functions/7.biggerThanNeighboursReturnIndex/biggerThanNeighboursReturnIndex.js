// Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element. Use the function from the previous exercise.

function biggerThanNeighboursReturnIndex() {
    var arr = [1, 2, 3, 4, 5, 45, 6, 7, 8, 4, 6, 7, 8, 59, 3, 2, 4, 5, 3, 5, 3, 5, 7, 4, 3, 21, 3, 5, 6, 8];
    var i;

    for (i = 1; i < arr.length - 2; i++) {
        if ((arr[i - 1] < arr[i]) && arr[i] > arr[i + 1]) {
            return arr[i];
        }
    }
	
	return -1;
}

console.log(biggerThanNeighboursReturnIndex());