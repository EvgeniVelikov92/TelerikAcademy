// Write a function that replaces non breaking white-spaces in a text with &nbsp.

var text = "Write a function that replaces non breaking white-spaces in a text with."

function replacesWhiteSpaces(txt) {
    var i;
    for (i = 0; i < txt.length; i++) {
        if (txt[i] === " ") {
            txt = txt.replace(txt[i], '&nbsp;');
        }
    }

    return txt;
}

console.log(replacesWhiteSpaces(text));

//function replacesWhiteSpaces(txt) {
//    txt = txt.split(' ').join('&nbsp;')

//    return txt;
//}

//console.log(replacesWhiteSpaces(text));