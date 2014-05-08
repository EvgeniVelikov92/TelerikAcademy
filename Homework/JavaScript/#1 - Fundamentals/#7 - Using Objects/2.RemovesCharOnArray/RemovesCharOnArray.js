// Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.

function getValue() {
    var char = parseInt(document.getElementById("char").value);

    removesCharOnArray(char);
}

function removesCharOnArray(arrChar) {
    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"];

    arr.indexOf(1, 0, arr.length);
    console.log("Removes char: " + arrChar.getValue(arrChar));
}