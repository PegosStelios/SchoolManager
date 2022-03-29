function validateForm() {
    var profPic = document.getElementById("profilePic");
    var name = document.getElementById("name");
    var tel = document.getElementById("tel");
    var gender = document.getElementById("gender");
    var email = document.getElementById("email");

    clear();

    var valid = true;

    if (profPic.value.length == 0) {
        profPic.nextElementSibling.classList.add("toggle");
        profPic.nextElementSibling.innerHTML =
            "Choose a profile picture to continue";
        valid = false;
    }
    if (name.value.length == 0) {
        name.classList.add("invalid");
        name.nextElementSibling.classList.add("toggle");
        name.nextElementSibling.innerHTML = "This field is required.";
        valid = false;
        name.focus();
    }
    if (tel.value.length == 0) {
        tel.classList.add("invalid");
        tel.nextElementSibling.classList.add("toggle");
        tel.nextElementSibling.innerHTML = "This field is required.";
        valid = false;
        tel.focus();
    }
    if (gender.value.length == 0) {
        gender.classList.add("invalid");
        gender.nextElementSibling.classList.add("toggle");
        gender.nextElementSibling.innerHTML = "This field is required.";
        valid = false;
        gender.focus();
    } else if (!checkEmail(email.value)) {
        email.classList.add("invalid");
        email.nextElementSibling.classList.add("toggle");
        email.nextElementSibling.innerHTML = "Input a valid email.";
        valid = false;
        email.focus();
    }
    return valid;
}

function clear() {
    var inputs = document.querySelectorAll(".in-field");

    [].forEach.call(inputs, function(field) {
        field.classList.remove("invalid");
        field.nextElementSibling.classList.remove("toggle");
        field.nextElementSibling.innerHTML = "";
    });
}

function closeError() {
    var msg;
    msg = document.getElementById("message");
    msg.classList.remove("warning");
    msg.classList.remove("error");
    msg.classList.remove("success");
}

function searchFunction() {
    var input, filter, ul, li, a, i;
    input = document.getElementById("searchField");
    filter = input.value.toUpperCase();
    ul = document.getElementById("recordList");
    li = ul.getElementsByClassName("user");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByClassName("item")[0];
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}