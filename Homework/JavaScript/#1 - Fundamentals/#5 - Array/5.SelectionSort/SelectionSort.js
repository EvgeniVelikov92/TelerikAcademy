// Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

var numbers = new Array(28, 23, 3, 2, 4, 5, 7, 1, 8, 9, 12, 11, 15, 1, 2, 4),
    len = numbers.length,
    sorted_numbers = new Array(),
    y,
    z,
    index = 0;

for (z = 0; z < len; z++) {
    index = 0;

    for (y = 0; y < numbers.length; y++) {

        if (numbers[y] < numbers[index]) {
            index = y;
        }
    }

    sorted_numbers[z] = numbers[index];
    numbers.splice(index, 1);
}

console.log(sorted_numbers.join(", "));