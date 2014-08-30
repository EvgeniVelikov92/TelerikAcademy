// Write a function that checks if a given object contains a given property

function hasProperty(obj, prop) {
    var property;

    for (property in obj) {
        if (property == prop) {
            return obj[property] + " = " + prop;
        }
    }

    return "Property is not in the object";
}

console.log(hasProperty(document, "getElementById"));