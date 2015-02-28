<?php 
if(isset($_POST['login']))
{
$username=$_POST['name'];
setcookie("uname","$username",time()+7600);
$user = $_COOKIE['uname'];
echo $user;
echo "<br/>";
}
?>
<html>
<body>
<form method = "post" action="">
name: <input type="text" name="name"/>
password:<input type="password" name="pass"/>
<input type = "submit" value ="login" name="login"/>
</form>
</body>
</html>