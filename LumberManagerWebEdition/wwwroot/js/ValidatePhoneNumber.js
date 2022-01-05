window.onload = function () {
    let submit = document.getElementById("submit-button");
    submit.onclick = verifyPhoneNumber;
}

function verifyPhoneNumber() {
    let phone = document.getElementById("phone");
    let phoneNumber = phone.value;

    let regex = /^(\+\d{1, 2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}/;

    let isValid = regex.test(phoneNumber);

    if (phoneNumber.trim() == "") {
        return;
    }

    if (isValid) {
        $("#form").unbind("submit").submit();
    }
    else {
        $("#form").submit(function (e) {
            e.preventDefault();
        });
        document.getElementById("phone-span").innerText = "Incorrect Format, ie 253 555 6556 or 253-555-6556";
    }
}