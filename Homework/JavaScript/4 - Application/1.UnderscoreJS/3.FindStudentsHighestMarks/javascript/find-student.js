// Write a function that by a given array of students finds the student with highest marks

(function($) {
	var Student, students, studentProfile, i, bestStudent, bestStudentProfile;
	
	function calculateAverageMarks(marks) {
		var len, 
			sum = 0, 
			average = 0;
		
		for(i = 0, len = marks.length; i < len; i+=1) {
			sum += marks[i];
		}
		
		average = (sum / marks.length).toFixed(2);
		
		return average;
	}
	
	Student = Object.create({
		init: function(firstName, lastName, marks) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.marks = marks;
			this.averageMark = calculateAverageMarks(this.marks);
			return this;
		},
		studentMarks: function() {
			return this.firstName + ' ' + this.lastName + ' ' + this.averageMark;
		}
	});
	
	students = [
		Object.create(Student).init('Gergana', 'Dimitrova', [4, 6, 3, 4, 5, 5]),
		Object.create(Student).init('Ivan', 'Ivanov', [3, 5, 5, 4, 5, 6]),
		Object.create(Student).init('Mihaela', 'Zlatkova', [3, 5 ,3, 3, 2, 6]),
		Object.create(Student).init('Veselina', 'Nikolova', [4, 4, 4, 3, 5, 6]),
		Object.create(Student).init('Georgi', 'Stoyanov', [3, 3, 4, 6, 5, 6]),
		Object.create(Student).init('Blagoy', 'Iliev', [4, 4, 6, 4, 3, 4]),
		Object.create(Student).init('Stoyan', 'Mihaylov', [2, 2, 3, 6, 5, 2]),
		Object.create(Student).init('Veselin', 'Petrov', [3, 4, 3, 2, 5, 5]),
		Object.create(Student).init('Daniela', 'Georgieva', [3, 5, 5, 5, 4, 6]),
		Object.create(Student).init('Milena', 'Simeonova', [4, 6, 6, 5, 5, 3])
	];
	
	console.log('---------------------------All students and then marks--------------------');
	for(i in students) {
		studentProfile = 'Name: ' + students[i].firstName + ' ' + students[i].lastName + ' Marks: [' + students[i].marks + '] = Average Mark: ' + students[i].averageMark;
		
		console.log(studentProfile);
	}
	
	console.log('');
	
	console.log('---------------------------The student with highest marks--------------------');
	bestStudent = _.sortBy(students, 'averageMark');
	
	for(i in bestStudent) {
		bestStudentProfile = 'Name: ' + bestStudent[i].firstName + ' ' + bestStudent[i].lastName + ' Marks: [' + bestStudent[i].marks + '] Average Mark: ' + bestStudent[i].averageMark;	
	}
	
	console.log(bestStudentProfile);
}(jQuery));