// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

var number = 1592;
var unit = number / 100;
var tens = unit % 10 | 0;
var booleans = true;

if (tens === 7) {
    booleans = true;
}
else {
    booleans = false;
}

console.log(tens);
console.log(booleans);