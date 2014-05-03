// Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

var numbers = new Array(28, 23, 3, 2, 4, 5, 7, 1, 8, 9, 12, 11, 15, 1, 2, 4),
    len = numbers.length,
    sorted_numbers = new Array(),
    i,
    j,
    index = 0;

for (i = 0; i < len; i++) {
    index = 0;

    for (j = 0; j < numbers.length; j++) {
        if (numbers[j] < numbers[index]) {
            index = j;
        }
    }

    sorted_numbers[i] = numbers[index];
    numbers.splice(index, 1);
}

console.log(sorted_numbers.join(", "));