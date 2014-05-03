// Write a script that finds the maximal increasing sequence in an array.

function findMaximalIncreasingSequence() {
    var arr = [3, 2, 3, 4, 5, 1, 2, 4],
        i,
        len = 1,
        bestlen = 1;

    for (i = 0; i < arr.length; i++) {
        if ((arr[i] + 1) == arr[i + 1]) {
            len++;
        }
        else {
            len = 1;
        }

        if (bestlen < len) {
            bestlen = len;
        }
    }

    console.log("Length: " + bestlen);
}