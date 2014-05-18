// Write a script that parses an URL address given in the format: and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:

function getWebSite() {
    var web = "http://devbg.org/forum/index.php";

    parseURLAddress(web);
}

function parseURLAddress(web) {
    var site = {
        protokol: "",
        server: "",
        resource: ""
    },
        symbol;

    for (symbol in web) {
        if (symbol !== ":") {
            site.protokol += symbol;
        }

    }

    return site.protokol;
}