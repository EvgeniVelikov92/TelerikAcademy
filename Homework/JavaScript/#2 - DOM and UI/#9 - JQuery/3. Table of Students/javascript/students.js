// By given an array of students, generate a table that represents these students. Each student has first name, last name and grade.

var students = [{
    firstName: 'Peter',
    lastName: 'Ivanov',
    grade: 3,
}, {
    firstName: 'Milena',
    lastName: 'Grigorova',
    grade: 6,
}, {
    firstName: 'Gergana',
    lastName: 'Borisova',
    grade: 12,
}, {
    firstName: 'Boyko',
    lastName: 'Petrov',
    grade: 7,
}];

function createTableByStudents(student) {
	var table = $('<table />');
	var rows = $('<tr />');
	var firstNameHeading = $('<th />').text('First Name');
	var lastNameHeading = $('<th />').text('Last Name');
	var gradeHeading = $('<th />').text('Grade');

	rows.append(firstNameHeading);
	rows.append(lastNameHeading);
	rows.append(gradeHeading);
	table.append(rows);

	for (var i = 0, len = student.length; i < len; i+=1) {
		var currentRow = $('<tr />');
		var firstNameCol = $('<td />').text(student[i].firstName);
		var lastNameCol = $('<td />').text(student[i].lastName);
		var gradeCol = $('<td />').text(student[i].grade);

		currentRow.append(firstNameCol);
		currentRow.append(lastNameCol);
		currentRow.append(gradeCol);

		table.append(currentRow);
	}

	$('body').append(table);
};

createTableByStudents(students);