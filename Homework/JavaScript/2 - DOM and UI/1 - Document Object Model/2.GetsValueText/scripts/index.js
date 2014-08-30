// Create a function that gets the value of <input type="text"> ands prints its value to the console

function getsValueText(){
    var txt = document.getElementsByTagName('input')[0];

    console.log("The value is: " + txt.value);
}