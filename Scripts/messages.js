(function () {
	//toastr options
	toastr.options = {
  	'showDuration': '10000',
  	'hideDuration': '1000',
  	'timeOut': '8000',
  	'closeButton': true,
  	'progressBar': true,
  	'positionClass': 'toast-bottom-center'
	};
	
	//First, we will hide the messages, you can do it with CSS, but in this example, I will use only JavaScript.
	$('#messages .message').css('display', 'none');
	
	var messageElement;
	$('#messages .message').each(function () {
		messageElement = $(this);
		if(messageElement.hasClass('message-Information')){
			toastr.success(messageElement.html());
		} else if (messageElement.hasClass('message-Success')) {
		    toastr.success(messageElement.html());
		} else if (messageElement.hasClass('message-Warning')) {
			toastr.warning(messageElement.html());
		} else if(messageElement.hasClass('message-Error')){
			toastr.error(messageElement.html());
		}
	});
} ());
