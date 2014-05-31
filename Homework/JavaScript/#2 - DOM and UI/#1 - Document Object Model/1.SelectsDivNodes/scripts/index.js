// Write a script that selects all the div nodes that are directly inside other div elements. Create a function using querySelectorAll(). Create a function using getElementsByTagName().

function usingQuerySelectorAll() {
    var insideDivs = document.querySelectorAll("div div");

    for (var i = 0, len = insideDivs.length; i < len; i++) {
        console.log(insideDivs[i]);
    }
}


// This Function is Not Working
function usingGetElementsByTagName(){
    var outsideDivs = document.getElementsByTagName("div");
    var insideDivs;

    for (var i = 0, len = outsideDivs.length; i < len; i++) {
        insideDivs = outsideDivs[i].getElementsByTagName("div");
        console.log(outsideDivs[i]);

        for (var j = 0, lenTwo = insideDivs.length; i < lenTwo; i++){
        console.log(insideDivs[i]);
        }
    }
}