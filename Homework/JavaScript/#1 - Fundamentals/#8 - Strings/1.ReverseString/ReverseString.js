// Write a JavaScript function reverses string and returns.

function reverseString(str) {
    var revStr = "",
        i;

    for (i = str.length - 1; i >= 0; i-=1) {
        revStr += str[i];
    }

    return revStr;
}

console.log(reverseString("This is String"));