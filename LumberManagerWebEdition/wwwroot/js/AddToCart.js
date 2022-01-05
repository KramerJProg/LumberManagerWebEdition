
window.onload = function () {
    let subtract = $(".subtract-button");
    let add = $(".add-button");
    let updateQuantityTotal = $(".update");
    add.on("click", addQuantity);
    subtract.on("click", subtractQuantity);
    updateQuantityTotal.on("click", updateQuantity)
    console.log(document.documentElement.scrollTop, document.documentElement.scrollLeft);
    window.scrollTo(0, yPos);
}

/**
 * Subtracts quantity by 1 product from cart.
 **/
function subtractQuantity() {
    console.log(this);
    console.log($(this).siblings());
    let input = $(this).siblings("#qty").val();
    let num = parseInt(input);
    let url = $(this).attr("href");
    num = num - 1;
    
    url = url.replace("temp", num);
    let y = document.documentElement.scrollTop;
    url = url.replace("tempY", y);
    $(this).attr("href", url);
}

/**
 * Adds quantity by 1 product from cart.
 **/
function addQuantity() {
    let input = $(this).siblings("#qty").val();
    let num = parseInt(input);
    let url = $(this).attr("href");
    num = num + 1;
    
    url = url.replace("temp", num);
    let y = document.documentElement.scrollTop;
    url = url.replace("tempY", y);
    $(this).attr("href", url);
}

function updateQuantity() {
    let input = $(this).siblings("#qty").val();
    let num = parseInt(input);
    let url = $(this).attr("formaction");
    
    url = url.replace("temp", num);
    let y = document.documentElement.scrollTop;
    url = url.replace("tempY", y);
    $(this).attr("formaction", url);
}