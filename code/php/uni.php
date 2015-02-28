<php
$con=mysql("localhost","root")
if(!$con)
{
die("no connection found".mysql_error());
}
mysql_select_db("uni_db",$con);
$sql = "select * from student";
$result=$sql_query($sql,$con);
while($row=mysql_fetch_array($result"))
}
echo '$row[Name]';
}
mysql_close($con);
?>