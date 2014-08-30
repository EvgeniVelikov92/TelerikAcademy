// Create a TODO list with the following UI controls. Form input for new Item. Button for adding the new Item. Button for deleting some item. Show and Hide Button

var content = document.getElementById('content'),
	addContent = document.getElementById('add-new-item'),
	deleteContent = document.getElementById('delete-some-item'),
	showContent = document.getElementById('show-btn'),
	hideContent = document.getElementById('hide-btn');

addContent.addEventListener('click', function(e) {
	var lessContent = document.createElement('div');
	lessContent.className = 'container';
	lessContent.innerHTML = content.value;
	document.body.appendChild(lessContent);
});

deleteContent.addEventListener('click', function(e) {
	var divContent = document.getElementsByTagName('div');

	for (var item = 0, len = divContent.length; item < len; item+=1) {
		divContent[item / 2].remove();
	}
});

showContent.addEventListener('click', function(e) {
	var newBtn = document.createElement('button');
	newBtn.className = 'other-btn';
	newBtn.innerHTML = 'New Button';
	document.body.appendChild(newBtn);
});

hideContent.addEventListener('click', function(e) {
	var btnContent = document.getElementsByTagName('button');

	for (var item = 0, len = divContent.length; item < len; item+=1) {
		btnContent[item / 2].remove();
	}
});