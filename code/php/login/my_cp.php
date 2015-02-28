<?php 
if(!($_SESSION['login'] && empty($_SESSION['user'])))
{
header("Location:login.php");
} 
?>
<html>
<head> <title> Admin Area </title></head>
<body>
<h3> welcome <?=$_SESSION['username']?> to control pannel</h3>
<a href="login.php"> logout </a>
</body>
</html>