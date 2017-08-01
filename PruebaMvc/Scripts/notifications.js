var notificationType = { Success: 'success', Error: 'error', Confirm: 'confirm' };


function showConfirmNotification(message, yesCallback, noCallback) {

	hideNotificationMessage();

	var messageParagraph = $('<p class="notificationsConf" />').text(message);

	var notificationContainer = $("<div id='notificationMessage' data-content='notifications' class='confirm' />"),
		btnYes = $("<a class='btnYes'>Ok</a>"),
		curtain = $("<div class='wht-curtain'></div>"),
		btnNo = $("<a class='btnNo'>Cancel</a>");

	$(notificationContainer).prepend(btnNo);
	$(notificationContainer).prepend(btnYes);
	$(notificationContainer).prepend(messageParagraph);


	var parent = $("#notificationContent");
	$(parent).prepend(curtain);

	parent.prepend(notificationContainer);
	$('.btnYes').click(function () {
		yesCallback();
		$(this).parent().remove();
		$(".wht-curtain").remove();
	});

	$('.btnNo').click(function () {
		if (noCallback != undefined) {
			noCallback();
		}

		$(this).parent().remove();
		$(".wht-curtain").remove();
	});
}

function showNotification(notification) {
	var className = notification.NotificationType;

	var closeBtn = $('<span class="closeGrl close-btn">x</span>');

	var messageParagraph;

	if (notification.isHtmlContent) {
		messageParagraph = $('<p class="infoAlertCnt" />').html(notification.Message);
	}
	else {
		messageParagraph = $('<p class="infoAlertCnt" />').text(notification.Message);
	}

	var notificationId = 'notification_' + guid();

	var notificationContainer = $("<div id='notificationMessage' data-content='notifications' data-notificationid='" + notificationId + "' />").addClass(className);
	$(notificationContainer).prepend(closeBtn);
	$(notificationContainer).prepend(messageParagraph);

	var parent = $("#notificationContent");

	parent.prepend(notificationContainer);

	$(closeBtn).click(function () {
		$(this).parent().remove();
	});

	if (notification.AutoHide) {
		var duration = notification.NotificationDuration == undefined ? 5 : notification.NotificationDuration;
		console.log(duration);
		console.log(notificationId);
		autoHideNotificationMessage(duration, notificationId);
	}
}


function showSuccessNotification(message, autohide, isHtmlContent, notificationDuration) {
	var notification = { NotificationType: notificationType.Success, Message: message, AutoHide: autohide == undefined ? true : autohide, isHtmlContent: isHtmlContent, NotificationDuration: notificationDuration };
	showNotification(notification);
}

function showErrorNotification(message, autohide, isHtmlContent, notificationDuration) {

	var notification = { NotificationType: notificationType.Error, Message: message, AutoHide: autohide == undefined ? true : autohide, isHtmlContent: isHtmlContent, NotificationDuration: notificationDuration };
	showNotification(notification);
}

//function showConfirmNotification(message) {
//    var notification = { NotificationType: notificationType.Confirm, Message: message };
//    showNotification(notification);
//}

//function autoHideNotificationMessage(duration, notificationId)
//{
//    console.log("onNotificatin");
//    var notificationElement = $('[data-notificationid="' + notificationId + '"]');
//    setTimeout(function () {
//        $(notificationElement).remove()
//    }, (seconds * 1000));

//}

function autoHideNotificationMessage(seconds, notificationId) {
	console.log("AutoHiude");

	var functionToInvoke = hideNotificationMessage;

	if (notificationId != undefined) {
		var notificationElement = $('[data-notificationid="' + notificationId + '"]');

		functionToInvoke = function () {
			$(notificationElement).remove()
		};
	}

	setTimeout(functionToInvoke, (seconds * 1000));
}

function hideNotificationMessage() {
	$("#notificationMessage").remove();
}
