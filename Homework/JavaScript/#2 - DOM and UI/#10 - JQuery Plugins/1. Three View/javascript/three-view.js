$(function() {
	$.fn.threeView = function() {
		this.each(function() {
			$('.menu div:has(div)').addClass('parent');
			
			$('.menu div').click(function() {
				var menu = $(this);
				menu.children('div').toggle();
				menu.filter('.parent').toggleClass('expanded');
				return false;
			});
		});		
		return this;
	}
});

$(document).ready(function() {
	$('.menu').threeView();
})