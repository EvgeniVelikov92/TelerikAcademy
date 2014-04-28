// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var number = 6;
var bool;
var divider = 2;
var num = Math.sqrt(number);

for (var i = divider; i <= num; i++) {
    if (number % i == 0) {
        bool = false;
        alert("The Integer Number is Not Prime");
        break;
    }
    else {
        bool = true;
        alert("The Integer Number is Prime");
    }
}