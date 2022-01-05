window.onload = function () {
    let wwCheckBox = document.getElementById("ww");
    let twoFiveCheckBox = document.getElementById("25");
    let fourOCheckBox = document.getElementById("40");
    let sixOCheckBox = document.getElementById("60");
    let acqCheckBox = document.getElementById("acq");
    let ccaCheckBox = document.getElementById("cca");
    let onSubmit = document.getElementById("submit");
    wwCheckBox.onclick = disableCheckBoxes;
    twoFiveCheckBox.onclick = disableCheckBoxes;
    fourOCheckBox.onclick = disableCheckBoxes;
    sixOCheckBox.onclick = disableCheckBoxes;
    acqCheckBox.onclick = disableCheckBoxes;
    ccaCheckBox.onclick = disableCheckBoxes;
    onSubmit.onclick = validateCheckboxes;
}

function validateInput() {
    let isValid = true;

    let height = document.getElementById("height");
    let heightValue = height.value;
    if (heightValue.trim() == "") {
        isValid = false;
    }

    let width = document.getElementById("width");
    let widthValue = width.value;
    if (widthValue.trim() == "") {
        isValid = false;
    }

    let length = document.getElementById("length");
    let lengthValue = length.value;
    if (lengthValue.trim() == "") {
        isValid = false;
    }

    let boardfeet = document.getElementById("boardfeet");
    let boardfeetValue = boardfeet.value;
    if (boardfeetValue.trim() == "") {
        isValid = false;
    }

    return isValid;
}

/**
 * Checks to see which checkboxes are checked.
 **/
function validateCheckboxes() {
    let isValid = false;
    if ($("#ww").prop("checked")) {
        isValid = true;
    }
    else if ($("#25").prop("checked") && ($("#acq").prop("checked") || $("#cca").prop("checked"))) {
        isValid = true;
    }
    else if ($("#40").prop("checked") && ($("#acq").prop("checked") || $("#cca").prop("checked"))) {
        isValid = true;
    }
    else if ($("#60").prop("checked") && ($("#acq").prop("checked") || $("#cca").prop("checked"))) {
        isValid = true;
    }

    let validInput = validateInput();

    if (!isValid) {
        document.getElementById("checkbox-error").innerText = "Must select appropriate checkbox categories";
        $("#create").submit(function (e) {
            e.preventDefault();
        });
    }
    else if (validInput == true) {
        $("#create").unbind("submit").submit();
    }
}

/**
 * Disables incompatable type checkboxes.
 **/
function disableCheckBoxes() {
    if (this == document.getElementById("ww")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group2").prop("disabled", true);
            $("input.group3").prop("disabled", true);
            $("#acq").prop("checked", false);
            $("#cca").prop("checked", false);
        }
        else {
            $("input.group2").prop("disabled", false);
            $("input.group3").prop("disabled", false);
        }
    }
    else if (this == document.getElementById("25")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group1").prop("disabled", true);
            $("#40").prop("checked", false);
            $("#60").prop("checked", false);
        }
        else if ($("#acq").prop("checked") == false && $("#cca").prop("checked") == false) {
            $("input.group1").prop("disabled", false);
        }
    }
    else if (this == document.getElementById("40")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group1").prop("disabled", true);
            $("#25").prop("checked", false);
            $("#60").prop("checked", false);
        }
        else if ($("#acq").prop("checked") == false && $("#cca").prop("checked") == false) {
            $("input.group1").prop("disabled", false);
        }
    }
    else if (this == document.getElementById("60")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group1").prop("disabled", true);
            $("#25").prop("checked", false);
            $("#40").prop("checked", false);
        }
        else if ($("#acq").prop("checked") == false && $("#cca").prop("checked") == false) {
            $("input.group1").prop("disabled", false);
        }
    }
    else if (this == document.getElementById("acq")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group1").prop("disabled", true);
            $("#cca").prop("checked", false);
        }
        else if ($("#25").prop("checked") == false && $("#40").prop("checked") == false &&
                $("#60").prop("checked") == false) {
                $("input.group1").prop("disabled", false);    
        }
    }
    else if (this == document.getElementById("cca")) {
        if (this.checked) {
            document.getElementById("checkbox-error").innerText = "";
            $("input.group1").prop("disabled", true);
            $("#acq").prop("checked", false);
        }
        else if ($("#25").prop("checked") == false && $("#40").prop("checked") == false &&
            $("#60").prop("checked") == false) {
            $("input.group1").prop("disabled", false);
        }
    }
}