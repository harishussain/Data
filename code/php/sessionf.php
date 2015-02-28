<!doctype html>
<html>
<head>
<title>
sessions
</title>
</head>
<body>
<?php
if(isset($_POST['login']))
{
if($_POST['remember']=="on")
{
$name = $_POST['username'];
setcookie("Username","$name",time()+7200);
$username = $_COOKIE['Username'];
echo $username;

}


}
?>




<h3> <?php echo "FORM";?> </h3>
<form method="POST" action=""> </br>
Name: <input type="text" name = "username"/></br>
Password: <input type = "password" name="pwd"/></br>
Remember me : <input type ="checkbox" name="remember"/></br>
<input type = "submit" name="login" value="login"/>
<input type ="reset" name ="remove" value ="clear"/>
</form>
</body>
</html>