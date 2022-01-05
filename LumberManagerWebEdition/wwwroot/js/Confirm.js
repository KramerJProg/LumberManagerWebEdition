
window.onload = function() {
    let onSubmit = document.getElementById("submit");
    onSubmit.onclick = validateEntries;
}

function validateEntries() {
    let isValid = true;

    let firstName = document.getElementById("firstName").value;
    let lastName = document.getElementById("lastName").value;
    let address = document.getElementById("address").value;
    let city = document.getElementById("city").value;
    let state = document.getElementById("state").value;
    let zipCode = document.getElementById("zipCode").value;

    if (firstName.trim() == "") {
        isValid = false;
        document.getElementById("firstNameError").innerHTML = "First name is required.";
    }
    else {
        document.getElementById("firstNameError").innerHTML = "";
    }

    if (lastName.trim() == "") {
        isValid = false;
        document.getElementById("lastNameError").innerHTML = "Last name is required.";
    }
    else {
        document.getElementById("lastNameError").innerHTML = "";
    }

    if (address.trim() == "") {
        isValid = false;
        document.getElementById("addressError").innerHTML = "Address is required.";
    }
    else {
        document.getElementById("addressError").innerHTML = "";
    }

    if (city.trim() == "") {
        isValid = false;
        document.getElementById("cityError").innerHTML = "City is required.";
    }
    else {
        document.getElementById("cityError").innerHTML = "";
    }

    if (state.trim() == "") {
        isValid = false;
        document.getElementById("stateError").innerHTML = "State is required.";
    }
    else {
        document.getElementById("stateError").innerHTML = "";
    }

    if (zipCode.trim() == "") {
        isValid = false;
        document.getElementById("zipCodeError").innerHTML = "Zip code is required.";
    }
    else {
        document.getElementById("zipCodeError").innerHTML = "";
    }

    if (!isValid) {
        $("#confirm").submit(function (e) {
            e.preventDefault();
        });
    }

    else {
        $("#confirm").unbind("submit").submit();
    }
}