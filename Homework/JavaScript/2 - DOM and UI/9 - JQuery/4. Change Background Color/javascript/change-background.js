// Implement functionality to change the background color of a web page. i.e. select a color from a color picker and set this color as the background color of the page

$('#change-background-color').change(function () {
	var bgColor = $('#change-background-color').val();
	$('body').css('background', bgColor);
});