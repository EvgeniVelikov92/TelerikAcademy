// Create a tag cloud: Visualize a string of tags (strings) in a given container. By given minFontSize and maxFontSize, generate the tags with different font-size, depending on the number of occurrences.

var tags = ["cms", "javascript", "js", "ASP.NET MVC", 
            ".net", ".net", "css", "wordpress",
            "xaml", "js", "http", "web", 
            "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", 
            "javascript", "js", "cms", "html", 
            "javascript", "http", "http", "CMS"];
var tagCloud = generateTagCloud(tags, 17, 42);
document.body.appendChild(tagCloud);

function generateTagCloud(text, minSize, maxSize) {
    var wordCount = countWords(text);
    var div = document.createElement("div");
    div.style.width = "910px";
    div.style.border = "1px solid black";

    var min = Number.MAX_VALUE;
    var max = 0;

    for (var word in wordCount) {
        if (wordCount[word] < min) {
            min = wordCount[word];
        }

        if (wordCount[word] > max) {
            max = wordCount[word];
        }
    }

    for (var word in wordCount) {
        var tag = document.createElement('span');

        if (min === wordCount[word]) {
            tag.style.fontSize = minSize + 'px';
        }
        else if (max === wordCount[word]) {
            tag.style.fontSize = maxSize + 'px';
        }
        else {
            tag.style.fontSize = minSize + ((maxSize - minSize) / ((max - wordCount[word])+1))+"px";
        }

        tag.innerText = word + " ";
        div.appendChild(tag);
    }

    function countWords(words) {
        var wordCount = {};
        var word = {};

        for (var i in words) {
            word = words[i].toLowerCase();
            if (wordCount[word]) {
                wordCount[word]+=1;
            }
            else {
                wordCount[word] = 1;
            }
        }
        return wordCount;
    }
    return div;
}