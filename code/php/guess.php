<html>
<head>
<title> My first form </title>
</head>
<body>
<form method="POST" action="guess.php">
Enter desired number:
<!--<a href="?site=ITDUNIYA">sending querystring</a>-->
<input name="posted" type="hidden" value="true"/>
<input name="number" type ="text"/>
<input name="submit" value ="enter text" type="submit"/>
</form>
<?php
if(isset($_POST['submit']))
{
$user_number=$_POST['number'];
switch($user_number)
{
case 1:
echo "1 is pressed";
break;
case 2:
echo "2 is pressed";
break;
case 3:
echo "3 is pressed";
break;
default:
echo "no desired number is pressed";
}
}
?>
</body>
</html>