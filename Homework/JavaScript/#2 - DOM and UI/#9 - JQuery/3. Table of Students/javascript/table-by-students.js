(function() {
	var $firstName = $('#first-name'),
		$lastName = $('#last-name'),
		$grade = $('#grade');

	function createTableByStudents(first, last, grade) {
		var students = {
			firstName: first,
			lastName: last,
			grade: grade
		};
		var table = $('<table />'),
			headRow = $('<tr />'),
			firstNameHeading = $('<th />').html('First Name'),
			lastNameHeading = $('<th />').html('Last Name'),
			gradeHeading = $('<th />').html('Grade');

		headRow.append(firstNameHeading);
		headRow.append(lastNameHeading);
		headRow.append(gradeHeading);
		table.append(headRow);

		$('#submit').on('click', function() {
			var rows = $('<tr />'),
				firstNameColumns = $('<td />').html(students.firstName.val()),
				lastNameColumns = $('<td />').html(students.lastName.val()),
				gradeColumns = $('<td />').html(students.grade.val());

			rows.append(firstNameColumns);
			rows.append(lastNameColumns);
			rows.append(gradeColumns);
			table.append(rows);
		});

		$('#wrapper').append(table);		
	}

	createTableByStudents($firstName, $lastName, $grade);
})()