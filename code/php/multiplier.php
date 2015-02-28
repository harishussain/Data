<html>
<head>
</head>
<body>
<form method ="POST" action="multiplier.php" >
Enter number:<input type="text" name="number"/>
<input type="hidden" name="posted" value = "true"/>
<input type="submit" name = "submit"/>
</form>
<?php
$num=$_POST['number'];
if(($num > 1) && ($num < 21))
{
$c=1;
while($c < 11)
{
   $a=$num*$c;
   echo "$num*$c=$a";
   echo "<br/>";
   $c++;
}
}
else 
print " not in range";
?>

</body>
</html>