// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function binarySearchAlgorithm() {
    var number = 78;
    var arr = [-999, -333, -1, 0, 1, 2, 3, 4, 6, 8, 9, 11, 13, 14, 17, 21, 23, 32, 54, 65, 77, 78, 79, 81, 88, 99, 222, 100000];
    var leftIndex = 0; // the index of the first element
    var rightIndex = arr.length - 1; // the index of the last element
    var midleIndex;
    var count = 1;

    while (true) {
        console.log("loop " + count);
        console.log("leftIndex = " + leftIndex);
        console.log("rightIndex = " + rightIndex);
        midleIndex = parseInt((leftIndex + rightIndex) / 2);
        console.log("midleIndex = " + midleIndex);

        if (number > arr[midleIndex]) {
            console.log("'number = " + number + "' > '" + " arr[midleIndex] = " + arr[midleIndex] + "'");
            console.log(" ");
            count += 1;
            leftIndex = midleIndex + 1;
        }
        else {
            if (number < arr[midleIndex]) {
                console.log("'number = " + number + "' < '" + " arr[midleIndex] = " + arr[midleIndex] + "'");
                console.log(" ");
                count += 1;
                rightIndex = midleIndex - 1;
            }
            else {
                console.log("'number = " + number + "' = '" + " arr[midleIndex] = " + arr[midleIndex] + "'");
                console.log(" ");
                console.log("The index of 'number' is: " + midleIndex);
                break;
            }
        }
    }
}