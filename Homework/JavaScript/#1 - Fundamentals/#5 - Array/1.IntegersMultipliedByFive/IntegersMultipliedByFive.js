// Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19];
var i;

for (i = 0; i < arr.length; i++) {
    console.log(arr[i] + " * 5 = " + (arr[i] * 5));
}