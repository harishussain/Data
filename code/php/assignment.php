<html>
<head>
</head>
<body>
<div>
<?php
function draw_table($cols,$rows)
{
echo "table has $rows:rows and $cols:columns";
echo "<table border=\"2\">";
for($i=1; $i<$rows+1; $i++)
{
echo "<tr>";
for($j=1; $j<$cols+1 ;$j++)
{
echo "<td>";
echo $i*$j;
echo "</td>";
}
echo "</tr>";
}
echo "</table>";
}

draw_table(10,10);

?>
</div>
</body>
<html>