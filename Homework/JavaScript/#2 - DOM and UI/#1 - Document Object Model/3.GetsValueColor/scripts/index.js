// Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value

function getValueColor(){
    color = document.getElementsByTagName('input')[0];
    document.body.style.backgroundColor = color.value;
}