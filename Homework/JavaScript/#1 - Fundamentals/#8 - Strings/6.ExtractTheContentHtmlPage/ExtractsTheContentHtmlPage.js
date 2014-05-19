// Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags:

var html = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

function extractHTML(txt) {
    var startIndex,
        endIndex,
        newText = "",
        symbol;

    for (symbol = 0; symbol < txt.length; symbol++) {
        startIndex = txt.indexOf("<", symbol);
        endIndex = txt.indexOf(">", symbol + 1);
        newText += txt.substring(symbol, startIndex);
        symbol = endIndex;
    }

    return newText;
}

extractHTML(html);