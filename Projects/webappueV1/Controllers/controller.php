<?php

/*
 * Return the view
 */

function getView($model, $name) {
    return file_get_contents(__DIR__ . '/../Views/'.$model.'View/'.$name.'.xhtml');
}
?>
