// Write a script that parses an URL address given in the format: and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:

var webSite = "http://www.devbg.org/forum/index.php";

function parseURLAddress(web) {
    var site = {
            protokol: "",
            server: "",
            resource: "",
            toString: function () {
                return this.protokol + "\n" + this.server + "\n" + this.resource;
            }
        },
        colon,
        slash;

    colon = web.indexOf(":");
    slash = web.indexOf("/", 12);

    site.protokol = web.substr(web[0], colon);;
    site.server = web.substring(colon + 3, slash);
    site.resource = web.substring(slash, web.length);

    return site;
}

parseURLAddress(webSite);