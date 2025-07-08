// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/salesHub")
    .build();

connection.on("ReceiveLargeSale", amount => {
    let paragraph = document.createElement("p");
    paragraph.textContent = amount;
    document.getElementById("largeSales").appendChild(paragraph);
});

connection.start();

document.getElementById("send").addEventListener("click", event => {
    let amount = document.getElementById("saleAmount").value;
    connection.invoke("PostNewSale", Number(amount));
    event.preventDefault();
});