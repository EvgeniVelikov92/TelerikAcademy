// Create a text area and two inputs with type="color". Make the font color of the text area as the value of the first color input. Make the background color of the text area as the value of the second input.

function changeColor(selector) {
	var color = document.getElementById(selector),
		textarea = document.getElementsByTagName('textarea')[0];

	if (selector === 'font-color') {
		color.addEventListener('change', function(ev){
			textarea.style.color = color.value;
		});
	} 
	else if (selector === 'bg-color') {
		color.addEventListener('change', function(ev){
			textarea.style.backgroundColor = color.value;
		});
	}; 
}

changeColor('font-color');

changeColor('bg-color');