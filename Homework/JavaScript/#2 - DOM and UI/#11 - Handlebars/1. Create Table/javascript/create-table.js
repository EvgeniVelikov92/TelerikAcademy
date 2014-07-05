// Create the following using Handlebars.js

function createTable() {
	var templateNode = document.getElementById('table-template');
	var templateString = templateNode.innerHTML;

	var template = Handlebars.compile(templateString);

	var rows = [
		{
			number: '№',
			title: 'Title',
			dataOne: 'Date №1',
			dataTwo: 'Date №2'
		},
		{
			number: '0',
			title: 'Course Information',
			dataOne: 'Wed 18:00 28-May-2014',
			dataTwo: 'Thu 14:00 29-May-2014',
		}
	];

	var tableHTML = template({
		rows: rows
	});

	document.body.innerHTML += template({
		rows: rows
	});
};

createTable();




// var templateNode = document.getElementById('articles-template');
// var templateString = templateNode.innerHTML;

// var template = Handlebars.compile(templateString);

// var articles = [
// {
// 	title: 'Article title #1',
// 	content: 'One Lorem ipsum <strong>dolor</strong> sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
// 	id: 1,
// 	postDate: '29.06.2014'
// },
// {
// 	title: 'Article title #2',
// 	content: 'Two Lorem ipsum <strong>dolor</strong> sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
// 	id: 2
// },
// {
// 	title: 'Article title #3',
// 	content: 'Three Lorem ipsum <strong>dolor</strong> sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
// 	id: 3,
// 	postDate: '19.06.2014'
// }
// ];

// var articleHTML = template({
// 	articles: []
// });
// console.log(articleHTML);
// document.body.innerHTML += articleHTML;



