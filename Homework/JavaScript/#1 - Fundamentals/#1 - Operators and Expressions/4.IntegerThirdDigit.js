// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

var number = 1592;
var unit = number / 100;
var tens = unit % 10 | 0;
var bool = true;

if (tens === 7) {
    bool = true;
}
else {
    bool = false;
}