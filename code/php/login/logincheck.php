<html>
<head>
<title> validation </title>
</head>
<body>
<?php 
function clean($str)
{
$cstr= trim($str);
$cstr = htmlspecialchars($cstr);
return $cstr;
}
$userName = $_COOKIE['username'];
$pass = $_COOKIE['userpass'];
$remember = $_POST['chkbox'];
if(empty(username))
{
header("Location:login.php");
}
if(empty(userpass))
{
header("Location:login.php");
}
if(!(empty(username)||empty(userpass)))
{
$UserName = clean($_POST['username']);
$UserPass = clean($_POST['userpass']);
$Remember = $_POST['chkbox'];
header("Location:user.php");
}
if(username=="google" && userpass=="1111")
{
session_start();
$_SESSION['username'] = $AdminName;
$_SESSION['login']= true;
if(remember=="on")
{
setcookie("admin",$UserName,time()+3600);
setcookie("adminPwd",$UserPass,time()+3600);
}
header("Location:my_cp.php");
}
else
{
header("Location:login.php");
}



if(username!="google" && userpass!="1111")
{
session_start();
$_SESSION['username'] = $UserName;
$_SESSION['login']= true;
if(remember=="on")
{
setcookie("user",$UserName,time()+3600);
setcookie("Pwd",$UserPass,time()+3600);
}
header("Location:user.php");
}
else
{
header("Location:login.php");
}

?>
</body>
<html>