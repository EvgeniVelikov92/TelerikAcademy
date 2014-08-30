// Using jQuery implement functionality to insert a DOM element before or after another element.

function insertElement() {
	$('<div />').addClass('.before-element').prependTo(document.body);
	$('<div />').addClass('.after-element').appendTo(document.body);
}

insertElement();