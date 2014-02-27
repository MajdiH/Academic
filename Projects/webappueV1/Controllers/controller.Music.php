<?php

require(__DIR__ . '/../Models/class.Music.php');


if (isset($_POST['locate'])) {

    $locate = $_POST['locate'];

    switch ($locate):

        case 'allArtists':
            $Music = new Music();
            $artists = $Music->getAllArtists();
            $html = '';
            $html .='<table class="table table-striped">';
            $html = '<tr><td>Artiste</td></tr>';
            $html = '<tr><td></td></tr>';
            $html = '<tr><td></td></tr>';
            $html = '<tr><td></td></tr>';
            $html = '</table>';
            echo $artists[1]->type;
            break;


        default:
            echo "Never Mind";

    endswitch;
}
?>
