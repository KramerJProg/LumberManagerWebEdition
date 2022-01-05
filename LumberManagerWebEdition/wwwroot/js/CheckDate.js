
window.onload = function () {
    let submit = document.getElementById("submit");
    submit.onclick = validateDate;

    instance = new dtsel.DTS('input[name="dateTimePicker"]', {
        showTime: false,
        showDate: true,
        dateFormat: "mm/dd/yyyy",
        direction: 'BOTTOM',
        paddingX: 5,
        paddingY: 5
    });
}

function validateDate() {
    let inputDate = document.getElementById("date").value;

    let regexp = /^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d/g;

    let isValid = regexp.test(inputDate);

    if (isValid) {
        let url = $(this).attr("formaction");
        url = url.replace("temp", inputDate);
        $(this).attr("formaction", url);

        $("#form").unbind("submit").submit();
    }
    else {
        document.getElementById("error").innerHTML = "Enter a valid date. ie 07/08/2021"
        $("form").submit(function (e) {
            e.preventDefault();
        });
    }
}