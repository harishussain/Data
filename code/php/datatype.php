<html>
<head>
</head>
<body>
<?php
/*$var=5;
//echo $var;
settype($var,"string");
echo $var;
echo gettype($var);
settype($var,"integer");
echo $var;
echo gettype($var); 
echo "</br>";
$a="12.3333str";
settype($a,"float");
echo $a;
if(is_float($a))
{
echo "floats type";
}
$b=array("ID"=>"021","NAME"=>"Haris");
echo $b['NAME'];
if(empty($b))
{
echo "<br>";
echo "b is empty";
}
echo "</br>";
echo "</br>";
echo "</br>";
echo "</br>";
echo "</br>";
ob_start();
echo "object buffering start";
echo "</br>";
setcookie("mycookie","remberyet",time()+3600);
echo "cookie working";
session_start();
$_Session['user']="haris";
$_Session['pwd']="123";
echo "</br>";
$user = $_COOKIE['mycookie'];
echo $user;
echo "</br>";
echo $_Session['user'];
echo "</br>";
echo $_Session['pwd'];
ob_end_flush();
*/
ob_start();
echo "its all obout error";
echo "</br>";
setcookie("mycookie","remberyet",time()+3600);
session_start();
$_Session['name']="haris";
$_Session['pwd']="123";
echo $_Session['name'];
echo "</br>";
echo $_Session['pwd'];
echo "</br>";
$user=$_COOKIE['mycookie'];
echo $user;
$decider = ob_get_contents();
ob_end_clean();
echo $decider;






















?>
</body>
</html>