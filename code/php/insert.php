<html>
<body>
<?php $con = mysql_connect("localhost","root");
if (!$con)
{ die('Could not connect: ' . mysql_error());
}
mysql_select_db("harisdb", $con);
$sql="INSERT INTO teacher(ID,Name,Subject)
VALUES('$_REQUEST[ID]','$_REQUEST[Name]','$_REQUEST[Subject]')";
if (!mysql_query($sql,$con))
{
echo 'record is successfully added';
}
mysql_close($con)
?>
</body></html>
