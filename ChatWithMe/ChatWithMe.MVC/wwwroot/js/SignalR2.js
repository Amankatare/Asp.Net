"use strict";
/*
var userElement = document.getElementById("userInput");
var messageElement = document.getElementById("messageInput");

var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

connection.on("ReceiveMessage", function (user, message, time) {
    var msg = message;

    var encodedMsg = "[" + time + "] " + user + ": " + msg;
    var li = document.createElement("li");

    li.textContent = encodedMsg;
    document.getElementById("MessagesList").appendChild(li).innerText(encodedMsg);
});


connection.start().then(function () {
    document.getElementById("SendButton").disabled = false; // 'disabled' not 'disable'
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("SendButton").addEventListener("click", function (event) {

    var userElement = document.getElementById("userInput");
    var messageElement = document.getElementById("messageInput");


    if (userElement && messageElement) {
        var user = userElement.value;
        var message = messageElement.value;

        connection.invoke("SendMessage", user, message).catch(function (err) {
            return console.error(err.toString());
        });
    }

    event.preventDefault();
    
});

function escapeHtml(text) {
    var div = document.createElement("div");
    div.textContent = text;
    return div.innerHTML;
}

*/
var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

connection.start().catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("SendButton").addEventListener("click", function (event) {

    var userElement = document.getElementById("userInput");
    var messageElement = document.getElementById("messageInput");


    if (userElement && messageElement) {
        var user = userElement.value;
        var message = messageElement.value;

        connection.invoke("SendMessage", user, message).catch(function (err) {
            return console.error(err.toString());
        });
    }

    event.preventDefault();

});

connection.on("ReceiveMessage", function (user, message, time) {

    var encodedMsg = "[" + time + "] " + user + ": " + message;
    var li = document.createElement("li");

    li.textContent = encodedMsg;
    document.getElementById("MessagesList").appendChild(li).innerText(encodedMsg);

    escapeHtml(encodedMsg);
});

function escapeHtml(text) {
    var div = document.createElement("div");
    div.textContent = text;
    return div.innerHTML;
}