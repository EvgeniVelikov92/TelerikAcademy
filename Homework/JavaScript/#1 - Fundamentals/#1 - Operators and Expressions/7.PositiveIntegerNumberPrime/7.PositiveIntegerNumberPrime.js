// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var number = 6;
var booleans;
var divider = 2;
var num = Math.sqrt(number);

for (var i = divider; i <= num; i++) {
    if (number % i == 0) {
        booleans = false;
        alert("The Integer Number is Not Prime");
        break;
    }
    else {
        booleans = true;
        alert("The Integer Number is Prime");
    }
}