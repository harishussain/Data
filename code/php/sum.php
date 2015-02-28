<html>
<head> </head>
<body>
<?php
#working with user defined function
$age=22;
function sum($num1)
{ 
global $age;
$num1+=$age;
print $num1;
}
echo "It will print Ist <br/>";
sum(3);
?> 
</body>
</html>