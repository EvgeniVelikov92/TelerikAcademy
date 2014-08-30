// Write a function that finds all the occurrences of word in a text. The search can case sensitive or case insensitive. Use function overloading.

var text = "We are living in an yellow submarine. In the sky there are no clouds. So we are drinking all the day. We will move out of it in 5 days.";
var wordToSearch = "in";
var caseSensitive = false;

function theOccurrencesOfWordInAText(txt, word, caseSensitive) {
    caseSensitive = caseSensitive || false;

    var count = 0;
    var index = txt.indexOf(word);
    var i;
    var strArr = txt.split(word);

    if (caseSensitive === false) {
        for (i in strArr) {
            count += 1;
        }

        return count;
    }
    else {
        while (index > -1) {
            count += 1;
            index = txt.indexOf(word, index + 1);
        }

        return count;
    }
}

console.log(theOccurrencesOfWordInAText(text, wordToSearch, caseSensitive));