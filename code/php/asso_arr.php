<?php
#constructing an associative array;
$cities = array(1,"two"=>"2",3,5);
$cities["Zero"] = "0000";
$cities[]="haris";
echo $cities[0], $cities["two"], $cities["Zero"], $cities[2], $cities[1], $cities[3];
?>