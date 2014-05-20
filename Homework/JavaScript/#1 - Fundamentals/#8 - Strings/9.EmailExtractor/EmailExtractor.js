// Write a function for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails. Return the emails as array of strings.

var mail = "baj.ivan@yahoo.co.uk";

function emailExtract(email) {
    var valid = email.match(/([\w-\.]+@[\w]+\.?[a-zA-Z]{2,4}\.[a-zA-Z]{2,4})/g);

    return valid;
}

emailExtract(mail);