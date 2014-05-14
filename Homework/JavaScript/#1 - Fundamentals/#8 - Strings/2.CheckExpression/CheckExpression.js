// Write a JavaScript function to check if in a given expression the brackets are put correctly.

function checkExpression() {
    var expression = document.getElementById("exp").value,
        i,
        correct = 0;

    for (i = 0; i < expression.length; i +=1) {
        if (expression[i] === "(") {
            correct += 1;
        }
        else if (expression[i] === ")") {
            correct -= 1;
        }
    }

    if (correct === 0) {
        document.getElementById("result").innerHTML = "The Expressions: " + expression + " is Correct";
    }
    else {
        document.getElementById("result").innerHTML = "The Expressions: " + expression + " is not Correct";
    }
}