// Write a program that finds the most frequent number in an array.

function FindsTheMostFrequentNumber() {
    var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 3, 3, 3, 3, 3, 4],
        i,
        len = 1,
        bestlen = 1,
        arrIndex;

    arr.sort();

    for (i = 0; i < arr.length; i++) {
        if (arr[i] == arr[i + 1]) {
            len++;
        }
        else {
            len = 1;
        }

        if (bestlen < len) {
            bestlen = len;
            arrIndex = arr[i];
        }
    }

    console.log("Index: " + arrIndex + " = Length: " + bestlen);
}