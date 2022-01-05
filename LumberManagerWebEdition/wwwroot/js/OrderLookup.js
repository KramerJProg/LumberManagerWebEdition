window.onload = function () {
    let button = document.getElementById("order-button");
    button.onclick = getOrderNumber;
}

function getOrderNumber() {
    let input = $(this).siblings("#order").val();
    let num = parseInt(input);
    let url = $(this).attr("href");
    url = url.replace("temp", num);
    $(this).attr("href", url);
}