// By an array of people find the most common first and last name. Use underscore.

(function($) {
	var Human, 
		people, 
		findPeopleByFirstName = [],		
		findPeopleByLastName = [], 
		i, 
		PeopleByFirstName,
		PeopleByLastName;
	
	Human = Object.create({
		init: function(firstName, lastName) {
			this.firstName = firstName;
			this.lastName = lastName;
			return this;
		},
		findPeoples: function() {
			return this.firstName + ' ' + this.lastName;
		}
	});
	
	function findMostCommonPeople(people) {
		var count = 1,
			maxSum = 1,
			name,
			len;
			
		for(i = 0, len = people.length; i < len; i+=1) {
			if (people[i] === people[i - 1]) {
				count += 1;
			}
			else if (people[i] !== people[i - 1]) {
				count = 1;
			}
			
			if (count > maxSum) {
				maxSum = count;
				name = people[i];
			}
		}
		
		return name + ' ' + maxSum;
	}
	
	people = [
		Object.create(Human).init('Gergana', 'Dimitrova'),
		Object.create(Human).init('Ivan', 'Ivanov'),
		Object.create(Human).init('Mihaela', 'Zlatkova'),
		Object.create(Human).init('Veselina', 'Nikolova'),
		Object.create(Human).init('Georgi', 'Stoyanov'),
		Object.create(Human).init('Blagoy', 'Iliev'),
		Object.create(Human).init('Daniela', 'Zlatkova'),
		Object.create(Human).init('Gergana', 'Georgieva'),
		Object.create(Human).init('Stoyan', 'Mihaylov'),
		Object.create(Human).init('Veselin', 'Petrov'),
		Object.create(Human).init('Daniela', 'Iliev'),
		Object.create(Human).init('Georgi', 'Iliev'),
		Object.create(Human).init('Milena', 'Simeonova'),
		Object.create(Human).init('Gergana', 'Simeonova'),
		Object.create(Human).init('Veselina', 'Petrova'),
	];
	
	PeopleByFirstName = _.sortBy(people, 'firstName');
	
	for(i in PeopleByFirstName) {
		findPeopleByFirstName.push(PeopleByFirstName[i].firstName); 
	}
	
	console.log('The most common first name is: ' + findMostCommonPeople(findPeopleByFirstName));
	
	PeopleByLastName = _.sortBy(people, 'lastName');
	
	for(i in PeopleByLastName) {
		findPeopleByLastName.push(PeopleByLastName[i].lastName); 
	}
	
	console.log('The most common last name is: ' + findMostCommonPeople(findPeopleByLastName));
}(jQuery));