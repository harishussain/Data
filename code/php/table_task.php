<html>
<head>
</head>
<body>
<div>
<?php
function table($a,$b,$c,$d)
{
echo "<table border=\"2\">";
for($row=0; $row<2 ; $row++)
{
echo "<tr>";
for($col=0; $col<2; $col++)
{
If(($row==0) && ($col==0))
{
echo "<td>"; 
echo "$a";
echo "</td>";
}
if(($row==0 )&& ($col==1))
{
echo "<td>"; 
echo "$b";
echo "</td>";
}
if(($row==1) &&($col==0))
{
echo "<td>"; 
echo "$c";
echo "</td>";
}
if(($row==1) && ($col==1))
{
echo "<td>"; 
echo "$d";
echo "</td>";
}
}
echo "</tr>";
}
echo "</table>";
}
table(1,2,3,4);
?>
</div>
</body>

</html>