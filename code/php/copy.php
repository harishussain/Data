<?php
$con = mysql_connect("localhost","root");
if (!$con)
  {
  die('Could not connect: ' . mysql_error());
  }

mysql_select_db("my_db", $con);

$result = mysql_query("SELECT * FROM customer");

while($row = mysql_fetch_array($result))
  {
  echo $row['ID'] . " " . $row['Name'];
  echo "<br />";
  }

mysql_close($con);
?>
