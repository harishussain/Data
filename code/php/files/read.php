<?php
$myfile = fopen("myfile.txt","r");
if(!$myfile)
{
die("unreadable");
}
fread($myfile,20);
$fcontent = file_get_contents("myfile.txt");
echo $fcontent;
fclose($myfile);
?>