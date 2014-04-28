// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var bool = true;
var number = 36;

if (number % 5 == 0 && number % 7 == 0) {
    bool = true;
}
else {
    bool = false;
}