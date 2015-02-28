<html>
<head></head>
<body> 
<div>
<?php
echo "<table border=\"4\">";
for($x=1;$x<=10;$x++)
{
echo "<tr>";
for($y=1;$y<=10;$y++)
{
echo "<td>";
$z=$x*$y;
echo "$z";
echo "</td>";
}
echo "</tr>";
}
echo "</table>";

?>
</div>


</body>
</html>