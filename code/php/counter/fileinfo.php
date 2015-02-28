<?php
/*
$fp = fopen("counter.txt","a+");
if(!$fp)
die ("cannot open");
fwrite($fp,"haris",6);
fclose($fp);
$fp = fopen("counter.txt","r");
$counter;
while(!feof($fp))
{
global $counter;
$one_char = fgetc($fp);
$counter .=$one_char;
}
$counter = (int) $counter;
echo $counter;
fclose($fp);
*/
$line = "counter.txt";
$arr = file($line);
$counter = (int)$arr[0];
$counter++;
echo "u r visitor no.".$counter;

?>