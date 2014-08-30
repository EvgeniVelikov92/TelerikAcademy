// Write a function that by a given array of animals, groups them by species and sorts them by number of legs

(function($) {
    var Animal, animals, sortAnimal, i, groupAnimalBy;

    Animal = Object.create({
        init: function(name, breed, legs) {
            this.name = name;
            this.breed = breed;
            this.legs = legs;
            return this;
        },
        animalProfile: function() {
            return this.name + ' ' + this.breed + ' ' + this.legs;
        }
    });

    animals = [
        Object.create(Animal).init('Shailo', 'Dog', 4),
        Object.create(Animal).init('Kity', 'Cat', 4),
        Object.create(Animal).init('Barny', 'Snake', 0),
        Object.create(Animal).init('Filipo', 'Dog', 4),
        Object.create(Animal).init('Bony', 'Cat', 4),
        Object.create(Animal).init('Shilo', 'Monkey', 2),
        Object.create(Animal).init('Freddy', 'Caterpillar', 16),
        Object.create(Animal).init('Francys', 'Fish', 0),
        Object.create(Animal).init('Vital', 'Dog', 4),
        Object.create(Animal).init('Bong', 'Spider', 8)
    ];

    sortAnimal = _.sortBy(animals, 'legs');
    sortAnimal.reverse();
    console.log('----------------------Sort Animals by Legs----------------------')
    for(i in sortAnimal) {
        console.log('The Animal: ' + sortAnimal[i].name + ' is ' + sortAnimal[i].breed + ' ' + sortAnimal[i].legs);
    }

    groupAnimalBy = _.groupBy(animals, 'breed');
    console.log('----------------------Group Animals by ...----------------------')
    console.log(groupAnimalBy);
}(jQuery))