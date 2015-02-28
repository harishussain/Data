<?php $con = mysql_connect("localhost","root");
if(!$con)
{
die('couldnot connect' . mysql_error());
}
if(mysql_query("CREATE DATABASE mydb",$con))
{
echo 'database of name mydb has been created';
}
else
{ 
echo "error creating database" . mysql_error();
} 
mysql_close($con);
?>