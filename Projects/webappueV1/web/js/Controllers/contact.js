/*
 * Get the contcat form
 */
function getContactForm(){
    $.ajax({
        type: "POST",
        url: "Controllers/controller.Contact.php",
        data: {locate: "GetContactForm"}
    })
            .done(function(msg) {
        $("#loginsubscribefroms").html(msg);
    });
}