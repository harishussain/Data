<html>
<head>
</head>
<body>
<form method="post" action="task.php">
Enter Number:<input type = "text" name = "number"/>
<input type = "hidden" name="posted" value="true"/>
<input type = "submit" name="submit">
</form>
<?php
if(isset($_POST['posted']))
{
$number = $_POST['number'];
if($number%2==0)
{
echo "even";
}
else if($number%2!=0) 
{
echo "odd";
}
}
?>

</body>
</html>