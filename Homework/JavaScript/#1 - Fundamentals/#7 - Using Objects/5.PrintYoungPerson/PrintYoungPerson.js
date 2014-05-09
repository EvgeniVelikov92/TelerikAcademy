// Write a function that finds the youngest person in a given array of persons and prints his/hers full name. Each person have properties firstname, lastname and age, as shown

var person = [
    {
        firstName: "Gosho",
        lastName: "Petrov",
        age: 32,
    },
    {
        firstName: "Bay",
        lastName: "Ivan",
        age: 81,
    },
    {
        firstName: "Georgi",
        lastName: "Georgiev",
        age: 25,
    },
    {
        firstName: "Plamen",
        lastName: "Plamenov",
        age: 38,
    },
    {
        firstName: "Ivan",
        lastName: "Ivanov",
        age: 30,
    }
];
var i;
var bestYounger = 1000;
var bestYoungerPerson = 0;

console.log("---------------------------------------");

for (i in person) {
    if (person[i].age < bestYounger) {
        bestYounger = person[i].age;
        bestYoungerPerson = person[i];
    }
    console.log(person[i]);
}

console.log("---------------------------------------");

console.log("First name: " + bestYoungerPerson.firstName + "\nLast name: " + bestYoungerPerson.lastName + "\nAge: " + bestYoungerPerson.age);