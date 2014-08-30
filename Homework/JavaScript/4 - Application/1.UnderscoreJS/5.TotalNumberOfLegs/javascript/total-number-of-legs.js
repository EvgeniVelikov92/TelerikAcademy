// By a given array of animals, find the total number of legs. Each animal can have 2, 4, 6, 8 or 100 legs

(function($) {
	var Animal, 
		animals, 
		i, 
		sum = 0;
	
	Animal = Object.create({
		init: function(animal, legs) {
			this.animal = animal;
			this.legs = legs;
			return this;
		},
		totalNumberOfLegs: function() {
			return this.animal + ' ' + this.legs;
		}
	});
	
	animals = [
		Object.create(Animal).init('Dog', 4),
        Object.create(Animal).init('Cat', 4),
        Object.create(Animal).init('Snake', 0),
        Object.create(Animal).init('Bear', 4),
        Object.create(Animal).init('Wolve', 4),
        Object.create(Animal).init('Monkey', 2),
        Object.create(Animal).init('Caterpillar', 16),
        Object.create(Animal).init('Fish', 0),
        Object.create(Animal).init('lion', 4),
        Object.create(Animal).init('Spider', 8)
	];
	
	console.log('----------------All animals in this script!----------------');
	for(i in animals) {
		console.log(animals[i].animal + ' ' + animals[i].legs);
		sum += animals[i].legs;
	}
	console.log(' ');
	console.log('Total number of legs in this animals is: ' + sum);
}(jQuery))