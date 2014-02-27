<?php

/**
 * Description of class
 *
 * @author majdih
 */
require(__DIR__ . '/../requires/bootstrap.php');

class Music {

    function __construct() {
        
    }

    public function getAllArtists() {
        $uri = "https://www.googleapis.com/freebase/v1/mqlread/?lang=%2Flang%2Ffr&query=%5B%7B+%22id%22%3A+null%2C+%22name%22%3A+null%2C+%22type%22%3A+%22%2Fmusic%2Fartist%22+%7D%5D";
        $response = \Httpful\Request::get($uri)
                ->expectsJson()
                ->sendIt();
        return $response->body->result;
    }

}

?>
