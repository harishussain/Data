<?php 
if(isset($_POST['login']))
{
$username=$_POST['name'];
$userpass = $_POST['pass'];
setcookie("Uname",$username,time()+3600);
setcookie("Upass",$userpass,time()+3600);
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