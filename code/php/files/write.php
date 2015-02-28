<?php
$myfile = fopen("myfile.txt","r+");
if(!$myfile)
{
die("cannot open file");
}
$text = "knowledge is power, logic enpowers ";
fwrite($myfile,"$text",50);
fclose($myfile);

?>