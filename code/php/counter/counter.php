<?php
/*
$fp=fopen("counter.txt","r+");
if(!$fp)
{
die("cannot open");
}
$filecount = (int)fread($fp,20);
fclose($fp);
$filecount++;
echo "your count is".$filecount;
$fp=fopen("counter.txt","w");
fwrite($fp,$filecount);
fclose($fp);
*/
$read = file("delete.txt");
echo $read[0];
if(is_readable("./counter.php"))
echo "readable";
else 
echo "doesnot exist";
unlink("delete.txt");
?>