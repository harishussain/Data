<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('unable to connect'.mysql_error());
}
mysql_select_db("my_db",$con);
$sql = "sort customer IN Descending";
mysql_query($sql,$con);
if(!mysql_query($sql,$con))
{
echo 'one record added';
}
mysql_close($con);
?>