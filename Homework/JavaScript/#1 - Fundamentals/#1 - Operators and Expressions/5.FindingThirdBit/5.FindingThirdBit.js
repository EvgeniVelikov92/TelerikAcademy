// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var num = 7;
var p = 3;
var byt = num >> p;
var nanbyt = num & 1;

console.log(nanbyt);