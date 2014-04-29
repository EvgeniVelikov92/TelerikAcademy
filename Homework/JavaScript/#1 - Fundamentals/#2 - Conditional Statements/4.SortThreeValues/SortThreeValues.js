// Sort 3 real values in descending order using nested if statements.

function SortThreeValues() {
    var first = parseFloat(document.getElementById("first").value);
    var second = parseFloat(document.getElementById("second").value);
    var third = parseFloat(document.getElementById("third").value);
    var bigger = 0;
    var i = 0;

    for (i = 0; i < 2; i++) {
        if (first < second) {
            bigger = second;
            second = first;
            first = bigger;
            if (first < third) {
                bigger = third;
                third = first;
                first = bigger;
            }
        }
        else {
            if (second < third) {
                bigger = third;
                third = second;
                second = bigger;
            }
        }
    }

    document.getElementById("result").value = first + "; " + second + "; " + third;
}