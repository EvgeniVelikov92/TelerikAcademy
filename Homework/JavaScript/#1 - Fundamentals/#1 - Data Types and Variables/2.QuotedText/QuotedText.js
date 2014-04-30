// Create a string variable with quoted text in it. For example: "How you doin'?", Joey said.

function QuotedText() {
    var name = document.getElementById("name").value;
    var question = document.getElementById("question").value;

    document.getElementById("result").value = "\"" + question + "?\" " + name + " said.";
}