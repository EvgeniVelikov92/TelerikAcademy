// Write a script that creates a number of div elements. Each div element must have the following

function randomPixels(min, max) {
	var	pixels = Math.floor(Math.random() * (max - min )) + min;

	return pixels;
}

function randomColors() {
    var red = ('0' + randomPixels(0,255).toString(16)).substr(-2), // red
      	green = ('0' + randomPixels(0,255).toString(16)).substr(-2), // green
    	blue = ('0' + randomPixels(0,255).toString(16)).substr(-2); // blue

    return '#' + red + green + blue;
}

function createNumberOfDivElements() {
	var headDiv = document.getElementById('wrapper');
	var divFrag = document.createDocumentFragment(),
		count = 5;

	for (var i = 0; i < count; i+=1) {
		var div = document.createElement('div'),
			strongElem = document.createElement('strong');

		div.appendChild(strongElem);
		strongElem.innerHTML = 'div #' + (i + 1);
		
		div.style.width = randomPixels(20, 100) + 'px';
		div.style.height = randomPixels(20, 100)  + 'px';
		div.style.backgroundColor = randomColors();
		div.style.color = randomColors();
		div.style.position = 'absolute';
		div.style.borderRadius = randomPixels(20, 100) + 'px';
		div.style.borderColor = randomColors();
		div.style.borderWidth = randomPixels(1, 20) + 'px';
		div.style.borderStyle = 'solid';		

		divFrag.appendChild(div);
	};
	
	headDiv.appendChild(divFrag);
}

createNumberOfDivElements();