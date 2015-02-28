<html>
<head></head>
<body>
<div>
<?php
#working with optional arguments
/*
function optarg($txt,$size=3)
{
echo "<h$size> $txt </h$size> </br>";
}
optarg("information technology",1);
optarg("information technology",2);
optarg("information technology");*/
$number=10;
function sum($num)
{
 $num *=$num;
 return $num;
}
print sum($number);
?>
</div>
</body>
</html>