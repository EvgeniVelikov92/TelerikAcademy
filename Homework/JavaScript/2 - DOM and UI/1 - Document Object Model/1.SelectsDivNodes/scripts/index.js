// Write a script that selects all the div nodes that are directly inside other div elements. Create a function using querySelectorAll(). Create a function using getElementsByTagName().

function usingQuerySelectorAll() {
    var insideDivs = document.querySelectorAll("div div");

    for (var item in insideDivs){
        if (undefined != insideDivs[item].innerHTML) {
            console.log(insideDivs[item].innerHTML);
            console.log("*********************");
        }
    }
}

function usingGetElementsByTagName(){
    var outsideDivs = document.getElementsByTagName("div");
    var insideDivs;

    for (var item in outsideDivs){
        insideDivs = outsideDivs[item].getElementsByTagName("div");

        for (var itemTwo in insideDivs) {
            if (undefined != insideDivs[itemTwo].innerHTML) {
                console.log(insideDivs[itemTwo].innerHTML);
                console.log("*********************");
            }
        }
    }
}