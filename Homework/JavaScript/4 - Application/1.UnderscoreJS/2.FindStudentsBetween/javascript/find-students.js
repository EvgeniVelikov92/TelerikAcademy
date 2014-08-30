// Write function that finds the first name and last name of all students with age between 18 and 24. Use Underscore.js

(function() {
    var Student, students, findsStuden, i;

    Student = Object.create({
        init: function (firstName, lastName, age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            return this;
        },
        findStudents: function() {
            return 'Name: ' + this.firstName + ' ' + this.lastName + ' ' + this.age;
        }
    });

    students = [
        Object.create(Student).init('Gergana', 'Dimitrova', 26),
        Object.create(Student).init('Ivan', 'Ivanov', 23),
        Object.create(Student).init('Mihaela', 'Zlatkova', 21),
        Object.create(Student).init('Veselina', 'Nikolova', 25),
        Object.create(Student).init('Georgi', 'Stoyanov', 25),
        Object.create(Student).init('Blagoy', 'Iliev', 18),
        Object.create(Student).init('Stoyan', 'Mihaylov', 22),
        Object.create(Student).init('Veselin', 'Petrov', 29),
        Object.create(Student).init('Daniela', 'Georgieva', 18),
		Object.create(Student).init('Milena', 'Simeonova', 22)
    ];
	
	function findStudentBetween(age) {
		findsStudent = _.where(students, {
		   age: age
		})

		for(i in findsStudent) {
			console.log('Name: ' + findsStudent[i].firstName + ' ' + findsStudent[i].lastName + ' ' + 'Age: ' + findsStudent[i].age);
		}
	}
	
	findStudentBetween(18);
	findStudentBetween(19);
	findStudentBetween(20);
	findStudentBetween(21);
	findStudentBetween(22);
	findStudentBetween(23);
	findStudentBetween(24);
}())