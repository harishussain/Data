<?php
$con= mysql_connect("localhost","root");
if(!con)
{
die("no connection found" . mysql_error);
}
mysql_select_db("mydb",$con)
$sql= "CREATETABLE Student  
( fname varchar(12),deptname varchar(20) )";
mysql_query($sql,$con);
mysql_close($con);