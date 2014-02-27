/*
 * Get the subscription form
 */
function getCreateAcountForm() {
    $.ajax({
        type: "POST",
        url: "Controllers/controller.User.php",
        data: {locate: "GetCreateAcountForm"}
    })
            .done(function(msg) {
        $("#loginsubscribefroms").html(msg);
    });

}


/*
 * Get The login from
 */
function getLoginForm() {
    $.ajax({
        type: "POST",
        url: "Controllers/controller.User.php",
        data: {locate: "GetLoginForm"}
    })
            .done(function(msg) {
        $("#loginsubscribefroms").html(msg);
    });

}

/*
 * Get The login from
 */
function loginUser() {
    var email,
            password;
    email = $("#inputEmail3").val();
    password = $("#inputPassword3").val();
    $.ajax({
        type: "POST",
        url: "Controllers/controller.User.php",
        data: {locate: 'UserLogin', email: email, password: password}
    })
            .done(function(msg) {
        if (msg === '') {
            noty({
                layout: 'bottom',
                type: 'alert',
                text: 'Your Email or your Password are wrong!',
                dismissQueue: true,
                animation: {
                    open: {height: 'toggle'},
                    close: {height: 'toggle'},
                    easing: 'swing',
                    speed: 500
                },
                timeout: 4000
            });
            return;
        }else{
            alert(msg);
        }
    });

}

/*
 * Get The profile from
 */
function getProfileForm(userid) {
    $.ajax({
        type: "POST",
        url: "Controllers/controller.User.php",
        data: {locate: "GetProfileForm", userid: userid}
    })
            .done(function(msg) {
        $("#loginsubscribefroms").html(msg);
    });

}

/*
 * Add new User
 */
function addNewUser() {
    var fname,
            lname,
            birthday,
            phone,
            email,
            password;
    fname = $("#inputFirstName3").val();
    lname = $("#inputLastName3").val();
    birthday = $("#inputBirthday3").val();
    phone = $("#inputPhone3").val();
    email = $("#inputEmail3").val();
    password = $("#inputPassword3").val();
    if (fname === '' || email === '' || password === '') {
        noty({
            layout: 'bottom',
            type: 'alert',
            text: 'All fields are required. Please complete all fields!',
            dismissQueue: true,
            animation: {
                open: {height: 'toggle'},
                close: {height: 'toggle'},
                easing: 'swing',
                speed: 500
            },
            timeout: 4000
        });
        return;
    }
    $.ajax({
        type: "POST",
        url: "Controllers/controller.User.php",
        data: {locate: 'AddNewUser', fname: fname, lname: lname, birthday: birthday, phone: phone, email: email, password: password}
    })
            .done(function(msg) {
        $("#loginsubscribefroms").html(msg);
        noty({
            layout: 'bottom',
            type: 'alert',
            text: 'Thanks for subscribe! You can login now.',
            dismissQueue: true,
            animation: {
                open: {height: 'toggle'},
                close: {height: 'toggle'},
                easing: 'swing',
                speed: 500
            },
            timeout: 4000
        });
    });

}

/*
 * Test if is a JSON
 */
function IsJsonString(str) {
    try {
        JSON.parse(str);
    } catch (e) {
        return false;
    }
    return true;
}