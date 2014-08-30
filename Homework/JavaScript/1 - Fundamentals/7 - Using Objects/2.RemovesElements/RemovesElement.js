// Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"],
    finalArr = arr.remove(1);

if (!Array.prototype.remove) {
    Array.prototype.remove = function (elems) {
        var newArr = [],
            i;

        for (var i in this) {
            if (this[i] != elems) {
                newArr.push(this[i]);
            }
        }

        return newArr;
    }    
}

console.log(finalArr);