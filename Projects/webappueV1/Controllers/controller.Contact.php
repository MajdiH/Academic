<?php

require(__DIR__ . '/controller.php');
require(__DIR__ . '/../Models/class.Contact.php');


if (isset($_POST['locate'])) {

    $locate = $_POST['locate'];

    switch ($locate):

        case 'GetContactForm':
            $view = getView('contact', 'contact');
            echo $view;
            break;


        default:
            echo "Never Mind";

    endswitch;
}

?>
