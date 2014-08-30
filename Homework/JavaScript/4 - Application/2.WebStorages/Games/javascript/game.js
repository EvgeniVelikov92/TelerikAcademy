(function($) {

	var x = $('#x'),
		y = $('#y'),
		z = $('#z'),
		w = $('#w'),
		a = $('#a'),
		b = $('#b'),
		c = $('#c'),
		d = $('#d'),
		countRam = 0;

	function loadPairs() {

	    if (!localStorage.length || localStorage.length === 0) {
	        document.getElementById('user').innerHTML('Username: ');
	        document.getElementById('rams').innerHTML('Rams: ');
	        return;
	    }

	    var resultHTML = $('<ul/>');
	    var listItem = $('<li/>');

	    var resultHTML = "<ul>";
	    for (var i = 0; i < localStorage.length; i++) {
	        var key = localStorage.key(i);
	        resultHTML +=
            '<li>' +
            '{<strong>key</strong>: "' + key + '", <br/><strong>value</strong>: "' + localStorage.getItem(key) + '"}' +
            '</li>';
	    }
	    resultHTML += "</ul>";
	    document.getElementById("pairs-container").innerHTML = resultHTML;
	}

	$('#registration-btn').on('click', function (e) {
	    var key = document.getElementById("tb-key").value;
	    var value = document.getElementById("value-text").value;
	    localStorage.setItem(key, value);
	    loadPairs();
	})

	$('#login-btn').on('click', function (e) {
	    var key = document.getElementById("tb-key").value;
	    document.getElementById("value-text").value = localStorage.getItem(key);
	})

	$('#submit').on('click', function (e) {
		e.preventDefault();
		
		a.html(Math.floor(Math.random() * 9) + 1);
		b.html(Math.floor(Math.random() * 9));
		c.html(Math.floor(Math.random() * 9));
		d.html(Math.floor(Math.random() * 9));
		
		// Check first digit of all random number
		if(x.val() === a.html()) {
			countRam+=1;
		}
		
		// Check second digit of all random number
		if(y.val() === b.html()) {
			countRam+=1;
		}
		
		// Check third digit of all random number	
		if(z.val() === c.html()) {
			countRam+=1;
		}
		
		// Check fourth digit of all random number
		if(w.val() === d.html()) {
			countRam+=1;
		}
		
		$('#result').html('Ram = ' + countRam);
		
		if(countRam >= 4) {
			$('#submit').attr('disabled', 'disabled');
			$('#result').html('Ram = ' + countRam + '<br/>' + 'Congratilation you Win a game ');
		}
	});
}(jQuery))