<?php
$fp= fopen("myfile.txt","a");
if(!$fp)
{
die("cannot open");
}
$string1 = "<h3> best </h3>";
fwrite($fp,$string1);
$string2= "<h3> good</h3>";
fwrite($fp,$string2);
fclose($fp);
?>