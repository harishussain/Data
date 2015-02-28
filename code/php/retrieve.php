<?php
$con = mysql_connect("localhost","root");
if(!$con)
{
die('cant connect'.mysql_error());
}
Mysql_select_db("my_db",$con);
$sql="select * from customer
where Name like 'y%'";
$result = mysql_query($sql,$con);
while($row=mysql_fetch_array($result))
{
echo $row['ID']."  ".$row['Name'];
echo "</br>" ;
}
mysql_close($con);