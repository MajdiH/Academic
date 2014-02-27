$(document).ready(function() {
    
    var user = "web/js/Controllers/user.js";
    var contact = "web/js/Controllers/contact.js";
    var charset = {charset: "utf-8"};

    include(user, charset);
    include(contact, charset);

    /*
     * Make menu active selected
     */
    $(".navbar-collapse li").on("click", function() {
        $(".navbar-collapse li").removeClass("active");
        $(this).addClass("active")
    });

    /*
     * 
     * @returns {All Views Actions}
     */

    $('.container').on('click', '#add-new-user-link', function() {
        addNewUser();
    });
    $('.container').on('click', '#contact-link', function() {
        getContactForm();
    });
    $('.container').on('click', '#home-link', function() {
        getLoginForm();
    });
    $('.container').on('click', '#create-account-link', function(e) {
        getCreateAcountForm();
        e.preventDefault();
    });
    $('.container').on('click', '#signin-link', function() {
        getLoginForm();
    });
    $('.container').on('click', '#login-account-link', function(e) {
        loginUser();
        e.preventDefault();
    });
    $('.container').on('click', '#profile-link', function() {
        getProfileForm($(this).data("userid"));
    });
})()

/*
 * Include file function
 */
function include(src, attributes)
{
    try {
        attributes = attributes || {};
        attributes.type = "text/javascript";
        attributes.src = src;

        var script = document.createElement("script");
        for (aName in attributes)
            script[aName] = attributes[aName];

        document.getElementsByTagName("head")[0].appendChild(script);
        return true;
    } catch (e) {
        return false;
    }
}


/*
 * Free Base
 */
function getAllArtistes() {
    $("#loader").show();
    $.ajax({
        type: "POST",
        url: "Controllers/controller.Music.php",
        data: {locate: "allArtists"}
    })
            .done(function(msg) {
        $("#content").html(msg);
        $("#loader").hide();
    });
}