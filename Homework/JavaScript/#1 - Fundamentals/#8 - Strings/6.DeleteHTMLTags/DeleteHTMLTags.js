// Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.

var htmlDoc = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

function deleteHTMLTags(txt) {
    var startIndex;
    var endIndex;
    var i;
    var str = "";

    for (i = 0; i < txt.length; i++) {
        startIndex = txt.indexOf("<", i);
        endIndex = txt.indexOf(">", i + 1);
        str += txt.substring(i, startIndex);
        i = endIndex;
    }

    return str;
}

console.log(deleteTagsOnHTML(htmlDoc));