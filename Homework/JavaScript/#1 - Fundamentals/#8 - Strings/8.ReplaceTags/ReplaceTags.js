// Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:

var htmlDoc = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTag(txt) {
    var html;

    html = txt.split('</a>').join('[/URL]');
    html = html.split('<a href="').join('[URL=');
    html = html.split('">').join(']');

    return html;
}

replaceTag(htmlDoc);