// Create a slider control using jQuery. The slider can have many slides. Only one slide is visible at a time. Each slide contains HTML code. i.e. it can contain images, forms, divs, headers, links, etc… Implement functionality for changing the visible slide after 5 seconds. Create buttons for next and previous slide.

window.onload = function sliderControl () {
	var count = 1;
	$('.current .title').html($('.current .image').attr('title'));
	
	function slideShow() {
		$('.current').next().addClass('current');
		$('.current').prev().removeClass('current');
		count+=1;
		$('.current .title').html($('.current .image').attr('title'));
		if (count > $('li').length) {
			count = 1;
			$('li').first().addClass('current');	
			$('li').last().removeClass('current');
		}	
	}

	$('#prev').click(function(e) {
		e.preventDefault();	
		$('.current').prev().addClass('current');
		$('.current').next().removeClass('current');
		count-=1;
		$('.current .title').html($('.current .image').attr('title'));
		if(count < 1) {
			count = $('li').length;
			$('li').last().addClass('current');
			$('li').first().removeClass('current');
		}
	});

	$('#next').click(function(e) {
		e.preventDefault();	
		slideShow();
	});

	function autoSlider() {
		slideShow();
		setTimeout(autoSlider, 1000);
	}

	setTimeout(autoSlider, 1000);
}

setTimeout(sliderControl, 1000);