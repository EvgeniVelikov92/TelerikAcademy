// Write a script that finds the maximal sequence of equal elements in an array.

function FindsMaximalSequenceEqual() {
    var arr = [2, 1, 1, 3, 3, 2, 2, 2, 1],
        i,
        len = 1,
        bestlen = 1,
        arrIndex;

    for (i = 0; i < arr.length - 1; i++) {
        if (arr[i] == arr[i + 1]) {
            len++;
        }
        else if (arr[i] != arr[i + 1]) {
            len = 1;
        }
        
        if (len > bestlen) {
            bestlen = len;
            arrIndex = arr[i];
        }
    }
    console.log("Index: " + arrIndex + " = Length: " + bestlen );
}